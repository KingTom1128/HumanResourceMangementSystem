using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDSystem.DAL
{
    public class OperationLogService
    {
        public OperationLogService()
        {

        }

        public bool Add(OperationLog log)
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "insert into OperationLog values(newid(), @OperatorId, @ActionDate, @ActionDesc)";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.Add(new SqlParameter("@OperatorId", log.OperatorId));
            comm.Parameters.Add(new SqlParameter("@ActionDate", log.ActionDate));
            comm.Parameters.Add(new SqlParameter("@ActionDesc", log.ActionDesc));

            conn.Open();
            int n = comm.ExecuteNonQuery();
            if(n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetLogCount()
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "select count(*) from OperationLog";
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int n = (int)comm.ExecuteScalar();
            conn.Close();
            return n;
        }

        public DataTable GetLogList(int pageNo, int numPerPage)
        {
            DataTable dt = new DataTable();
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "SELECT Temp.Id AS 编号,Operator.RealName AS 操作员, Temp.ActionDate AS操作时间, Temp.ActionDesc AS 描述 FROM(SELECT TOP (@LogNum) * FROM OperationLog WHEREId NOT IN (SELECT TOP (@BeforeNum) Id FROM OperationLog)) AS Temp, Operator WHERETemp.OperatorId = Operator.Id";


            return dt;
        }
    }
}
