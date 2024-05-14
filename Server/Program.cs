using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Server.env;
using Server.DAO;

namespace Server
{
    class Program
    {
        static async Task Main(string[] args)
        {


            Console.WriteLine("May chu bat dau hoat dong ...");
            String serverIP = "127.0.0.1";
            int port = 8080;
            //Khởi tạo firestorehelper
            FireStoreHelper.SetEnviromentVariable();
            //Khởi tạo
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
                    //Đăng nhập
                    int check;
                    string username = noidung.Split('~')[1];
                    string password = noidung.Split('~')[2];
                    check = await UserInter.Instance.login(username, password);
                    byte[] traLoi;
                    switch (check)
                    {   
                        case 0:
                            traLoi = Encoding.UTF8.GetBytes("User doesn't exist");
                            break;
                        case 1:
                            Dictionary<string, object> userInfo = await UserInter.Instance.LoadInfo(username);
                            traLoi = Encoding.UTF8.GetBytes("success~" + userInfo["username"].ToString() + "~" + userInfo["displayName"].ToString() + "~" + userInfo["email"].ToString() + "~" + userInfo["usertype"].ToString());
                            break;
                        case -1:
                            traLoi = Encoding.UTF8.GetBytes("Password didn't match");
                            break;
                        default:
                            traLoi = Encoding.UTF8.GetBytes("An error have occurred");
                            break;
                    }
                    skXL.Send(traLoi);
                }
                else if (noidung.StartsWith("CheckTK"))
                {
                    bool checkuser, checkemail;
                    //Đăng ký: [DangKy] ~ username ~ Email 
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
                    //Đăng ký: [DangKy] ~ username ~ displayname ~ Pass ~ Email 
                    string username = noidung.Split('~')[1];
                    string displayname = noidung.Split('~')[2];
                    string password =  MD5Helper.Instance.GiaiMa(noidung.Split('~')[3]);
                    string email = MD5Helper.Instance.GiaiMa(noidung.Split('~')[4]) ;
                    string usertype = noidung.Split('~')[5];
                    checkuser = await UserInter.Instance.field_exist("users", "username", username);
                    checkemail = await UserInter.Instance.field_exist("users", "email", email);
                    if (checkuser || checkemail)
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("User or email already exit");
                        skXL.Send(traLoi);
                    }
                    else
                    {
                        await UserInter.Instance.RegisterUserAsync(username, displayname, email, password, usertype);
                        byte[] traLoi = Encoding.UTF8.GetBytes("OK");
                        skXL.Send(traLoi);
                    }
                }
                else if (noidung.StartsWith("SendMail"))
                {
                    //gui mail: SendMail ~ Email
                    string email = noidung.Split('~')[1];
                    Random rd = new Random();
                    int code = rd.Next(0, 9999);
                    fnSendMail(email, code.ToString("D4"));
                    byte[] traLoi = Encoding.UTF8.GetBytes(code.ToString("D4"));
                    skXL.Send(traLoi);
                }
                else if (noidung.StartsWith("CheckEmail"))
                {
                    //CheckEmail ~ Email
                    bool check;
                    string email = noidung.Split('~')[1];
                    check =  await UserInter.Instance.field_exist("users", "email", email);
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
                    //ResetPass~email~newpass
                    string email = noidung.Split('~')[1];
                    string passnew = noidung.Split('~')[2];
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
                    //ResetDisplayName~username~newdisplayname
                    string username = noidung.Split('~')[1];
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
                    //GetPasswordWithUserName~username
                    string username = noidung.Split('~')[1];
                    string pass = await UserInter.Instance.GetPasswordByUsername(username);
                    if (pass == "khongco")
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("Error");
                        skXL.Send(traLoi);
                        Console.WriteLine("user '" + username + "' get password successful");
                    }
                    else
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes(pass);
                        skXL.Send(traLoi);
                        Console.WriteLine("user '" + username + "' get password fail");
                    }
                }
                else if (noidung.StartsWith("GetInfoAccount"))
                {
                    //GetInfoAccount~username
                    string username = noidung.Split('~')[1];
                    Dictionary<string, object> userInfo = await UserInter.Instance.LoadInfo(username);
                    byte[] traLoi = Encoding.UTF8.GetBytes("success~" + userInfo["username"].ToString() + "~" + userInfo["displayName"].ToString() + "~" + userInfo["email"].ToString() + "~" + userInfo["usertype"].ToString());
                    skXL.Send(traLoi);
                    Console.WriteLine("user '" + username + "' get info successfully");
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
