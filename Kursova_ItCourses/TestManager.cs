using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Kursova_ItCourses
{
    public static class TestManager
    {
        private static string filePath = "tests.json";
        public static List<Test> Tests { get; private set; } = new List<Test>();

        public static void SaveTests()
        {
            var json = JsonSerializer.Serialize(Tests);
            File.WriteAllText(filePath, json);
        }

        public static void LoadTests()
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                Tests = JsonSerializer.Deserialize<List<Test>>(json) ?? new List<Test>();
            }
        }

        public static void AddTest(Test test)
        {
            Tests.Add(test);
            SaveTests();
        }
    }
}
