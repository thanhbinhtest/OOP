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
    public partial class ClassManagementForm : Form
    {
        private string classID;

        public ClassManagementForm()
        {
            InitializeComponent();
            tabControl1.Selecting += new TabControlCancelEventHandler(tabControl1_Selecting);
            dataRegClass.SelectionChanged += DataGridView_SelectionChanged;
            dataPostClass.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dataPostClass.CurrentRow;

            if (currentRow == null)
                return;

            classID = dataPostClass.CurrentRow.Cells[0].Value.ToString();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dataRegClass.CurrentRow;

            if (currentRow == null)
                return;

            classID = dataRegClass.CurrentRow.Cells[0].Value.ToString();
        }

        void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;

            ClassManagement classManagament = new ClassManagement();

            if (current.Name == "tabPage1")
            {
                LoadRegularClasses(classManagament.GetAllRegularClasses());
            }
            else if (current.Name == "tabPage2")
            {
                LoadPostgraduateClasses(classManagament.GetAllPostgraduateClasses());
            }
        }

        private void LoadRegularClasses(List<RegularClass> list)
        {
            if (list == null)
                list = new List<RegularClass>();

            DataTable dt1 = new DataTable();

            dt1.Columns.Add("Mã lớp");
            dt1.Columns.Add("Tên môn học");
            dt1.Columns.Add("Giảng viên giảng dạy");
            dt1.Columns.Add("Ngày bắt đầu môn học");
            dt1.Columns.Add("Ngày kết thúc môn học");
            dt1.Columns.Add("Số lượng sinh viên đã đăng ký");
            dt1.Columns.Add("Số lượng sinh viên tối đa");
            dt1.Columns.Add("Giờ bắt đầu tiết học");
            dt1.Columns.Add("Số tiết học");

            CourseManagement courseManagement = new CourseManagement();

            TeacherManagement teacherManagement = new TeacherManagement();

            foreach (RegularClass item in list)
            {
                Teacher teacher = teacherManagement.GetByID(item.GetTeacher());

                if (teacher == null)
                    continue;

                Course course = courseManagement.GetByID(item.GetCourseID());

                if (course == null)
                    continue;

                dt1.Rows.Add(new object[] {
                    item.GetClassID(),
                    course.GetNameCourse(),
                    teacher.GetName(),
                    item.GetStartDate(),
                    item.GetEndDate(),
                    item.GetListStudents().Count,
                    item.GetMaxStudents(),
                    item.GetClassStartTime(),
                    item.GetNumberOfLessons(),
                });
            }

            dataRegClass.DataSource = dt1;

            for (int i = 0; i < dataRegClass.Columns.Count; i++)
            {
                dataRegClass.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void LoadPostgraduateClasses(List<PostgraduateClass> list)
        {
            if (list == null)
                list = new List<PostgraduateClass>();

            DataTable dt1 = new DataTable();

            dt1.Columns.Add("Mã lớp");
            dt1.Columns.Add("Tên môn học");
            dt1.Columns.Add("Giảng viên giảng dạy");
            dt1.Columns.Add("Ngày bắt đầu môn học");
            dt1.Columns.Add("Ngày kết thúc môn học");
            dt1.Columns.Add("Số lượng sinh viên đã đăng ký");
            dt1.Columns.Add("Số lượng sinh viên tối đa");
            dt1.Columns.Add("Ngày nộp luận");

            CourseManagement courseManagement = new CourseManagement();

            TeacherManagement teacherManagement = new TeacherManagement();

            foreach (PostgraduateClass item in list)
            {
                Teacher teacher = teacherManagement.GetByID(item.GetTeacher());

                if (teacher == null)
                    continue;

                Course course = courseManagement.GetByID(item.GetCourseID());

                if (course == null)
                    continue;

                dt1.Rows.Add(new object[] {
                    item.GetClassID(),
                    course.GetNameCourse(),
                    teacher.GetName(),
                    item.GetStartDate(),
                    item.GetEndDate(),
                    item.GetListStudents().Count,
                    item.GetMaxStudents(),
                    item.GetEssayReportingTime()
                });
            }

            dataPostClass.DataSource = dt1;

            for (int i = 0; i < dataPostClass.Columns.Count; i++)
            {
                dataPostClass.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void ClassManagementForm_Load(object sender, EventArgs e)
        {
            ClassManagement classManagament = new ClassManagement();

            LoadRegularClasses(classManagament.GetAllRegularClasses());
            LoadPostgraduateClasses(classManagament.GetAllPostgraduateClasses());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TabPage current = tabControl1.SelectedTab;

            ClassManagement classManagament = new ClassManagement();

            if (current.Name == "tabPage1")
            {
                AddRegularClassForm addRegularClassForm = new AddRegularClassForm();
                addRegularClassForm.ShowDialog();

                LoadRegularClasses(classManagament.GetAllRegularClasses());
            }
            else if (current.Name == "tabPage2")
            {
                AddPostgraduateClassForm addPostgraduateClass = new AddPostgraduateClassForm();
                addPostgraduateClass.ShowDialog();

                LoadPostgraduateClasses(classManagament.GetAllPostgraduateClasses());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClassManagement classManagament = new ClassManagement();

            if (classManagament.Delete(classID))
            {
                MessageBox.Show("Xóa thành công");

                LoadRegularClasses(classManagament.GetAllRegularClasses());
                LoadPostgraduateClasses(classManagament.GetAllPostgraduateClasses());
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TabPage current = tabControl1.SelectedTab;

            ClassManagement classManagament = new ClassManagement();

            if (current.Name == "tabPage1")
            {
                UpdateRegularClassForm updateRegularClassForm = new UpdateRegularClassForm();

                updateRegularClassForm.SetData(classID);

                updateRegularClassForm.ShowDialog();

                LoadRegularClasses(classManagament.GetAllRegularClasses());
            }
            else if (current.Name == "tabPage2")
            {
                UpdatePostgraduateClassForm updatePostgraduateClassForm = new UpdatePostgraduateClassForm();

                updatePostgraduateClassForm.SetData(classID);

                updatePostgraduateClassForm.ShowDialog();

                LoadPostgraduateClasses(classManagament.GetAllPostgraduateClasses());
            }
        }
    }
}
