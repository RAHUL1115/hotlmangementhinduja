﻿namespace WindowsFormsApplication1
{
    partial class roomfilmenuewindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(roomfilmenuewindow));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.namelab = new System.Windows.Forms.Label();
            this.roomlab = new System.Windows.Forms.Label();
            this.rooml = new System.Windows.Forms.Label();
            this.namel = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.checkoutbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.servicesbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.canclebutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.services1 = new WindowsFormsApplication1.services();
            this.checkout1 = new WindowsFormsApplication1.checkout();
            this.canclewin1 = new WindowsFormsApplication1.canclewin();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // namelab
            // 
            this.namelab.AutoSize = true;
            this.namelab.Location = new System.Drawing.Point(71, 108);
            this.namelab.Name = "namelab";
            this.namelab.Size = new System.Drawing.Size(44, 13);
            this.namelab.TabIndex = 4;
            this.namelab.Text = "Name : ";
            // 
            // roomlab
            // 
            this.roomlab.AutoSize = true;
            this.roomlab.Location = new System.Drawing.Point(71, 79);
            this.roomlab.Name = "roomlab";
            this.roomlab.Size = new System.Drawing.Size(61, 13);
            this.roomlab.TabIndex = 5;
            this.roomlab.Text = "Room No : ";
            // 
            // rooml
            // 
            this.rooml.AutoSize = true;
            this.rooml.Location = new System.Drawing.Point(152, 79);
            this.rooml.Name = "rooml";
            this.rooml.Size = new System.Drawing.Size(61, 13);
            this.rooml.TabIndex = 7;
            this.rooml.Text = "Room No : ";
            // 
            // namel
            // 
            this.namel.AutoSize = true;
            this.namel.Location = new System.Drawing.Point(153, 108);
            this.namel.Name = "namel";
            this.namel.Size = new System.Drawing.Size(44, 13);
            this.namel.TabIndex = 6;
            this.namel.Text = "Name : ";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::WindowsFormsApplication1.Properties.Resources.back;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 28);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.roomfilmenuewindow_Deactivate);
            // 
            // checkoutbutton
            // 
            this.checkoutbutton.ActiveBorderThickness = 1;
            this.checkoutbutton.ActiveCornerRadius = 20;
            this.checkoutbutton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.checkoutbutton.ActiveForecolor = System.Drawing.Color.White;
            this.checkoutbutton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.checkoutbutton.BackColor = System.Drawing.SystemColors.Control;
            this.checkoutbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkoutbutton.BackgroundImage")));
            this.checkoutbutton.ButtonText = "chek out";
            this.checkoutbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.checkoutbutton.IdleBorderThickness = 1;
            this.checkoutbutton.IdleCornerRadius = 20;
            this.checkoutbutton.IdleFillColor = System.Drawing.Color.White;
            this.checkoutbutton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.checkoutbutton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.checkoutbutton.Location = new System.Drawing.Point(50, 266);
            this.checkoutbutton.Margin = new System.Windows.Forms.Padding(5);
            this.checkoutbutton.Name = "checkoutbutton";
            this.checkoutbutton.Size = new System.Drawing.Size(181, 41);
            this.checkoutbutton.TabIndex = 2;
            this.checkoutbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkoutbutton.Click += new System.EventHandler(this.checkoutbutton_Click);
            // 
            // servicesbutton
            // 
            this.servicesbutton.ActiveBorderThickness = 1;
            this.servicesbutton.ActiveCornerRadius = 20;
            this.servicesbutton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.servicesbutton.ActiveForecolor = System.Drawing.Color.White;
            this.servicesbutton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.servicesbutton.BackColor = System.Drawing.SystemColors.Control;
            this.servicesbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("servicesbutton.BackgroundImage")));
            this.servicesbutton.ButtonText = "services";
            this.servicesbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.servicesbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.servicesbutton.IdleBorderThickness = 1;
            this.servicesbutton.IdleCornerRadius = 20;
            this.servicesbutton.IdleFillColor = System.Drawing.Color.White;
            this.servicesbutton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.servicesbutton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.servicesbutton.Location = new System.Drawing.Point(50, 215);
            this.servicesbutton.Margin = new System.Windows.Forms.Padding(5);
            this.servicesbutton.Name = "servicesbutton";
            this.servicesbutton.Size = new System.Drawing.Size(181, 41);
            this.servicesbutton.TabIndex = 1;
            this.servicesbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.servicesbutton.Click += new System.EventHandler(this.servicesbutton_Click);
            // 
            // canclebutton
            // 
            this.canclebutton.ActiveBorderThickness = 1;
            this.canclebutton.ActiveCornerRadius = 20;
            this.canclebutton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.canclebutton.ActiveForecolor = System.Drawing.Color.White;
            this.canclebutton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.canclebutton.BackColor = System.Drawing.SystemColors.Control;
            this.canclebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("canclebutton.BackgroundImage")));
            this.canclebutton.ButtonText = "cancle";
            this.canclebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.canclebutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canclebutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.canclebutton.IdleBorderThickness = 1;
            this.canclebutton.IdleCornerRadius = 20;
            this.canclebutton.IdleFillColor = System.Drawing.Color.White;
            this.canclebutton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.canclebutton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.canclebutton.Location = new System.Drawing.Point(50, 164);
            this.canclebutton.Margin = new System.Windows.Forms.Padding(5);
            this.canclebutton.Name = "canclebutton";
            this.canclebutton.Size = new System.Drawing.Size(181, 41);
            this.canclebutton.TabIndex = 0;
            this.canclebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.canclebutton.Click += new System.EventHandler(this.cancle_click);
            // 
            // services1
            // 
            this.services1.Location = new System.Drawing.Point(0, -1);
            this.services1.Name = "services1";
            this.services1.Size = new System.Drawing.Size(272, 348);
            this.services1.TabIndex = 8;
            this.services1.Visible = false;
            // 
            // checkout1
            // 
            this.checkout1.Location = new System.Drawing.Point(-1, 0);
            this.checkout1.Name = "checkout1";
            this.checkout1.Size = new System.Drawing.Size(272, 348);
            this.checkout1.TabIndex = 9;
            this.checkout1.Visible = false;
            // 
            // canclewin1
            // 
            this.canclewin1.Location = new System.Drawing.Point(-1, -1);
            this.canclewin1.Name = "canclewin1";
            this.canclewin1.Size = new System.Drawing.Size(272, 348);
            this.canclewin1.TabIndex = 10;
            this.canclewin1.Visible = false;
            // 
            // roomfilmenuewindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(272, 348);
            this.Controls.Add(this.rooml);
            this.Controls.Add(this.namel);
            this.Controls.Add(this.roomlab);
            this.Controls.Add(this.namelab);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.checkoutbutton);
            this.Controls.Add(this.servicesbutton);
            this.Controls.Add(this.canclebutton);
            this.Controls.Add(this.services1);
            this.Controls.Add(this.checkout1);
            this.Controls.Add(this.canclewin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "roomfilmenuewindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "roomfilmenuewindow";
            this.Deactivate += new System.EventHandler(this.roomfilmenuewindow_Deactivate);
            this.Load += new System.EventHandler(this.roomfilmenuewindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuThinButton2 servicesbutton;
        public Bunifu.Framework.UI.BunifuThinButton2 canclebutton;
        public Bunifu.Framework.UI.BunifuThinButton2 checkoutbutton;
        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public System.Windows.Forms.Label roomlab;
        public System.Windows.Forms.Label namelab;
        public System.Windows.Forms.Label rooml;
        public System.Windows.Forms.Label namel;
        public services services1;
        public checkout checkout1;
        private canclewin canclewin1;
    }
}