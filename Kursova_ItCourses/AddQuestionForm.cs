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
    public partial class AddQuestionForm : Form
    {
        private List<Test> tests;
        public AddQuestionForm(List<Test> tests)
        {
            InitializeComponent();
            this.tests = tests;

            comboBoxTests.DataSource = null;
            comboBoxTests.DataSource = tests;
            comboBoxTests.DisplayMember = "Title";
        }

        private void textBoxAnswer4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAnswer3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAnswer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAnswer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            // Отримуємо вибраний тест
            if (comboBoxTests.SelectedItem != null)
            {
                var selectedTest = (Test)comboBoxTests.SelectedItem;

                // Отримуємо введене питання
                string questionText = textBoxQuestion.Text;

                // Отримуємо варіанти відповідей
                List<string> answerOptions = new List<string>
                {
            textBoxAnswer1.Text,
            textBoxAnswer2.Text,
            textBoxAnswer3.Text,
            textBoxAnswer4.Text
                };

                // Отримуємо правильну відповідь
                int correctAnswerIndex = -1;
                if (radioButton1.Checked)
                    correctAnswerIndex = 0;
                else if (radioButton2.Checked)
                    correctAnswerIndex = 1;
                else if (radioButton3.Checked)
                    correctAnswerIndex = 2;
                else if (radioButton4.Checked)
                    correctAnswerIndex = 3;

                // Створюємо нове питання
                var newQuestion = new Question(questionText, answerOptions, correctAnswerIndex);

                // Додаємо питання до тесту
                selectedTest.AddQuestion(newQuestion);

                // Очищаємо форму
                textBoxQuestion.Clear();
                textBoxAnswer1.Clear();
                textBoxAnswer2.Clear();
                textBoxAnswer3.Clear();
                textBoxAnswer4.Clear();

                // Повідомлення про успішне додавання питання
                MessageBox.Show("Питання додано до тесту!");

                // Оновлюємо список питань
                //UpdateQuestionsList(selectedTest);
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть тест.");
            }
        }
/*
        private void comboBoxTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTests.SelectedItem is Test selectedTest)
            {
                UpdateQuestionsList(selectedTest); // Оновлюємо список питань
            }
        }
        private void UpdateQuestionsList(Test selectedTest)
        {
            listBoxQuestions.Items.Clear(); // Очищаємо старі питання
            foreach (var question in selectedTest.Questions)
            {
                listBoxQuestions.Items.Add(question.QuestionText); // Додаємо питання в ListBox
            }
        }
*/
    }
}
