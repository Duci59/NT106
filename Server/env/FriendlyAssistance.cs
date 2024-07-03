using System;
using System.Collections.Generic;
using System.Linq;
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
}
