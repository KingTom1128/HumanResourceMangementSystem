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

        private void 日志查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogQuery f1 = new FormLogQuery();
            f1.MdiParent = this;
            f1.Show();
        }

        private void 员工管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEmployeeList f1 = new FormEmployeeList();
            f1.MdiParent = this;
            f1.Show();
        }

        private void 部门管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepartment f1 = new FormDepartment();
            f1.MdiParent = this;
            f1.Show();
        }

        private void 生成工资单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSalary f1 = new FormSalary();
            f1.MdiParent = this;
            f1.Show();
        }

        private void 字典管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDictionary f1 = new FormDictionary();
            f1.MdiParent = this;
            f1.Show();
        }

        private void 打印工资单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrintSalary f1 = new FormPrintSalary();
            f1.MdiParent = this;
            f1.Show();
        }

        private void 关于我们ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout f1 = new FormAbout();
            f1.ShowDialog();
        }

        private void 系统锁定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLock f1 = new FormLock();
            f1.ShowDialog();
        }

        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalculator f1 = new FormCalculator();
            f1.MdiParent = this;
            f1.Show();
        }

        private void 切换账号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain fm = new FormMain();
            fm.Show();
        }

        private void 公司信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompanyInformation f1 = new FormCompanyInformation();
            f1.MdiParent = this;
            f1.Show();
        }
    }
}
