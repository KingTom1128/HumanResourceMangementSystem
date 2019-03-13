using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem2019B
{
    class UserInfo
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
        public string RealName { get; set; }
        public bool IsLocked { get; set; }

        private static UserInfo usr = null;

        private UserInfo()
        {

        }

        public static UserInfo GetInstance()
        {
            if (usr == null)
            {
                usr = new UserInfo();
            }
            return usr;
        }
    }
}
