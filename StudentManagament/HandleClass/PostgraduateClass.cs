using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagament.HandleClass
{
    internal class PostgraduateClass : Class
    {
        private string essayReportingTime;
        public PostgraduateClass(string classID, string teacherID, string courseID, string startDate, string endDate, int maxStudents, string essayReportingTime) : base(classID, teacherID, courseID, startDate, endDate, maxStudents)
        {
            this.essayReportingTime = essayReportingTime;
        }
        public string GetEssayReportingTime()
        {
            return essayReportingTime;
        }
    }
}
