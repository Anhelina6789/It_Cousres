namespace Kursova_ItCourses
{
    partial class CreateTestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTest = new System.Windows.Forms.TextBox();
            this.descTest = new System.Windows.Forms.TextBox();
            this.saveTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва тесту";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Опис тесту";
            // 
            // nameTest
            // 
            this.nameTest.Location = new System.Drawing.Point(119, 19);
            this.nameTest.Name = "nameTest";
            this.nameTest.Size = new System.Drawing.Size(100, 20);
            this.nameTest.TabIndex = 2;
            // 
            // descTest
            // 
            this.descTest.Location = new System.Drawing.Point(119, 52);
            this.descTest.Name = "descTest";
            this.descTest.Size = new System.Drawing.Size(100, 20);
            this.descTest.TabIndex = 3;
            // 
            // saveTest
            // 
            this.saveTest.Location = new System.Drawing.Point(97, 196);
            this.saveTest.Name = "saveTest";
            this.saveTest.Size = new System.Drawing.Size(75, 23);
            this.saveTest.TabIndex = 4;
            this.saveTest.Text = "Зберегти";
            this.saveTest.UseVisualStyleBackColor = true;
            this.saveTest.Click += new System.EventHandler(this.saveTest_Click);
            // 
            // CreateTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 319);
            this.Controls.Add(this.saveTest);
            this.Controls.Add(this.descTest);
            this.Controls.Add(this.nameTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateTestForm";
            this.Text = "CreateTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTest;
        private System.Windows.Forms.TextBox descTest;
        private System.Windows.Forms.Button saveTest;
    }
}