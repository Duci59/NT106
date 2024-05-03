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
                    if (check == 0)
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("User doesn't exist");
                        skXL.Send(traLoi);
                    }
                    else if (check == 1)
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("Login successfully");
                        skXL.Send(traLoi);
                    }
                    else if (check == -1)
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("Password didn't match");
                        skXL.Send(traLoi);
                    }
                    else
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("An error have occurred");
                        skXL.Send(traLoi);
                    }
                }
                if (noidung.StartsWith("DangKy"))
                {
                    bool check;
                    //Đăng ký: [DangKy] ~ username ~ displayname ~ Pass ~ Email 
                    string username = noidung.Split('~')[1];
                    string displayname = noidung.Split('~')[2];
                    string password = noidung.Split('~')[3];
                    string email = noidung.Split('~')[4];
                    check = await UserInter.Instance.userexist(username, email);
                    if (check)
                    {
                        byte[] traLoi = Encoding.UTF8.GetBytes("User or email already exit");
                        skXL.Send(traLoi);
                    }
                    else
                    {
                        await UserInter.Instance.RegisterUserAsync(username, displayname, email, password);
                        byte[] traLoi = Encoding.UTF8.GetBytes("OK");
                        skXL.Send(traLoi);
                    }
                }

                skXL.Close();
                skXL.Dispose();
            }

        }
    }
}
