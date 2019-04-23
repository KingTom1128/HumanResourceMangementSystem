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
    public partial class FormCompanyInformation : Form
    {
        public FormCompanyInformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMoney.Text = txtMoney.Text;
            txtName.Text = txtName.Text;
            txtPerson.Text = txtPerson.Text;
            txtTime.Text = txtTime.Text;
            txtDepartment.Text = txtDepartment.Text;
            txtEmployee.Text = txtEmployee.Text;
            txtUser.Text = txtUser.Text;
            MessageBox.Show("保存成功");
        }
    }
}
