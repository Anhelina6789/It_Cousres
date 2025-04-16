using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_ItCourses
{
    public partial class CreateTestForm : Form
    {
        private List<Test> tests;

        public CreateTestForm(List<Test> tests)
        {
            InitializeComponent();
            this.tests = tests;
        }

        private void saveTest_Click(object sender, EventArgs e)
        {
            string title = nameTest.Text;
            string description = descTest.Text;

            if (!string.IsNullOrEmpty(title))
            {
                var newTest = new Test(title, description);
                tests.Add(newTest);
                MessageBox.Show("Тест створено!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть назву тесту.");
            }
        }
    }
}
