namespace Kursova_ItCourses
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBoxTests = new System.Windows.Forms.ListBox();
            this.AddTestQ = new System.Windows.Forms.Button();
            this.createTest = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBoxT = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelProfRole = new System.Windows.Forms.Label();
            this.labelProfEmail = new System.Windows.Forms.Label();
            this.labelProfT = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.TabControl();
            this.ListStudents = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxT)).BeginInit();
            this.Exit.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(0, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(384, 30);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Вас вітає...";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBoxTests);
            this.tabPage4.Controls.Add(this.AddTestQ);
            this.tabPage4.Controls.Add(this.createTest);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(384, 498);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Тести";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBoxTests
            // 
            this.listBoxTests.FormattingEnabled = true;
            this.listBoxTests.Location = new System.Drawing.Point(28, 18);
            this.listBoxTests.Name = "listBoxTests";
            this.listBoxTests.Size = new System.Drawing.Size(320, 186);
            this.listBoxTests.TabIndex = 3;
            // 
            // AddTestQ
            // 
            this.AddTestQ.Location = new System.Drawing.Point(185, 231);
            this.AddTestQ.Name = "AddTestQ";
            this.AddTestQ.Size = new System.Drawing.Size(163, 64);
            this.AddTestQ.TabIndex = 2;
            this.AddTestQ.Text = "Додати питання до тесту";
            this.AddTestQ.UseVisualStyleBackColor = true;
            this.AddTestQ.Click += new System.EventHandler(this.AddTestQ_Click);
            // 
            // createTest
            // 
            this.createTest.Location = new System.Drawing.Point(28, 231);
            this.createTest.Name = "createTest";
            this.createTest.Size = new System.Drawing.Size(119, 64);
            this.createTest.TabIndex = 1;
            this.createTest.Text = "Створити тест";
            this.createTest.UseVisualStyleBackColor = true;
            this.createTest.Click += new System.EventHandler(this.createTest_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.ListStudents);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(384, 498);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Студенти";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textDescription);
            this.tabPage2.Controls.Add(this.textTitle);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.listBoxCourses);
            this.tabPage2.Controls.Add(this.buttonDel);
            this.tabPage2.Controls.Add(this.buttonEdit);
            this.tabPage2.Controls.Add(this.buttonAdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(384, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Курси";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(222, 77);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(100, 20);
            this.textDescription.TabIndex = 11;
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(222, 27);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(100, 20);
            this.textTitle.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Опис";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Назва";
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.Location = new System.Drawing.Point(12, 6);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(120, 173);
            this.listBoxCourses.TabIndex = 7;
            this.listBoxCourses.Tag = "";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(115, 349);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(150, 40);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "Видалити";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(115, 303);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(150, 40);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Редагувати";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(115, 257);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 40);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBoxT);
            this.tabPage1.Controls.Add(this.buttonExit);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.labelProfRole);
            this.tabPage1.Controls.Add(this.labelProfEmail);
            this.tabPage1.Controls.Add(this.labelProfT);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(384, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Профіль";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxT
            // 
            this.pictureBoxT.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxT.Image")));
            this.pictureBoxT.Location = new System.Drawing.Point(133, 25);
            this.pictureBoxT.Name = "pictureBoxT";
            this.pictureBoxT.Size = new System.Drawing.Size(106, 91);
            this.pictureBoxT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxT.TabIndex = 5;
            this.pictureBoxT.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(115, 372);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(139, 37);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Вихід";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Редагувати профіль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelProfRole
            // 
            this.labelProfRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfRole.Location = new System.Drawing.Point(39, 212);
            this.labelProfRole.Name = "labelProfRole";
            this.labelProfRole.Size = new System.Drawing.Size(114, 20);
            this.labelProfRole.TabIndex = 2;
            this.labelProfRole.Text = "Роль:";
            // 
            // labelProfEmail
            // 
            this.labelProfEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfEmail.Location = new System.Drawing.Point(39, 174);
            this.labelProfEmail.Name = "labelProfEmail";
            this.labelProfEmail.Size = new System.Drawing.Size(114, 20);
            this.labelProfEmail.TabIndex = 1;
            this.labelProfEmail.Text = "Email:";
            this.labelProfEmail.Click += new System.EventHandler(this.lblProfEmail_Click);
            // 
            // labelProfT
            // 
            this.labelProfT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfT.Location = new System.Drawing.Point(39, 140);
            this.labelProfT.Name = "labelProfT";
            this.labelProfT.Size = new System.Drawing.Size(114, 20);
            this.labelProfT.TabIndex = 0;
            this.labelProfT.Text = "Ім\'я:";
            // 
            // Exit
            // 
            this.Exit.Controls.Add(this.tabPage1);
            this.Exit.Controls.Add(this.tabPage2);
            this.Exit.Controls.Add(this.tabPage3);
            this.Exit.Controls.Add(this.tabPage4);
            this.Exit.Location = new System.Drawing.Point(-4, 42);
            this.Exit.Name = "Exit";
            this.Exit.SelectedIndex = 0;
            this.Exit.Size = new System.Drawing.Size(392, 524);
            this.Exit.TabIndex = 2;
            this.Exit.TabStop = false;
            // 
            // ListStudents
            // 
            this.ListStudents.FormattingEnabled = true;
            this.ListStudents.Location = new System.Drawing.Point(12, 6);
            this.ListStudents.Name = "ListStudents";
            this.ListStudents.Size = new System.Drawing.Size(360, 186);
            this.ListStudents.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Знайти студента";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(88, 259);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Введіть дані студента для пошуку";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.labelWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxT)).EndInit();
            this.Exit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelProfRole;
        private System.Windows.Forms.Label labelProfEmail;
        private System.Windows.Forms.Label labelProfT;
        private System.Windows.Forms.TabControl Exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBoxT;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddTestQ;
        private System.Windows.Forms.Button createTest;
        private System.Windows.Forms.ListBox listBoxTests;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ListStudents;
    }
}