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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentManagament.HandleClass
{
    public partial class AddRegularClassForm : Form
    {
        public AddRegularClassForm()
        {
            InitializeComponent();

            txtClassTime.ShowUpDown = true;
            txtClassTime.CustomFormat = "HH:mm";
            txtClassTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;

            CourseManagement courseManagement = new CourseManagement();

            List<RegularCourse> courses = courseManagement.GetAllRegularCourse();

            cbCourse.DisplayMember = "Text";
            cbCourse.ValueMember = "Value";

            foreach (Course item in courses)
            {
                cbCourse.Items.Add(new
                {
                    Text = item.GetCourseID() + "-" + item.GetNameCourse(),
                    Value = item.GetCourseID()
                });
            }

            cbCourse.SelectedIndex = 0;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtNumOfStudents.Text == "")
            {
                MessageBox.Show("Không được để trống");
                return;
            }

            var obj = cbCourse.SelectedItem;

            System.Reflection.PropertyInfo pi = obj.GetType().GetProperty("Value");

            string courseID = (string)(pi.GetValue(obj, null));

            obj = cbTeacher.SelectedItem;

            pi = obj.GetType().GetProperty("Value");

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

            string classID = "RCC" + DateTime.Now.Year.ToString();

            List<RegularClass> regularClasses = classManagement.GetAllRegularClasses();

            int Count = 0;

            if (regularClasses == null || regularClasses.Count == 0)
                Count = 0;
            else
            {
                string ID = regularClasses[regularClasses.Count - 1].GetClassID();

                string numberID = ID.Substring(classID.Length, ID.Length - classID.Length);

                Count = Int32.Parse(numberID);
            }

            if (Count >= 0 && Count < 10)
            {
                Count++;
                classID += "000" + Count.ToString();
            }
            else if (Count >= 10 && Count < 100)
            {
                Count++;
                classID += "00" + Count.ToString();
            }
            else if (Count >= 100 && Count < 1000)
            {
                Count++;
                classID += "0" + Count.ToString();
            }
            else
            {
                classID += Count.ToString();
            }

            RegularClass regularClass = new RegularClass(classID, teacherId, courseID, startDate, endDate, numOfStudents, numOfLessons, classTime);

            if (classManagement.Add(regularClass))
            {
                MessageBox.Show("Thêm thành công");
                Dispose();
            }
            else
                MessageBox.Show("Thêm thất bại");
        }

        private void AddRegularClassFormcs_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cbNumLessons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
