using StudentManagament.HandleCourse;
using StudentManagament.HandleTeacher;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentManagament.HandleClass
{
    public partial class UpdateRegularClassForm : Form
    {
        private Class _class;

        public UpdateRegularClassForm()
        {
            InitializeComponent();

            txtClassTime.ShowUpDown = true;
            txtClassTime.CustomFormat = "HH:mm";
            txtClassTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

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

            List<string> listNumber = new List<string>();

            listNumber.Add("1");
            listNumber.Add("2");
            listNumber.Add("3");
            listNumber.Add("4");
            listNumber.Add("5");

            cbNumLessons.DataSource = listNumber;
        }

        public void SetData(string classID)
        {
            ClassManagement classManagement = new ClassManagement();

            CourseManagement courseManagament = new CourseManagement();

            TeacherManagement teacherManagement = new TeacherManagement();  

            _class = classManagement.GetByID(classID);

            RegularClass regularClass = (RegularClass) _class;

            if (_class == null)
                return;

            txtClassTime.Text = regularClass.GetClassStartTime();
            txtStartDate.Text = regularClass.GetStartDate();
            txtEndDate.Text = regularClass.GetEndDate();

            Course course = courseManagament.GetByID(regularClass.GetCourseID());

            Teacher teacher = teacherManagement.GetByID(regularClass.GetTeacher());

            cbCourse.Text = course.GetCourseID() + "-" + course.GetNameCourse();

            cbCourse.Enabled = false;

            cbTeacher.Text = teacher.GetTeacherID() + "-" + teacher.GetName();

            cbNumLessons.Text = regularClass.GetNumberOfLessons().ToString();

            txtClassTime.Text = regularClass.GetClassStartTime();

            txtNumOfStudents.Text = _class.GetMaxStudents().ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNumOfStudents.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }

            var obj = cbTeacher.SelectedItem;

            System.Reflection.PropertyInfo pi = obj.GetType().GetProperty("Value");

            string teacherId = (string)(pi.GetValue(obj, null));

            string startDate = txtStartDate.Text;

            string endDate = txtEndDate.Text;

            string classTime = txtClassTime.Text;

            int numOfLessons = Int32.Parse(cbNumLessons.Text);

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

            RegularClass regularClass = new RegularClass(_class.GetClassID(), teacherId, _class.GetCourseID(), startDate, endDate, numOfStudents, numOfLessons, classTime);

            if (classManagement.Update(regularClass))
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
    }
}
