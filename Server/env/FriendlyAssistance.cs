using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Server.env
{
    public class FriendlyAssistance
    {
        private static FriendlyAssistance instance;
        public static FriendlyAssistance Instance
        {
            get { if (instance == null) instance = new FriendlyAssistance(); return instance; }
            private set { instance = value; }
        }

        public class UserInfo
        {
            public string DisplayName { get; set; }
            public string UserName { get; set; }
            public bool CheckFriend { get; set; }
            public bool FriendSent { get; set; }
        }
    }
    public class ChatFriend
    {
        public ChatFriend(DataRow row)
        {
            this.Otheruser = row["tennhom"].ToString();
            this.Username = row["username"].ToString();
        }

        public ChatFriend() { }

        private string username;
        private string otheruser;
        private string tinnhan;

        public string Username { get => username; set => username = value; }
        public string Otheruser { get => otheruser; set => otheruser = value; }
        public string TinNhan { get => tinnhan; set => tinnhan = value; }

        public void MaHoaTinNhan(string key)
        {
            MD5Helper md = new MD5Helper(key);
            this.TinNhan = md.MaHoa(this.TinNhan);
        }

        public void GiaiMaTinNhan(string key)
        {
            MD5Helper md = new MD5Helper(key);
            this.TinNhan = md.GiaiMa(this.TinNhan);
        }
    }
}
