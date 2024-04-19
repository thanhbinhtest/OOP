using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagament.HandleTeacher
{
    public partial class UpdateTeacherForm : Form
    {
        private Teacher teacher;

        public UpdateTeacherForm()
        {
            InitializeComponent();
        }

        public void SetData(string teacherID)
        {
            TeacherManagement teacherManagament = new TeacherManagement();

            this.teacher = teacherManagament.GetByID(teacherID);

            if (this.teacher == null)
                Dispose();

            txtCCCD.Text = this.teacher.GetCitizenIdentificationCode();
            txtName.Text = this.teacher.GetName();
            txtEmail.Text = this.teacher.GetEmail();
            txtPhone.Text = this.teacher.GetPhone();
            txtAddress.Text = this.teacher.GetAddress();
            txtBirthday.Text = this.teacher.GetBirthday();
            txtPassword.Text = this.teacher.GetPassword();

            if (teacher.GetSex() == 1)
                btnMen.Checked = true;
            else if (teacher.GetSex() == 2)
                btnWoman.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TeacherManagement teacherManagament = new TeacherManagement();

            string citizenIdentificationCode = txtCCCD.Text;
            string name = txtName.Text;
            string birthday = txtBirthday.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string password = txtPassword.Text;

            int sex = 1;
            if (btnWoman.Checked)
                sex = 2;

            if (citizenIdentificationCode.Length == 0
                || name.Length == 0
                || email.Length == 0
                || phone.Length == 0
                || address.Length == 0)
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

            Teacher teach =
                new Teacher(citizenIdentificationCode,
                name,
                birthday,
                sex,
                phone,
                address,
                email,
                teacher.GetTeacherID());

            teach.SetPassword(password);

            if (teacherManagament.Update(teach))
            {
                MessageBox.Show("Cập nhật thành công");
                Dispose();
            }
            else
                MessageBox.Show("Cập nhật thất bại");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
