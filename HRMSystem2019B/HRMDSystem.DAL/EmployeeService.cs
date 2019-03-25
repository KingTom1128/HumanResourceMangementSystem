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
    public class EmployeeService
    {
        public DataTable GetList()
        {
            DataTable dt = new DataTable();
            string sql = @"select Id as 编号, Number as 工号, Name as 姓名,
                InDay as 入职时间, Nation as 民族, NativePlace as 籍贯 from Employee";
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand comm = new SqlCommand(sql, conn);
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
        public class Department
        {
            public Guid id { get; set; }
            public string name { get; set; }
        }
        public List<Department> GetDepartment()
        {
            List<Department> departments = new List<Department>();
            string sql = "select * from Department";
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                Department depart = new Department();
                depart.id = (Guid)dr["Id"];
                depart.name = dr["Name"].ToString();
                departments.Add(depart);
            }
            return departments;
        }

        public DataTable GetSearch(string sql, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddRange(parameters);
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
