using StudentManagament.HandleClass;
using StudentManagament.HandleCourse;
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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentManagementForm studentManagamentForm = new StudentManagementForm();
            studentManagamentForm.ShowDialog();
            this.Show();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseManagementForm courseManagamentForm = new CourseManagementForm();
            courseManagamentForm.ShowDialog();
            this.Show();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClassManagementForm form = new ClassManagementForm();
            form.ShowDialog();
            this.Show();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherManagementForm form = new TeacherManagementForm();
            form.ShowDialog();
            this.Show();
        }
    }
}
