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

namespace StudentManagament.HandleTeacher
{
    public partial class UpdateTranscriptsForm : Form
    {
        private Class _class;

        public UpdateTranscriptsForm()
        {
            InitializeComponent();
        }

        public void SetData(string classID)
        {
            ClassManagement classManagement = new ClassManagement();

            _class = classManagement.GetByID(classID);

            List<string> listStudentsID = _class.GetListStudents();

            StudentManagement studentManagament = new StudentManagement();

            TranscriptManagement transcriptManagement = new TranscriptManagement();

            dataTranscripts.Columns.Add("MSSV", "MSSV");
            dataTranscripts.Columns.Add("Tên sinh viên", "Tên sinh viên");
            dataTranscripts.Columns.Add("Điểm môn học", "Điểm môn học");

            foreach (string studentID in listStudentsID)
            {
                Transcript transcript = transcriptManagement.GetByID(studentID);

                Student student = studentManagament.GetByID(studentID);

                List<ClassScore> list = transcript.GetListScores();

                ClassScore score = null;

                foreach (ClassScore item in list)
                {
                    if (item.GetClassID() == classID)
                    {
                        score = item;
                        break;
                    }
                }

                if (score != null)
                {
                    dataTranscripts.Rows.Add(new object[] {
                    student.GetStudentID(),
                    student.GetName(),
                    score.GetScore()
                    });
                }
            }

            for (int i = 0; i < dataTranscripts.Columns.Count; i++)
            {
                dataTranscripts.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TranscriptManagement transcriptManagement = new TranscriptManagement();

            foreach (DataGridViewRow row in dataTranscripts.Rows)
            {
                if (row.Cells[0].Value == null)
                    continue;

                string studentID = row.Cells[0].Value.ToString();

                int score = 0;

                bool check = Int32.TryParse(row.Cells[2].Value.ToString(), out score);

                if (!check)
                {
                    MessageBox.Show("Sai định dạng điểm");
                    return;
                }

                if (score < 0 || score > 10)
                {
                    MessageBox.Show("Sai định dạng điểm");
                    return;
                }

                Transcript transcript = transcriptManagement.GetByID(studentID);

                List<ClassScore> list = transcript.GetListScores();

                ClassScore _score = null;

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].GetClassID() == _class.GetClassID())
                    {
                        list[i].SetScore(score);

                        if (score >= 5)
                        {
                            list[i].SetStatus(1);
                        }
                        else
                        {
                            list[i].SetStatus(2);
                        }

                        break;
                    }
                }

                transcript.SetListScores(list);

                if (!transcriptManagement.Update(transcript))
                {
                    MessageBox.Show("Cập nhật điểm cho sinh viên: " + studentID + "bị sai");
                    return;
                }
            }

            MessageBox.Show("Cập nhật thành công");

            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void UpdateTranscriptsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
