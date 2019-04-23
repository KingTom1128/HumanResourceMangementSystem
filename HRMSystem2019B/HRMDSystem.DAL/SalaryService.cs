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
    public class SalaryService
    {
        EmployeeService es = new EmployeeService();

        public DataTable GetSalarySheetItems(Guid sheetId)
        {
            string sql = @"select Employee.Id as 编号, Employee.Name as 姓名, SalarySheetItem.BaseSalary as 基本工资, SalarySheetItem.Bonus as 奖金, 
                SalarySheetItem.Fine as 罚款,SalarySheetItem.Other as 其他 from Employee, SalarySheetItem 
                where Employee.Id = SalarySheetItem.EmployeeId and SalarySheetItem.SheetId = @sheetId";
            SqlParameter parameter = new SqlParameter("@sheetId", sheetId);
            return SqlHelper.GetDataTable(sql, parameter);
        }


        public Guid GetSalarySheetId(int year, int month, Guid deptId)
        {
            string sql = "select * from SalarySheet where Year = @Year and Month = @Month and DepartmentId = @DepartmentId"; ;
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Year", year),
                new SqlParameter("@Month", month),
                new SqlParameter("@DepartmentId", deptId)
            };
            using (SqlDataReader dr = SqlHelper.GetDataReader(sql, parameters))
            {
                if(dr.Read())
                {
                    return (Guid)dr["Id"];
                }
                else
                {
                    return Guid.Empty;
                }
            }
        }

        public Guid BuildNewSalarySheet(SalarySheet sheet)
        {
            string sql = "insert into SalarySheet values(@Id, @Year, @Month, @DepartmentId)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", sheet.Id),
                new SqlParameter("@Year", sheet.Year),
                new SqlParameter("@Month", sheet.Month),
                new SqlParameter("@DepartmentId", sheet.DepartmentId)
            };
            if(SqlHelper.ExcuteNonQuery(sql, parameters) > 0)
            {
                return sheet.Id;
            }
            else
            {
                return Guid.Empty;
            }
        }

        public DataTable DeleteSalaryItems(Guid sheetId)
        {
            string sql = "delete from SalarySheetItem where SheetId = @sheetId";
            SqlParameter paras = new SqlParameter("@sheetId", sheetId);
            return SqlHelper.GetDataTable(sql, paras);
        }

        public void BuildSalaryItems(Guid sheetId, Guid depId)
        {
            Employee e = new Employee();
            e.DepartmentId = depId;
            DataTable dt = es.GetEmployeeList(e);
            Guid empId;
            string sql;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                empId = (Guid)dt.Rows[i]["编号"];
                sql = "insert into SalarySheetItem values(@Id, @SheetId, @EmployeeId, 0, 0, 0, 0)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Id", Guid.NewGuid()),
                    new SqlParameter("@SheetId", sheetId),
                    new SqlParameter("@EmployeeId", empId)
                };
                SqlHelper.ExcuteNonQuery(sql, parameters);
            }
        }

        public bool UpdateSalaryItems(SalarySheetItem item)
        {
            string sql = "update SalarySheetItem set BaseSalary = @BaseSalary, Bonus = @Bonus, Fine = @Fine, Other = @Other where EmployeeId = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("Id", item.Id),
                new SqlParameter("BaseSalary", item.BaseSalary),
                new SqlParameter("Bonus", item.Bonus),
                new SqlParameter("Fine", item.Fine),
                new SqlParameter("Other", item.Other)
            };
            return SqlHelper.ExcuteNonQuery(sql, parameters) > 0;
        }
    }
}
