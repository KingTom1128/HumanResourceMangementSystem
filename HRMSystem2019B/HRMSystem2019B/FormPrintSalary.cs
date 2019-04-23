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
    public partial class FormPrintSalary : Form
    {
        EmployeeService es = new EmployeeService();
        SalaryService ss = new SalaryService();
        SalarySheetItem ssh = new SalarySheetItem();
        public FormPrintSalary()
        {
            InitializeComponent();
        }

        private void FormPrintSalary_Load(object sender, EventArgs e)
        {
            cmbDepartment.DataSource = es.GetDepartment();
            cmbDepartment.DisplayMember = "Name";
            cmbDepartment.ValueMember = "Id";

            cmbDepartment.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbMonth.SelectedIndex = -1;

            for (int i = -10; i <= 10; i++)
            {
                cmbYear.Items.Add((Convert.ToString(2019 + i)));
            }

            for (int i = 1; i <= 12; i++)
            {
                cmbMonth.Items.Add((Convert.ToString(i)));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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

            Guid id = ss.GetSalarySheetId(year, month, depId);


            if (id == Guid.Empty)
            {
                //生成新的工资单
                CommonHelper.FailedReply("没有工资单，请先生成工资单！");
                return;
            }
            else
            {
                DataTable dt = ss.GetSalarySheetItems(id);
                List<SalarySheetItemReport> items = new List<SalarySheetItemReport>();
                SalarySheetItemReport item;
                foreach(DataRow dr in dt.Rows)
                {
                    item = new SalarySheetItemReport();
                    item.EmployeeName = dr["姓名"].ToString();
                    item.BaseSalary = (decimal)dr["基本工资"];
                    item.Bonus = (decimal)dr["奖金"];
                    item.Fine = (decimal)dr["罚款"];
                    item.Other = (decimal)dr["其他"];
                    items.Add(item);
                }

                CrystalReportSalarySheet report = new CrystalReportSalarySheet();
                report.SetDataSource(items);
                report.SetParameterValue("Y", year);
                report.SetParameterValue("M", month);
                report.SetParameterValue("D", cmbDepartment.Text);

                CrystalReportViewer.ReportSource = report;
            }
        }

    }
}
