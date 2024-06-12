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
