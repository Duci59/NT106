using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Server.env;
using Server.DAO;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Server
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("May chu bat dau hoat dong ...");
            String serverIP = "127.0.0.1";
            int port = 8080;
            FireStoreHelper.SetEnviromentVariable();
            Socket sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(serverIP), port);
            sk.Bind(ep);
            sk.Listen(100);

            while (true)
            {
                Socket skXL = sk.Accept();
                Byte[] duLieu = new byte[102400000];
                int demNhan = skXL.Receive(duLieu);
                String noidung = Encoding.UTF8.GetString(duLieu, 0, demNhan);

                if (noidung.StartsWith("DangNhap"))
                {
                    int check;
                    string username = noidung.Split('~')[1];
                    string password = MD5Helper.Instance.MaHoaMotChieu(MD5Helper.Instance.GiaiMa(noidung.Split('~')[2]));
                    check = await UserInter.Instance.login(username, password);
                    byte[] traLoi;

                    switch (check)
                    {
                        case 0:
                            traLoi = Encoding.UTF8.GetBytes("User doesn't exist");
                            break;
                        case 1:
                            Dictionary<string, object> userInfo = await UserInter.Instance.LoadInfo(username);
                            traLoi = Encoding.UTF8.GetBytes("success~" + userInfo["username"].ToString() + "~" +
                                                            MD5Helper.Instance.MaHoa(userInfo["displayName"].ToString()) + "~" +
                                                            MD5Helper.Instance.MaHoa(userInfo["email"].ToString()) + "~" +
                                                            MD5Helper.Instance.MaHoa(userInfo["usertype"].ToString()) + "~" +
                                                            MD5Helper.Instance.MaHoa(userInfo["avatar"].ToString())); // Include avatar
                            break;
                        case -1:
                            traLoi = Encoding.UTF8.GetBytes("Password didn't match");
                            break;
                        default:
                            traLoi = Encoding.UTF8.GetBytes("An error has occurred");
                            break;
                    }
                    skXL.Send(traLoi);
                }
                else if (noidung.StartsWith("CheckTK"))
                {
                    bool checkuser, checkemail;
                    string username = noidung.Split('~')[1];
                    string email = noidung.Split('~')[2];
                    checkuser = await UserInter.Instance.field_exist("users", "username", username);
                    checkemail = await UserInter.Instance.field_exist("users", "email", email);
                    if (checkuser)
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("User exit");
                        skXL.Send(traLoi);
                    }
                    else if (checkemail)
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("Email exit");
                        skXL.Send(traLoi);
                    }
                }
                else if (noidung.StartsWith("DangKy"))
                {
                    bool checkuser, checkemail;
                    string username = MD5Helper.Instance.GiaiMa(noidung.Split('~')[1]);
                    string displayname = MD5Helper.Instance.GiaiMa(noidung.Split('~')[2]);
                    string password = MD5Helper.Instance.MaHoaMotChieu(MD5Helper.Instance.GiaiMa(noidung.Split('~')[3]));
                    string email = MD5Helper.Instance.GiaiMa(noidung.Split('~')[4]);
                    string usertype = MD5Helper.Instance.GiaiMa(noidung.Split('~')[5]);
                    string avatar = MD5Helper.Instance.GiaiMa(noidung.Split('~')[6]); // Avatar field

                    checkuser = await UserInter.Instance.field_exist("users", "username", username);
                    checkemail = await UserInter.Instance.field_exist("users", "email", email);
                    if (checkuser || checkemail)
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("User or email already exit");
                        skXL.Send(traLoi);
                    }
                    else
                    {
                        await UserInter.Instance.RegisterUserAsync(username, displayname, email, password, usertype, avatar);
                        byte[] traLoi = Encoding.UTF8.GetBytes("OK");
                        skXL.Send(traLoi);
                    }
                }
                else if (noidung.StartsWith("SendMail"))
                {
                    string email = noidung.Split('~')[1];
                    Random rd = new Random();
                    int code = rd.Next(0, 9999);
                    fnSendMail(email, code.ToString("D4"));
                    byte[] traLoi = Encoding.UTF8.GetBytes(code.ToString("D4"));
                    skXL.Send(traLoi);
                }
                else if (noidung.StartsWith("CheckEmail"))
                {
                    bool check;
                    string email = noidung.Split('~')[1];
                    check = await UserInter.Instance.field_exist("users", "email", email);
                    if (check)
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("Email exist");
                        skXL.Send(traLoi);
                    }
                    else
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("Email doesn't");
                        skXL.Send(traLoi);
                    }
                }
                else if (noidung.StartsWith("RestPass"))
                {
                    string email = noidung.Split('~')[1];
                    string passnew = MD5Helper.Instance.MaHoaMotChieu(MD5Helper.Instance.GiaiMa(noidung.Split('~')[2]));
                    bool check;
                    check = await UserInter.Instance.ResetPass(email, passnew);
                    if (check)
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("OK");
                        skXL.Send(traLoi);
                    }
                    else
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("Error");
                        skXL.Send(traLoi);
                    }
                }
                else if (noidung.StartsWith("ResetDisplayName"))
                {
                    string username = MD5Helper.Instance.GiaiMa(noidung.Split('~')[1]);
                    string Displayname = noidung.Split('~')[2];
                    bool check;
                    check = await UserInter.Instance.ResetDisplayName(username, Displayname);
                    if (check)
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("OK");
                        skXL.Send(traLoi);
                        Console.WriteLine("user '" + username + "' reset display name successful");
                    }
                    else
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("Error");
                        skXL.Send(traLoi);
                        Console.WriteLine("user '" + username + "' reset display name fail");
                    }
                }
                else if (noidung.StartsWith("GetPasswordWithUserName"))
                {
                    string username = noidung.Split('~')[1];
                    string pass = await UserInter.Instance.GetPasswordByUsername(username);
                    if (pass == "khongco")
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("Error");
                        skXL.Send(traLoi);
                        Console.WriteLine("user '" + username + "' get password fail");
                    }
                    else
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes(pass);
                        skXL.Send(traLoi);
                        Console.WriteLine("user '" + username + "' get password successfully");
                    }
                }
                else if (noidung.StartsWith("GetInfoAccount"))
                {
                    string username = MD5Helper.Instance.GiaiMa(noidung.Split('~')[1]);
                    Dictionary<string, object> userInfo = await UserInter.Instance.LoadInfo(username);
                    byte[] traLoi = Encoding.UTF8.GetBytes("success~" + MD5Helper.Instance.MaHoa(userInfo["username"].ToString()) + "~" +
                                                            MD5Helper.Instance.MaHoa(userInfo["displayName"].ToString()) + "~" +
                                                            MD5Helper.Instance.MaHoa(userInfo["email"].ToString()) + "~" +
                                                            MD5Helper.Instance.MaHoa(userInfo["usertype"].ToString()) + "~" +
                                                            MD5Helper.Instance.MaHoa(userInfo["avatar"].ToString())); // Include avatar
                    skXL.Send(traLoi);
                    Console.WriteLine("user '" + username + "' get info successfully");
                }
                else if (noidung.StartsWith("ResetAvatar"))
                {
                    string username = MD5Helper.Instance.GiaiMa(noidung.Split('~')[1]);
                    string newAvatar = MD5Helper.Instance.GiaiMa(noidung.Split('~')[2]);
                    bool check;
                    check = await UserInter.Instance.ResetAvatar(username, newAvatar);
                    if (check)
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("OK");
                        skXL.Send(traLoi);
                        Console.WriteLine("user '" + username + "' reset avatar successfully");
                    }
                    else
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("Error");
                        skXL.Send(traLoi);
                        Console.WriteLine("user '" + username + "' reset avatar fail");
                    }
                }
                else if (noidung.StartsWith("TaoNhom"))
                {
                    bool checkgrname;
                    string username = noidung.Split('~')[1];
                    string grname = noidung.Split('~')[2];
                    string grpassword = MD5Helper.Instance.MaHoaMotChieu(MD5Helper.Instance.GiaiMa(noidung.Split('~')[3]));

                    checkgrname = await GroupInter.Instance.FieldExistAsync("groupname", grname);
                    if (checkgrname)
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("DTT");
                        skXL.Send(traLoi);
                    }
                    else
                    {
                        await GroupInter.Instance.RegisterGroupAsync(grname, username, grpassword);
                        byte[] traLoi = Encoding.UTF8.GetBytes("TC");
                        skXL.Send(traLoi);
                    }
                }
                else if (noidung.StartsWith("DelGr"))
                {
                    string TenNhom = noidung.Split('~')[1];
                    await GroupInter.Instance.DeleteGroupAsync(TenNhom);
                    skXL.Send(Encoding.UTF8.GetBytes("TC"));
                    Console.WriteLine("Xoa nhom -" + TenNhom);
                }
                else if (noidung.StartsWith("LoadGroup"))
                {
                    string username = noidung.Split('~')[1];
                    string traloi = await GroupInter.Instance.LoadGroupAsync(username);
                    skXL.Send(Encoding.UTF8.GetBytes(traloi));
                }
                else if (noidung.StartsWith("TimNhom"))
                {
                    string groupName = noidung.Split('~')[1];
                    bool groupExists = await GroupInter.Instance.FieldExistAsync("groupname", groupName);
                    byte[] traLoi;
                    if (groupExists)
                    {
                        traLoi = Encoding.UTF8.GetBytes("Group found");
                    }
                    else
                    {
                        traLoi = Encoding.UTF8.GetBytes("Group not found");
                    }
                    skXL.Send(traLoi);
                }
                else if (noidung.StartsWith("ThamGiaNhom"))
                {
                    string username = noidung.Split('~')[1];
                    string groupName = noidung.Split('~')[2];
                    string groupPassword = MD5Helper.Instance.MaHoaMotChieu(MD5Helper.Instance.GiaiMa(noidung.Split('~')[3]));

                    bool validGroup = await GroupInter.Instance.CheckGroupCredentials(groupName, groupPassword);
                    byte[] traLoi;
                    if (validGroup)
                    {
                        await GroupInter.Instance.AddUserToGroup(username, groupName);
                        traLoi = Encoding.UTF8.GetBytes("Joined successfully");
                    }
                    else
                    {
                        traLoi = Encoding.UTF8.GetBytes("Invalid group name or password");
                    }
                    skXL.Send(traLoi);
                }
                else if (noidung.StartsWith("LeaveGroup"))
                {
                    string username = noidung.Split('~')[1];
                    string groupName = noidung.Split('~')[2];

                    bool leftGroup = await GroupInter.Instance.LeaveGroupAsync(username, groupName);

                    byte[] traLoi;
                    if (leftGroup)
                    {
                        traLoi = Encoding.UTF8.GetBytes("Left group successfully");
                    }
                    else
                    {
                        traLoi = Encoding.UTF8.GetBytes("Failed to leave group");
                    }
                    skXL.Send(traLoi);
                }
                else if (noidung.StartsWith("LoadFriend"))
                {
                    string username = noidung.Split('~')[1];
                    string result = await FriendInter.Instance.GetFriendInfo(username);
                    byte[] traloi = Encoding.UTF8.GetBytes(result);
                    skXL.Send(traloi);
                }
                else if (noidung.StartsWith("LoadInRequest"))
                {
                    string username = noidung.Split('~')[1];
                    string result = await FriendInter.Instance.GetFriendRequestsReceived(username);
                    byte[] traloi = Encoding.UTF8.GetBytes(result);
                    skXL.Send(traloi);
                }
                else if (noidung.StartsWith("LoadSendRequest"))
                {
                    string username = noidung.Split('~')[1];
                    string result = await FriendInter.Instance.GetFriendRequestsSent(username);
                    byte[] traloi = Encoding.UTF8.GetBytes(result);
                    skXL.Send(traloi);
                }
                else if (noidung.StartsWith("FriendSearch"))
                {
                    try
                    {
                        string[] parts = noidung.Split('~');
                        string search = parts[1];
                        string uname = parts[2];
                        var result = await FriendInter.Instance.FriendSearch(search, uname);
                        string jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(result);
                        byte[] traloi = Encoding.UTF8.GetBytes(jsonResult);
                        skXL.Send(traloi);
                    }
                    catch (Exception ex)
                    {
                        string errorMessage = "Error: " + ex.Message;
                        byte[] errorResponse = Encoding.UTF8.GetBytes(errorMessage);
                        skXL.Send(errorResponse);
                    }
                }
                else if (noidung.StartsWith("SendFriendRequest"))
                {
                    string username = noidung.Split('~')[1];
                    string otheruser = noidung.Split('~')[2];
                    bool check = await FriendInter.Instance.SendFriendRequest(username, otheruser);
                    byte[] traloi = Encoding.UTF8.GetBytes((check) ? "Success" : "Failed");
                    skXL.Send(traloi);
                }
                else if (noidung.StartsWith("UnFriendRequest"))
                {
                    string username = noidung.Split('~')[1];
                    string otheruser = noidung.Split('~')[2];
                    bool check = await FriendInter.Instance.UnfriendUser(username, otheruser);
                    byte[] traloi = Encoding.UTF8.GetBytes((check) ? "Success" : "Failed");
                    skXL.Send(traloi);
                }
                else if (noidung.StartsWith("AcceptFriendRequest"))
                {
                    string username = noidung.Split('~')[1];
                    string otheruser = noidung.Split('~')[2];
                    bool check = await FriendInter.Instance.AcceptFriendRequest(username, otheruser);
                    byte[] traloi = Encoding.UTF8.GetBytes((check) ? "Success" : "Failed");
                    skXL.Send(traloi);
                }
                else if (noidung.StartsWith("DenyFriendRequest"))
                {
                    string username = noidung.Split('~')[1];
                    string otheruser = noidung.Split('~')[2];
                    bool check = await FriendInter.Instance.RejectFriendRequest(username, otheruser);
                    byte[] traloi = Encoding.UTF8.GetBytes((check) ? "Success" : "Failed");
                    skXL.Send(traloi);
                }
                else if (noidung.StartsWith("UnsendFriendRequest"))
                {
                    string username = noidung.Split('~')[1];
                    string otheruser = noidung.Split('~')[2];
                    bool check = await FriendInter.Instance.UnsendFriendRequest(username, otheruser);
                    byte[] traloi = Encoding.UTF8.GetBytes((check) ? "Success" : "Failed");
                    skXL.Send(traloi);
                }
                else if (noidung.StartsWith("SendMTGroup"))
                {
                    // Yc Gửi tin nhắn = [SendMTGroup] ~ username ~ groupname ~ noidung
                    string[] parts = noidung.Split('~');
                    if (parts.Length < 4)
                    {
                        // Nếu độ dài không đủ 4 phần tử, thông báo lỗi
                        skXL.Send(Encoding.UTF8.GetBytes("[ERROR]~Invalid message format"));
                        return;
                    }

                    string username = parts[1];
                    string tennhom = parts[2];
                    string noiDung = parts[3];

                    try
                    {
                        // Gọi phương thức SendToGrAsync của GroupInter
                        string traLoi = await GroupInter.Instance.SendToGrAsync(username, tennhom, noiDung);

                        // Gửi phản hồi về client
                        skXL.Send(Encoding.UTF8.GetBytes(traLoi));
                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ nếu có lỗi xảy ra
                        skXL.Send(Encoding.UTF8.GetBytes("[ERROR]~" + ex.Message));
                    }
                }

                else if (noidung.StartsWith("CheckMIGroup"))
                {
                    // Yc load tin nhắn = [CheckMIGroup] ~ username ~ groupname ~ stt
                    string[] splitParts = noidung.Split('~');
                    string username = splitParts[1];
                    string groupname = splitParts[2];
                    string stt = splitParts[3];

                    // Sử dụng await để gọi phương thức CheckMessGr từ GroupInter.Instance
                    string traLoi = await GroupInter.Instance.CheckMessGr(username, groupname, stt);

                    // Gửi kết quả trả về
                    skXL.Send(Encoding.UTF8.GetBytes(traLoi));
                }
                else if (noidung.StartsWith("NewMessGroup"))
                {

                    GroupChat gc = new GroupChat();
                    string username = noidung.Split('~')[1];
                    string tennhom = noidung.Split('~')[2];
                    string traLoi = await GroupInter.Instance.NewMessGrAsync(username, tennhom);
                    skXL.Send(Encoding.UTF8.GetBytes(traLoi));
                }
                else if (noidung.StartsWith("NewMessDel"))
                {
                    string username = noidung.Split('~')[1];
                    string tennhom = noidung.Split('~')[2];
                    string traLoi = await GroupInter.Instance.NewMessGr_DelAsync(username, tennhom);
                    skXL.Send(Encoding.UTF8.GetBytes(traLoi));
                }

                else if (noidung.StartsWith("LoadMemGr"))
                {
                    //Yc load thành viên nhóm = [LoadMemGr] ~ username ~ groupname
                    //noiDung.Split('~')[1] = username
                    //noiDung.Split('~')[2] = groupname
                    string username = noidung.Split('~')[1];
                    string groupname = noidung.Split('~')[2];

                    // Call the async method and await its result
                    string traLoi = await GroupInter.Instance.LoadMemGrAsync(username, groupname);

                    // Send the response back
                    skXL.Send(Encoding.UTF8.GetBytes(traLoi));
                }

                else if (noidung.StartsWith("OldMess"))
                {
                    GroupChat gc = new GroupChat();
                    string username = noidung.Split('~')[1];
                    string tennhom = noidung.Split('~')[2];
                    string traLoi = await GroupInter.Instance.OldMessGrAsync(username, tennhom);
                    skXL.Send(Encoding.UTF8.GetBytes(traLoi));
                }

                else if (noidung.StartsWith("DellMess"))
                {

                    string[] parts = noidung.Split('~');
                    if (parts.Length >= 2)
                    {
                        string messageId = parts[1].Trim();
                        int messageIdInt = int.Parse(messageId);
                        try
                        {
                            await GroupInter.Instance.DelMessAsync(messageIdInt);

                            // Gửi phản hồi về cho client (VD: "DONE" để thông báo rằng đã xóa thành công)
                            skXL.Send(Encoding.UTF8.GetBytes("DONE"));
                        }
                        catch (Exception ex)
                        {
                            // Xử lý nếu có lỗi xảy ra trong quá trình xóa tin nhắn
                            Console.WriteLine($"Error deleting message with id {messageId}: {ex.Message}");
                            skXL.Send(Encoding.UTF8.GetBytes($"ERROR: {ex.Message}"));
                        }
                    }
                    else
                    {
                        // Xử lý khi định dạng yêu cầu không đúng
                        skXL.Send(Encoding.UTF8.GetBytes("ERROR: Invalid request format"));
                    }
                }

                else if (noidung.StartsWith("KGR"))
                {
                    // Yêu cầu: [KGR] ~ groupname ~ us;
                    string[] parts = noidung.Split('~');
                    if (parts.Length >= 3)
                    {
                        string groupname = parts[1].Trim();
                        string us = parts[2].Trim();

                        // Gọi hàm KickMemberFromGroup để kick thành viên us ra khỏi nhóm groupname
                        await GroupInter.Instance.KickMemberFromGroup(us, groupname);

                        Console.WriteLine("- Kick thành viên ra khỏi nhóm");

                        string traLoi = "DONE";
                        skXL.Send(Encoding.UTF8.GetBytes(traLoi));
                    }
                    else
                    {
                        // Xử lý khi dữ liệu đầu vào không đủ
                        Console.WriteLine("Lỗi: Dữ liệu không hợp lệ cho yêu cầu KGR");
                        string traLoi = "ERROR";
                        skXL.Send(Encoding.UTF8.GetBytes(traLoi));
                    }
                }

                else if (noidung.StartsWith("MoiVaoNhom"))
                {
                    //Yc = [MoiVaoNhom] ~ username ~ tên nhóm
                    GroupChat gc = new GroupChat();
                    gc.Username = noidung.Split('~')[1];
                    gc.TenNhom = noidung.Split('~')[2];
                    bool checkuser, check;

                    checkuser = await UserInter.Instance.field_exist("users", "username", gc.Username);
                    check = await GroupInter.Instance.StatusMember(gc.TenNhom, gc.Username); //Check trạng thái thành viên

                    ;
                    if (checkuser)
                    {
                        if (!check)
                        {
                            await GroupInter.Instance.AddUserToGroup(gc.Username, gc.TenNhom);
                        }
                        Console.WriteLine(gc.Username + "- Moi vao nhom.");
                        skXL.Send(Encoding.UTF8.GetBytes("TC"));
                    }
                    else
                    {
                        skXL.Send(Encoding.UTF8.GetBytes("TB"));
                    }
                }//Tìm và vào nhóm
                else if (noidung.StartsWith("SendMTFriend"))
                {
                    // Yc Gửi tin nhắn = [SendMTFriend] ~ username ~ otheruser ~ noidung
                    string[] parts = noidung.Split('~');
                    if (parts.Length < 4)
                    {
                        // Nếu độ dài không đủ 4 phần tử, thông báo lỗi
                        skXL.Send(Encoding.UTF8.GetBytes("[ERROR]~Invalid message format"));
                        return;
                    }

                    string senderUsername = parts[1];
                    string receiverUsername = parts[2];
                    string noiDung = parts[3];

                    try
                    {
                        // Gọi phương thức SendToGrAsync của GroupInter
                        string traLoi = await FriendInter.Instance.SendToUserAsync(senderUsername, receiverUsername, noiDung);

                        // Gửi phản hồi về client
                        skXL.Send(Encoding.UTF8.GetBytes(traLoi));
                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ nếu có lỗi xảy ra
                        skXL.Send(Encoding.UTF8.GetBytes("[ERROR]~" + ex.Message));
                    }
                }
                else if (noidung.StartsWith("CheckMIFriend"))
                {
                    // Yc load tin nhắn = [CheckMIGroup] ~ username ~ groupname ~ stt
                    string[] splitParts = noidung.Split('~');
                    string username = splitParts[1];
                    string otheruser = splitParts[2];
                    string stt = splitParts[3];

                    // Sử dụng await để gọi phương thức CheckMessGr từ GroupInter.Instance
                    string traLoi = await FriendInter.Instance.CheckMessFriend(username, otheruser, stt);

                    // Gửi kết quả trả về
                    skXL.Send(Encoding.UTF8.GetBytes(traLoi));
                }
                else if (noidung.StartsWith("NewMessFriend"))
                {

                    
                    string username = noidung.Split('~')[1];
                    string otheruser = noidung.Split('~')[2];
                    string traLoi = await FriendInter.Instance.NewMessFriendAsync(username, otheruser);
                    skXL.Send(Encoding.UTF8.GetBytes(traLoi));
                }
                else if (noidung.StartsWith("NewMessFriendDel"))
                {
                    string username = noidung.Split('~')[1];
                    string otheruser = noidung.Split('~')[2];
                    string traLoi = await FriendInter.Instance.NewMessFriend_DelAsync(username, otheruser);
                    skXL.Send(Encoding.UTF8.GetBytes(traLoi));
                }
                else if (noidung.StartsWith("OldFriendMess"))
                {
                    
                    string username = noidung.Split('~')[1];
                    string otheruser = noidung.Split('~')[2];
                    string traLoi = await FriendInter.Instance.OldMessFriendAsync(username, otheruser);
                    skXL.Send(Encoding.UTF8.GetBytes(traLoi));
                }
                else if (noidung.StartsWith("DellFriendMess"))
                {

                    string[] parts = noidung.Split('~');
                    if (parts.Length >= 2)
                    {
                        string messageId = parts[1].Trim();
                        int messageIdInt = int.Parse(messageId);
                        try
                        {
                            await FriendInter.Instance.DelFriendMessAsync(messageIdInt);

                            // Gửi phản hồi về cho client (VD: "DONE" để thông báo rằng đã xóa thành công)
                            skXL.Send(Encoding.UTF8.GetBytes("DONE"));
                        }
                        catch (Exception ex)
                        {
                            // Xử lý nếu có lỗi xảy ra trong quá trình xóa tin nhắn
                            Console.WriteLine($"Error deleting message with id {messageId}: {ex.Message}");
                            skXL.Send(Encoding.UTF8.GetBytes($"ERROR: {ex.Message}"));
                        }
                    }
                    else
                    {
                        // Xử lý khi định dạng yêu cầu không đúng
                        skXL.Send(Encoding.UTF8.GetBytes("ERROR: Invalid request format"));
                    }
                }
                else if (noidung.StartsWith("LoadDisplayFriendName")){
                    string username = noidung.Split('~')[1];
                    string traloi = await FriendInter.Instance.GetDisplayNameByUsernameAsync(username);
                    skXL.Send(Encoding.UTF8.GetBytes(traloi));
                }
                skXL.Close();
                skXL.Dispose();
            }

            void fnSendMail(string sMail, string Code)
            {
                SendMail sm = new SendMail(sMail, Code);
                sm.SendEmail();
            }
        }
    }
}
