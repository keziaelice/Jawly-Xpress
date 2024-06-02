namespace Jawly_Design4
{
    partial class Form_SavedAddress_Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Line_Sender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 40);
            this.label11.TabIndex = 43;
            this.label11.Text = "Saved Address";
            // 
            // panel_Line_Sender
            // 
            this.panel_Line_Sender.BackColor = System.Drawing.Color.LightCoral;
            this.panel_Line_Sender.Controls.Add(this.panel1);
            this.panel_Line_Sender.Location = new System.Drawing.Point(38, 88);
            this.panel_Line_Sender.Name = "panel_Line_Sender";
            this.panel_Line_Sender.Size = new System.Drawing.Size(844, 3);
            this.panel_Line_Sender.TabIndex = 154;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 3);
            this.panel1.TabIndex = 154;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(133, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 102);
            this.label1.TabIndex = 155;
            this.label1.Text = "COMING SOON";
            // 
            // Form_SavedAddress_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(946, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Line_Sender);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_SavedAddress_Main";
            this.Text = "Form_SavedAddress_Main";
            this.Load += new System.EventHandler(this.Form_SavedAddress_Main_Load);
            this.panel_Line_Sender.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel_Line_Sender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}