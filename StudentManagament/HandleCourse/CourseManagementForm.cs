using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagament.HandleCourse
{
    public partial class CourseManagementForm : Form
    {
        private string courseID;

        public CourseManagementForm()
        {
            InitializeComponent();
            dataRegCourse.SelectionChanged += DataGridView_SelectionChanged;
            dataPostCourse.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dataPostCourse.CurrentRow;

            if (currentRow == null)
                return;

            courseID = dataPostCourse.CurrentRow.Cells[0].Value.ToString();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dataRegCourse.CurrentRow;

            if (currentRow == null)
                return;

            courseID = dataRegCourse.CurrentRow.Cells[0].Value.ToString();
        }
        private void LoadPostgraduateCourse(List<PostgraduateCourse> list)
        {
            if (list == null)
                list = new List<PostgraduateCourse>();

            DataTable dt = new DataTable();

            dt.Columns.Add("Mã môn học");
            dt.Columns.Add("Tên môn học");
            dt.Columns.Add("Số giờ nghiên cứu");

            foreach (PostgraduateCourse item in list)
            {
                dt.Rows.Add(new object[] {
                    item.GetCourseID(),
                    item.GetNameCourse(),
                    item.GetHourOfResearch(),

                });
            }

            dataPostCourse.DataSource = dt;

            for(int i = 0; i < dataPostCourse.Columns.Count;i++)
            {
                dataPostCourse.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            }     
        }
        private void LoadRegularCourse(List<RegularCourse> list)
        {
            if (list == null)
                list = new List<RegularCourse>();

            DataTable dt = new DataTable();

            dt.Columns.Add("Mã môn học");
            dt.Columns.Add("Tên môn học");
            dt.Columns.Add("Số tín chỉ");

            foreach (RegularCourse item in list)
            {
                dt.Rows.Add(new object[] {
                    item.GetCourseID(),
                    item.GetNameCourse(),
                    item.GetCreditsNumber(),
                });
            }

            dataRegCourse.DataSource = dt;

            for (int i = 0; i < dataRegCourse.Columns.Count; i++)
            {
                dataRegCourse.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void CourseManagamentForm_Load(object sender, EventArgs e)
        {
            CourseManagement courseManagament = new CourseManagement();

            LoadPostgraduateCourse(courseManagament.GetAllPostgraduateCourse());
            LoadRegularCourse(courseManagament.GetAllRegularCourse());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.ShowDialog();

            CourseManagement courseManagament = new CourseManagement();

            LoadPostgraduateCourse(courseManagament.GetAllPostgraduateCourse());
            LoadRegularCourse(courseManagament.GetAllRegularCourse());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CourseManagement courseManagament = new CourseManagement();

            if (!courseManagament.Delete(this.courseID))
                MessageBox.Show("Xóa thất bại");
            else
            {
                MessageBox.Show("Xóa thành công");

                LoadPostgraduateCourse(courseManagament.GetAllPostgraduateCourse());
                LoadRegularCourse(courseManagament.GetAllRegularCourse());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TabPage current = tabControl1.SelectedTab;

            CourseManagement courseManagament = new CourseManagement();

            if (current.Name == "tabPage1")
            {
                LoadRegularCourse(courseManagament.GetRegularCourseByName(txtSearch.Text));
            }
            else if (current.Name == "tabPage2")
            {
                LoadPostgraduateCourse(courseManagament.GetPostgraduateCourseByName(txtSearch.Text));
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCourseForm updateCourseForm = new UpdateCourseForm();

            updateCourseForm.SetData(this.courseID);

            updateCourseForm.ShowDialog();

            CourseManagement courseManagament = new CourseManagement();

            LoadPostgraduateCourse(courseManagament.GetAllPostgraduateCourse());
            LoadRegularCourse(courseManagament.GetAllRegularCourse());
        }

        private void dataRegCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
