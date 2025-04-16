using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Kursova_ItCourses
{
    public partial class LoginForm : Form
    {
        private List<User> users = new List<User>();
        public LoginForm()
        {
            InitializeComponent();

            cmbRole.Items.AddRange(new string[] { "Студент", "Викладач" });
            cmbRole.SelectedIndex = 0;
                      users.Add(new User("student1", "1234", "student@gmail.com", "Студент"));
            users.Add(new User("teacher1", "1234", "teacher@gmail.com", "Викладач"));
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textUserName.Text.Trim();
            string password = textPassword.Text.Trim();
            string role = cmbRole.SelectedItem.ToString();

            var user = users.FirstOrDefault(u =>
                u.Username == username &&
                u.Password == password &&
                u.Role == role);

            if (user != null)
            {
                MessageBox.Show($"Вхід як {role} успішний!");
                this.Hide();

                if (role == "Студент")
                    new StudentForm(user).Show();
                else if (role == "Викладач")
                    new TeacherForm(user).Show();
            }
            else
            {
                labelStatus.Text = "Неправильне ім'я, Email, пароль або роль.";
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textUserName.Text.Trim();
            string password = textPassword.Text.Trim();
            string email = textEmail.Text.Trim();

            // Перевірка на порожнє ім'я користувача
            if (string.IsNullOrWhiteSpace(username) || username == "Введіть ім'я користувача")
            {
                labelStatus.Text = "Ім'я користувача не може бути порожнім!";
                return;
            }

            // Перевірка на порожній пароль
            if (string.IsNullOrWhiteSpace(password) || password == "Введіть пароль")
            {
                labelStatus.Text = "Пароль не може бути порожнім!";
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || email == "Введіть Email")
            {
                labelStatus.Text = "Електронна пошта не може бути порожньою!";
                return;
            }

            if (users.Any(u => u.Username == username))
            {
                labelStatus.Text = "Користувач з таким іменем вже існує.";
                return;
            }

            string role = cmbRole.SelectedItem.ToString();

           
            users.Add(new User(username, password, email, role));
            labelStatus.Text = "Реєстрація успішна!";

        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (textUserName.Text == "Введіть ім'я користувача")
            {
                textUserName.Text = "";
                textUserName.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textUserName.Text))
            {
                textUserName.Text = "Введіть ім'я користувача";
                textUserName.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (textPassword.Text == "Введіть пароль")
            {
                textPassword.Text = "";
                textPassword.ForeColor = Color.Black;
                textPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textPassword.Text))
            {
                textPassword.UseSystemPasswordChar = false;
                textPassword.Text = "Введіть пароль";
                textPassword.ForeColor = Color.Gray;
            }
        }

        private void textEmail_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "Введіть Email")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.Black;
            }
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEmail.Text))
            {
                textEmail.Text = "Введіть Email";
                textEmail.ForeColor = Color.Gray;
            }
        }
        private void labelStatus_Click(object sender, EventArgs e)
        {

        }
    }
}

