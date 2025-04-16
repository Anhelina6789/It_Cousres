using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_ItCourses
{
    public class Test
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Question> Questions { get; set; }

        public Test(string title, string description)
        {
            Title = title;
            Description = description;
            Questions = new List<Question>();
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }
        public override string ToString()
        {
            return Title;
        }
    }
}
