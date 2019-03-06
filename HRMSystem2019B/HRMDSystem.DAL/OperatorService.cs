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
        //查询
        public string Search(string username)
        {
            string s = "";
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
                s = "UserName:  " + sdr["UserName"].ToString() + "\n" + "Password:  " + sdr["Password"].ToString() + "\n" + "RealName:  " + sdr["RealName"].ToString() + "\n";
            }
            else
            {
                s = null;
            }
            conn.Close();
            return s;
        }
        //添加
        public bool Add(Guid id, string username, string password, bool isdeleted, string realname, bool islocked)
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string sql = string.Format("insert into Operator(Id, UserName, Password, IsDeleted, RealName, IsLocked) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", id, username, password, isdeleted, realname, islocked); ;
            SqlParameter paraUserName = new SqlParameter("@UserName", username);
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.Add(paraUserName);
            conn.Open();
            int n = (int)comm.ExecuteNonQuery();
            conn.Close();
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //删除
        public bool Delete(string username, bool flag)
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string sql = string.Format("update Operator set IsDeleted = '{0}' where UserName = '{1}'", flag, username);
            SqlParameter paraUserName = new SqlParameter("@UserName", username);
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.Add(paraUserName);
            conn.Open();
            int n = (int)comm.ExecuteNonQuery();
            conn.Close();
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //锁定
        public bool Lock(string username, bool flag)
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string sql = string.Format("update Operator set IsLocked = '{0}' where UserName = '{1}'", flag, username);
            SqlParameter paraUserName = new SqlParameter("@UserName", username);
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.Add(paraUserName);
            conn.Open(); 
            int n = (int)comm.ExecuteNonQuery();
            conn.Close();
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //修改密码
        public bool Update(string username, string newpwd)
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string sql = string.Format("update Operator set Password = '{0}' where Username = '{1}'", newpwd, username);
            SqlParameter paraUserName = new SqlParameter("@UserName", username);
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.Add(paraUserName);
            conn.Open();
            int n = (int)comm.ExecuteNonQuery();
            conn.Close();
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
