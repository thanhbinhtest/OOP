using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace StudentManagament.HandleTeacher
{
    internal class TeacherManagement : IManagement<Teacher>
    {
        public bool WriteDataToFile(List<Teacher> teachers)
        {
            List<object> list = new List<object>();

            foreach (Teacher teacher in teachers)
            {
                var obj = new
                {
                    TeacherID = teacher.GetTeacherID(),
                    Name = teacher.GetName(),
                    Birthday = teacher.GetBirthday(),
                    CitizenIdentificationCode = teacher.GetCitizenIdentificationCode(),
                    Phone = teacher.GetPhone(),
                    Address = teacher.GetAddress(),
                    Sex = teacher.GetSex(),
                    Email = teacher.GetEmail(),
                    Password = teacher.GetPassword(),
                };

                list.Add(obj);
            }

            string pathFile = Environment.CurrentDirectory + "\\data_teachers.xml";

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

        public bool Add(Teacher teacher)
        {
            List<Teacher> teachers = GetAll();

            if (teachers == null)
                teachers = new List<Teacher>();

            teachers.Add(teacher);

            return WriteDataToFile(teachers);
        }

        public bool Delete(string ID)
        {
            List<Teacher> teachers = GetAll();

            foreach (Teacher teacher in teachers)
            {
                if (teacher.GetTeacherID() == ID)
                {
                    teachers.Remove(teacher);
                    return WriteDataToFile(teachers);
                }
            }

            return false;
        }

        public List<Teacher>? GetAll()
        {
            List<Teacher>? teachers = new List<Teacher>();

            string pathFile = Environment.CurrentDirectory + "\\data_teachers.xml";

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
                return teachers;
            }

            for (int i = 0; i < list.Count; ++i)
            {
                Newtonsoft.Json.Linq.JObject obj = (Newtonsoft.Json.Linq.JObject)list[i];

                Teacher teacher = new Teacher(
                    (string)obj["CitizenIdentificationCode"],
                    (string)obj["Name"],
                    (string)obj["Birthday"],
                    (int)obj["Sex"],
                    (string)obj["Phone"],
                    (string)obj["Address"],
                    (string)obj["Email"],
                    (string)obj["TeacherID"]                   
                    );

                teacher.SetPassword((string)obj["Password"]);

                teachers.Add(teacher);

            }

            stream.Close();

            return teachers;
        }

        public Teacher? GetByID(string ID)
        {
            List<Teacher> teachers = GetAll();

            foreach (Teacher item in teachers)
            {
                if (item.GetTeacherID() == ID)
                    return item;
            }

            return null;
        }

        public List<Teacher>? GetByName(string name)
        {
            List<Teacher> list = GetAll();

            List<Teacher> listGetByName = new List<Teacher>();

            foreach (Teacher teacher in list)
            {
                if (teacher.GetName().ToLower().Contains(name.ToLower()))
                {
                    listGetByName.Add(teacher);
                }
            }

            return listGetByName;
        }

        public bool Update(Teacher teacher)
        {
            List<Teacher> teachers = GetAll();

            if (teachers == null)
                return false;

            for (int i = 0; i < teachers.Count; ++i)
            {
                if (teachers[i].GetTeacherID() == teacher.GetTeacherID())
                {
                    teachers[i] = teacher;
                    return WriteDataToFile(teachers);
                }
            }

            return false;
        }
    }
}
