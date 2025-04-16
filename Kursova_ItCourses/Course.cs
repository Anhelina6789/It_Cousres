using Kursova_ItCourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Kursova_ItCourses
{
    public class Course
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
public static class CourseManager
{
    private static List<Course> courses = new List<Course>();
    private static string filePath = "courses.json";

    public static void AddCourse(Course course)
    {
        courses.Add(course);
        SaveCourses();
    }

    public static List<Course> GetCourses()
    {
        return new List<Course>(courses);
    }
    public static void LoadCourses()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            courses = JsonSerializer.Deserialize<List<Course>>(json);
        }
    }

    public static void SaveCourses()
    {
        string json = JsonSerializer.Serialize(courses);
        File.WriteAllText(filePath, json);
    }
    public static void RemoveCourse(Course course)
    {
        courses.Remove(course);
        SaveCourses();
    }

}

