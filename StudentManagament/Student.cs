namespace StudentManagament
{
    internal class Student : Person
    {
        private string studentID;
        private string dayAdmission;
        private string major;
        private string password;
        private double GPA;
        public Student(string citizenIdentificationCode, string name, string birthday, int sex, string phone, string address, string email, string studentID, string dayAdmission, string major) : base(citizenIdentificationCode, name, birthday, sex, phone, address, email)
        {
            this.studentID = studentID;
            this.dayAdmission = dayAdmission;
            this.major = major;
            password = "";
        }

        public string GetStudentID()
        {
            return studentID;
        }
        public string GetPassword()
        {
            return password;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }
        public string GetDayAdmission()
        {
            return dayAdmission;
        }
        public double GetGPA()
        {
            return GPA;
        }
        public string GetMajor()
        {
            return major;
        }
        public void SetGPA(double gpa)
        {
            GPA = gpa;
        }
    }
}
