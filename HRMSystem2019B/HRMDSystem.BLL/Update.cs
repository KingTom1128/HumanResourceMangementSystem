using HRMDSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDSystem.BLL
{
    public class Update
    {
        private string username;
        private string newpwd;
        private string renewpwd;
        public Update(string un, string np, string rnp)
        {
            username = un;
            newpwd = np;
            renewpwd = rnp;
        }
        public bool UpdateResult(string newpwd, string renewpwd)
        {
            OperatorService opServ = new OperatorService();
            bool f = opServ.Update(username, newpwd);
            if (f && newpwd == renewpwd)
            {
                return true;
            }
            return false;
        }
        
    }
}
