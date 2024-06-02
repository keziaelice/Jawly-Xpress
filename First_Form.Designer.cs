namespace Jawly_Design4
{
    partial class First_Form
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
            this.panel_Login_Signin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Login_Signin
            // 
            this.panel_Login_Signin.AutoScroll = true;
            this.panel_Login_Signin.BackColor = System.Drawing.Color.Linen;
            this.panel_Login_Signin.Location = new System.Drawing.Point(115, 117);
            this.panel_Login_Signin.Name = "panel_Login_Signin";
            this.panel_Login_Signin.Size = new System.Drawing.Size(381, 281);
            this.panel_Login_Signin.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Jawly_Design4.Properties.Resources._625__500__4_;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 462);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // First_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 461);
            this.Controls.Add(this.panel_Login_Signin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "First_Form";
            this.Text = "First_Form";
            this.Load += new System.EventHandler(this.First_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Login_Signin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}