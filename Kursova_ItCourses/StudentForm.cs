using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kursova_ItCourses
{
    public partial class StudentForm : Form
    {
        private User currentUser;
        private List<Course> registeredCoursesBox = new List<Course>();
        private string registeredCoursesFilePath;
        public StudentForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            registeredCoursesFilePath = $"registered_courses_{currentUser.Username}.json";
            LoadProfileData();
            labelWelcome.Text = $"Вітаємо, {currentUser.Username}!";
            CourseManager.LoadCourses();
            UpdateCourseList();
            TestManager.LoadTests();
            UpdateTestList();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void lastres_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateTestList()
        {
            listBoxAvailableTests.Items.Clear();  // Очищаємо старі тести

            // Додаємо нові тести з TestManager
            foreach (var test in TestManager.Tests)
            {
                listBoxAvailableTests.Items.Add(test);
            }
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            TestManager.LoadTests();  // Завантажуємо тести з файлу
            listBoxAvailableTests.Items.Clear();  // Очищаємо список перед заповненням

            // Додаємо тести в ListBox
            foreach (var test in TestManager.Tests)
            {
                listBoxAvailableTests.Items.Add(test);  // Додаємо тест (за замовчуванням використовується ToString())
            }

            // Встановлюємо, щоб відображався тільки заголовок тесту (якщо потрібно)
            listBoxAvailableTests.DisplayMember = "Title";
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
        private void UpdateCourseList()
        {
            listBoxCourseStudent.Items.Clear(); 
            foreach (var course in CourseManager.GetCourses())
            {
                listBoxCourseStudent.Items.Add(course);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
                        
            LoginForm registerForm = new LoginForm();
            registerForm.Show();
        }

        private void btnRegCourse_Click(object sender, EventArgs e)
        {
            if (listBoxCourseStudent.SelectedItem is Course selectedCourse)
            {
                if (!registeredCoursesBox.Any(c => c.Title == selectedCourse.Title))
                {
                    registeredCoursesBox.Add(selectedCourse);
                    SaveRegisteredCourses();
                    MessageBox.Show($"Ви успішно зареєстровані на курс: {selectedCourse.Title}");
                    //UpdateRegisteredCourses();
                }
                else
                {
                    MessageBox.Show("Ви вже зареєстровані на цей курс.");
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть курс для реєстрації.");
            }
        }
        //private void UpdateRegisteredCourses()
        //{
           // registeredCourses.Items.Clear();
            //oreach (var course in registeredCourses)
           // {
              //  registeredCourses.Items.Add(course);
        //    }
       // }
        private void SaveRegisteredCourses()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(registeredCoursesFilePath, JsonSerializer.Serialize(registeredCourses, options));
        }

       // private void LoadRegisteredCourses()
        //{
        //    if (File.Exists(registeredCoursesFilePath))
         //   {
         //       string json = File.ReadAllText(registeredCoursesFilePath);
                //registeredCourses = JsonSerializer.Deserialize<List<Course>>(json);
           // }
       // }


        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            EditProfile editForm = new EditProfile(currentUser);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadProfileData();
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxAvailableTests.SelectedItem is Test selectedTest)
            {
                TakeTestForm testForm = new TakeTestForm(selectedTest);
                testForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть тест для проходження.");
            }
        }
    }
}
