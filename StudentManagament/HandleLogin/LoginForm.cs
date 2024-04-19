using StudentManagament.HandleTeacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagament.HandleLogin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if(username == "admin" && password == "admin")
            {
                DashboardForm table = new DashboardForm();

                this.Hide();

                table.ShowDialog();

                this.Show();
            }
            else
            {
                StudentManagement studentManagement = new StudentManagement();

                Student student = studentManagement.GetByID(username);

                TeacherManagement teacherManagement = new TeacherManagement();

                Teacher teacher = teacherManagement.GetByID(username);

                if (student != null && password == student.GetPassword())
                {
                    if(student.GetType() == typeof(RegularStudent))
                    {
                        RegularStudentInformationForm regularStudentInformationForm = new RegularStudentInformationForm();

                        regularStudentInformationForm.SetData(student.GetStudentID());

                        this.Hide();

                        regularStudentInformationForm.ShowDialog();

                        this.Show();
                    }
                    else if(student.GetType() == typeof(PostgraduateStudent))
                    {
                        PostgraduateStudentInformationForm postgraduateStudentInformationForm = new PostgraduateStudentInformationForm();

                        postgraduateStudentInformationForm.SetData(student.GetStudentID());

                        this.Hide();

                        postgraduateStudentInformationForm.ShowDialog();

                        this.Show();
                    }    
                }    
                else if(teacher != null && password == teacher.GetPassword())
                {
                    TeacherInformationForm teacherInformationForm = new TeacherInformationForm();

                    teacherInformationForm.SetData(teacher.GetTeacherID());

                    this.Hide();

                    teacherInformationForm.ShowDialog();

                    this.Show();
                } 
                else
                {
                    MessageBox.Show("Sai mật khẩu");
                }    
            }
        }
    }
}
