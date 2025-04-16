namespace Kursova_ItCourses
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(125, 247);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(134, 21);
            this.cmbRole.TabIndex = 0;
            this.cmbRole.Text = "Виберіть категорію";
            // 
            // textUserName
            // 
            this.textUserName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textUserName.Location = new System.Drawing.Point(125, 128);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(134, 20);
            this.textUserName.TabIndex = 1;
            this.textUserName.Text = "Введіть ім\'я користувача";
            this.textUserName.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.textUserName.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // textPassword
            // 
            this.textPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textPassword.Location = new System.Drawing.Point(125, 163);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(134, 20);
            this.textPassword.TabIndex = 2;
            this.textPassword.Text = "Введіть пароль";
            this.textPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.textPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вас вітає програма для курсів IT-школи";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(81, 322);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(106, 35);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Увійти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(201, 322);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(106, 35);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Зареєструватися";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.Location = new System.Drawing.Point(0, 271);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(384, 38);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "---";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // textEmail
            // 
            this.textEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textEmail.Location = new System.Drawing.Point(125, 201);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(134, 20);
            this.textEmail.TabIndex = 7;
            this.textEmail.Text = "Введіть Email";
            this.textEmail.Enter += new System.EventHandler(this.textEmail_Enter);
            this.textEmail.Leave += new System.EventHandler(this.textEmail_Leave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.cmbRole);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Меню реєстрації/логіну";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textEmail;
    }
}