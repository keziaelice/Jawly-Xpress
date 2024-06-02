namespace Jawly_Design4
{
    partial class Form_EditAccount
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
            this.label11 = new System.Windows.Forms.Label();
            this.panel_Line_Sender = new System.Windows.Forms.Panel();
            this.pictureBox_pass = new System.Windows.Forms.PictureBox();
            this.label_passx = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Yourname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.button_EditAcc = new System.Windows.Forms.Button();
            this.textBox2_OLDPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_phonenumberx = new System.Windows.Forms.Label();
            this.label_usernamex = new System.Windows.Forms.Label();
            this.button_EDITPASS = new System.Windows.Forms.Button();
            this.pictureBox_passy = new System.Windows.Forms.PictureBox();
            this.label_passy = new System.Windows.Forms.Label();
            this.textBox_NEWPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_DeleteAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_passy)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 25);
            this.label11.TabIndex = 43;
            this.label11.Text = "Edit Account";
            // 
            // panel_Line_Sender
            // 
            this.panel_Line_Sender.BackColor = System.Drawing.Color.LightCoral;
            this.panel_Line_Sender.Location = new System.Drawing.Point(28, 56);
            this.panel_Line_Sender.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Line_Sender.Name = "panel_Line_Sender";
            this.panel_Line_Sender.Size = new System.Drawing.Size(563, 2);
            this.panel_Line_Sender.TabIndex = 153;
            // 
            // pictureBox_pass
            // 
            this.pictureBox_pass.Image = global::Jawly_Design4.Properties.Resources.Untitled_design__2_;
            this.pictureBox_pass.Location = new System.Drawing.Point(306, 270);
            this.pictureBox_pass.Name = "pictureBox_pass";
            this.pictureBox_pass.Size = new System.Drawing.Size(22, 23);
            this.pictureBox_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pass.TabIndex = 168;
            this.pictureBox_pass.TabStop = false;
            this.pictureBox_pass.Click += new System.EventHandler(this.pictureBox_passoff_Click);
            // 
            // label_passx
            // 
            this.label_passx.AutoSize = true;
            this.label_passx.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_passx.ForeColor = System.Drawing.Color.Red;
            this.label_passx.Location = new System.Drawing.Point(25, 295);
            this.label_passx.Name = "label_passx";
            this.label_passx.Size = new System.Drawing.Size(211, 13);
            this.label_passx.TabIndex = 165;
            this.label_passx.Text = "* Password must be minimal 8 characters!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 162;
            this.label4.Text = "Your Name";
            // 
            // textBox_Yourname
            // 
            this.textBox_Yourname.Location = new System.Drawing.Point(28, 150);
            this.textBox_Yourname.Multiline = true;
            this.textBox_Yourname.Name = "textBox_Yourname";
            this.textBox_Yourname.Size = new System.Drawing.Size(227, 29);
            this.textBox_Yourname.TabIndex = 161;
            this.textBox_Yourname.TextChanged += new System.EventHandler(this.textBox_Yourname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 160;
            this.label3.Text = "Phone Number";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(28, 82);
            this.textBox_Phone.MaxLength = 15;
            this.textBox_Phone.Multiline = true;
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(227, 29);
            this.textBox_Phone.TabIndex = 159;
            this.textBox_Phone.TextChanged += new System.EventHandler(this.textBox_Phone_TextChanged);
            this.textBox_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Phone_KeyPress);
            // 
            // button_EditAcc
            // 
            this.button_EditAcc.BackColor = System.Drawing.Color.LightCoral;
            this.button_EditAcc.Enabled = false;
            this.button_EditAcc.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EditAcc.ForeColor = System.Drawing.Color.Maroon;
            this.button_EditAcc.Location = new System.Drawing.Point(28, 197);
            this.button_EditAcc.Name = "button_EditAcc";
            this.button_EditAcc.Size = new System.Drawing.Size(542, 43);
            this.button_EditAcc.TabIndex = 158;
            this.button_EditAcc.Text = "EDIT ACCOUNT";
            this.button_EditAcc.UseVisualStyleBackColor = false;
            this.button_EditAcc.Click += new System.EventHandler(this.button_EditAcc_Click);
            // 
            // textBox2_OLDPassword
            // 
            this.textBox2_OLDPassword.Location = new System.Drawing.Point(28, 272);
            this.textBox2_OLDPassword.Name = "textBox2_OLDPassword";
            this.textBox2_OLDPassword.Size = new System.Drawing.Size(274, 20);
            this.textBox2_OLDPassword.TabIndex = 157;
            this.textBox2_OLDPassword.UseSystemPasswordChar = true;
            this.textBox2_OLDPassword.TextChanged += new System.EventHandler(this.textBox2_PasswordSignIn_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 156;
            this.label2.Text = "Old Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 155;
            this.label1.Text = "Username";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(270, 82);
            this.textBox_Username.Multiline = true;
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(274, 29);
            this.textBox_Username.TabIndex = 154;
            this.textBox_Username.TextChanged += new System.EventHandler(this.textBox_Username_TextChanged);
            // 
            // label_phonenumberx
            // 
            this.label_phonenumberx.AutoSize = true;
            this.label_phonenumberx.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phonenumberx.ForeColor = System.Drawing.Color.Red;
            this.label_phonenumberx.Location = new System.Drawing.Point(25, 114);
            this.label_phonenumberx.Name = "label_phonenumberx";
            this.label_phonenumberx.Size = new System.Drawing.Size(163, 13);
            this.label_phonenumberx.TabIndex = 170;
            this.label_phonenumberx.Text = "* Phone Number has been used!";
            this.label_phonenumberx.Visible = false;
            // 
            // label_usernamex
            // 
            this.label_usernamex.AutoSize = true;
            this.label_usernamex.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usernamex.ForeColor = System.Drawing.Color.Red;
            this.label_usernamex.Location = new System.Drawing.Point(267, 114);
            this.label_usernamex.Name = "label_usernamex";
            this.label_usernamex.Size = new System.Drawing.Size(141, 13);
            this.label_usernamex.TabIndex = 169;
            this.label_usernamex.Text = "* Username has been used!";
            this.label_usernamex.Visible = false;
            // 
            // button_EDITPASS
            // 
            this.button_EDITPASS.BackColor = System.Drawing.Color.LightCoral;
            this.button_EDITPASS.Enabled = false;
            this.button_EDITPASS.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EDITPASS.ForeColor = System.Drawing.Color.Maroon;
            this.button_EDITPASS.Location = new System.Drawing.Point(28, 387);
            this.button_EDITPASS.Name = "button_EDITPASS";
            this.button_EDITPASS.Size = new System.Drawing.Size(542, 43);
            this.button_EDITPASS.TabIndex = 171;
            this.button_EDITPASS.Text = "EDIT PASSWORD";
            this.button_EDITPASS.UseVisualStyleBackColor = false;
            this.button_EDITPASS.Click += new System.EventHandler(this.button_EDITPASS_Click);
            // 
            // pictureBox_passy
            // 
            this.pictureBox_passy.Image = global::Jawly_Design4.Properties.Resources.Untitled_design__2_;
            this.pictureBox_passy.Location = new System.Drawing.Point(306, 338);
            this.pictureBox_passy.Name = "pictureBox_passy";
            this.pictureBox_passy.Size = new System.Drawing.Size(22, 23);
            this.pictureBox_passy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_passy.TabIndex = 175;
            this.pictureBox_passy.TabStop = false;
            this.pictureBox_passy.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_passy
            // 
            this.label_passy.AutoSize = true;
            this.label_passy.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_passy.ForeColor = System.Drawing.Color.Red;
            this.label_passy.Location = new System.Drawing.Point(25, 361);
            this.label_passy.Name = "label_passy";
            this.label_passy.Size = new System.Drawing.Size(211, 13);
            this.label_passy.TabIndex = 174;
            this.label_passy.Text = "* Password must be minimal 8 characters!";
            // 
            // textBox_NEWPass
            // 
            this.textBox_NEWPass.Location = new System.Drawing.Point(28, 338);
            this.textBox_NEWPass.Name = "textBox_NEWPass";
            this.textBox_NEWPass.Size = new System.Drawing.Size(274, 20);
            this.textBox_NEWPass.TabIndex = 173;
            this.textBox_NEWPass.UseSystemPasswordChar = true;
            this.textBox_NEWPass.TextChanged += new System.EventHandler(this.textBox_NEWPass_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 172;
            this.label6.Text = "New Password";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 54);
            this.panel1.TabIndex = 176;
            // 
            // button_DeleteAccount
            // 
            this.button_DeleteAccount.BackColor = System.Drawing.Color.Firebrick;
            this.button_DeleteAccount.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteAccount.ForeColor = System.Drawing.Color.White;
            this.button_DeleteAccount.Location = new System.Drawing.Point(456, 23);
            this.button_DeleteAccount.Name = "button_DeleteAccount";
            this.button_DeleteAccount.Size = new System.Drawing.Size(135, 29);
            this.button_DeleteAccount.TabIndex = 177;
            this.button_DeleteAccount.Text = "DELETE ACCOUNT";
            this.button_DeleteAccount.UseVisualStyleBackColor = false;
            this.button_DeleteAccount.Click += new System.EventHandler(this.button_DeleteAccount_Click);
            // 
            // Form_EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(613, 274);
            this.Controls.Add(this.button_DeleteAccount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_passy);
            this.Controls.Add(this.label_passy);
            this.Controls.Add(this.textBox_NEWPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_EDITPASS);
            this.Controls.Add(this.label_phonenumberx);
            this.Controls.Add(this.label_usernamex);
            this.Controls.Add(this.pictureBox_pass);
            this.Controls.Add(this.label_passx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Yourname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.button_EditAcc);
            this.Controls.Add(this.textBox2_OLDPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.panel_Line_Sender);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_EditAccount";
            this.Text = "Form_EditAccount";
            this.Load += new System.EventHandler(this.Form_EditAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_passy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel_Line_Sender;
        private System.Windows.Forms.PictureBox pictureBox_pass;
        private System.Windows.Forms.Label label_passx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Yourname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Button button_EditAcc;
        private System.Windows.Forms.TextBox textBox2_OLDPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_phonenumberx;
        private System.Windows.Forms.Label label_usernamex;
        private System.Windows.Forms.Button button_EDITPASS;
        private System.Windows.Forms.PictureBox pictureBox_passy;
        private System.Windows.Forms.Label label_passy;
        private System.Windows.Forms.TextBox textBox_NEWPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_DeleteAccount;
    }
}