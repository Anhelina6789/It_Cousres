namespace Kursova_ItCourses
{
    partial class EditProfile
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
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.textConfirmPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(96, 12);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(96, 81);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 1;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(96, 107);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(100, 20);
            this.textemail.TabIndex = 2;
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(96, 133);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(100, 20);
            this.textpassword.TabIndex = 3;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(168, 259);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(104, 37);
            this.save.TabIndex = 4;
            this.save.Text = "Зберегти зміни";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(12, 259);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(104, 36);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Скасувати";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(76, 217);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(136, 36);
            this.load.TabIndex = 6;
            this.load.Text = "Завантажити фото";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // textConfirmPass
            // 
            this.textConfirmPass.Location = new System.Drawing.Point(96, 160);
            this.textConfirmPass.Name = "textConfirmPass";
            this.textConfirmPass.Size = new System.Drawing.Size(100, 20);
            this.textConfirmPass.TabIndex = 7;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.textConfirmPass);
            this.Controls.Add(this.load);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.pictureBoxProfile);
            this.Name = "EditProfile";
            this.Text = "EditProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.TextBox textConfirmPass;
    }
}