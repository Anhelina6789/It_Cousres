using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using Newtonsoft.Json;

namespace Kursova_ItCourses
{
    internal class UserAcount
    {
        private static string filePath = "C:\\Users\\User\\source\\repos\\Kursova_ItCourses\\Kursova_ItCourses\\bin\\Debug\\users.json";

        public static void SaveUsers(List<User> users)
        {
            string json = JsonConvert.SerializeObject(users, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public static List<User> LoadUsers()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<List<User>>(json);
            }
            return new List<User>();
        }
    }
}
