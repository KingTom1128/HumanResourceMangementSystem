using HRMDSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDSystem.BLL
{
    public class Add
    {
        private Guid id;
        private string username;
        private string password;
        private bool isdeleted;
        private string realname;
        private bool islocked;
        public Add(Guid i, string un, string pwd, bool isd, string rn, bool isl)
        {
            id = i;
            username = un;
            password = pwd;
            isdeleted = isd;
            realname = rn;
            islocked = isl;
        }
        public bool AddResult()
        {
            OperatorService opServ = new OperatorService();
            bool f = opServ.Add(id, username, password, isdeleted, realname, islocked);
            return f;
        }
    }
}
