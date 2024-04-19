using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace StudentManagament.HandleCourse
{
    internal class RegularCourse : Course
    {
        private int creditsNumber;
        public RegularCourse(string courseID, string name, int creditsNumber) : base(courseID, name)
        {
            this.creditsNumber = creditsNumber;
        }
        public int GetCreditsNumber()
        { return creditsNumber; }
    }
}
