using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagament.HandleClass
{
    internal class ClassManagement : IManagement<Class>
    {
        public bool WriteDataToFile(List<Class> classes)
        {
            List<object> list = new List<object>();

            foreach (Class item in classes)
            {
                if (item.GetType().Name == "PostgraduateClass")
                {
                    PostgraduateClass postgraduateClass = (PostgraduateClass)item;

                    var obj = new
                    {
                        ClassID = item.GetClassID(),
                        TeacherID = item.GetTeacher(),
                        CourseID = item.GetCourseID(),
                        StartDate = item.GetStartDate(),
                        EndDate = item.GetEndDate(),
                        MaxStudents = item.GetMaxStudents(),
                        Students = item.GetListStudents(),
                        EssayReportingTime = postgraduateClass.GetEssayReportingTime()
                    };

                    list.Add(obj);
                }
                else
                {
                    RegularClass regularClass = (RegularClass)item;

                    var obj = new
                    {
                        ClassID = item.GetClassID(),
                        TeacherID = item.GetTeacher(),
                        CourseID = item.GetCourseID(),
                        StartDate = item.GetStartDate(),
                        EndDate = item.GetEndDate(),
                        MaxStudents = item.GetMaxStudents(),
                        Students = item.GetListStudents(),
                        NumberOfLessons = regularClass.GetNumberOfLessons(),
                        ClassStartTime = regularClass.GetClassStartTime()
                        };

                    list.Add(obj);
                }
            }

            string pathFile = Environment.CurrentDirectory + "\\data_classes.xml";

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

        public bool Add(Class _class)
        {
            List<Class> classes = GetAll();

            if (classes == null)
                classes = new List<Class>();

            classes.Add(_class);

            return WriteDataToFile(classes);
        }

        public bool Delete(string ID)
        {
            List<Class> classes = GetAll();

            foreach (Class item in classes)
            {
                if (item.GetClassID() == ID)
                {
                    classes.Remove(item);
                    return WriteDataToFile(classes);
                }
            }

            return false;
        }

        public List<Class>? GetAll()
        {
            List<Class>? classes = new List<Class>();

            string pathFile = Environment.CurrentDirectory + "\\data_classes.xml";

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
                return classes;
            }

            for (int i = 0; i < list.Count; ++i)
            {
                Newtonsoft.Json.Linq.JObject obj = (Newtonsoft.Json.Linq.JObject)list[i];

                if (obj["EssayReportingTime"] == null)
                {
                    RegularClass _class = new RegularClass(
                    (string)obj["ClassID"],
                    (string)obj["TeacherID"],
                    (string)obj["CourseID"],
                    (string)obj["StartDate"],
                    (string)obj["EndDate"],
                    (int)obj["MaxStudents"],
                    (int)obj["NumberOfLessons"],
                    (string)obj["ClassStartTime"]
                    );

                    List<string> listStudents = new List<string>();

                    foreach(string item in obj["Students"])
                    {
                        listStudents.Add(item);
                    }

                    _class.SetListStudents(listStudents);

                    classes.Add(_class);
                }
                else
                {
                    PostgraduateClass _class = new PostgraduateClass(
                    (string)obj["ClassID"],
                    (string)obj["TeacherID"],
                    (string)obj["CourseID"],
                    (string)obj["StartDate"],
                    (string)obj["EndDate"],
                    (int)obj["MaxStudents"],
                    (string)obj["EssayReportingTime"]
                    );

                    List<string> listStudents = new List<string>();

                    foreach (string item in obj["Students"])
                    {
                        listStudents.Add(item);
                    }

                    _class.SetListStudents(listStudents);

                    classes.Add(_class);
                }

            }

            stream.Close();

            return classes;
        }

        public List<PostgraduateClass>? GetAllPostgraduateClasses()
        {
            List<Class> list = GetAll();

            List<PostgraduateClass> postgraduateClasses = new List<PostgraduateClass>();

            foreach (Class item in list)
            {
                if (item.GetType() == typeof(PostgraduateClass))
                    postgraduateClasses.Add((PostgraduateClass)item);
            }

            return postgraduateClasses;
        }

        public List<RegularClass>? GetAllRegularClasses()
        {
            List<Class> list = GetAll();

            List<RegularClass> regularClasses = new List<RegularClass>();

            foreach (Class item in list)
            {
                if (item.GetType() == typeof(RegularClass))
                    regularClasses.Add((RegularClass)item);
            }

            return regularClasses;
        }

        public Class? GetByID(string ID)
        {
            List<Class> classes = GetAll();

            foreach (Class item in classes)
            {
                if (item.GetClassID() == ID)
                    return item;
            }

            return null;
        }

        public List<PostgraduateClass>? GetPostgraduateClassesByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<RegularClass>? GetRegularClassesByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Update(Class _class)
        {
            List<Class> classes = GetAll();

            for(int i = 0; i < classes.Count; i++)
            {
                if (classes[i].GetClassID() == _class.GetClassID())
                {
                    classes[i] = _class;
                    return WriteDataToFile(classes);
                }
            }    

            return false;
        }
    }
}
