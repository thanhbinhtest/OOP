using Microsoft.VisualBasic.Devices;
using StudentManagament.HandleClass;
using StudentManagament.HandleCourse;
using StudentManagament.HandleTranscript;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentManagament
{
    public partial class StudentManagementForm : Form
    {
        private string studentID;
        public StudentManagementForm()
        {
            InitializeComponent();

            tabControl1.Selecting += new TabControlCancelEventHandler(tabControl1_Selecting);
            dataStudent2.SelectionChanged += DataGridView_SelectionChanged;
            dataStudents.SelectionChanged += DataStudent_SelectionChanged;
        }

        private void DataStudent_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dataStudents.CurrentRow;

            if (currentRow == null)
                return;

            studentID = dataStudents.CurrentRow.Cells[0].Value.ToString();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dataStudents.CurrentRow;

            if (currentRow == null)
                return;

            studentID = dataStudent2.CurrentRow.Cells[0].Value.ToString();
        }

        void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;

            StudentManagement studentManagament = new StudentManagement();

            if (current.Name == "tabPage1")
            {
                LoadRegularStudents(studentManagament.GetAllRegularStudents());
            }
            else if (current.Name == "tabPage2")
            {
                LoadPostgraduateStudents(studentManagament.GetAllPostgraduateStudents());
            }
        }

        private void LoadPostgraduateStudents(List<PostgraduateStudent> list)
        {
            if (list == null)
                list = new List<PostgraduateStudent>();

            DataTable dt = new DataTable();

            dt.Columns.Add("MSSV");
            dt.Columns.Add("Tên sinh viên");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("Ngày nhập học");
            dt.Columns.Add("Email");
            dt.Columns.Add("SĐT");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Ngành học");
            dt.Columns.Add("Chứng chỉ");
            dt.Columns.Add("Điểm trung bình");

            TranscriptManagement transcriptManagement = new TranscriptManagement();

            foreach (PostgraduateStudent item in list)
            {
                double totalScore = 0;

                int totalCourse = 0;

                Transcript transcript = transcriptManagement.GetByID(item.GetStudentID());

                if(transcript == null)
                {
                    transcript = new Transcript(item.GetStudentID());
                    transcriptManagement.Add(transcript);
                }
                else
                {
                    List<ClassScore> scores = transcript.GetListScores();

                    foreach (ClassScore score in scores)
                    {
                        if (score.GetStatus() == 1)
                        {
                            totalScore += score.GetScore();
                            totalCourse += 1;
                        }
                    }
                }               

                double GPA = 0;

                if (totalCourse != 0)
                {
                    GPA = totalScore / totalCourse;
                }

                item.SetGPA(GPA);

                string sex = "Nam";
                if (item.GetSex() == 2)
                    sex = "Nữ";

                dt.Rows.Add(new object[] {
                    item.GetStudentID(),
                    item.GetName(),
                    item.GetBirthday(),
                    sex,
                    item.GetCitizenIdentificationCode(),
                    item.GetDayAdmission(),
                    item.GetEmail(),
                    item.GetPhone(),
                    item.GetAddress(),
                    item.GetMajor(),
                    item.getType(),
                    String.Format("{0:0.00}", item.GetGPA())
                });
            }

            dataStudent2.DataSource = dt;

            for (int i = 0; i < dataStudent2.Columns.Count; i++)
            {
                dataStudent2.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void LoadRegularStudents(List<RegularStudent> list)
        {
            if (list == null)
                list = new List<RegularStudent>();

            DataTable dt1 = new DataTable();

            dt1.Columns.Add("MSSV");
            dt1.Columns.Add("Tên sinh viên");
            dt1.Columns.Add("Ngày sinh");
            dt1.Columns.Add("Giới tính");
            dt1.Columns.Add("CCCD");
            dt1.Columns.Add("Ngày nhập học");
            dt1.Columns.Add("Email");
            dt1.Columns.Add("SĐT");
            dt1.Columns.Add("Địa chỉ");
            dt1.Columns.Add("Ngành học");
            dt1.Columns.Add("Điểm trung bình");

            TranscriptManagement transcriptManagement = new TranscriptManagement();

            CourseManagement courseManagement = new CourseManagement();

            ClassManagement classManagement = new ClassManagement();

            foreach (RegularStudent item in list)
            {
                double totalScore = 0;

                int totalCredits = 0;

                Transcript transcript = transcriptManagement.GetByID(item.GetStudentID());

                if (transcript == null)
                {
                    transcript = new Transcript(item.GetStudentID());
                    transcriptManagement.Add(transcript);
                }
                else
                {
                    List<ClassScore> scores = transcript.GetListScores();

                    foreach (ClassScore score in scores)
                    {
                        Class _class = classManagement.GetByID(score.GetClassID());

                        RegularCourse course = (RegularCourse)courseManagement.GetByID(_class.GetCourseID());

                        if (score.GetStatus() == 1)
                        {
                            totalScore += (score.GetScore() * course.GetCreditsNumber());
                            totalCredits += course.GetCreditsNumber();
                        }
                    }
                }              

                double GPA = 0;

                if (totalCredits != 0)
                {
                    GPA = totalScore / totalCredits;
                }

                item.SetGPA(GPA);

                string sex = "Nam";

                if (item.GetSex() == 2)
                    sex = "Nữ";

                dt1.Rows.Add(new object[] {
                    item.GetStudentID(),
                    item.GetName(),
                    item.GetBirthday(),
                    sex,
                    item.GetCitizenIdentificationCode(),
                    item.GetDayAdmission(),
                    item.GetEmail(),
                    item.GetPhone(),
                    item.GetAddress(),
                    item.GetMajor(),
                    String.Format("{0:0.00}", item.GetGPA())
                });
            }

            dataStudents.DataSource = dt1;

            for (int i = 0; i < dataStudents.Columns.Count; i++)
            {
                dataStudents.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void StudentManagamentForm_Load(object sender, EventArgs e)
        {
            StudentManagement studentManagament = new StudentManagement();

            LoadPostgraduateStudents(studentManagament.GetAllPostgraduateStudents());
            LoadRegularStudents(studentManagament.GetAllRegularStudents());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();

            StudentManagement studentManagament = new StudentManagement();

            LoadPostgraduateStudents(studentManagament.GetAllPostgraduateStudents());
            LoadRegularStudents(studentManagament.GetAllRegularStudents());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStudentForm updateStudentForm = new UpdateStudentForm();

            updateStudentForm.SetData(studentID);

            updateStudentForm.ShowDialog();

            StudentManagement studentManagament = new StudentManagement();

            LoadPostgraduateStudents(studentManagament.GetAllPostgraduateStudents());
            LoadRegularStudents(studentManagament.GetAllRegularStudents());
        }

        private void dataStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StudentManagement studentManagament = new StudentManagement();

            List<Student> list = studentManagament.GetAll();

            if (list == null)
            {
                MessageBox.Show("Xóa không thành công");
                return;
            }

            if (!studentManagament.Delete(studentID))
                MessageBox.Show("Xóa không thành công");
            else
            {
                MessageBox.Show("Xóa thành công");

                LoadPostgraduateStudents(studentManagament.GetAllPostgraduateStudents());
                LoadRegularStudents(studentManagament.GetAllRegularStudents());
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TabPage current = tabControl1.SelectedTab;

            StudentManagement studentManagament = new StudentManagement();

            if (current.Name == "tabPage1")
            {
                LoadRegularStudents(studentManagament.GetRegularStudentsByName(txtSearch.Text));
            }
            else if (current.Name == "tabPage2")
            {
                LoadPostgraduateStudents(studentManagament.GetPostgraduateStudentsByName(txtSearch.Text));
            }
        }
    }
}
