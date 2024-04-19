namespace StudentManagament.HandleTeacher
{
    internal class Teacher : Person
    {
        private string teacherID;
        private string password;
        public Teacher(string citizenIdentificationCode, string name, string birthday, int sex, string phone, string address, string email, string teacherID) : base(citizenIdentificationCode, name, birthday, sex, phone, address, email)
        {
            this.teacherID = teacherID;
        }
        public string GetTeacherID() { return teacherID; }
        public string GetPassword() { return password; }
        public void SetPassword(string password) { this.password = password; }
    }
}
