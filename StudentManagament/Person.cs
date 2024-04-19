namespace StudentManagament
{
    internal class Person
    {
        private string citizenIdentificationCode;
        private string name;
        private string birthday;
        private int sex;
        private string phone;
        private string address;
        private string email;

        public Person(string citizenIdentificationCode, string name, string birthday, int sex, string phone, string address, string email)
        {
            this.citizenIdentificationCode = citizenIdentificationCode;
            this.name = name;
            this.birthday = birthday;
            this.sex = sex;
            this.phone = phone;
            this.address = address;
            this.email = email;
        }

        public string GetCitizenIdentificationCode() {  return this.citizenIdentificationCode; }
        public string GetEmail() { return email; }
        public string GetName() { return name; }
        public string GetBirthday() {  return birthday; }
        public string GetPhone() { return phone; }  
        public string GetAddress() { return address; }  
        public int GetSex() { return sex; }
    }
}
