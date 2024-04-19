using StudentManagament.HandleClass;
using StudentManagament.HandleCourse;
using StudentManagament.HandleTeacher;
using StudentManagament.HandleTranscript;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudentManagament
{
    public partial class UpdateInfoStudent : Form
    {
        public UpdateInfoStudent()
        {
            InitializeComponent();
        }

        private Student student;

        public void SetData(string studentID)
        {
            StudentManagement studentManagament = new StudentManagement();

            this.student = studentManagament.GetByID(studentID);

            if (this.student == null)
                Dispose();

            txtPhone.Text = student.GetPhone();
            txtAddress.Text = student.GetAddress();
            txtPassword.Text = student.GetPassword();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtAddress.Text == "" || txtPhone.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }

            if (txtPhone.Text.Length != 10)
            {
                MessageBox.Show("Sai cấu trúc số điện thoại");
                return;
            }

            if (student.GetType() == typeof(RegularStudent))
            {
                RegularStudent regularStudent =
                    new RegularStudent(this.student.GetCitizenIdentificationCode(),
                    this.student.GetName(),
                    this.student.GetBirthday(),
                    this.student.GetSex(),
                    txtPhone.Text,
                    txtAddress.Text,
                    this.student.GetEmail(),
                    this.student.GetStudentID(),
                    this.student.GetDayAdmission(),
                    this.student.GetMajor());

                regularStudent.SetPassword(txtPassword.Text);

                StudentManagement studentManagament = new StudentManagement();

                if (studentManagament.Update(regularStudent))
                {
                    MessageBox.Show("Cập nhật thành công");
                    Dispose();
                }
                else
                    MessageBox.Show("Cập nhật thất bại");
            }
            else
            {
                PostgraduateStudent stu = (PostgraduateStudent)this.student;

                PostgraduateStudent postgraduateStudent =
                    new PostgraduateStudent(this.student.GetCitizenIdentificationCode(),
                    this.student.GetName(),
                    this.student.GetBirthday(),
                    this.student.GetSex(),
                    txtPhone.Text,
                    txtAddress.Text,
                    this.student.GetEmail(),
                    this.student.GetStudentID(),
                    this.student.GetDayAdmission(),
                    this.student.GetMajor(),
                    stu.getType());

                postgraduateStudent.SetPassword(txtPassword.Text);

                StudentManagement studentManagament = new StudentManagement();

                if (studentManagament.Update(postgraduateStudent))
                {
                    MessageBox.Show("Cập nhật thành công");
                    Dispose();
                }
                else
                    MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
