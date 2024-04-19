namespace StudentManagament.HandleCourse
{
    internal class Course
    {
        private string courseID;
        private string nameCourse;

        public Course(string courseID, string name)
        {
            this.courseID = courseID;
            nameCourse = name;
        }
        public string GetCourseID() { return courseID; }
        public string GetNameCourse() { return nameCourse; }


    }
}
