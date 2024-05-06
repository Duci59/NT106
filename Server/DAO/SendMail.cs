using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Server.DAO
{
    public class SendMail
    {
        static bool enableSSL = true;
        static string smtpAddress = "smtp.gmail.com";
        static string EmailFromAddress = env.Security.sEmailFromAddress;
        static string EPassword = env.Security.sPassword;
        static int portNumber = 587;
        //Email nguồn cần bắt buộc bật quyền truy cập từ các ứng dụng khác
        string emailToAddress;
        string code;
        //property
        public string EmailToAddress { get => emailToAddress; set => emailToAddress = value; }
        public string Code { get => code; set => code = value; }
        //constructor
        public SendMail(string ToEmail, string eCode)
        {
            EmailToAddress = ToEmail;
            Code = eCode;
        }

        public void SendEmail()
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(EmailFromAddress);
                mail.To.Add(emailToAddress);
                mail.Subject = "OTP";
                mail.Body = "Hello, Thank you for using my app <br /> This is your code: <b>" + code + "<b>.";
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(EmailFromAddress, EPassword);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }
        }
    }
}
