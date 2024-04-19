using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json.Linq;
using StudentManagament.HandleClass;
using StudentManagament.HandleCourse;
using StudentManagament.HandleTeacher;
using StudentManagament.HandleTranscript;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace StudentManagament
{
    public partial class RegisterClassForm : Form
    {
        private Student student;

        public RegisterClassForm()
        {
            InitializeComponent();
        }

        public void SetData(string studentID)
        {
            StudentManagement studentManagement = new StudentManagement();

            CourseManagement courseManagement = new CourseManagement();

            TeacherManagement teacherManagement = new TeacherManagement();

            ClassManagement classManagement = new ClassManagement();

            TranscriptManagement transcriptManagement = new TranscriptManagement();

            student = studentManagement.GetByID(studentID);

            Transcript transcript = transcriptManagement.GetByID(student.GetStudentID());

            List<ClassScore> scores = transcript.GetListScores();

            if (student.GetType() == typeof(RegularStudent))
            {
                List<RegularClass> regularClasses = classManagement.GetAllRegularClasses();

                for (int i = 0; i < regularClasses.Count; i++)
                {
                    if (regularClasses[i].GetMaxStudents() <= regularClasses[i].GetListStudents().Count)
                    {
                        regularClasses.Remove(regularClasses[i]);
                        break;
                    }
                }

                for (int j = 0; j < scores.Count; j++)
                {
                    for (int i = 0; i < regularClasses.Count; i++)
                    {
                        if (scores[j].GetClassID() == regularClasses[i].GetClassID() && (scores[j].GetStatus() == 1 || (scores[j].GetStatus() == 0)))
                        {
                            regularClasses.Remove(regularClasses[i]);
                            break;
                        }

                        if (regularClasses[i].GetMaxStudents() <= regularClasses[i].GetListStudents().Count)
                        {
                            regularClasses.Remove(regularClasses[i]);
                            break;
                        }    
                    }
                }

                dataClass.Columns.Add("Mã lớp học", "Mã lớp học");
                dataClass.Columns.Add("Tên môn học", "Tên môn học");
                dataClass.Columns.Add("Giảng viên hướng dẫn", "Giảng viên hướng dẫn");
                dataClass.Columns.Add("Số chỉ", "Số chỉ");

                List<DataGridViewCheckBoxColumn> list = new List<DataGridViewCheckBoxColumn>();

                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();

                checkColumn.Name = "Đăng ký";
                checkColumn.HeaderText = "Đăng ký";
                checkColumn.ReadOnly = false;

                dataClass.Columns.Add(checkColumn);

                foreach (RegularClass item in regularClasses)
                {
                    RegularCourse course = (RegularCourse)courseManagement.GetByID(item.GetCourseID());

                    Teacher teacher = teacherManagement.GetByID(item.GetTeacher());

                    dataClass.Rows.Add(new object[] {
                    item.GetClassID(),
                    course.GetNameCourse(),
                    teacher.GetName(),
                    course.GetCreditsNumber(),
                    });

                    list.Add(checkColumn);
                }
            }
            else if (student.GetType() == typeof(PostgraduateStudent))
            {
                List<PostgraduateClass> postgraduateClasses = classManagement.GetAllPostgraduateClasses();

                for (int i = 0; i < postgraduateClasses.Count; i++)
                {
                    if (postgraduateClasses[i].GetMaxStudents() <= postgraduateClasses[i].GetListStudents().Count)
                    {
                        postgraduateClasses.Remove(postgraduateClasses[i]);
                        break;
                    }
                }

                for (int j = 0; j < scores.Count; j++)
                {
                    for (int i = 0; i < postgraduateClasses.Count; i++)
                    {
                        if (scores[j].GetClassID() == postgraduateClasses[i].GetClassID() && (scores[j].GetStatus() == 1 || (scores[j].GetStatus() == 0)))
                        {
                            postgraduateClasses.Remove(postgraduateClasses[i]);
                            break;
                        }

                        if (postgraduateClasses[i].GetMaxStudents() <= postgraduateClasses[i].GetListStudents().Count)
                        {
                            postgraduateClasses.Remove(postgraduateClasses[i]);
                            break;
                        }
                    }
                }

                dataClass.Columns.Add("Mã lớp học", "Mã lớp học");
                dataClass.Columns.Add("Tên môn học", "Tên môn học");
                dataClass.Columns.Add("Giảng viên hướng dẫn", "Giảng viên hướng dẫn");
                dataClass.Columns.Add("Số giờ nghiên cứu", "Số giờ nghiên cứu");

                List<DataGridViewCheckBoxColumn> list = new List<DataGridViewCheckBoxColumn>();

                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();

                checkColumn.Name = "Đăng ký";
                checkColumn.HeaderText = "Đăng ký";
                checkColumn.ReadOnly = false;

                dataClass.Columns.Add(checkColumn);

                foreach (PostgraduateClass item in postgraduateClasses)
                {
                    PostgraduateCourse course = (PostgraduateCourse)courseManagement.GetByID(item.GetCourseID());

                    Teacher teacher = teacherManagement.GetByID(item.GetTeacher());

                    dataClass.Rows.Add(new object[] {
                    item.GetClassID(),
                    course.GetNameCourse(),
                    teacher.GetName(),
                    course.GetHourOfResearch(),
                    });

                    list.Add(checkColumn);
                }
            }

            for (int i = 0; i < dataClass.Columns.Count; i++)
            {
                dataClass.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            foreach (DataGridViewRow row in dataClass.Rows)
            {
                // Kiểm tra xem ô đầu tiên của hàng có giá trị không
                if (row.Cells[0].Value == null || string.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                    continue;

                string classID = row.Cells[0].Value.ToString();

                // Kiểm tra giá trị của ô thứ 5 của hàng
                bool check = false;
                if (row.Cells[4].Value != null && row.Cells[4].Value is bool)
                {
                    check = (bool)row.Cells[4].Value;
                }

                if (check)
                {
                    list.Add(classID);
                }
            }
        

        TranscriptManagement transcriptManagement = new TranscriptManagement();

            ClassManagement classManagement = new ClassManagement();

            Transcript transcript = transcriptManagement.GetByID(student.GetStudentID());

            List<ClassScore> scores = transcript.GetListScores();

            foreach (string item in list)
            {
                ClassScore score = new ClassScore(item, 0, 0);

                Class _class = classManagement.GetByID(item);

                List<string> listStudents = _class.GetListStudents();

                listStudents.Add(this.student.GetStudentID());

                _class.SetListStudents(listStudents);

                classManagement.Update(_class);

                scores.Add(score);
            }

            transcript.SetListScores(scores);

            if (transcriptManagement.Update(transcript))
            {
                MessageBox.Show("Đăng ký thành công");
                Dispose();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại");
            }
        }

        private void RegisterClassForm_Load(object sender, EventArgs e)
        {

        }
    }
}
