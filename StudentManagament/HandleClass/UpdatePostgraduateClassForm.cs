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

namespace StudentManagament.HandleClass
{
    public partial class UpdatePostgraduateClassForm : Form
    {
        private Class _class;
        public UpdatePostgraduateClassForm()
        {
            InitializeComponent();

            TeacherManagement teacherManagement = new TeacherManagement();

            List<Teacher> teachers = teacherManagement.GetAll();

            cbTeacher.DisplayMember = "Text";
            cbTeacher.ValueMember = "Value";

            foreach (Teacher item in teachers)
            {
                cbTeacher.Items.Add(new
                {
                    Text = item.GetTeacherID() + "-" + item.GetName(),
                    Value = item.GetTeacherID()
                });
            }

            cbTeacher.SelectedIndex = 0;
        }

        public void SetData(string classID)
        {
            ClassManagement classManagement = new ClassManagement();

            CourseManagement courseManagament = new CourseManagement();

            TeacherManagement teacherManagement = new TeacherManagement();

            _class = classManagement.GetByID(classID);

            PostgraduateClass postgraduateClasss = (PostgraduateClass)_class;

            if (_class == null)
                return;

            txtTime.Text = postgraduateClasss.GetEssayReportingTime();
            txtStartDate.Text = postgraduateClasss.GetStartDate();
            txtEndDate.Text = postgraduateClasss.GetEndDate();

            Course course = courseManagament.GetByID(postgraduateClasss.GetCourseID());

            Teacher teacher = teacherManagement.GetByID(postgraduateClasss.GetTeacher());

            cbCourse.Text = course.GetCourseID() + "-" + course.GetNameCourse();

            cbCourse.Enabled = false;

            cbTeacher.Text = teacher.GetTeacherID() + "-" + teacher.GetName();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtNumOfStudents.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }    

            var obj = cbTeacher.SelectedItem;

            System.Reflection.PropertyInfo pi = obj.GetType().GetProperty("Value");

            string teacherId = (string)(pi.GetValue(obj, null));

            string startDate = txtStartDate.Text;

            string endDate = txtEndDate.Text;

            string time = txtTime.Text;

            int numOfStudents = 0;

            if (!Int32.TryParse(txtNumOfStudents.Text, out numOfStudents))
            {
                MessageBox.Show("Số lượng sinh viên phải là số");
                return;
            }

            if (numOfStudents < 1)
            {
                MessageBox.Show("Số lượng sinh viên phải lớn hơn 0");
                return;
            }


            ClassManagement classManagement = new ClassManagement();

            PostgraduateClass postgraduateClass = new PostgraduateClass(_class.GetClassID(), teacherId, _class.GetCourseID(), startDate, endDate, numOfStudents, time);

            if (classManagement.Update(postgraduateClass))
            {
                MessageBox.Show("Thêm thành công");
                Dispose();
            }
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtNumOfStudents_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdatePostgraduateClassForm_Load(object sender, EventArgs e)
        {

        }
    }
}
