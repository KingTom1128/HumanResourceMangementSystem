using HRMDSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem2019B
{
    public partial class FormPasswordService : Form
    {
        string userid;
        public FormPasswordService()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Update up = new Update(userid, txtNewPassword.Text, txtConfirmPassword.Text);
            bool f = up.UpdateResult(CommonHelper.GetMD5(txtNewPassword.Text.Trim()), CommonHelper.GetMD5(txtConfirmPassword.Text.Trim()));
            if (f == true)
            {
                CommonHelper.SuccessReply("修改成功！");
                this.Close();
            }
            else
            {
                CommonHelper.FailedReply("修改失败！");
            }
        }

        private void FormPasswordService_Load(object sender, EventArgs e)
        {
            userid = FormLogin.userid;
        }
    }
}
