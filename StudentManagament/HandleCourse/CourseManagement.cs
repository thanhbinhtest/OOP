using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace StudentManagament.HandleCourse
{
    internal class CourseManagement : IManagement<Course>
    {
        public bool WriteDataToFile(List<Course> courses)
        {
            List<object> list = new List<object>();

            foreach (Course course in courses)
            {
                if (course.GetType() == typeof(PostgraduateCourse))
                {
                    PostgraduateCourse postgraduateCourse = (PostgraduateCourse)course;

                    var obj = new
                    {
                        CourseID = postgraduateCourse.GetCourseID(),
                        Name = postgraduateCourse.GetNameCourse(),
                        Hour = postgraduateCourse.GetHourOfResearch()
                    };

                    list.Add(obj);
                }
                else if (course.GetType() == typeof(RegularCourse))
                {
                    RegularCourse regularCourse = (RegularCourse)course;

                    var obj = new
                    {
                        CourseID = regularCourse.GetCourseID(),
                        Name = regularCourse.GetNameCourse(),
                        Number = regularCourse.GetCreditsNumber()
                    };

                    list.Add(obj);
                }
            }

            string pathFile = Environment.CurrentDirectory + "\\data_courses.xml";

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

        public bool Add(Course course)
        {
            List<Course> courses = GetAll();

            if (courses == null)
                courses = new List<Course>();

            courses.Add(course);

            return WriteDataToFile(courses);
        }

        public bool Delete(string ID)
        {
            List<Course> courses = GetAll();

            foreach (Course item in courses)
            {
                if (item.GetCourseID() == ID)
                {
                    courses.Remove(item);
                    return WriteDataToFile(courses);
                }
            }

            return false;
        }

        public List<Course>? GetAll()
        {
            List<Course>? courses = new List<Course>();

            string pathFile = Environment.CurrentDirectory + "\\data_courses.xml";

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
                return courses;
            }

            for (int i = 0; i < list.Count; ++i)
            {
                Newtonsoft.Json.Linq.JObject obj = (Newtonsoft.Json.Linq.JObject)list[i];

                if (obj["Number"] != null)
                {
                    RegularCourse course = new RegularCourse(
                    (string)obj["CourseID"],
                    (string)obj["Name"],
                    (int)obj["Number"]
                    );

                    courses.Add(course);
                }
                else
                {
                    PostgraduateCourse course = new PostgraduateCourse(
                    (string)obj["CourseID"],
                    (string)obj["Name"],
                    (int)obj["Hour"]
                    );

                    courses.Add(course);
                }

            }

            stream.Close();

            return courses;
        }

        public Course? GetByID(string ID)
        {
            List<Course> courses = GetAll();

            foreach (Course item in courses)
            {
                if (item.GetCourseID() == ID)
                    return item;
            }

            return null;
        }

        public List<Course>? GetByName(string name)
        {
            return null;
        }

        public bool Update(Course course)
        {
            List<Course> courses = GetAll();

            if (courses == null)
                return false;

            for (int i = 0; i < courses.Count; ++i)
            {
                if (courses[i].GetCourseID() == course.GetCourseID())
                {
                    courses[i] = course;
                    return WriteDataToFile(courses);
                }
            }

            return false;
        }

        public List<PostgraduateCourse>? GetAllPostgraduateCourse()
        {
            List<Course> list = GetAll();

            List<PostgraduateCourse> postgraduateCourses = new List<PostgraduateCourse>();

            foreach (Course item in list)
            {
                if (item.GetType() == typeof(PostgraduateCourse))
                    postgraduateCourses.Add((PostgraduateCourse)item);
            }

            return postgraduateCourses;
        }

        public List<RegularCourse>? GetAllRegularCourse()
        {
            List<Course> list = GetAll();

            List<RegularCourse> regularCourses = new List<RegularCourse>();

            foreach (Course item in list)
            {
                if (item.GetType() == typeof(RegularCourse))
                    regularCourses.Add((RegularCourse)item);
            }

            return regularCourses;
        }

        public List<PostgraduateCourse>? GetPostgraduateCourseByName(string name)
        {
            List<PostgraduateCourse> list = GetAllPostgraduateCourse();

            List<PostgraduateCourse> listGetByName = new List<PostgraduateCourse>();

            foreach (PostgraduateCourse course in list)
            {
                if(course.GetNameCourse().ToLower().Contains(name.ToLower()))
                {
                    listGetByName.Add(course);
                }
            }

            return listGetByName;
        }

        public List<RegularCourse>? GetRegularCourseByName(string name)
        {
            List<RegularCourse> list = GetAllRegularCourse();

            List<RegularCourse> listGetByName = new List<RegularCourse>();

            foreach (RegularCourse course in list)
            {
                if (course.GetNameCourse().ToLower().Contains(name.ToLower()))
                {
                    listGetByName.Add(course);
                }
            }

            return listGetByName;
        }
    }
}
