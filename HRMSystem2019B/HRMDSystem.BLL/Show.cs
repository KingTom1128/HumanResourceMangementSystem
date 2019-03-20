using HRMDSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDSystem.BLL
{
    public class Show
    {
        public DataTable ShowResult(int pageNo, int numPerPage)
        {
            DataTable dt = new DataTable();
            OperationLogService logServ = new OperationLogService();
            dt = logServ.GetLogList(pageNo, numPerPage);
            if (dt == null)
            {
                return null;
            }
            return dt;
        }
    }
}
