using HRMDSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDSystem.BLL
{
    public class Delete
    {
        private string username;
        private bool flag;
        public Delete(string un, bool f)
        {
            username = un;
            flag = f;
        }
        public bool DeleteResult()
        {
            OperatorService opServ = new OperatorService();
            bool f = opServ.Delete(username, flag);
            return f;
        }
    }
}
