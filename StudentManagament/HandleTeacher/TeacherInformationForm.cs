using StudentManagament.HandleClass;
using StudentManagament.HandleCourse;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagament.HandleTeacher
{
    public partial class TeacherInformationForm : Form
    {
        private Teacher teacher;

        private string classID;

        public TeacherInformationForm()
        {
            InitializeComponent();

            dataClass.SelectionChanged += DataGridView_SelectionChanged;
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dataClass.CurrentRow;

            if (currentRow == null)
                return;

            classID = dataClass.CurrentRow.Cells[0].Value.ToString();
        }

        public void SetData(string teacherID)
        {
            TeacherManagement teacherManagement = new TeacherManagement();

            teacher = teacherManagement.GetByID(teacherID);

            txtCCCD.Text = teacher.GetTeacherID();
            txtCCCD.Enabled = false;

            txtBirthday.Text = teacher.GetBirthday();
            txtBirthday.Enabled = false;

            txtAddress.Text = teacher.GetAddress();
            txtAddress.Enabled = false;

            txtPhone.Text = teacher.GetPhone();
            txtPhone.Enabled = false;

            txtEmail.Text = teacher.GetEmail();
            txtEmail.Enabled = false;

            txtName.Text = teacher.GetName();
            txtName.Enabled = false;

            if (teacher.GetSex() == 1)
            {
                btnMen.Checked = true;
                btnWoman.Enabled = false;
            }
            else if (teacher.GetSex() == 2)
            {
                btnMen.Enabled = false;
                btnWoman.Checked = true;
            }

            ClassManagement classManagement = new ClassManagement();

            List<Class> classes = classManagement.GetAll();

            DataTable dt1 = new DataTable();

            dt1.Columns.Add("Mã lớp");
            dt1.Columns.Add("Tên môn học");
            dt1.Columns.Add("Ngày bắt đầu môn học");
            dt1.Columns.Add("Ngày kết thúc môn học");
            dt1.Columns.Add("Số lượng sinh viên đã đăng ký");
            dt1.Columns.Add("Số lượng sinh viên tối đa");

            CourseManagement courseManagement = new CourseManagement();

            foreach (Class item in classes)
            {
                if (teacher == null)
                    continue;

                if (teacher.GetTeacherID() == item.GetTeacher())
                {
                    Course course = courseManagement.GetByID(item.GetCourseID());

                    if (course == null)
                        continue;

                    dt1.Rows.Add(new object[] {
                    item.GetClassID(),
                    course.GetNameCourse(),
                    item.GetStartDate(),
                    item.GetEndDate(),
                    item.GetListStudents().Count,
                    item.GetMaxStudents(),
                    });
                }
            }

            dataClass.DataSource = dt1;

            for (int i = 0; i < dataClass.Columns.Count; i++)
            {
                dataClass.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TeacherInformationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateScore_Click(object sender, EventArgs e)
        {
            UpdateTranscriptsForm updateTranscriptsForm = new UpdateTranscriptsForm();

            updateTranscriptsForm.SetData(classID);

            updateTranscriptsForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateInfoTeacherForm updateInfoTeacherForm = new UpdateInfoTeacherForm();

            updateInfoTeacherForm.SetData(teacher.GetTeacherID());

            updateInfoTeacherForm.ShowDialog();

            SetData(teacher.GetTeacherID());
        }
    }
}
