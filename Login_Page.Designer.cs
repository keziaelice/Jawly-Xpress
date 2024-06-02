namespace Jawly_Design4
{
    partial class Login_Page
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
            this.label_LoginFailed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_signup = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.textBox2_PasswordLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_UsernameLogin = new System.Windows.Forms.TextBox();
            this.pictureBox_passon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_passon)).BeginInit();
            this.SuspendLayout();
            // 
            // label_LoginFailed
            // 
            this.label_LoginFailed.AutoSize = true;
            this.label_LoginFailed.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LoginFailed.ForeColor = System.Drawing.Color.Red;
            this.label_LoginFailed.Location = new System.Drawing.Point(5, 39);
            this.label_LoginFailed.Name = "label_LoginFailed";
            this.label_LoginFailed.Size = new System.Drawing.Size(355, 13);
            this.label_LoginFailed.TabIndex = 37;
            this.label_LoginFailed.Text = "*Log In Failed! Phone Number / Username or Password might be wrong!";
            this.label_LoginFailed.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 35;
            this.label5.Text = "Log In";
            // 
            // label_signup
            // 
            this.label_signup.AutoSize = true;
            this.label_signup.Font = new System.Drawing.Font("Ebrima", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signup.Location = new System.Drawing.Point(195, 214);
            this.label_signup.Name = "label_signup";
            this.label_signup.Size = new System.Drawing.Size(45, 13);
            this.label_signup.TabIndex = 34;
            this.label_signup.Text = "Sign Up";
            this.label_signup.Click += new System.EventHandler(this.label_signup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "New to Jawly?";
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.LightCoral;
            this.button_Login.Enabled = false;
            this.button_Login.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.ForeColor = System.Drawing.Color.DarkRed;
            this.button_Login.Location = new System.Drawing.Point(18, 165);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(330, 43);
            this.button_Login.TabIndex = 32;
            this.button_Login.Text = "LOG IN";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // textBox2_PasswordLogin
            // 
            this.textBox2_PasswordLogin.Location = new System.Drawing.Point(18, 129);
            this.textBox2_PasswordLogin.Name = "textBox2_PasswordLogin";
            this.textBox2_PasswordLogin.Size = new System.Drawing.Size(302, 20);
            this.textBox2_PasswordLogin.TabIndex = 31;
            this.textBox2_PasswordLogin.UseSystemPasswordChar = true;
            this.textBox2_PasswordLogin.TextChanged += new System.EventHandler(this.textBox2_PasswordLogin_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Phone Number / Username";
            // 
            // textBox_UsernameLogin
            // 
            this.textBox_UsernameLogin.Location = new System.Drawing.Point(18, 76);
            this.textBox_UsernameLogin.Multiline = true;
            this.textBox_UsernameLogin.Name = "textBox_UsernameLogin";
            this.textBox_UsernameLogin.Size = new System.Drawing.Size(330, 29);
            this.textBox_UsernameLogin.TabIndex = 28;
            this.textBox_UsernameLogin.TextChanged += new System.EventHandler(this.textBox_UsernameLogin_TextChanged);
            // 
            // pictureBox_passon
            // 
            this.pictureBox_passon.Image = global::Jawly_Design4.Properties.Resources.Untitled_design__2_;
            this.pictureBox_passon.Location = new System.Drawing.Point(325, 127);
            this.pictureBox_passon.Name = "pictureBox_passon";
            this.pictureBox_passon.Size = new System.Drawing.Size(22, 23);
            this.pictureBox_passon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_passon.TabIndex = 36;
            this.pictureBox_passon.TabStop = false;
            this.pictureBox_passon.Click += new System.EventHandler(this.pictureBox_passon_Click);
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(365, 242);
            this.Controls.Add(this.label_LoginFailed);
            this.Controls.Add(this.pictureBox_passon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_signup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox2_PasswordLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_UsernameLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login_Page";
            this.Text = "Login_Page";
            this.Load += new System.EventHandler(this.Login_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_passon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_LoginFailed;
        private System.Windows.Forms.PictureBox pictureBox_passon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_signup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.TextBox textBox2_PasswordLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_UsernameLogin;
    }
}