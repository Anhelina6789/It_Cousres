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
    public partial class TeacherForm : Form
    {
        private User currentUser;
        private List<Test> tests = new List<Test>();  // список тестів
        public TeacherForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadProfileData();
            LoadTests();
            CourseManager.LoadCourses();
            UpdateCourseList();
            UpdateTestList();

        }

        private void UpdateTestList()
        {
            listBoxTests.Items.Clear();
            foreach (var test in TestManager.Tests)
            {
                listBoxTests.Items.Add(test.Title);
            }
        }
        private void LoadProfileData()
        {            
            labelWelcome.Text = $"Вітаємо, {currentUser.Username}!";
            labelProfT.Text = $"Ім'я користувача: {currentUser.Username}";
            labelProfEmail.Text = $"Email: {currentUser.Email}";
            labelProfRole.Text = $"Роль: {currentUser.Role}";
            // Завантажити фото, якщо потрібно:
            if (currentUser.ProfileImage != null)
            {
                pictureBoxT.Image = currentUser.ProfileImage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditProfile editForm = new EditProfile(currentUser);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadProfileData();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            Close();

            LoginForm registerForm = new LoginForm();
            registerForm.Show();
        }

        private void lblProfEmail_Click(object sender, EventArgs e)
        {

        }

        private List<Course> courses = new List<Course>();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string title = textTitle.Text.Trim();
            string description = textDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Назва курсу не може бути порожньою.");
                return;
            }

            Course newCourse = new Course
            {
                Title = title,
                Description = description
            };

            CourseManager.AddCourse(newCourse);
            UpdateCourseList();

            textTitle.Clear();
            textDescription.Clear();
        }
        private void UpdateCourseList()
        {
            listBoxCourses.Items.Clear();
            foreach (var course in CourseManager.GetCourses())
            {
                listBoxCourses.Items.Add(course);
            }
        }
       

        private void LoadTests()
        {
            listBoxTests.Items.Clear();
            foreach (var test in tests)
            {
                listBoxTests.Items.Add(test.Title);  // Відображаємо тести в ListBox
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listBoxCourses.SelectedItem is Course selectedCourse)
            {
                CourseManager.RemoveCourse(selectedCourse);
                UpdateCourseList();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        

        private void createTest_Click(object sender, EventArgs e)
        {
            var createTestForm = new CreateTestForm(tests);
            createTestForm.ShowDialog();
            LoadTests();
        }

        private void AddTestQ_Click(object sender, EventArgs e)
        {
            AddQuestionForm addQuestionForm = new AddQuestionForm(tests);
            addQuestionForm.ShowDialog();
        }
         
    }
    
}