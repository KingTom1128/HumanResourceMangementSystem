using HRMDSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDSystem.BLL
{
    public class EmployeeOperation
    {
        public DataTable SearchResult()
        {
            EmployeeService emServ = new EmployeeService();
            DataTable dt = new DataTable();
            dt = emServ.GetList();
            return dt;
        }
    }
}
