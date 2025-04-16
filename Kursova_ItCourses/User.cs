using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_ItCourses
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string ProfileImagePath { get; set; }
        public string ImagePath { get; set; }

        public Image ProfileImage
        {
            get
            {
                if (!string.IsNullOrEmpty(ImagePath))
                {
                    return Image.FromFile(ImagePath);
                }
                return null;
            }
        }
        public User(string username, string password, string email, string role)
        {
            Username = username;
            Password = password;
            Email = email;
            Role = role;
            ImagePath = null;
        }
    }
}
