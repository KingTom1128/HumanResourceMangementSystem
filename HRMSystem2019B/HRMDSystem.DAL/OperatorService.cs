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
        //登陆
        public Operator GetOperator(string username)
        {
            Operator op = null;
            string sql = "select * from Operator where UserName = @UserName";
            SqlParameter paraUserName = new SqlParameter("@UserName", username);
            using(SqlDataReader sdr = SqlHelper.GetDataReader(sql, paraUserName))
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
            return op;
        }
        //查询
        public string Search(string username)
        {
            string s = "";
            string sql = "select * from Operator where UserName = @UserName";
            SqlParameter paraUserName = new SqlParameter("@UserName", username);
            using (SqlDataReader sdr = SqlHelper.GetDataReader(sql, paraUserName))
                if (sdr.Read())
                {
                    s = "UserName:  " + sdr["UserName"].ToString() + "\n" + "Password:  " + sdr["Password"].ToString() + "\n" + "RealName:  " + sdr["RealName"].ToString() + "\n";
                }
                else
                {
                    s = null;
                }
            return s;
        }
        //添加
        public bool Add(Guid id, string username, string password, bool isdeleted, string realname, bool islocked)
        {
            string sql = "insert into Operator(Id, UserName, Password, IsDeleted, RealName, IsLocked) values(@Id, @UserName, @Password, @IsDeleted, @RealName, @IsLocked)";
            SqlParameter[] paras =
            {
                new SqlParameter("@Id", id),
                new SqlParameter("@UserName", username),
                new SqlParameter("@Password", password),
                new SqlParameter("@IsDeleted", isdeleted),
                new SqlParameter("@RealName", realname),
                new SqlParameter("@IsLocked", islocked)
            };
            return SqlHelper.ExcuteNonQuery(sql, paras) > 0;
        }
        //删除
        public bool Delete(string username, bool flag)
        {
            string sql = "update Operator set IsDeleted = @IsDeleted where UserName = @UserName";
            SqlParameter[] paras =
            {
                new SqlParameter("@IsDeleted", flag),
                new SqlParameter("@UserName", username),
            };
            return SqlHelper.ExcuteNonQuery(sql, paras) > 0;
        }
        //锁定
        public bool Lock(string username, bool flag)
        {
            string sql = "update Operator set IsLocked = @IsLocked where UserName = @UserName";
            SqlParameter[] paras =
            {
                new SqlParameter("@IsLocked", flag),
                new SqlParameter("@UserName", username),
            };
            return SqlHelper.ExcuteNonQuery(sql, paras) > 0;
        }
        //修改密码
        public bool Update(string username, string newpwd)
        {
            string sql = "update Operator set Password = @Password where Username = @UserName";
            SqlParameter[] paras =
            {
                new SqlParameter("@UserName", username),
                new SqlParameter("@Password", newpwd),
            };
            return SqlHelper.ExcuteNonQuery(sql, paras) > 0;
        }
    }
}
