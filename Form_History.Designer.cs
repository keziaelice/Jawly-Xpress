namespace Jawly_Design4
{
    partial class Form_History
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
            this.label_History = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_History
            // 
            this.label_History.AutoSize = true;
            this.label_History.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_History.Location = new System.Drawing.Point(23, 23);
            this.label_History.Name = "label_History";
            this.label_History.Size = new System.Drawing.Size(112, 38);
            this.label_History.TabIndex = 143;
            this.label_History.Text = "History";
            // 
            // Form_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(946, 508);
            this.Controls.Add(this.label_History);
            this.Name = "Form_History";
            this.Text = "Form_History";
            this.Load += new System.EventHandler(this.Form_History_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_History;
    }
}