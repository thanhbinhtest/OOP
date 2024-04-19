namespace StudentManagament
{
    internal class PostgraduateStudent : Student
    {
        private string type;

        public PostgraduateStudent(string citizenIdentificationCode, string name, string birthday, int sex, string phone, string address, string email, string studentID, string dayAdmission, string major, string type) : base(citizenIdentificationCode, name, birthday, sex, phone, address, email, studentID, dayAdmission, major)
        {
            this.type = type;
        }

        public string getType() { return type; }
    }
}
