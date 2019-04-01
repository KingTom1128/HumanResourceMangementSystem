using HRMDSystem.BLL;
using HRMDSystem.DAL;
using HRMSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem2019B
{
    public partial class FormEmployeeUI : Form
    {
        private EmployeeOperation eo = new EmployeeOperation();
        private EmployeeService es = new EmployeeService();
        private byte[] photo;

        private Guid editEmployssId;

        public FormEmployeeUI()
        {
            editEmployssId = Guid.Empty;
            InitializeComponent();
        }

        public FormEmployeeUI(Guid id)
        {
            editEmployssId = id;
            InitializeComponent();
        }

        private void FormEmployeeUI_Load(object sender, EventArgs e)
        {
            cbGender.DataSource = es.GetInformation("'性别'");
            cbGender.DisplayMember = "s";
            cbGender.ValueMember = "Id";

            cbMarriage.DataSource = es.GetInformation("'婚姻状况'");
            cbMarriage.DisplayMember = "s";
            cbMarriage.ValueMember = "Id";

            cbPartyStatus.DataSource = es.GetInformation("'政治面貌'");
            cbPartyStatus.DisplayMember = "s";
            cbPartyStatus.ValueMember = "Id";

            cbEducation.DataSource = es.GetInformation("'学历'");
            cbEducation.DisplayMember = "s";
            cbEducation.ValueMember = "Id";

            cbDepartment.DataSource = es.GetDepartment();
            cbDepartment.DisplayMember = "Name";
            cbDepartment.ValueMember = "Id";

            if(editEmployssId != Guid.Empty)
            {
                Employee emp = es.GetEmployee(editEmployssId);
                cbDepartment.SelectedValue = emp.DepartmentId;
                cbEducation.SelectedValue = emp.EducationId;
                cbGender.SelectedValue = emp.GenderId;
                cbMarriage.SelectedValue = emp.MarriageId;
                cbPartyStatus.SelectedValue = emp.PartyId;

                txtName.Text = emp.Name;
                dpBirthDay.Value = emp.Birthday;
                dpInDate.Value = emp.InDay;
                txtNativeAddr.Text = emp.NativePlace;
                txtNational.Text = emp.Nation;
                txtAddr.Text = emp.Address;
                txtEmail.Text = emp.Email;
                txtTelNum.Text = emp.Telephone;
                txtNumber.Text = emp.Number;
                txtRemarks.Text = emp.Remarks;
                txtResume.Text = emp.Resume;

                if (emp.Photo != null)
                {
                    photo = emp.Photo;
                    MemoryStream ms = new MemoryStream(photo);
                    picPhoto.Image = new Bitmap(ms);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Employee emp = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text.Trim(),
                GenderId = (Guid)cbGender.SelectedValue,
                Birthday = dpBirthDay.Value,
                InDay = dpInDate.Value,
                MarriageId = (Guid)cbMarriage.SelectedValue,
                PartyId = (Guid)cbPartyStatus.SelectedValue,
                Number = txtNumber.Text.Trim(),
                EducationId = (Guid)cbEducation.SelectedValue,
                DepartmentId = (Guid)cbDepartment.SelectedValue,
                Nation = txtNational.Text.Trim(),
                NativePlace = txtNativeAddr.Text.Trim(),
                Telephone = txtTelNum.Text.Trim(),
                Address = txtAddr.Text.Trim(),
                Remarks = txtRemarks.Text.Trim(),
                Resume = txtResume.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Photo = photo
            };

            if(editEmployssId == Guid.Empty)
            {
                if (es.AddEmployee(emp))
                {
                    CommonHelper.SuccessReply("添加成功!");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    CommonHelper.SuccessReply("添加失败 !");
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                emp.Id = editEmployssId;
                if(es.UpdateEmployee(emp))
                {
                    CommonHelper.SuccessReply("更新成功");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    CommonHelper.FailedReply("更新失败");
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "所有文件|*.*|JPG图片|*.jpg|GIF图片|*.gif|位图|*.bmp|PNG文件|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                photo = File.ReadAllBytes(ofd.FileName);
                picPhoto.Image = new Bitmap(ofd.FileName);
            }
        }
    }
}
