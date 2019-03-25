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
                sql += " and Employee.Name = @Name";
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

    }
}
