using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DTO
{
    public class User
    {
        public User(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Namedisplay = row["Displayname"].ToString();
            this.Email = row["Email"].ToString();
            //this.Username = row["Username"].ToString();
            //this.Password = row["Password"].ToString();
            this.Type = (int)row["type"];
            this.Key = row["sKey"].ToString();
        }

        private int id;
        private string namedisplay;
        private string email;
        private string username;
        private string password;
        private string passnew;
        private int type;
        private string key;
        public int Id { get => id; set => id = value; }
        public string Namedisplay { get => namedisplay; set => namedisplay = value; }
        public string Email { get => email; set => email = value; }
        //public string Username { get => username; set => username = MD5Helper.Instance.MaHoaMotChieu(value); }
        //public string Password { get => password; set => password = MD5Helper.Instance.MaHoaMotChieu(value); }
        //public string Passnew { get => passnew; set => passnew = MD5Helper.Instance.MaHoaMotChieu(value); }
        public int Type { get => type; set => type = value; }
        public string Key { get => key; set => key = value; }
    }
}
