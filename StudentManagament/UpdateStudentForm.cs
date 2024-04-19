using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagament
{
    public partial class UpdateStudentForm : Form
    {
        private Student student;

        public UpdateStudentForm()
        {
            InitializeComponent();

            List<string> list = new List<string>();

            list.Add("Thạc sĩ");
            list.Add("Tiến sĩ");

            cbType.DataSource = list;
        }

        public void SetData(string studentID)
        {
            StudentManagement studentManagament = new StudentManagement();

            this.student = studentManagament.GetByID(studentID);

            if (this.student == null)
                Dispose();

            txtCCCD.Text = student.GetCitizenIdentificationCode();
            txtName.Text = student.GetName();
            txtEmail.Text = student.GetEmail();
            txtPhone.Text = student.GetPhone();
            txtAddress.Text = student.GetAddress();
            txtMajor.Text = student.GetMajor();
            txtBirthday.Text = student.GetBirthday();
            txtDayAdd.Text = student.GetDayAdmission();
            txtPassword.Text = student.GetPassword();

            if (student.GetSex() == 1)
                btnMen.Checked = true;
            else if (student.GetSex() == 2)
                btnWoman.Checked = true;

            if (student.GetType() == typeof(PostgraduateStudent))
            {
                checkPost.Checked = true;
                checkPost.Enabled = false;
                checkReg.Enabled = false;

                PostgraduateStudent postgraduateStudent = (PostgraduateStudent)student;

                cbType.Text = postgraduateStudent.getType();
            }
            else
            {
                checkReg.Checked = true;
                checkReg.Enabled = false;
                checkPost.Enabled = false;
                cbType.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentManagement studentManagament = new StudentManagement();

            string citizenIdentificationCode = txtCCCD.Text;
            string name = txtName.Text;
            string birthday = txtBirthday.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string major = txtMajor.Text;
            string dayAddmission = txtDayAdd.Text;
            string password = txtPassword.Text;
            int sex = 1;

            if (btnWoman.Checked)
                sex = 2;

            if (citizenIdentificationCode.Length == 0
                || name.Length == 0
                || email.Length == 0
                || phone.Length == 0
                || address.Length == 0
                || major.Length == 0)
            {
                MessageBox.Show("Không được để trống");
                return;
            }

            if (!email.Contains("@"))
            {
                MessageBox.Show("Sai cấu trúc email");
                return;
            }

            if (phone.Length != 10)
            {
                MessageBox.Show("Sai cấu trúc số điện thoại");
                return;
            }

            if (checkPost.Checked)
            {
                string type = cbType.Text;

                PostgraduateStudent postgraduateStudent =
                    new PostgraduateStudent(citizenIdentificationCode,
                    name,
                    birthday,
                    sex,
                    phone,
                    address,
                    email,
                    this.student.GetStudentID(),
                    dayAddmission,
                    major,
                    type);

                postgraduateStudent.SetPassword(password);

                if (studentManagament.Update(postgraduateStudent))
                {
                    MessageBox.Show("Cập nhật thành công");
                    Dispose();
                }
                else
                    MessageBox.Show("Cập nhật thất bại");
            }
            else if (checkReg.Checked)
            {
                RegularStudent regularStudent =
                    new RegularStudent(citizenIdentificationCode,
                    name,
                    birthday,
                    sex,
                    phone,
                    address,
                    email,
                    this.student.GetStudentID(),
                    dayAddmission,
                    major);

                regularStudent.SetPassword(password);

                if (studentManagament.Update(regularStudent))
                {
                    MessageBox.Show("Cập nhật thành công");
                    Dispose();
                }
                else
                    MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void checkReg_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkReg.Checked)
            {
                checkPost.Checked = false;
                cbType.Enabled = false;
            }
        }

        private void checkPost_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkPost.Checked)
            {
                checkReg.Checked = false;
                cbType.Enabled = true;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Dispose(); 
        }
    }
}
