using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMDSystem.DAL
{
    public class OperatorService
    {
        public Operator GetOperator(string username)
        {
            Operator op = null;
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "select * from Operator where UserName = @UserName";
            SqlParameter paraUserName = new SqlParameter("@UserName", username);
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.Add(paraUserName);

            conn.Open();

            SqlDataReader sdr = comm.ExecuteReader();

            if (sdr.Read())
            {
                op = new Operator();
                op.Id = (Guid)sdr["Id"];
                op.UserName = sdr["UserName"].ToString();
                op.Password = sdr["Password"].ToString();
                op.IsDeleted = (bool)sdr["IsDeleted"];
                op.RealName = sdr["RealName"].ToString();
                op.IsLocked = (bool)sdr["IsLocked"];
            }


            conn.Close();
            return op;
        }
        

    }
}
