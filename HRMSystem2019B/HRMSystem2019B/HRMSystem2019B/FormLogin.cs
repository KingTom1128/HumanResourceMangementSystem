using HRMSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            string username = txtUserName.Text.Trim();
            string password = CommonHelper.GetMD5(txtPassword.Text.Trim());

            LoginUser lu = new LoginUser(username, password);
            LoginUser.LoginResult lr = lu.IsValid();

            if (lr == LoginUser.LoginResult.UserNameError)
            {
                CommonHelper.FailedReply("用户名错误！");
                this.DialogResult = DialogResult.Cancel;
            }
            else if (lr == LoginUser.LoginResult.PasswordError)
            {
                CommonHelper.FailedReply("密码错误！");
                this.DialogResult = DialogResult.Cancel;
            }
            else if (lr == LoginUser.LoginResult.LockedError)
            {
                CommonHelper.FailedReply("用户锁定！");
                this.DialogResult = DialogResult.Cancel;
            }
            else if (lr == LoginUser.LoginResult.DeletedError)
            {
                CommonHelper.FailedReply("用户不存在！");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                CommonHelper.SuccessReply("登陆成功！");
                this.DialogResult = DialogResult.OK;
            }

            //while (sdr.Read())
            //{
            //    //判断是否被删除
            //    if (Convert.ToBoolean(sdr["IsDeleted"]) == true)
            //    {
            //        CommonHelper.SuccessReply("此用户已被删除！");
            //        this.DialogResult = DialogResult.Cancel;
            //    }
            //    //判断是否被锁定
            //    else if (Convert.ToBoolean(sdr["IsLocked"]) == true)
            //    {
            //        CommonHelper.SuccessReply("此用户已被锁定！");
            //        this.DialogResult = DialogResult.Cancel;
            //    }
            //    //判断用户名或密码错误
            //    else if (sdr["UserName"].ToString() != user && sdr["Password"].ToString() == password)
            //    {
            //        CommonHelper.SuccessReply("用户名错误！");
            //        this.DialogResult = DialogResult.Cancel;
            //    }
            //    else if (sdr["Password"].ToString() != password && sdr["UserName"].ToString() == user)
            //    {
            //        CommonHelper.SuccessReply("密码错误！");
            //        this.DialogResult = DialogResult.Cancel;
            //    }
            //    else if (sdr["Password"].ToString() != password && sdr["UserName"].ToString() != user)
            //    {
            //        CommonHelper.SuccessReply("用户名或密码错误！");
            //        this.DialogResult = DialogResult.Cancel;
            //    }
            //    //正常登录
            //    else
            //    {
            //        userid = user;
            //        CommonHelper.SuccessReply("欢迎使用本系统！");
            //        this.DialogResult = DialogResult.OK;
            //    }
            //}
            //sdr.Close();
            //conn.Close();
        }
    }
}
