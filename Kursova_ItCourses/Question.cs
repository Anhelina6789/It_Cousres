using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova_ItCourses
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<string> AnswerOptions { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public Question(string questionText, List<string> answerOptions, int correctAnswerIndex)
        {
            QuestionText = questionText;
            AnswerOptions = answerOptions;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}
