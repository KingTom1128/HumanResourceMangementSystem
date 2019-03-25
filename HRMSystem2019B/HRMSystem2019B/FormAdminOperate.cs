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
using static HRMDSystem.BLL.Administrator;
using static HRMDSystem.BLL.Administrator.Update;

namespace HRMSystem2019B
{
    public partial class FormAdminOperate : Form
    {
        public FormAdminOperate()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            string username = txtUserName.Text.Trim();
            Search sea = new Search(username);
            string seaResult = sea.SearchResult();
            if (seaResult != null)
            {
                lblDisplay.Text = seaResult;
                CommonHelper.SuccessReply("查找成功!");
            }
            else
            {
                CommonHelper.FailedReply(seaResult);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool IsDelete = false;
            bool IsLocked = false;
            if (cmbIsDeleted.Text == "Yes")
            {
                IsDelete = true;
            }
            if (cmbIsLocked.Text == "Yes")
            {
                IsLocked = true;
            }
            txtId.Text = Guid.NewGuid().ToString();
            Guid guid = new Guid(txtId.Text);
            Add ad = new Add(guid, txtUserName.Text, CommonHelper.GetMD5(txtPassword.Text.Trim()), IsDelete, txtRealName.Text, IsLocked);
            bool f = ad.AddResult();
            if (f == true)
            {
                CommonHelper.SuccessReply("添加成功！");
            }
            else
            {
                CommonHelper.FailedReply("添加失败！");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool IsDeleted;
            if (cmbIsDeleted.Text == "Yes")
            {
                IsDeleted = true;
            }
            else
            {
                IsDeleted = false;
            }
            string username = txtUserName.Text.Trim();
            Delete de = new Delete(username, IsDeleted);
            bool f = de.DeleteResult();
            if (f == true)
            {
                CommonHelper.SuccessReply("操作成功！");
            }
            else
            {
                CommonHelper.FailedReply("操作失败！");
            }
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            bool IsLocked;
            if (cmbIsLocked.Text == "Yes")
            {
                IsLocked = true;
            }
            else
            {
                IsLocked = false;
            }
            string username = txtUserName.Text.Trim();
            Lock lo = new Lock(username, IsLocked);
            bool f = lo.LockResult();
            if (f == true)
            {
                CommonHelper.SuccessReply("操作成功！");
            }
            else
            {
                CommonHelper.FailedReply("操作失败！");
            }
        }

        private void FormAdminOperate_Load(object sender, EventArgs e)
        {
            UserInfo ui = UserInfo.GetInstance();
            if (ui.UserName != "admin")
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnLock.Enabled = false;
                btnSearch.Enabled = false;
                txtId.Enabled = false;
                txtPassword.Enabled = false;
                txtRealName.Enabled = false;
                txtUserName.Enabled = false;
                cmbIsDeleted.Enabled = false;
                cmbIsLocked.Enabled = false;
            }
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            //全部可见，初始化
            lblId.Visible = true;
            lblIsDeleted.Visible = true;
            lblIsLocked.Visible = true;
            lblPassword.Visible = true;
            lblRealName.Visible = true;
            lblUserName.Visible = true;
            txtId.Visible = true;
            cmbIsDeleted.Visible = true;
            cmbIsLocked.Visible = true;
            txtPassword.Visible = true;
            txtRealName.Visible = true;
            txtUserName.Visible = true;
            //根据需求隐藏
            lblId.Visible = false;
            lblIsDeleted.Visible = false;
            lblIsLocked.Visible = false;
            lblPassword.Visible = false;
            lblRealName.Visible = false;
            cmbIsDeleted.Visible = false;
            cmbIsLocked.Visible = false;
            txtId.Visible = false;
            txtPassword.Visible = false;
            txtRealName.Visible = false;
            //txt
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            lblId.Visible = true;
            lblIsDeleted.Visible = true;
            lblIsLocked.Visible = true;
            lblPassword.Visible = true;
            lblRealName.Visible = true;
            lblUserName.Visible = true;
            txtId.Visible = true;
            cmbIsDeleted.Visible = true;
            cmbIsLocked.Visible = true;
            txtPassword.Visible = true;
            txtRealName.Visible = true;
            txtUserName.Visible = true;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            //全部可见，初始化
            lblId.Visible = true;
            lblIsDeleted.Visible = true;
            lblIsLocked.Visible = true;
            lblPassword.Visible = true;
            lblRealName.Visible = true;
            lblUserName.Visible = true;
            txtId.Visible = true;
            cmbIsDeleted.Visible = true;
            cmbIsLocked.Visible = true;
            txtPassword.Visible = true;
            txtRealName.Visible = true;
            txtUserName.Visible = true;
            //根据需求隐藏
            lblId.Visible = false;
            lblIsLocked.Visible = false;
            lblPassword.Visible = false;
            lblRealName.Visible = false;
            txtId.Visible = false;
            cmbIsLocked.Visible = false;
            txtPassword.Visible = false;
            txtRealName.Visible = false;
        }

        private void btnLock_MouseEnter(object sender, EventArgs e)
        {
            //全部可见，初始化
            lblId.Visible = true;
            lblIsDeleted.Visible = true;
            lblIsLocked.Visible = true;
            lblPassword.Visible = true;
            lblRealName.Visible = true;
            lblUserName.Visible = true;
            txtId.Visible = true;
            cmbIsDeleted.Visible = true;
            cmbIsLocked.Visible = true;
            txtPassword.Visible = true;
            txtRealName.Visible = true;
            txtUserName.Visible = true;
            //根据需求隐藏
            lblId.Visible = false;
            lblIsDeleted.Visible = false;
            lblPassword.Visible = false;
            lblRealName.Visible = false;
            txtId.Visible = false;
            cmbIsDeleted.Visible = false;
            txtPassword.Visible = false;
            txtRealName.Visible = false;
        }
    }
}
