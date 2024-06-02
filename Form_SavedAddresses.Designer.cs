namespace Jawly_Design4
{
    partial class Form_SavedAddresses
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
            this.label_SelectAddress = new System.Windows.Forms.Label();
            this.panel_Back = new System.Windows.Forms.Panel();
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.panel_Back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SelectAddress
            // 
            this.label_SelectAddress.AutoSize = true;
            this.label_SelectAddress.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectAddress.Location = new System.Drawing.Point(27, 2);
            this.label_SelectAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SelectAddress.Name = "label_SelectAddress";
            this.label_SelectAddress.Size = new System.Drawing.Size(140, 21);
            this.label_SelectAddress.TabIndex = 142;
            this.label_SelectAddress.Text = "SELECT ADDRESS";
            this.label_SelectAddress.Click += new System.EventHandler(this.back_Click);
            this.label_SelectAddress.MouseEnter += new System.EventHandler(this.back_MouseEnter);
            this.label_SelectAddress.MouseLeave += new System.EventHandler(this.back_MouseLeave);
            // 
            // panel_Back
            // 
            this.panel_Back.Controls.Add(this.pictureBox_Back);
            this.panel_Back.Controls.Add(this.label_SelectAddress);
            this.panel_Back.Location = new System.Drawing.Point(8, 8);
            this.panel_Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Back.Name = "panel_Back";
            this.panel_Back.Size = new System.Drawing.Size(169, 29);
            this.panel_Back.TabIndex = 143;
            // 
            // pictureBox_Back
            // 
            this.pictureBox_Back.Image = global::Jawly_Design4.Properties.Resources.icon_back;
            this.pictureBox_Back.Location = new System.Drawing.Point(2, 3);
            this.pictureBox_Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_Back.Name = "pictureBox_Back";
            this.pictureBox_Back.Size = new System.Drawing.Size(30, 21);
            this.pictureBox_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Back.TabIndex = 143;
            this.pictureBox_Back.TabStop = false;
            this.pictureBox_Back.Click += new System.EventHandler(this.back_Click);
            this.pictureBox_Back.MouseEnter += new System.EventHandler(this.back_MouseEnter);
            this.pictureBox_Back.MouseLeave += new System.EventHandler(this.back_MouseLeave);
            // 
            // Form_SavedAddresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(613, 330);
            this.Controls.Add(this.panel_Back);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_SavedAddresses";
            this.Text = "Form_SavedAddresses";
            this.Load += new System.EventHandler(this.Form_SavedAddresses_Load);
            this.panel_Back.ResumeLayout(false);
            this.panel_Back.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_SelectAddress;
        private System.Windows.Forms.Panel panel_Back;
        private System.Windows.Forms.PictureBox pictureBox_Back;
    }
}