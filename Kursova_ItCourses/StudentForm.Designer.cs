namespace Kursova_ItCourses
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBoxT = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelProfRole = new System.Windows.Forms.Label();
            this.labelProfEmail = new System.Windows.Forms.Label();
            this.labelProfT = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label = new System.Windows.Forms.Label();
            this.registeredCourses = new System.Windows.Forms.ListBox();
            this.btnRegCourse = new System.Windows.Forms.Button();
            this.YourCourse = new System.Windows.Forms.Label();
            this.listBoxCourseStudent = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.listBoxAvailableTests = new System.Windows.Forms.ListBox();
            this.Test = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lastres = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxT)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(0, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(384, 30);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "вас вітає...";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 420);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBoxT);
            this.tabPage1.Controls.Add(this.buttonExit);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.labelProfRole);
            this.tabPage1.Controls.Add(this.labelProfEmail);
            this.tabPage1.Controls.Add(this.labelProfT);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Профіль";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxT
            // 
            this.pictureBoxT.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxT.Image")));
            this.pictureBoxT.Location = new System.Drawing.Point(133, 21);
            this.pictureBoxT.Name = "pictureBoxT";
            this.pictureBoxT.Size = new System.Drawing.Size(106, 91);
            this.pictureBoxT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxT.TabIndex = 11;
            this.pictureBoxT.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(115, 327);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(139, 37);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Вихід";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(115, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Редагувати профіль";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelProfRole
            // 
            this.labelProfRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfRole.Location = new System.Drawing.Point(35, 213);
            this.labelProfRole.Name = "labelProfRole";
            this.labelProfRole.Size = new System.Drawing.Size(114, 20);
            this.labelProfRole.TabIndex = 8;
            this.labelProfRole.Text = "Роль:";
            // 
            // labelProfEmail
            // 
            this.labelProfEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfEmail.Location = new System.Drawing.Point(35, 170);
            this.labelProfEmail.Name = "labelProfEmail";
            this.labelProfEmail.Size = new System.Drawing.Size(114, 20);
            this.labelProfEmail.TabIndex = 7;
            this.labelProfEmail.Text = "Email:";
            // 
            // labelProfT
            // 
            this.labelProfT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfT.Location = new System.Drawing.Point(35, 131);
            this.labelProfT.Name = "labelProfT";
            this.labelProfT.Size = new System.Drawing.Size(114, 20);
            this.labelProfT.TabIndex = 6;
            this.labelProfT.Text = "Ім\'я:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label);
            this.tabPage3.Controls.Add(this.registeredCourses);
            this.tabPage3.Controls.Add(this.btnRegCourse);
            this.tabPage3.Controls.Add(this.YourCourse);
            this.tabPage3.Controls.Add(this.listBoxCourseStudent);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(376, 394);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Мої курси";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(200, 44);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(168, 20);
            this.label.TabIndex = 5;
            this.label.Text = "Зареєстровані курси";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registeredCourses
            // 
            this.registeredCourses.FormattingEnabled = true;
            this.registeredCourses.Location = new System.Drawing.Point(200, 77);
            this.registeredCourses.Name = "registeredCourses";
            this.registeredCourses.Size = new System.Drawing.Size(168, 95);
            this.registeredCourses.TabIndex = 4;
            this.registeredCourses.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // btnRegCourse
            // 
            this.btnRegCourse.BackColor = System.Drawing.Color.Aquamarine;
            this.btnRegCourse.Location = new System.Drawing.Point(111, 252);
            this.btnRegCourse.Name = "btnRegCourse";
            this.btnRegCourse.Size = new System.Drawing.Size(155, 38);
            this.btnRegCourse.TabIndex = 2;
            this.btnRegCourse.Text = "Записатись на курс";
            this.btnRegCourse.UseVisualStyleBackColor = false;
            this.btnRegCourse.Click += new System.EventHandler(this.btnRegCourse_Click);
            // 
            // YourCourse
            // 
            this.YourCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourCourse.Location = new System.Drawing.Point(3, 44);
            this.YourCourse.Name = "YourCourse";
            this.YourCourse.Size = new System.Drawing.Size(168, 20);
            this.YourCourse.TabIndex = 1;
            this.YourCourse.Text = "Доступні курси";
            this.YourCourse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxCourseStudent
            // 
            this.listBoxCourseStudent.FormattingEnabled = true;
            this.listBoxCourseStudent.Location = new System.Drawing.Point(3, 77);
            this.listBoxCourseStudent.Name = "listBoxCourseStudent";
            this.listBoxCourseStudent.Size = new System.Drawing.Size(168, 95);
            this.listBoxCourseStudent.TabIndex = 0;
            this.listBoxCourseStudent.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.listBoxAvailableTests);
            this.tabPage2.Controls.Add(this.Test);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 394);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Тести";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Розпочати тест";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxAvailableTests
            // 
            this.listBoxAvailableTests.FormattingEnabled = true;
            this.listBoxAvailableTests.Location = new System.Drawing.Point(56, 46);
            this.listBoxAvailableTests.Name = "listBoxAvailableTests";
            this.listBoxAvailableTests.Size = new System.Drawing.Size(276, 95);
            this.listBoxAvailableTests.TabIndex = 1;
            // 
            // Test
            // 
            this.Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test.Location = new System.Drawing.Point(0, 20);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(376, 23);
            this.Test.TabIndex = 0;
            this.Test.Text = "Доступні тести:";
            this.Test.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.lastres);
            this.tabPage4.Controls.Add(this.listBox3);
            this.tabPage4.Controls.Add(this.result);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(376, 394);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Результати";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lastres
            // 
            this.lastres.AutoSize = true;
            this.lastres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastres.ForeColor = System.Drawing.Color.Red;
            this.lastres.Location = new System.Drawing.Point(30, 306);
            this.lastres.Name = "lastres";
            this.lastres.Size = new System.Drawing.Size(134, 20);
            this.lastres.TabIndex = 2;
            this.lastres.Text = "Останній тест:";
            this.lastres.Click += new System.EventHandler(this.lastres_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(80, 65);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(210, 95);
            this.listBox3.TabIndex = 1;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(0, 28);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(376, 23);
            this.result.TabIndex = 0;
            this.result.Text = "Ваші результати:";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Переглянути результат тесту";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelWelcome);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxT)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnRegCourse;
        private System.Windows.Forms.Label YourCourse;
        private System.Windows.Forms.ListBox listBoxCourseStudent;
        private System.Windows.Forms.ListBox listBoxAvailableTests;
        private System.Windows.Forms.Label Test;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lastres;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.PictureBox pictureBoxT;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelProfRole;
        private System.Windows.Forms.Label labelProfEmail;
        private System.Windows.Forms.Label labelProfT;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListBox registeredCourses;
        private System.Windows.Forms.Button button1;
    }
}