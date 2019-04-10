using HRMDSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HRMDSystem.BLL.Dictionary;

namespace HRMSystem2019B
{
    public partial class FormDictionary : Form
    {
        private EmployeeService es = new EmployeeService();

        public FormDictionary()
        {
            InitializeComponent();
        }

        private void FormDictionary_Load(object sender, EventArgs e)
        {
            cmbSex.DataSource = es.GetInformation("'性别'");
            cmbSex.DisplayMember = "s";
            cmbSex.ValueMember = "Id";
            cmbSex.SelectedIndex = -1;

            cmbEducation.DataSource = es.GetInformation("'学历'");
            cmbEducation.DisplayMember = "s";
            cmbEducation.ValueMember = "Id";
            cmbEducation.SelectedIndex = -1;

            cmbState.DataSource = es.GetInformation("'政治面貌'");
            cmbState.DisplayMember = "s";
            cmbState.ValueMember = "Id";
            cmbState.SelectedIndex = -1;

            cmbMarry.DataSource = es.GetInformation("'婚姻状况'");
            cmbMarry.DisplayMember = "s";
            cmbMarry.ValueMember = "Id";
            cmbMarry.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Name = txtSex.Text.Trim();
            string Depart = "性别";
            Guid Id = Guid.NewGuid();
            Add ad = new Add(Id, Name, Depart);
            bool f = ad.AddResult();
            if (f == true)
            {
                CommonHelper.SuccessReply("添加成功！");
            }
            else
            {
                CommonHelper.FailedReply("添加失败！");
            }
            txtSex.Text = "";
            this.FormDictionary_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Guid Id = (Guid)cmbSex.SelectedValue;
            Delete de = new Delete(Id);
            bool f = de.DeleteResult();
            if (f == true)
            {
                CommonHelper.SuccessReply("操作成功！");
            }
            else
            {
                CommonHelper.FailedReply("操作失败！");
            }
            this.FormDictionary_Load(null, null);
        }

        private void btuUpdate_Click(object sender, EventArgs e)
        {
            Guid Id = (Guid)cmbSex.SelectedValue;
            string Name = txtSex.Text.Trim();
            Update up = new Update(Id, Name);
            bool f = up.UpdateResult(Id, Name);
            if (f == true)
            {
                CommonHelper.SuccessReply("修改成功！");
                this.Close();
            }
            else
            {
                CommonHelper.FailedReply("修改失败！");
            }
            txtSex.Text = "";
            this.FormDictionary_Load(null, null);
        }

        private void btnAddEdu_Click(object sender, EventArgs e)
        {
            string Name = txtEdu.Text.Trim();
            string Depart = "学历";
            Guid Id = Guid.NewGuid();
            Add ad = new Add(Id, Name, Depart);
            bool f = ad.AddResult();
            if (f == true)
            {
                CommonHelper.SuccessReply("添加成功！");
            }
            else
            {
                CommonHelper.FailedReply("添加失败！");
            }
            txtEdu.Text = "";
            this.FormDictionary_Load(null, null);
        }

        private void btnDeleteEdu_Click(object sender, EventArgs e)
        {
            Guid Id = (Guid)cmbEducation.SelectedValue;
            Delete de = new Delete(Id);
            bool f = de.DeleteResult();
            if (f == true)
            {
                CommonHelper.SuccessReply("操作成功！");
            }
            else
            {
                CommonHelper.FailedReply("操作失败！");
            }
            this.FormDictionary_Load(null, null);
        }

        private void btnUpdateEdu_Click(object sender, EventArgs e)
        {
            Guid Id = (Guid)cmbEducation.SelectedValue;
            string Name = txtEdu.Text.Trim();
            Update up = new Update(Id, Name);
            bool f = up.UpdateResult(Id, Name);
            if (f == true)
            {
                CommonHelper.SuccessReply("修改成功！");
                this.Close();
            }
            else
            {
                CommonHelper.FailedReply("修改失败！");
            }
            txtEdu.Text = "";
            this.FormDictionary_Load(null, null);
        }

        private void btnAddState_Click(object sender, EventArgs e)
        {
            string Name = txtState.Text.Trim();
            string Depart = "政治面貌";
            Guid Id = Guid.NewGuid();
            Add ad = new Add(Id, Name, Depart);
            bool f = ad.AddResult();
            if (f == true)
            {
                CommonHelper.SuccessReply("添加成功！");
            }
            else
            {
                CommonHelper.FailedReply("添加失败！");
            }
            txtState.Text = "";
            this.FormDictionary_Load(null, null);
        }

        private void btnDeleteState_Click(object sender, EventArgs e)
        {
            Guid Id = (Guid)cmbState.SelectedValue;
            Delete de = new Delete(Id);
            bool f = de.DeleteResult();
            if (f == true)
            {
                CommonHelper.SuccessReply("操作成功！");
            }
            else
            {
                CommonHelper.FailedReply("操作失败！");
            }
            this.FormDictionary_Load(null, null);
        }

        private void btnUpdateState_Click(object sender, EventArgs e)
        {
            Guid Id = (Guid)cmbState.SelectedValue;
            string Name = txtState.Text.Trim();
            Update up = new Update(Id, Name);
            bool f = up.UpdateResult(Id, Name);
            if (f == true)
            {
                CommonHelper.SuccessReply("修改成功！");
                this.Close();
            }
            else
            {
                CommonHelper.FailedReply("修改失败！");
            }
            txtState.Text = "";
            this.FormDictionary_Load(null, null);
        }

        private void btnAddMarry_Click(object sender, EventArgs e)
        {
            string Name = txtMarry.Text.Trim();
            string Depart = "婚姻状况";
            Guid Id = Guid.NewGuid();
            Add ad = new Add(Id, Name, Depart);
            bool f = ad.AddResult();
            if (f == true)
            {
                CommonHelper.SuccessReply("添加成功！");
            }
            else
            {
                CommonHelper.FailedReply("添加失败！");
            }
            txtMarry.Text = "";
            this.FormDictionary_Load(null, null);
        }

        private void btnDeleteMarry_Click(object sender, EventArgs e)
        {
            Guid Id = (Guid)cmbMarry.SelectedValue;
            Delete de = new Delete(Id);
            bool f = de.DeleteResult();
            if (f == true)
            {
                CommonHelper.SuccessReply("操作成功！");
            }
            else
            {
                CommonHelper.FailedReply("操作失败！");
            }
            this.FormDictionary_Load(null, null);
        }

        private void btnUpdateMarry_Click(object sender, EventArgs e)
        {
            Guid Id = (Guid)cmbMarry.SelectedValue;
            string Name = txtMarry.Text.Trim();
            Update up = new Update(Id, Name);
            bool f = up.UpdateResult(Id, Name);
            if (f == true)
            {
                CommonHelper.SuccessReply("修改成功！");
                this.Close();
            }
            else
            {
                CommonHelper.FailedReply("修改失败！");
            }
            txtMarry.Text = "";
            this.FormDictionary_Load(null, null);
        }
    }
}
