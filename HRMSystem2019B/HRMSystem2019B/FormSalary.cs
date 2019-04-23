using HRMDSystem.BLL;
using HRMDSystem.DAL;
using HRMSystem.Model;
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
    public partial class FormSalary : Form
    {
        EmployeeService es = new EmployeeService();
        SalaryService ss = new SalaryService();

        public FormSalary()
        {
            InitializeComponent();
        }

        private void FormSalary_Load(object sender, EventArgs e)
        {
            cmbDepartment.DataSource = es.GetDepartment();
            cmbDepartment.DisplayMember = "Name";
            cmbDepartment.ValueMember = "Id";

            cmbDepartment.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbMonth.SelectedIndex = -1;

            for (int i = -10; i <= 10; i++)
            {
                cmbYear.Items.Add((Convert.ToString(2019  + i)));
            }

            for (int i = 1; i  <= 12; i++)
            {
                cmbMonth.Items.Add((Convert.ToString(i)));
            }

        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            //是否为空
            if (cmbYear.SelectedIndex == -1 || cmbMonth.SelectedIndex == -1 || cmbDepartment.SelectedIndex == -1)
            {
                CommonHelper.FailedReply("不能为空！");
                return;
            }

            int year = int.Parse(cmbYear.Text);
            int month = int.Parse(cmbMonth.Text);
            Guid depId = (Guid)cmbDepartment.SelectedValue;
            Guid sheetId = ss.GetSalarySheetId(year, month, depId);


            if(sheetId == Guid.Empty)
            {
                //生成新的工资单
                SalarySheet sheet = new SalarySheet();
                sheet.Id = Guid.NewGuid();
                sheet.Year = year;
                sheet.Month = month;
                sheet.DepartmentId = depId;
                ss.BuildNewSalarySheet(sheet);
                ss.BuildSalaryItems(sheet.Id, depId);
                DataGridView.DataSource = ss.GetSalarySheetItems(sheet.Id);
            }
            else
            {
                //是否重新生成
                DialogResult dr = MessageBox.Show("已经生成该工资表，是否重新生成？", "警告", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    ss.DeleteSalaryItems(sheetId);
                    ss.BuildSalaryItems(sheetId, depId);
                    DataGridView.DataSource = ss.GetSalarySheetItems(sheetId);
                }
                else
                {
                    DataGridView.DataSource = ss.GetSalarySheetItems(sheetId);
                }
            }
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SalarySheetItem item = null;
            for (int i = 0; i < DataGridView.Rows.Count - 1; i++)
            {
                item = new SalarySheetItem();
                item.Id = (Guid)DataGridView.Rows[i].Cells[0].Value;
                item.BaseSalary = (decimal)DataGridView.Rows[i].Cells[2].Value;
                item.Bonus = (decimal)DataGridView.Rows[i].Cells[3].Value;
                item.Fine = (decimal)DataGridView.Rows[i].Cells[4].Value;
                item.Other = (decimal)DataGridView.Rows[i].Cells[5].Value;
                ss.UpdateSalaryItems(item);
            }
            CommonHelper.SuccessReply("工资单保存成功!");
    }
    }
}
