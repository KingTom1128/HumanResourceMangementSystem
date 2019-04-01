using HRMDSystem.BLL;
using HRMDSystem.DAL;
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
    public partial class FormEmployeeList : Form
    {
        EmployeeOperation eo = new EmployeeOperation();
        EmployeeService es = new EmployeeService();
        public FormEmployeeList()
        {
            InitializeComponent();
        }

        private void FormEmployeeList_Load(object sender, EventArgs e)
        {

            DataGridView.DataSource = eo.SearchResult();
            cmbDepartment.DataSource = es.GetDepartment();
            cmbDepartment.DisplayMember = "Name";
            cmbDepartment.ValueMember = "Id";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select Employee.Id as 编号, Number as 工号, Employee.Name as 姓名, InDay as 入职时间, Nation as 民族, NativePlace as 籍贯 from Employee, Department where Department.Id = Employee.DepartmentId";
            if(chbName.Checked)
            {
                sql += " and Employee.Name like '%' + @Name + '%'";
            }
            if (chbDepartment.Checked)
            {
                sql += " and Employee.DepartmentId = @DeId";
            }
            if (chbTime.Checked)
            {
                sql += " and Employee.InDay > @Start and Employee.InDay < @End";
            }
            SqlParameter[] paras =
           {
                new SqlParameter("@Name", txtName.Text),
                new SqlParameter("@DeId", cmbDepartment.SelectedValue.ToString()),
                new SqlParameter("@Start", TimeIn.Value),
                new SqlParameter("@End", TimeOut.Value),
            };
            DataGridView.DataSource = es.GetSearch(sql, paras);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormEmployeeUI feu = new FormEmployeeUI();
            DialogResult dr = feu.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.FormEmployeeList_Load(null, null);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(DataGridView.SelectedRows.Count > 0)
            {
                string strId = DataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if(string.IsNullOrEmpty(strId))
                {
                    CommonHelper.FailedReply("请选择一个正确的行！");
                }
                else
                {
                    Guid id = Guid.Parse(strId);
                    FormEmployeeUI fe = new FormEmployeeUI(id);
                    if(fe.ShowDialog() == DialogResult.OK)
                    {
                        this.FormEmployeeList_Load(null, null);
                    }
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count > 0)
            {
                string strId = DataGridView.SelectedRows[0].Cells[0].Value.ToString();
                if (string.IsNullOrEmpty(strId))
                {
                    CommonHelper.FailedReply("请选择一个正确的行！");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("您确认删除吗?", "警告", MessageBoxButtons.OKCancel); ;
                    
                    if(dr == DialogResult.OK)
                    {
                        CommonHelper.FailedReply(es.DeleteEmployee(strId));
                    }

                    this.FormEmployeeList_Load(null, null);
                }
            }
        }
    }
}
