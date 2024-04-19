namespace StudentManagament.HandleCourse
{
    internal class PostgraduateCourse : Course
    {
        private int hoursOfResearch;
        public PostgraduateCourse(string courseID, string name, int hoursOfResearch) : base(courseID, name)
        {
            this.hoursOfResearch = hoursOfResearch;
        }

        public int GetHourOfResearch()
        {
            return hoursOfResearch;
        }
    }
}
