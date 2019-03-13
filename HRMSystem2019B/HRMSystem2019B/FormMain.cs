using HRMDSystem.BLL;
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
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin f1 = new FormLogin();
            if (f1.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            UserInfo ui = UserInfo.GetInstance();
            tssInfo.Text = string.Format("欢迎'{0}'，登录时间:'{1}'", ui.RealName, DateTime.Now.ToString());

        }

        private void 操作员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminOperate f1 = new FormAdminOperate();
            f1.MdiParent = this;
            f1.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPasswordService f1 = new FormPasswordService();
            f1.MdiParent = this;
            f1.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 切换账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f1 = new FormLogin();
            f1.StartPosition = FormStartPosition.CenterParent;
            f1.ShowDialog(); 
        }

        private void 日志查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogQuery f1 = new FormLogQuery();
            f1.MdiParent = this;
            f1.Show();
        }
    }
}
