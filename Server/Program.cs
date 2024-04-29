using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("May chu bat dau hoat dong ...");
            string serverIP = "192.168.1.12";
            int port = 8080;

            //Khởi tạo
            Socket sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(serverIP), port);
            sk.Bind(ep);
            sk.Listen(100);

            while (true)
            {
                Socket skXL = sk.Accept();
                Byte[] dulieu = new byte[102400000];
                int demNhan = skXL.Receive(dulieu);
                String noidung = Encoding.UTF8.GetString(dulieu, 0, demNhan);
                if (noidung.StartsWith("DangNhap"))
                {
                    //Đăng nhập

                }

            }
        }
    }
}
