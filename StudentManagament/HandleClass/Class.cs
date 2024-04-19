using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagament.HandleClass
{
    internal class Class
    {
        private string classID;
        private string teacherID;
        private string courseID;
        private List<string> students;
        private string startDate;
        private string endDate;
        private int maxStudents;
        public Class(string classID, string teacherID, string courseID, string startDate, string endDate, int maxStudents)
        {
            this.classID = classID;
            this.teacherID = teacherID;
            this.courseID = courseID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.students = new List<string>();
            this.maxStudents = maxStudents;
        }

        public string GetClassID()
        { return classID; }
        public int GetMaxStudents()
        { return maxStudents; }
        public string GetTeacher()
        { return teacherID; }
        public List<string> GetListStudents()
        { return students; }
        public string GetCourseID() { return courseID; }
        public string GetStartDate() { return startDate; }
        public string GetEndDate() { return endDate; }
        public void SetListStudents(List<string> students)
        {
            this.students = students;
        }
    }
}
