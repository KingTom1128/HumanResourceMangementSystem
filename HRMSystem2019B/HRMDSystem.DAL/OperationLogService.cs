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
            string sql = "insert into OperationLog values(newid(), @OperatorId, @ActionDate, @ActionDesc)";
            SqlParameter[] paras =
            {
                new SqlParameter("@OperatorId", log.OperatorId),
                new SqlParameter("@ActionDate", log.ActionDate),
                new SqlParameter("@ActionDesc", log.ActionDesc)
            };
            return SqlHelper.ExcuteNonQuery(sql, paras) > 0;
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
            string sql = "SELECT Temp.Id AS 编号,Operator.RealName AS 操作员, Temp.ActionDate AS 操作时间, Temp.ActionDesc AS 描述 FROM(SELECT TOP (@LogNum) * FROM OperationLog WHERE Id NOT IN(SELECT TOP(@BeforeNum) Id FROM OperationLog)) AS Temp, Operator WHERE Temp.OperatorId = Operator.Id";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.Add(new SqlParameter("@LogNum", numPerPage));
            comm.Parameters.Add(new SqlParameter("@BeforeNum", (pageNo - 1) * 10 + 1));
            conn.Open();
            SqlDataReader sda = comm.ExecuteReader();
            for (int num = 0; num < sda.FieldCount; num++)
            {
                DataColumn column = new DataColumn();
                column.DataType = sda.GetFieldType(num);
                column.ColumnName = sda.GetName(num);
                dt.Columns.Add(column);
            }
            while (sda.Read())
            {
                DataRow dr = dt.NewRow();
                for (int num = 0; num < sda.FieldCount; num++)
                {
                    dr[num] = sda[num].ToString();
                }
                dt.Rows.Add(dr);
            }
            sda.Close();
            conn.Close();
            return dt;
        }
    }
}
