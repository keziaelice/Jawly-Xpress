namespace Jawly_Design4
{
    partial class Form_Tracking
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
            this.textBox_cekresi = new System.Windows.Forms.TextBox();
            this.label110 = new System.Windows.Forms.Label();
            this.panel_Line_Sender = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.button_CheckRate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Line_Sender.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_cekresi
            // 
            this.textBox_cekresi.Location = new System.Drawing.Point(43, 173);
            this.textBox_cekresi.Multiline = true;
            this.textBox_cekresi.Name = "textBox_cekresi";
            this.textBox_cekresi.Size = new System.Drawing.Size(329, 42);
            this.textBox_cekresi.TabIndex = 0;
            this.textBox_cekresi.TextChanged += new System.EventHandler(this.textBox_cekresi_TextChanged);
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label110.Location = new System.Drawing.Point(36, 25);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(136, 40);
            this.label110.TabIndex = 43;
            this.label110.Text = "Tracking";
            // 
            // panel_Line_Sender
            // 
            this.panel_Line_Sender.Controls.Add(this.panel1);
            this.panel_Line_Sender.Location = new System.Drawing.Point(43, 77);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ebrima", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 30);
            this.label10.TabIndex = 155;
            this.label10.Text = "Waybill Number";
            // 
            // button_CheckRate
            // 
            this.button_CheckRate.BackColor = System.Drawing.Color.LightCoral;
            this.button_CheckRate.Enabled = false;
            this.button_CheckRate.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CheckRate.Location = new System.Drawing.Point(43, 234);
            this.button_CheckRate.Name = "button_CheckRate";
            this.button_CheckRate.Size = new System.Drawing.Size(329, 57);
            this.button_CheckRate.TabIndex = 156;
            this.button_CheckRate.Text = "Check";
            this.button_CheckRate.UseVisualStyleBackColor = false;
            this.button_CheckRate.Click += new System.EventHandler(this.button_CheckRate_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(403, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 357);
            this.panel2.TabIndex = 157;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "        ";
            // 
            // Form_Tracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(946, 483);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_CheckRate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel_Line_Sender);
            this.Controls.Add(this.label110);
            this.Controls.Add(this.textBox_cekresi);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Tracking";
            this.Text = "Form_Tracking";
            this.Load += new System.EventHandler(this.Form_Tracking_Load);
            this.panel_Line_Sender.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_cekresi;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Panel panel_Line_Sender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_CheckRate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}