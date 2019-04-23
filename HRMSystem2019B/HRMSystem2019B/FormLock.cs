using HRMDSystem.DAL;
using HRMSystem.Model;
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
    public partial class FormLock : Form
    {
        UserInfo ui = UserInfo.GetInstance();
        public FormLock()
        {
            InitializeComponent();
        }

        private void FormLock_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(CommonHelper.GetMD5(txtSecret.Text.Trim()) == ui.Password)
            {
                this.Close();
            }
            else
            {
                CommonHelper.FailedReply("密码错误!");
                return;
            }
        }
    }
}
