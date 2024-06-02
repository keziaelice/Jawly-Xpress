namespace Jawly_Design4
{
    partial class Form_EditAddress
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
            this.pictureBox_Back = new System.Windows.Forms.PictureBox();
            this.panel_Back = new System.Windows.Forms.Panel();
            this.label_EditAddress = new System.Windows.Forms.Label();
            this.textBox_PostCode = new System.Windows.Forms.TextBox();
            this.label_PostCode = new System.Windows.Forms.Label();
            this.label_AddressDetail = new System.Windows.Forms.Label();
            this.label_City = new System.Windows.Forms.Label();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.textBox_Phonenum = new System.Windows.Forms.TextBox();
            this.label_Province = new System.Windows.Forms.Label();
            this.label_Phonenum = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.comboBox_Province = new System.Windows.Forms.ComboBox();
            this.textBox_AddressDetail = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_Sender_Subdistrict = new System.Windows.Forms.TextBox();
            this.label_Sender_Subdistrict = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).BeginInit();
            this.panel_Back.SuspendLayout();
            this.SuspendLayout();
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
            // panel_Back
            // 
            this.panel_Back.Controls.Add(this.pictureBox_Back);
            this.panel_Back.Controls.Add(this.label_EditAddress);
            this.panel_Back.Location = new System.Drawing.Point(8, 8);
            this.panel_Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_Back.Name = "panel_Back";
            this.panel_Back.Size = new System.Drawing.Size(169, 29);
            this.panel_Back.TabIndex = 144;
            // 
            // label_EditAddress
            // 
            this.label_EditAddress.AutoSize = true;
            this.label_EditAddress.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EditAddress.Location = new System.Drawing.Point(27, 2);
            this.label_EditAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_EditAddress.Name = "label_EditAddress";
            this.label_EditAddress.Size = new System.Drawing.Size(121, 21);
            this.label_EditAddress.TabIndex = 142;
            this.label_EditAddress.Text = "EDIT ADDRESS";
            this.label_EditAddress.Click += new System.EventHandler(this.back_Click);
            this.label_EditAddress.MouseEnter += new System.EventHandler(this.back_MouseEnter);
            this.label_EditAddress.MouseLeave += new System.EventHandler(this.back_MouseLeave);
            // 
            // textBox_PostCode
            // 
            this.textBox_PostCode.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PostCode.Location = new System.Drawing.Point(305, 230);
            this.textBox_PostCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_PostCode.MaxLength = 5;
            this.textBox_PostCode.Name = "textBox_PostCode";
            this.textBox_PostCode.Size = new System.Drawing.Size(263, 26);
            this.textBox_PostCode.TabIndex = 233;
            // 
            // label_PostCode
            // 
            this.label_PostCode.AutoSize = true;
            this.label_PostCode.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PostCode.Location = new System.Drawing.Point(301, 209);
            this.label_PostCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_PostCode.Name = "label_PostCode";
            this.label_PostCode.Size = new System.Drawing.Size(72, 19);
            this.label_PostCode.TabIndex = 226;
            this.label_PostCode.Text = "Post Code";
            // 
            // label_AddressDetail
            // 
            this.label_AddressDetail.AutoSize = true;
            this.label_AddressDetail.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddressDetail.Location = new System.Drawing.Point(301, 99);
            this.label_AddressDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_AddressDetail.Name = "label_AddressDetail";
            this.label_AddressDetail.Size = new System.Drawing.Size(97, 19);
            this.label_AddressDetail.TabIndex = 225;
            this.label_AddressDetail.Text = "Address Detail";
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_City.Location = new System.Drawing.Point(16, 209);
            this.label_City.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(33, 19);
            this.label_City.TabIndex = 224;
            this.label_City.Text = "City";
            // 
            // comboBox_City
            // 
            this.comboBox_City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_City.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Location = new System.Drawing.Point(19, 229);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(263, 25);
            this.comboBox_City.TabIndex = 223;
            // 
            // textBox_Phonenum
            // 
            this.textBox_Phonenum.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Phonenum.Location = new System.Drawing.Point(19, 119);
            this.textBox_Phonenum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Phonenum.MaxLength = 15;
            this.textBox_Phonenum.Name = "textBox_Phonenum";
            this.textBox_Phonenum.Size = new System.Drawing.Size(263, 26);
            this.textBox_Phonenum.TabIndex = 222;
            // 
            // label_Province
            // 
            this.label_Province.AutoSize = true;
            this.label_Province.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Province.Location = new System.Drawing.Point(16, 154);
            this.label_Province.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Province.Name = "label_Province";
            this.label_Province.Size = new System.Drawing.Size(61, 19);
            this.label_Province.TabIndex = 221;
            this.label_Province.Text = "Province";
            // 
            // label_Phonenum
            // 
            this.label_Phonenum.AutoSize = true;
            this.label_Phonenum.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Phonenum.Location = new System.Drawing.Point(16, 99);
            this.label_Phonenum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Phonenum.Name = "label_Phonenum";
            this.label_Phonenum.Size = new System.Drawing.Size(102, 19);
            this.label_Phonenum.TabIndex = 218;
            this.label_Phonenum.Text = "Phone Number";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.Location = new System.Drawing.Point(19, 64);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(263, 26);
            this.textBox_Name.TabIndex = 217;
            // 
            // comboBox_Province
            // 
            this.comboBox_Province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Province.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Province.FormattingEnabled = true;
            this.comboBox_Province.Location = new System.Drawing.Point(19, 174);
            this.comboBox_Province.Name = "comboBox_Province";
            this.comboBox_Province.Size = new System.Drawing.Size(263, 25);
            this.comboBox_Province.TabIndex = 220;
            this.comboBox_Province.SelectedIndexChanged += new System.EventHandler(this.comboBox_Province_SelectedIndexChanged);
            // 
            // textBox_AddressDetail
            // 
            this.textBox_AddressDetail.AllowDrop = true;
            this.textBox_AddressDetail.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AddressDetail.Location = new System.Drawing.Point(305, 119);
            this.textBox_AddressDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_AddressDetail.MaxLength = 100;
            this.textBox_AddressDetail.Multiline = true;
            this.textBox_AddressDetail.Name = "textBox_AddressDetail";
            this.textBox_AddressDetail.Size = new System.Drawing.Size(263, 79);
            this.textBox_AddressDetail.TabIndex = 219;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(16, 44);
            this.label_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(45, 19);
            this.label_Name.TabIndex = 216;
            this.label_Name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(47, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 21);
            this.label1.TabIndex = 227;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(73, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 21);
            this.label3.TabIndex = 228;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(369, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 21);
            this.label4.TabIndex = 229;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(113, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 21);
            this.label5.TabIndex = 230;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepPink;
            this.label6.Location = new System.Drawing.Point(393, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 21);
            this.label6.TabIndex = 231;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepPink;
            this.label7.Location = new System.Drawing.Point(58, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 21);
            this.label7.TabIndex = 232;
            this.label7.Text = "*";
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(488, 270);
            this.button_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(80, 29);
            this.button_Save.TabIndex = 234;
            this.button_Save.Text = "SAVE";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_Sender_Subdistrict
            // 
            this.textBox_Sender_Subdistrict.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Sender_Subdistrict.Location = new System.Drawing.Point(304, 64);
            this.textBox_Sender_Subdistrict.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Sender_Subdistrict.MaxLength = 50;
            this.textBox_Sender_Subdistrict.Name = "textBox_Sender_Subdistrict";
            this.textBox_Sender_Subdistrict.Size = new System.Drawing.Size(263, 26);
            this.textBox_Sender_Subdistrict.TabIndex = 237;
            // 
            // label_Sender_Subdistrict
            // 
            this.label_Sender_Subdistrict.AutoSize = true;
            this.label_Sender_Subdistrict.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Sender_Subdistrict.Location = new System.Drawing.Point(301, 45);
            this.label_Sender_Subdistrict.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Sender_Subdistrict.Name = "label_Sender_Subdistrict";
            this.label_Sender_Subdistrict.Size = new System.Drawing.Size(73, 19);
            this.label_Sender_Subdistrict.TabIndex = 235;
            this.label_Sender_Subdistrict.Text = "Subdistrict";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DeepPink;
            this.label20.Location = new System.Drawing.Point(373, 43);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 21);
            this.label20.TabIndex = 236;
            this.label20.Text = "*";
            // 
            // Form_EditAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(613, 330);
            this.Controls.Add(this.textBox_Sender_Subdistrict);
            this.Controls.Add(this.label_Sender_Subdistrict);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_PostCode);
            this.Controls.Add(this.label_PostCode);
            this.Controls.Add(this.label_AddressDetail);
            this.Controls.Add(this.label_City);
            this.Controls.Add(this.comboBox_City);
            this.Controls.Add(this.textBox_Phonenum);
            this.Controls.Add(this.label_Province);
            this.Controls.Add(this.label_Phonenum);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.comboBox_Province);
            this.Controls.Add(this.textBox_AddressDetail);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel_Back);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_EditAddress";
            this.Text = "Form_EditAddress";
            this.Load += new System.EventHandler(this.Form_EditAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Back)).EndInit();
            this.panel_Back.ResumeLayout(false);
            this.panel_Back.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Back;
        private System.Windows.Forms.Panel panel_Back;
        private System.Windows.Forms.Label label_EditAddress;
        public System.Windows.Forms.TextBox textBox_PostCode;
        private System.Windows.Forms.Label label_PostCode;
        private System.Windows.Forms.Label label_AddressDetail;
        private System.Windows.Forms.Label label_City;
        public System.Windows.Forms.ComboBox comboBox_City;
        public System.Windows.Forms.TextBox textBox_Phonenum;
        private System.Windows.Forms.Label label_Province;
        private System.Windows.Forms.Label label_Phonenum;
        public System.Windows.Forms.TextBox textBox_Name;
        public System.Windows.Forms.ComboBox comboBox_Province;
        public System.Windows.Forms.TextBox textBox_AddressDetail;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Save;
        public System.Windows.Forms.TextBox textBox_Sender_Subdistrict;
        private System.Windows.Forms.Label label_Sender_Subdistrict;
        private System.Windows.Forms.Label label20;
    }
}