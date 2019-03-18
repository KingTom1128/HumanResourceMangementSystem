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

        public FormLogQuery()
        {
            InitializeComponent();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            currentPageNo = 1;
            DataGridView.DataSource = logServ.GetLogList(currentPageNo, NUM_PER_PAGE);
            totalPages = logServ.GetLogCount() / NUM_PER_PAGE + 1;
            lblAll.Text = "共" + totalPages + "页";
            lblNow.Text = "第" + currentPageNo + "页";
        }

        private void lblHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentPageNo = 1;
            DataGridView.DataSource = logServ.GetLogList(currentPageNo, NUM_PER_PAGE);
            totalPages = logServ.GetLogCount() / NUM_PER_PAGE + 1;
            lblAll.Text = "共" + totalPages + "页";
            lblNow.Text = "第" + currentPageNo + "页";
        }

        private void lblEnd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentPageNo = totalPages;
            DataGridView.DataSource = logServ.GetLogList(currentPageNo, NUM_PER_PAGE);
            totalPages = logServ.GetLogCount() / NUM_PER_PAGE + 1;
            lblAll.Text = "共" + totalPages + "页";
            lblNow.Text = "第" + currentPageNo + "页";
        }

        private void lblNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (currentPageNo == totalPages)
            {
                currentPageNo = 1;
            }
            else
            {
                currentPageNo++;
            }
            DataGridView.DataSource = logServ.GetLogList(currentPageNo, NUM_PER_PAGE);
            totalPages = logServ.GetLogCount() / NUM_PER_PAGE + 1;
            lblAll.Text = "共" + totalPages + "页";
            lblNow.Text = "第" + currentPageNo + "页";
        }

        private void lblLast_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (currentPageNo == 1)
            {
                currentPageNo = totalPages;
            }
            else
            {
                currentPageNo--;
            }
            DataGridView.DataSource = logServ.GetLogList(currentPageNo, NUM_PER_PAGE);
            totalPages = logServ.GetLogCount() / NUM_PER_PAGE + 1;
            lblAll.Text = "共" + totalPages + "页";
            lblNow.Text = "第" + currentPageNo + "页";
        }
    }
}
