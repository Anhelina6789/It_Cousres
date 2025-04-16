using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kursova_ItCourses
{
    public partial class EditProfile : Form
    {
        private User user;
        public EditProfile(User user)
        {
            InitializeComponent();
            this.user = user;

            textname.Text = user.Username;
            textemail.Text = user.Email;
            textpassword.Text = user.Password;
            if (user.ImagePath != null)
                pictureBoxProfile.Image = Image.FromFile(user.ImagePath);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (textpassword.Text != textConfirmPass.Text)
            {
                MessageBox.Show("Паролі не збігаються! Спробуйте ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            user.Username = textname.Text;
            user.Email = textemail.Text;
            user.Password = textpassword.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.png;*.jpeg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProfile.Image = Image.FromFile(openFile.FileName);
                user.ImagePath = openFile.FileName;
            }
        }
    }
}
