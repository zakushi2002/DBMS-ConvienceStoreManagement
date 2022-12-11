namespace ConvienceStore
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.forgotButton = new System.Windows.Forms.Button();
            this.newaccountButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioEmployeeButton = new System.Windows.Forms.RadioButton();
            this.radioManagerButton = new System.Windows.Forms.RadioButton();
            this.passIcon = new System.Windows.Forms.PictureBox();
            this.userIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(179, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 60);
            this.label1.TabIndex = 16;
            this.label1.Text = "LOGIN";
            // 
            // forgotButton
            // 
            this.forgotButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.forgotButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotButton.ForeColor = System.Drawing.Color.Silver;
            this.forgotButton.Location = new System.Drawing.Point(102, 393);
            this.forgotButton.Name = "forgotButton";
            this.forgotButton.Size = new System.Drawing.Size(303, 45);
            this.forgotButton.TabIndex = 14;
            this.forgotButton.Text = "Forgot Password";
            this.forgotButton.UseVisualStyleBackColor = false;
            // 
            // newaccountButton
            // 
            this.newaccountButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newaccountButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newaccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.newaccountButton.Location = new System.Drawing.Point(102, 342);
            this.newaccountButton.Name = "newaccountButton";
            this.newaccountButton.Size = new System.Drawing.Size(303, 45);
            this.newaccountButton.TabIndex = 13;
            this.newaccountButton.Text = "Create New Account";
            this.newaccountButton.UseVisualStyleBackColor = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.loginButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(103, 291);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(303, 45);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(103, 144);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(302, 35);
            this.txtUsername.TabIndex = 10;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(104, 213);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(302, 35);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // radioEmployeeButton
            // 
            this.radioEmployeeButton.AutoSize = true;
            this.radioEmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.radioEmployeeButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEmployeeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioEmployeeButton.Location = new System.Drawing.Point(276, 259);
            this.radioEmployeeButton.Name = "radioEmployeeButton";
            this.radioEmployeeButton.Size = new System.Drawing.Size(87, 23);
            this.radioEmployeeButton.TabIndex = 20;
            this.radioEmployeeButton.TabStop = true;
            this.radioEmployeeButton.Text = "Employee";
            this.radioEmployeeButton.UseVisualStyleBackColor = false;
            // 
            // radioManagerButton
            // 
            this.radioManagerButton.AutoSize = true;
            this.radioManagerButton.BackColor = System.Drawing.Color.Transparent;
            this.radioManagerButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioManagerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioManagerButton.Location = new System.Drawing.Point(103, 259);
            this.radioManagerButton.Name = "radioManagerButton";
            this.radioManagerButton.Size = new System.Drawing.Size(82, 23);
            this.radioManagerButton.TabIndex = 19;
            this.radioManagerButton.TabStop = true;
            this.radioManagerButton.Text = "Manager";
            this.radioManagerButton.UseVisualStyleBackColor = false;
            // 
            // passIcon
            // 
            this.passIcon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passIcon.Enabled = false;
            this.passIcon.Location = new System.Drawing.Point(103, 213);
            this.passIcon.Name = "passIcon";
            this.passIcon.Size = new System.Drawing.Size(42, 25);
            this.passIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passIcon.TabIndex = 17;
            this.passIcon.TabStop = false;
            // 
            // userIcon
            // 
            this.userIcon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userIcon.Enabled = false;
            this.userIcon.Location = new System.Drawing.Point(103, 144);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(42, 25);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIcon.TabIndex = 15;
            this.userIcon.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forgotButton);
            this.Controls.Add(this.newaccountButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passIcon);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.radioEmployeeButton);
            this.Controls.Add(this.radioManagerButton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button forgotButton;
        private System.Windows.Forms.Button newaccountButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox passIcon;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.RadioButton radioEmployeeButton;
        public System.Windows.Forms.RadioButton radioManagerButton;
    }
}