using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem2019B
{
    public partial class FormLogin : Form
    {
        public static string userid;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string connStr = "Data Source = .; Initial Catalog = HRMDB; User ID = hrmtest; pwd = test";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = "SELECT * FROM Operator WHERE UserName = @UserName or Password = @Password";
            SqlParameter paraUserName = new SqlParameter("@UserName", user);
            SqlParameter paraPassword = new SqlParameter("@Password", password);
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.Add(paraUserName);
            comm.Parameters.Add(paraPassword);
            SqlDataReader sdr = comm.ExecuteReader();
            while(sdr.Read())
            {
                //判断是否被删除
                if (Convert.ToBoolean(sdr["IsDeleted"]) == true)
                {
                    CommonHelper.SuccessReply("此用户已被删除！");
                    this.DialogResult = DialogResult.Cancel;
                }
                //判断是否被锁定
                else if (Convert.ToBoolean(sdr["IsLocked"]) == true)
                {
                    CommonHelper.SuccessReply("此用户已被锁定！");
                    this.DialogResult = DialogResult.Cancel;
                }
                //判断用户名或密码错误
                else if (sdr["UserName"].ToString() != user && sdr["Password"].ToString() == password)
                {
                    CommonHelper.SuccessReply("用户名错误！");
                    this.DialogResult = DialogResult.Cancel;
                }
                else if (sdr["Password"].ToString() != password && sdr["UserName"].ToString() == user)
                {
                    CommonHelper.SuccessReply("密码错误！");
                    this.DialogResult = DialogResult.Cancel;
                }
                else if (sdr["Password"].ToString() != password && sdr["UserName"].ToString() != user)
                {
                    CommonHelper.SuccessReply("用户名或密码错误！");
                    this.DialogResult = DialogResult.Cancel;
                }
                //正常登录
                else
                {
                    userid = user;
                    CommonHelper.SuccessReply("欢迎使用本系统！");
                    this.DialogResult = DialogResult.OK;
                }
            }
            sdr.Close();
            conn.Close();
        }
    }
}
