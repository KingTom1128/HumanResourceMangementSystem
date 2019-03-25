using HRMDSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDSystem.BLL
{
    public class Administrator
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

        public class Search
        {
            private string username;
            public Search(string un)
            {
                username = un;
            }
            public string SearchResult()
            {
                OperatorService opServ = new OperatorService();
                string s = opServ.Search(username);
                if (s == null)
                {
                    s = "查询失败！";
                }
                return s;
            }
        }

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
}
