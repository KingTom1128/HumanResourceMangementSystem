using HRMDSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDSystem.BLL
{
    public class Department
    {
        public class Search
        {
            private string name;
            public Search(string un)
            {
                name = un;
            }
            public string SearchResult()
            {
                DepartmentService dtServ = new DepartmentService();
                string s = dtServ.Search(name);
                if (s == null)
                {
                    s = "查询失败！";
                }
                return s;
            }
        }

        public class Add
        {
            private Guid id;
            private string name;
            public Add(Guid i, string un)
            {
                id = i;
                name = un;
            }
            public bool AddResult()
            {
                DepartmentService deServ = new DepartmentService();
                bool f = deServ.Add(id, name);
                return f;
            }
        }

        public class Delete
        {
            private string name;
            public Delete(string un)
            {
                name = un;
            }
            public bool DeleteResult()
            {
                DepartmentService deServ = new DepartmentService();
                bool f = deServ.Delete(name);
                return f;
            }
        }

        public class Update
        {
            private string newde;
            private string oldde;
            public Update(string od, string nd)
            {
                oldde = od;
                newde = nd;
            }

            public bool UpdateResult(string od, string nd)
            {
                DepartmentService deServ = new DepartmentService();
                bool f = deServ.Update(oldde, newde);
                if (f)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
