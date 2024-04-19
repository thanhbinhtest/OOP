using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace StudentManagament
{
    internal class StudentManagement : IManagement<Student>
    {
        public StudentManagement()
        {
        }

        public bool WriteDataToFile(List<Student> students)
        {
            if (students.Count == 0 || students == null)
            {
                return true;
            }

            List<object> list = new List<object>();

            foreach (Student student in students)
            {
                if (student.GetType().Name != "PostgraduateStudent")
                {
                    var obj = new
                    {
                        StudentID = student.GetStudentID(),
                        Name = student.GetName(),
                        Birthday = student.GetBirthday(),
                        CitizenIdentificationCode = student.GetCitizenIdentificationCode(),
                        Phone = student.GetPhone(),
                        Address = student.GetAddress(),
                        Sex = student.GetSex(),
                        Email = student.GetEmail(),
                        DayAdmission = student.GetDayAdmission(),
                        Major = student.GetMajor(),
                        Password = student.GetPassword(),
                        GPA = student.GetGPA(),
                    };

                    list.Add(obj);
                }
                else
                {
                    PostgraduateStudent postgraduateStudent = (PostgraduateStudent)student;

                    var obj = new
                    {
                        StudentID = student.GetStudentID(),
                        Name = student.GetName(),
                        Birthday = student.GetBirthday(),
                        CitizenIdentificationCode = student.GetCitizenIdentificationCode(),
                        Phone = student.GetPhone(),
                        Address = student.GetAddress(),
                        Sex = student.GetSex(),
                        Email = student.GetEmail(),
                        DayAdmission = student.GetDayAdmission(),
                        Major = student.GetMajor(),
                        Password = student.GetPassword(),
                        GPA = student.GetGPA(),
                        type = postgraduateStudent.getType(),
                    };

                    list.Add(obj);
                }
            }

            string pathFile = Environment.CurrentDirectory + "\\data_students.xml";

            if (!File.Exists(pathFile))
            {
                FileStream file = File.Create(pathFile);
                file.Close();
            }

            FileStream stream = File.OpenWrite(pathFile);

            if (stream == null)
                return false;

            try
            {
                StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

                JsonSerializer serializer = new JsonSerializer();

                serializer.Serialize(writer, list);
            }
            catch (Exception e)
            {
                stream.Close();
                return false;
            }

            stream.Close();

            return true;
        }

        public bool Add(Student student)
        {
            List<Student> students = GetAll();

            if (students == null)
                students = new List<Student>();

            students.Add(student);

            return WriteDataToFile(students);
        }

        public bool Delete(string ID)
        {
            List<Student> students = GetAll();

            foreach (Student item in students)
            {
                if (item.GetStudentID() == ID)
                {
                    students.Remove(item);
                    return WriteDataToFile(students);
                }
            }

            return false;
        }

        public List<Student>? GetAll()
        {
            List<Student>? students = new List<Student>();

            string pathFile = Environment.CurrentDirectory + "\\data_students.xml";

            if (!File.Exists(pathFile))
            {
                FileStream file = File.Create(pathFile);
                file.Close();
            }

            FileStream stream = File.OpenRead(pathFile);

            if (stream == null)
                return null;

            List<object> list = new List<object>();

            try
            {
                StreamReader reader = new StreamReader(stream);
                JsonSerializer serializer = new JsonSerializer();
                list = serializer.Deserialize(reader, typeof(List<object>)) as List<object>;
            }
            catch (Exception e)
            {
                stream.Close();
                return null;
            }

            if (list == null)
            {
                stream.Close();
                return students;
            }

            for (int i = 0; i < list.Count; ++i)
            {
                Newtonsoft.Json.Linq.JObject obj = (Newtonsoft.Json.Linq.JObject)list[i];

                if (obj["type"] == null)
                {
                    RegularStudent student = new RegularStudent(
                    (string)obj["CitizenIdentificationCode"],
                    (string)obj["Name"],
                    (string)obj["Birthday"],
                    (int)obj["Sex"],
                    (string)obj["Phone"],
                    (string)obj["Address"],
                    (string)obj["Email"],
                    (string)obj["StudentID"],
                    (string)obj["DayAdmission"],
                    (string)obj["Major"]
                    );

                    student.SetGPA((double)obj["GPA"]);
                    student.SetPassword((string)obj["Password"]);

                    students.Add(student);
                }
                else
                {
                    PostgraduateStudent student = new PostgraduateStudent(
                    (string)obj["CitizenIdentificationCode"],
                    (string)obj["Name"],
                    (string)obj["Birthday"],
                    (int)obj["Sex"],
                    (string)obj["Phone"],
                    (string)obj["Address"],
                    (string)obj["Email"],
                    (string)obj["StudentID"],
                    (string)obj["DayAdmission"],
                    (string)obj["Major"],
                    (string)obj["type"]
                    );

                    student.SetGPA((double)obj["GPA"]);
                    student.SetPassword((string)obj["Password"]);

                    students.Add(student);
                }

            }

            stream.Close();

            return students;
        }

        public Student? GetByID(string ID)
        {
            List<Student> students = GetAll();

            foreach (Student item in students)
            {
                if (item.GetStudentID() == ID)
                    return item;
            }

            return null;
        }

        public bool Update(Student student)
        {
            List<Student> students = GetAll();

            if (students == null)
                return false;

            for (int i = 0; i < students.Count; ++i)
            {
                if (students[i].GetStudentID() == student.GetStudentID())
                {
                    students[i] = student;
                    return WriteDataToFile(students);
                }
            }

            return false;
        }

        public List<PostgraduateStudent>? GetAllPostgraduateStudents()
        {
            List<Student> list = GetAll();

            List<PostgraduateStudent> postgraduateStudents = new List<PostgraduateStudent>();

            foreach (Student item in list)
            {
                if (item.GetType() == typeof(PostgraduateStudent))
                    postgraduateStudents.Add((PostgraduateStudent)item);
            }

            return postgraduateStudents;
        }

        public List<RegularStudent>? GetAllRegularStudents()
        {
            List<Student> list = GetAll();

            List<RegularStudent> regularStudents = new List<RegularStudent>();

            foreach (Student item in list)
            {
                if (item.GetType() == typeof(RegularStudent))
                    regularStudents.Add((RegularStudent)item);
            }

            return regularStudents;
        }

        public List<PostgraduateStudent>? GetPostgraduateStudentsByName(string name)
        {
            List<PostgraduateStudent> list = GetAllPostgraduateStudents();

            List<PostgraduateStudent> listGetByName = new List<PostgraduateStudent>();

            foreach (PostgraduateStudent stu in list)
            {
                if (stu.GetName().ToLower().Contains(name.ToLower()))
                {
                    listGetByName.Add(stu);
                }
            }

            return listGetByName;
        }

        public List<RegularStudent>? GetRegularStudentsByName(string name)
        {
            List<RegularStudent> list = GetAllRegularStudents();

            List<RegularStudent> listGetByName = new List<RegularStudent>();

            foreach (RegularStudent stu in list)
            {
                if (stu.GetName().ToLower().Contains(name.ToLower()))
                {
                    listGetByName.Add(stu);
                }
            }

            return listGetByName;
        }
    }
}
