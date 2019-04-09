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
    public class EmployeeService
    {

        public string DeleteEmployee(string id)
        {
            string sql = "delete from Employee where Id = @Id";
            SqlParameter paraId = new SqlParameter("@Id", id);
            if (SqlHelper.ExcuteNonQuery(sql, paraId) > 0)
            {
                return "删除成功!";
            }
            else
            {
                return "删除失败!";
            }
        }

        public Employee GetEmployee(Guid Id)
        {
            Employee emp = null;
            string sql = "select * from Employee where Id = @Id";
            using (SqlDataReader reader = SqlHelper.GetDataReader(sql, new SqlParameter("Id", Id)))
            {
                if(reader.Read())
                {
                    emp = new Employee();
                    {
                        emp.Id = (Guid)reader["Id"];
                        emp.Number = reader["Number"].ToString();
                        emp.Name = reader["Name"].ToString();
                        emp.Birthday = (DateTime)reader["Birthday"];
                        emp.InDay = (DateTime)reader["InDay"];
                        emp.MarriageId = (Guid)reader["MarriageId"];
                        emp.PartyId = (Guid)reader["PartyId"];
                        emp.GenderId = (Guid)reader["GenderId"];
                        emp.DepartmentId = (Guid)reader["DepartmentId"];
                        emp.EducationId = (Guid)reader["EducationId"];
                        emp.Address = reader["Address"].ToString();
                        emp.Nation = reader["Nation"].ToString();
                        emp.Email = reader["Email"].ToString();
                        emp.NativePlace = reader["NativePlace"].ToString();
                        emp.Telephone = reader["Telephone"].ToString();
                        emp.Remarks = reader["Remarks"].ToString();
                        emp.Resume = reader["Resume"].ToString();
                    };
                    if(reader["Photo"] == DBNull.Value)
                    {
                        emp.Photo = null;
                    }
                    else
                    {
                        emp.Photo = (byte[])reader["Photo"];
                    }
                }
            }
            return emp;
        }

        public bool UpdateEmployee(Employee emp)
        {
            string sql = @"update Employee set Number = @Number, Name = @Name, Birthday = @Birthday,InDay = @InDay, 
            PartyId = @PartyId, EducationId = @EducationId, GenderId = @GenderId, DepartmentId = @DepartmentId, 
            Address = @Address, Email = @Email, Remarks = @Remarks, Resume = @Resume, Photo = @Photo,
            Nation = @Nation, NativePlace = @NativePlace where Id = @Id";
            SqlParameter[] parameters = GetSqlParametersFromEmployeeModel(emp);
            return SqlHelper.ExcuteNonQuery(sql, parameters) > 0;
        }

        public bool AddEmployee(Employee emp)
        {
            string sql = "insert into Employee values(@Id, @Number, @Name, @Birthday, @Inday, @MarriageId, @PartyId, @EducationId, @GenderId, @DepartmentId, @Telephone, @Address, @Email, @Remarks, @Resume, @Photo, @Nation, @NativePlace)";
            SqlParameter[] parameters = GetSqlParametersFromEmployeeModel(emp);
            return SqlHelper.ExcuteNonQuery(sql, parameters) > 0;
        }

        public SqlParameter[] GetSqlParametersFromEmployeeModel(Employee emp)
        {
            SqlParameter paramPhoto = new SqlParameter("@Photo", SqlDbType.Image);
            if (emp.Photo == null)
            {
                paramPhoto.Value = DBNull.Value;
            }
            else
            {
                paramPhoto.Value = emp.Photo;
            }
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", emp.Id),
                new SqlParameter("@Number", emp.Number),
                new SqlParameter("@Name", emp.Name),
                new SqlParameter("@Birthday", emp.Birthday),
                new SqlParameter("@InDay", emp.InDay),
                new SqlParameter("@MarriageId", emp.MarriageId),
                new SqlParameter("@PartyId", emp.PartyId),
                new SqlParameter("@EducationId", emp.EducationId),
                new SqlParameter("@GenderId", emp.GenderId),
                new SqlParameter("@DepartmentId", emp.DepartmentId),
                new SqlParameter("@Telephone", emp.Telephone),
                new SqlParameter("@Address", emp.Address),
                new SqlParameter("@Email", emp.Email),
                new SqlParameter("@Nation", emp.Nation),
                new SqlParameter("@NativePlace", emp.NativePlace),
                new SqlParameter("@Remarks", emp.Remarks),
                new SqlParameter("@Resume", emp.Resume),
                paramPhoto
            };
            return parameters;
        }

        public class Info
        {
            public Guid id { get; set; }
            public string s { get; set; }
        }
        public List<Info> GetInformation(string s)
        {
            List<Info> infors = new List<Info>();
            string sql = "select Id, Name from Dictionary where Category = " + s;
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                Info inf = new Info();
                inf.id = (Guid)dr["Id"];
                inf.s = dr["Name"].ToString();
                infors.Add(inf);
            }
            return infors;
        }

        public DataTable GetEmployeeList(Employee e)
        {
            List<string> whereList = new List<string>();
            List<SqlParameter> paraList = new List<SqlParameter>();
            string sql = "SELECT Id AS 编号,Number AS 工号,Name AS 姓名,InDay AS 入职日期,Nation AS 民族,NativePlace AS 籍贯 FROM Employee";
            if (e != null)
            {
                if (!string.IsNullOrEmpty(e.Name))
                {
                    whereList.Add("Name LIKE '%' + @Name + '%'");
                    paraList.Add(new SqlParameter("@Name", e.Name));
                }
                if (e.InDateFrom > DateTime.MinValue && e.InDateTo > DateTime.MinValue)
                {
                    whereList.Add("InDay >= @InDateFrom AND InDay <= @InDateTo");
                    paraList.Add(new SqlParameter("@InDateFrom", e.InDateFrom));
                    paraList.Add(new SqlParameter("@InDateTo", e.InDateTo));
                }
                if (e.DepartmentId != Guid.Empty)
                {
                    whereList.Add("DepartmentId = @DepartmentId");
                    paraList.Add(new SqlParameter("@DepartmentId", e.DepartmentId));
                }
                string strWhere = string.Join("AND", whereList);
                if (!string.IsNullOrEmpty(strWhere))
                {
                    sql += " WHERE " + strWhere;
                }
            }
            return SqlHelper.GetDataTable(sql, paraList.ToArray());
        }




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
