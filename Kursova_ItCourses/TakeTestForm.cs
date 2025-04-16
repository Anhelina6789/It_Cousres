using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Kursova_ItCourses
{
    public partial class TakeTestForm : Form
    {
        private Test currentTest;
        private List<Question> questions;
        private int currentQuestionIndex = 0;
        private int correctAnswersCount = 0;
        public TakeTestForm(Test test)
        {
            InitializeComponent();
            currentTest = test;
            questions = currentTest.Questions;
            DisplayCurrentQuestion();
        }
        private void DisplayCurrentQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                var question = questions[currentQuestionIndex];

                labelQuestion.Text = question.QuestionText;
                labelProgress.Text = $"Питання {currentQuestionIndex + 1} з {questions.Count}";

                // Заповнюємо варіанти
                radioButton1.Text = question.AnswerOptions[0];
                radioButton2.Text = question.AnswerOptions[1];
                radioButton3.Text = question.AnswerOptions[2];
                radioButton4.Text = question.AnswerOptions[3];

                // Скидаємо вибір
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;

                // Кнопки
                buttonNext.Visible = currentQuestionIndex < questions.Count - 1;
                buttonFinish.Visible = currentQuestionIndex == questions.Count - 1;
            }
        }
        private void CheckAnswer()
        {
            int selectedAnswerIndex = -1;
            if (radioButton1.Checked) selectedAnswerIndex = 0;
            else if (radioButton2.Checked) selectedAnswerIndex = 1;
            else if (radioButton3.Checked) selectedAnswerIndex = 2;
            else if (radioButton4.Checked) selectedAnswerIndex = 3;

            if (selectedAnswerIndex == questions[currentQuestionIndex].CorrectAnswerIndex)
            {
                correctAnswersCount++;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            CheckAnswer();
            currentQuestionIndex++;
            DisplayCurrentQuestion();
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            CheckAnswer();
            MessageBox.Show($"Тест завершено!\nПравильних відповідей: {correctAnswersCount} з {questions.Count}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
