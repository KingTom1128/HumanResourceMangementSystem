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
    class SqlHelper
    {
        public static int ExcuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddRange(parameters);
            conn.Open();
            int n = comm.ExecuteNonQuery();
            conn.Close();
            return n;
        }

        public static DataTable GetDataTable(string sql, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            sda.SelectCommand.Parameters.AddRange(parameters);
            sda.Fill(dt);
            return dt;
        }

        public static SqlDataReader GetDataReader(string sql, params SqlParameter[] parameters)
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddRange(parameters);
            conn.Open();
            SqlDataReader dr = comm.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
    }
}
