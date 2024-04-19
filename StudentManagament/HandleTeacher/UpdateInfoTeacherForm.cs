using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagament.HandleTeacher
{
    public partial class UpdateInfoTeacherForm : Form
    {
        private Teacher teacher;

        public UpdateInfoTeacherForm()
        {
            InitializeComponent();
        }

        public void SetData(string teacherID)
        {
            TeacherManagement teacherManagement = new TeacherManagement();

            teacher = teacherManagement.GetByID(teacherID);

            txtAddress.Text = teacher.GetAddress();
            txtPhone.Text = teacher.GetPhone();
            txtPassword.Text = teacher.GetPassword();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtPhone.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }

            TeacherManagement teacherManagament = new TeacherManagement();
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            string password = txtPassword.Text;

            if (phone.Length != 10)
            {
                MessageBox.Show("Sai cấu trúc số điện thoại");
                return;
            }

            Teacher teach =
                new Teacher(teacher.GetCitizenIdentificationCode(),
                teacher.GetName(),
                teacher.GetBirthday(),
                teacher.GetSex(),
                phone,
                address,
                teacher.GetEmail(),
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
