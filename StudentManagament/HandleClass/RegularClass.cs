using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagament.HandleCourse;

namespace StudentManagament.HandleClass
{
    internal class RegularClass : Class
    {
        private int numberOfLessons;
        private string classStartTime;

        public RegularClass(string classID, string teacherID, string courseID, string startDate, string endDate, int maxStudents, int numberOfLessons, string classStartTime) : base(classID, teacherID, courseID, startDate, endDate, maxStudents)
        {
            this.numberOfLessons = numberOfLessons;
            this.classStartTime = classStartTime;
        }

        public int GetNumberOfLessons()
        {
            return this.numberOfLessons;
        }
        public string GetClassStartTime()
        {
            return this.classStartTime;
        }
    }
}
