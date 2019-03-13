using HRMDSystem.DAL;
using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem2019B
{
    public partial class FormLogQuery : Form
    {
        const int NUM_PER_PAGE = 10;
        public int currentPageNo;
        public int totalPages;
        OperationLogService logServ = new OperationLogService();

        public void Show(int pageNo)
        {

        }



        public FormLogQuery()
        {
            InitializeComponent();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            currentPageNo = 1;
            DataGridView.DataSource = logServ.GetLogList(10, currentPageNo + 9 * (currentPageNo -1));
            totalPages = logServ.GetLogCount() / 10 + 1;
            lblAll.Text = "共" + totalPages + "页";
            lblNow.Text = "第" + currentPageNo + "页";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPageNo == totalPages)
            {
                currentPageNo = 1;
            }
            else
            {
                currentPageNo++;
            }
            DataGridView.DataSource = logServ.GetLogList(10, currentPageNo + 9 * (currentPageNo - 1));
            totalPages = logServ.GetLogCount() / 10 + 1;
            lblAll.Text = "共" + totalPages + "页";
            lblNow.Text = "第" + currentPageNo + "页";
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (currentPageNo == 1 )
            {
                currentPageNo = totalPages;
            }
            else
            {
                currentPageNo --;
            }
            DataGridView.DataSource = logServ.GetLogList(10, currentPageNo + 9 * (currentPageNo - 1));
            totalPages = logServ.GetLogCount() / 10 + 1;
            lblAll.Text = "共" + totalPages + "页";
            lblNow.Text = "第" + currentPageNo + "页";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentPageNo = 1;
            DataGridView.DataSource = logServ.GetLogList(10, currentPageNo + 9 * (currentPageNo - 1));
            totalPages = logServ.GetLogCount() / 10 + 1;
            lblAll.Text = "共" + totalPages + "页";
            lblNow.Text = "第" + currentPageNo + "页";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            currentPageNo = totalPages;
            DataGridView.DataSource = logServ.GetLogList(10, currentPageNo + 9 * (currentPageNo - 1));
            totalPages = logServ.GetLogCount() / 10 + 1;
            lblAll.Text = "共" + totalPages + "页";
            lblNow.Text = "第" + currentPageNo + "页";
        }
    }
}
