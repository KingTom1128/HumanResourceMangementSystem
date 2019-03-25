using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HRMDSystem.BLL.Department;

namespace HRMSystem2019B
{
    public partial class FormDepartment : Form
    {

        public FormDepartment()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();
            Add ad = new Add(guid, txtAdd.Text);
            bool f = ad.AddResult();
            if (f == true)
            {
                CommonHelper.SuccessReply("添加成功！");
            }
            else
            {
                CommonHelper.FailedReply("添加失败！");
            }
            txtAdd.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtDelete.Text.Trim();
            Delete de = new Delete(name);
            bool f = de.DeleteResult();
            if (f == true)
            {
                CommonHelper.SuccessReply("操作成功！");
            }
            else
            {
                CommonHelper.FailedReply("操作失败！");
            }
            txtDelete.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblShow.Text = "";
            string name = txtSearch.Text.Trim();
            Search sea = new Search(name);
            string seaResult = sea.SearchResult();
            if (seaResult != null)
            {
                lblShow.Text = seaResult;
                CommonHelper.SuccessReply("查找成功!");
            }
            else
            {
                CommonHelper.FailedReply(seaResult);
            }
            txtSearch.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update up = new Update(txtOld.Text, txtNew.Text);
            bool f = up.UpdateResult(txtOld.Text, txtNew.Text);
            if (f == true)
            {
                CommonHelper.SuccessReply("修改成功！");
                this.Close();
            }
            else
            {
                CommonHelper.FailedReply("修改失败！");
            }
        }
    }
}
