using HRMDSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDSystem.BLL
{
    public class Lock
    {
        private string username;
        private bool flag;
        public Lock(string un, bool f)
        {
            username = un;
            flag = f;
        }
        public bool LockResult()
        {
            OperatorService opServ = new OperatorService();
            bool f = opServ.Lock(username, flag);
            return f;
        }
    }
}
