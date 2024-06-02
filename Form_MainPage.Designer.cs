namespace Jawly_Design4
{
    partial class Form_MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainPage));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_settings = new System.Windows.Forms.PictureBox();
            this.pictureBox_Address = new System.Windows.Forms.PictureBox();
            this.pictureBox_Voucher = new System.Windows.Forms.PictureBox();
            this.pictureBox_History = new System.Windows.Forms.PictureBox();
            this.pictureBox_Tracking = new System.Windows.Forms.PictureBox();
            this.pictureBox_ShippingRates = new System.Windows.Forms.PictureBox();
            this.pictureBox_OrderShipping = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Voucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Tracking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShippingRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OrderShipping)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAccountToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 68);
            // 
            // editAccountToolStripMenuItem
            // 
            this.editAccountToolStripMenuItem.Name = "editAccountToolStripMenuItem";
            this.editAccountToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
            this.editAccountToolStripMenuItem.Text = "Edit Account";
            this.editAccountToolStripMenuItem.Click += new System.EventHandler(this.editAccountToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // pictureBox_settings
            // 
            this.pictureBox_settings.Image = global::Jawly_Design4.Properties.Resources._625__500__10_;
            this.pictureBox_settings.Location = new System.Drawing.Point(816, 17);
            this.pictureBox_settings.Name = "pictureBox_settings";
            this.pictureBox_settings.Size = new System.Drawing.Size(60, 48);
            this.pictureBox_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_settings.TabIndex = 35;
            this.pictureBox_settings.TabStop = false;
            this.pictureBox_settings.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox_settings.MouseEnter += new System.EventHandler(this.pictureBox_settings_MouseEnter);
            this.pictureBox_settings.MouseLeave += new System.EventHandler(this.pictureBox_settings_MouseLeave);
            // 
            // pictureBox_Address
            // 
            this.pictureBox_Address.Image = global::Jawly_Design4.Properties.Resources.saddress;
            this.pictureBox_Address.Location = new System.Drawing.Point(610, 329);
            this.pictureBox_Address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_Address.Name = "pictureBox_Address";
            this.pictureBox_Address.Size = new System.Drawing.Size(238, 242);
            this.pictureBox_Address.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Address.TabIndex = 34;
            this.pictureBox_Address.TabStop = false;
            this.pictureBox_Address.Visible = false;
            this.pictureBox_Address.Click += new System.EventHandler(this.pictureBox_Address_Click);
            this.pictureBox_Address.MouseEnter += new System.EventHandler(this.pictureBox_Address_MouseEnter);
            this.pictureBox_Address.MouseLeave += new System.EventHandler(this.pictureBox_Address_MouseLeave);
            // 
            // pictureBox_Voucher
            // 
            this.pictureBox_Voucher.Image = global::Jawly_Design4.Properties.Resources.button_voucher;
            this.pictureBox_Voucher.Location = new System.Drawing.Point(321, 323);
            this.pictureBox_Voucher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_Voucher.Name = "pictureBox_Voucher";
            this.pictureBox_Voucher.Size = new System.Drawing.Size(249, 283);
            this.pictureBox_Voucher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Voucher.TabIndex = 33;
            this.pictureBox_Voucher.TabStop = false;
            this.pictureBox_Voucher.Click += new System.EventHandler(this.pictureBox_Voucher_Click);
            this.pictureBox_Voucher.MouseEnter += new System.EventHandler(this.pictureBox_Menu_MouseEnter);
            this.pictureBox_Voucher.MouseLeave += new System.EventHandler(this.pictureBox_Menu_MouseLeave);
            // 
            // pictureBox_History
            // 
            this.pictureBox_History.Image = global::Jawly_Design4.Properties.Resources.button_history;
            this.pictureBox_History.Location = new System.Drawing.Point(44, 323);
            this.pictureBox_History.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_History.Name = "pictureBox_History";
            this.pictureBox_History.Size = new System.Drawing.Size(249, 283);
            this.pictureBox_History.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_History.TabIndex = 32;
            this.pictureBox_History.TabStop = false;
            this.pictureBox_History.Click += new System.EventHandler(this.pictureBox_History_Click);
            this.pictureBox_History.MouseEnter += new System.EventHandler(this.pictureBox_Menu_MouseEnter);
            this.pictureBox_History.MouseLeave += new System.EventHandler(this.pictureBox_Menu_MouseLeave);
            // 
            // pictureBox_Tracking
            // 
            this.pictureBox_Tracking.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Tracking.Image")));
            this.pictureBox_Tracking.Location = new System.Drawing.Point(597, 18);
            this.pictureBox_Tracking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_Tracking.Name = "pictureBox_Tracking";
            this.pictureBox_Tracking.Size = new System.Drawing.Size(249, 283);
            this.pictureBox_Tracking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Tracking.TabIndex = 31;
            this.pictureBox_Tracking.TabStop = false;
            this.pictureBox_Tracking.Click += new System.EventHandler(this.pictureBox_Tracking_Click);
            this.pictureBox_Tracking.MouseEnter += new System.EventHandler(this.pictureBox_Menu_MouseEnter);
            this.pictureBox_Tracking.MouseLeave += new System.EventHandler(this.pictureBox_Menu_MouseLeave);
            // 
            // pictureBox_ShippingRates
            // 
            this.pictureBox_ShippingRates.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ShippingRates.Image")));
            this.pictureBox_ShippingRates.Location = new System.Drawing.Point(321, 18);
            this.pictureBox_ShippingRates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_ShippingRates.Name = "pictureBox_ShippingRates";
            this.pictureBox_ShippingRates.Size = new System.Drawing.Size(249, 283);
            this.pictureBox_ShippingRates.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ShippingRates.TabIndex = 30;
            this.pictureBox_ShippingRates.TabStop = false;
            this.pictureBox_ShippingRates.Click += new System.EventHandler(this.pictureBox_ShippingRates_Click);
            this.pictureBox_ShippingRates.MouseEnter += new System.EventHandler(this.pictureBox_Menu_MouseEnter);
            this.pictureBox_ShippingRates.MouseLeave += new System.EventHandler(this.pictureBox_Menu_MouseLeave);
            // 
            // pictureBox_OrderShipping
            // 
            this.pictureBox_OrderShipping.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_OrderShipping.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_OrderShipping.Image")));
            this.pictureBox_OrderShipping.Location = new System.Drawing.Point(44, 18);
            this.pictureBox_OrderShipping.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_OrderShipping.Name = "pictureBox_OrderShipping";
            this.pictureBox_OrderShipping.Size = new System.Drawing.Size(249, 283);
            this.pictureBox_OrderShipping.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_OrderShipping.TabIndex = 29;
            this.pictureBox_OrderShipping.TabStop = false;
            this.pictureBox_OrderShipping.Click += new System.EventHandler(this.pictureBox_OrderShipping_Click);
            this.pictureBox_OrderShipping.MouseEnter += new System.EventHandler(this.pictureBox_Menu_MouseEnter);
            this.pictureBox_OrderShipping.MouseLeave += new System.EventHandler(this.pictureBox_Menu_MouseLeave);
            // 
            // Form_MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1100, 508);
            this.Controls.Add(this.pictureBox_settings);
            this.Controls.Add(this.pictureBox_Address);
            this.Controls.Add(this.pictureBox_Voucher);
            this.Controls.Add(this.pictureBox_History);
            this.Controls.Add(this.pictureBox_Tracking);
            this.Controls.Add(this.pictureBox_ShippingRates);
            this.Controls.Add(this.pictureBox_OrderShipping);
            this.Name = "Form_MainPage";
            this.Text = "Form_MainPage";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Voucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Tracking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ShippingRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OrderShipping)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_OrderShipping;
        private System.Windows.Forms.PictureBox pictureBox_ShippingRates;
        private System.Windows.Forms.PictureBox pictureBox_Tracking;
        private System.Windows.Forms.PictureBox pictureBox_History;
        private System.Windows.Forms.PictureBox pictureBox_Voucher;
        private System.Windows.Forms.PictureBox pictureBox_Address;
        private System.Windows.Forms.PictureBox pictureBox_settings;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}