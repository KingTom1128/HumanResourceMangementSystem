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

        string userid;
        string connStr = "Data Source = .; Initial Catalog = HRMDB; User ID = hrmtest; pwd = test";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dr;
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
            userid = FormLogin.userid;
            if (userid != "admin")
            {
                CommonHelper.FailedReply("您没有权限修改该数据库！");
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
            conn = new SqlConnection(connStr);
            string sql = string.Format("insert into Operator(Id, UserName, Password, IsDeleted, RealName, IsLocked) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", txtId.Text, txtUserName.Text, txtPassword.Text, IsDelete, txtRealName.Text, IsLocked);
            conn.Open();
            comm = new SqlCommand(sql, conn);
            int n = comm.ExecuteNonQuery();
            if (n > 0)
            {
                CommonHelper.SuccessReply("添加成功");
                txtId.Text = "";
                txtPassword.Text = "";
                txtRealName.Text = "";
                txtUserName.Text = "";
                cmbIsDeleted.SelectedIndex = 0;
                cmbIsLocked.SelectedIndex = 0;
            }
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool IsDeleted = false;
            if (cmbIsDeleted.Text == "Yes")
            {
                IsDeleted = true;
            }
            else
            {
                IsDeleted = false;
            }
            conn = new SqlConnection(connStr);
            string sql = string.Format("update Operator set IsDeleted = '{0}' where UserName = '{1}'", IsDeleted, txtUserName.Text);
            conn.Open();
            comm = new SqlCommand(sql, conn);
            int n = comm.ExecuteNonQuery();
            if (n > 0)
            {
                CommonHelper.SuccessReply("操作成功！");
                txtUserName.Text = "";
            }
            else
            {
                CommonHelper.SuccessReply("操作失败！");
            }
            conn.Close();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            bool IsLocked = false;
            if (cmbIsLocked.Text == "Yes")
            {
                IsLocked = true;
            }
            else
            {
                IsLocked = false;
            }
            conn = new SqlConnection(connStr);
            string sql = string.Format("update Operator set IsLocked = '{0}' where UserName = '{1}'", IsLocked, txtUserName.Text);
            conn.Open();
            comm = new SqlCommand(sql, conn);
            int n = comm.ExecuteNonQuery();
            if (n > 0)
            {
                CommonHelper.SuccessReply("操作成功！");
                txtUserName.Text = "";
            }
            else
            {
                CommonHelper.SuccessReply("操作失败！");
            }
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            conn = new SqlConnection(connStr);
            string sql = string.Format("select * from Operator where UserName = '{0}'", txtUserName.Text);
            conn.Open();
            comm = new SqlCommand(sql, conn);
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                lblDisplay.Text = "UserName:  " + dr["UserName"].ToString() + "  Password:  " + dr["Password"].ToString() + "  RealName:  " + dr["RealName"].ToString() + "\n"; 
            }
            if (lblDisplay.Text != "")
            {
                CommonHelper.SuccessReply("查找成功！");
            }
            else
            {
                CommonHelper.FailedReply("查找失败！");
            }
            dr.Close();
            conn.Close();
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
