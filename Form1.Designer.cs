namespace Jawly_Design4
{
    partial class Form1
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
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.panel_Header_R = new System.Windows.Forms.Panel();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.panel_Header_L = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_Blob_R = new System.Windows.Forms.PictureBox();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.pictureBox_Blob_L = new System.Windows.Forms.PictureBox();
            this.panel_Header.SuspendLayout();
            this.panel_Header_R.SuspendLayout();
            this.panel_Header_L.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Blob_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Blob_L)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.AutoScroll = true;
            this.panel_Main.BackColor = System.Drawing.Color.White;
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 81);
            this.panel_Main.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(610, 327);
            this.panel_Main.TabIndex = 3;
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.White;
            this.panel_Header.Controls.Add(this.panel_Header_R);
            this.panel_Header.Controls.Add(this.panel_Header_L);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(610, 81);
            this.panel_Header.TabIndex = 2;
            // 
            // panel_Header_R
            // 
            this.panel_Header_R.Controls.Add(this.label_Date);
            this.panel_Header_R.Controls.Add(this.label_Username);
            this.panel_Header_R.Controls.Add(this.pictureBox_Blob_R);
            this.panel_Header_R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Header_R.Location = new System.Drawing.Point(199, 0);
            this.panel_Header_R.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Header_R.Name = "panel_Header_R";
            this.panel_Header_R.Size = new System.Drawing.Size(411, 81);
            this.panel_Header_R.TabIndex = 1;
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.BackColor = System.Drawing.Color.Transparent;
            this.label_Date.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(173, 28);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(56, 21);
            this.label_Date.TabIndex = 1;
            this.label_Date.Text = "(date)";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.BackColor = System.Drawing.Color.Transparent;
            this.label_Username.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(271, 52);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(50, 19);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "ui user";
            // 
            // panel_Header_L
            // 
            this.panel_Header_L.Controls.Add(this.pictureBox_Logo);
            this.panel_Header_L.Controls.Add(this.pictureBox_Blob_L);
            this.panel_Header_L.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Header_L.Location = new System.Drawing.Point(0, 0);
            this.panel_Header_L.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Header_L.Name = "panel_Header_L";
            this.panel_Header_L.Size = new System.Drawing.Size(199, 81);
            this.panel_Header_L.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox_Blob_R
            // 
            this.pictureBox_Blob_R.Image = global::Jawly_Design4.Properties.Resources.blob_R;
            this.pictureBox_Blob_R.Location = new System.Drawing.Point(83, 0);
            this.pictureBox_Blob_R.Name = "pictureBox_Blob_R";
            this.pictureBox_Blob_R.Size = new System.Drawing.Size(328, 81);
            this.pictureBox_Blob_R.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Blob_R.TabIndex = 2;
            this.pictureBox_Blob_R.TabStop = false;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = global::Jawly_Design4.Properties.Resources.jawly_logo;
            this.pictureBox_Logo.Location = new System.Drawing.Point(9, 6);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(158, 80);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logo.TabIndex = 1;
            this.pictureBox_Logo.TabStop = false;
            this.pictureBox_Logo.Click += new System.EventHandler(this.pictureBox_Logo_Click);
            this.pictureBox_Logo.MouseEnter += new System.EventHandler(this.pictureBox_Logo_MouseEnter);
            this.pictureBox_Logo.MouseLeave += new System.EventHandler(this.pictureBox_Logo_MouseLeave);
            // 
            // pictureBox_Blob_L
            // 
            this.pictureBox_Blob_L.Image = global::Jawly_Design4.Properties.Resources.blob_L;
            this.pictureBox_Blob_L.Location = new System.Drawing.Point(-8, -3);
            this.pictureBox_Blob_L.Name = "pictureBox_Blob_L";
            this.pictureBox_Blob_L.Size = new System.Drawing.Size(191, 84);
            this.pictureBox_Blob_L.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Blob_L.TabIndex = 0;
            this.pictureBox_Blob_L.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 408);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Header);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Jawly Express";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header_R.ResumeLayout(false);
            this.panel_Header_R.PerformLayout();
            this.panel_Header_L.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Blob_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Blob_L)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Panel panel_Header_R;
        private System.Windows.Forms.Panel panel_Header_L;
        public System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.PictureBox pictureBox_Blob_L;
        private System.Windows.Forms.PictureBox pictureBox_Blob_R;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
    }
}

