using HRMDSystem.DAL;
using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDSystem.BLL
{
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
}
