using HRMDSystem.DAL;
using HRMSystem.BLL;
using HRMSystem.Model;
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

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = CommonHelper.GetMD5(txtPassword.Text.Trim());

            OperatorService opsv = new OperatorService();
            Operator op = opsv.GetOperator(username);

            OperationLog log = new OperationLog();
            OperationLogService logsv = new OperationLogService();

            if (op == null || op.UserName != username)
            {
                log.OperatorId = Guid.Empty;
                log.ActionDate = DateTime.Now;
                log.ActionDesc = username + ":用户名不正确";
                CommonHelper.FailedReply("用户名错误！");
                this.DialogResult = DialogResult.Cancel;
            }
            else if (op.Password != password)
            {
                CommonHelper.FailedReply("密码错误！");
                this.DialogResult = DialogResult.Cancel;
            }
            else if (op.IsLocked == true)
            {
                CommonHelper.FailedReply("用户锁定！");
                this.DialogResult = DialogResult.Cancel;
            }
            else if(op.IsDeleted == true)
            {
                CommonHelper.FailedReply("用户不存在！");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                UserInfo ui = UserInfo.GetInstance();
                ui.Id = op.Id;
                ui.UserName = op.UserName;
                ui.Password = op.Password;
                ui.RealName = op.RealName;

                log.OperatorId = op.Id;
                log.ActionDate = DateTime.Now;
                log.ActionDesc = username + "登录成功！";
                

                CommonHelper.SuccessReply("登陆成功！");
                this.DialogResult = DialogResult.OK;
            }
            logsv.Add(log);
        }
    }
}
