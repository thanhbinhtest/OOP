﻿using StudentManagament.HandleClass;
using StudentManagament.HandleCourse;
using StudentManagament.HandleTeacher;
using StudentManagament.HandleTranscript;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace StudentManagament
{
    public partial class PostgraduateStudentInformationForm : Form
    {
        public PostgraduateStudentInformationForm()
        {
            InitializeComponent();
        }

        private Student student;

        public void SetData(string studentID)
        {
            StudentManagement studentManagament = new StudentManagement();

            this.student = studentManagament.GetByID(studentID);

            if (this.student == null)
                Dispose();

            txtCCCD.Text = student.GetCitizenIdentificationCode();
            txtCCCD.Enabled = false;
            txtName.Text = student.GetName();
            txtName.Enabled = false;
            txtEmail.Text = student.GetEmail();
            txtEmail.Enabled = false;
            txtPhone.Text = student.GetPhone();
            txtPhone.Enabled = false;
            txtAddress.Text = student.GetAddress();
            txtAddress.Enabled = false;
            txtMajor.Text = student.GetMajor();
            txtMajor.Enabled = false;
            txtBirthday.Text = student.GetBirthday();
            txtBirthday.Enabled = false;
            txtDayAdd.Text = student.GetDayAdmission();
            txtDayAdd.Enabled = false;

            PostgraduateStudent postgraduateStudent = (PostgraduateStudent)this.student;

            txtType.Text = postgraduateStudent.getType();
            txtType.Enabled = false;

            if (student.GetSex() == 1)
            {
                btnMen.Checked = true;
                btnWoman.Enabled = false;
            }
            else if (student.GetSex() == 2)
            {
                btnMen.Enabled = false;
                btnWoman.Checked = true;
            }

            TranscriptManagement transcriptManagement = new TranscriptManagement();

            Transcript transcript = transcriptManagement.GetByID(student.GetStudentID());

            if (transcript == null)
            {
                transcript = new Transcript(student.GetStudentID());
                if (!transcriptManagement.Add(transcript))
                {
                    MessageBox.Show("Chương trình bị lỗi!");
                    return;
                }
            }

            List<ClassScore> scores = transcript.GetListScores();

            if (scores == null)
                scores = new List<ClassScore>();

            DataTable dt1 = new DataTable();

            dt1.Columns.Add("Mã lớp học");
            dt1.Columns.Add("Tên môn học");
            dt1.Columns.Add("Giảng viên hướng dẫn");
            dt1.Columns.Add("Thời gian nghiên cứu");
            dt1.Columns.Add("Trạng thái");
            dt1.Columns.Add("Điểm môn học");

            CourseManagement courseManagement = new CourseManagement();

            TeacherManagement teacherManagement = new TeacherManagement();

            ClassManagement classManagement = new ClassManagement();

            double totalScore = 0 ;
            int totalCourse = 0 ;

            foreach (ClassScore item in scores)
            {
                Class _class = classManagement.GetByID(item.GetClassID());

                PostgraduateCourse course = (PostgraduateCourse)courseManagement.GetByID(_class.GetCourseID());

                Teacher teacher = teacherManagement.GetByID(_class.GetTeacher());

                string status = "";

                if (item.GetStatus() == 0)
                {
                    status = "Chưa hoàn thành môn học";
                }
                else if (item.GetStatus() == 1)
                {
                    status = "Đã hoàn thành môn học";
                    totalScore += item.GetScore();
                    totalCourse += 1;
                }
                else if (item.GetStatus() == 2)
                {
                    status = "Không hoàn thành môn học";
                }
                
                dt1.Rows.Add(new object[] {
                    item.GetClassID(),
                    course.GetNameCourse(),
                    teacher.GetName(),
                    course.GetHourOfResearch(),
                    status,
                    item.GetScore(),
                });
            }

            dt1.Rows.Add(new object[] {
                "",
                "",
                "",
                "",
                "",
                });

            double GPA = 0;

            if (totalCourse != 0)
            {
                GPA = totalScore / totalCourse;
            }

            student.SetGPA(GPA);

            dt1.Rows.Add(new object[] {
                "Điểm trung bình",
                "",
                "",
                "",
                "",
                String.Format("{0:0.00}", student.GetGPA())
                });

            dataTranscript.DataSource = dt1;

            for (int i = 0; i < dataTranscript.Columns.Count; i++)
            {
                dataTranscript.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void PostgraduateStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RegisterClassForm registerClassForm = new RegisterClassForm();

            registerClassForm.SetData(student.GetStudentID());

            registerClassForm.ShowDialog();

            SetData(this.student.GetStudentID());
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            UpdateInfoStudent updateInfoStudent = new UpdateInfoStudent();

            updateInfoStudent.SetData(this.student.GetStudentID());

            updateInfoStudent.ShowDialog();

            SetData(this.student.GetStudentID());
        }
    }
}
