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
    public class DepartmentService
    {
        //查询
        public string Search(string name)
        {
            string s = "";
            string sql = "select * from Department where Name = @Name";
            SqlParameter paraName = new SqlParameter("@Name", name);
            using (SqlDataReader sdr = SqlHelper.GetDataReader(sql, paraName))
                if (sdr.Read())
                {
                    s = "Id:" + sdr["Id"].ToString() + "\n" + "Name:  " + sdr["Name"].ToString() + "\n";
                }
                else
                {
                    s = null;
                }
            return s;
        }

        //添加
        public bool Add(Guid id, string name)
        {
            string sql = "insert into Department(Id, Name) values(@Id, @Name)";
            SqlParameter[] paras =
            {
                new SqlParameter("@Id", id),
                new SqlParameter("@Name", name),
            };
            return SqlHelper.ExcuteNonQuery(sql, paras) > 0;
        }

        //删除
        public bool Delete(string name)
        {
            string sql = "delete from Department where Name = @Name";
            SqlParameter[] paras =
            {
                new SqlParameter("@Name", name)
            };
            return SqlHelper.ExcuteNonQuery(sql, paras) > 0;
        }

        //修改
        public bool Update(string oldde, string newde)
        {
            string sql = "update Department set Name = @NewDe where Name = @OldDe";
            SqlParameter[] paras =
            {
                new SqlParameter("@NewDe", newde),
                new SqlParameter("@OldDe", oldde),
            };
            return SqlHelper.ExcuteNonQuery(sql, paras) > 0;
        }
    }
}
