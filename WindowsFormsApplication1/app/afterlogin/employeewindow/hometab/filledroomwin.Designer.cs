namespace WindowsFormsApplication1
{
    partial class filledroomwin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filledroomwin));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.servicesbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.checkoutbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.canclebutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.namelab = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.namel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.roomlab = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.canclewin1 = new WindowsFormsApplication1.canclewin();
            this.services1 = new WindowsFormsApplication1.services();
            this.checkout1 = new WindowsFormsApplication1.checkout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
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
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // servicesbutton
            // 
            this.servicesbutton.ActiveBorderThickness = 1;
            this.servicesbutton.ActiveCornerRadius = 20;
            this.servicesbutton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.servicesbutton.ActiveForecolor = System.Drawing.Color.Black;
            this.servicesbutton.ActiveLineColor = System.Drawing.Color.Black;
            this.servicesbutton.BackColor = System.Drawing.SystemColors.Control;
            this.servicesbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("servicesbutton.BackgroundImage")));
            this.servicesbutton.ButtonText = "Service";
            this.servicesbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.servicesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.servicesbutton.IdleBorderThickness = 1;
            this.servicesbutton.IdleCornerRadius = 20;
            this.servicesbutton.IdleFillColor = System.Drawing.Color.White;
            this.servicesbutton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.servicesbutton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.servicesbutton.Location = new System.Drawing.Point(14, 260);
            this.servicesbutton.Margin = new System.Windows.Forms.Padding(5);
            this.servicesbutton.Name = "servicesbutton";
            this.servicesbutton.Size = new System.Drawing.Size(125, 39);
            this.servicesbutton.TabIndex = 92;
            this.servicesbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.servicesbutton.Click += new System.EventHandler(this.servicebut_Click);
            // 
            // checkoutbutton
            // 
            this.checkoutbutton.ActiveBorderThickness = 1;
            this.checkoutbutton.ActiveCornerRadius = 20;
            this.checkoutbutton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.checkoutbutton.ActiveForecolor = System.Drawing.Color.Black;
            this.checkoutbutton.ActiveLineColor = System.Drawing.Color.Black;
            this.checkoutbutton.BackColor = System.Drawing.SystemColors.Control;
            this.checkoutbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkoutbutton.BackgroundImage")));
            this.checkoutbutton.ButtonText = "Check Out";
            this.checkoutbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.checkoutbutton.IdleBorderThickness = 1;
            this.checkoutbutton.IdleCornerRadius = 20;
            this.checkoutbutton.IdleFillColor = System.Drawing.Color.White;
            this.checkoutbutton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.checkoutbutton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.checkoutbutton.Location = new System.Drawing.Point(348, 260);
            this.checkoutbutton.Margin = new System.Windows.Forms.Padding(5);
            this.checkoutbutton.Name = "checkoutbutton";
            this.checkoutbutton.Size = new System.Drawing.Size(125, 39);
            this.checkoutbutton.TabIndex = 93;
            this.checkoutbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkoutbutton.Click += new System.EventHandler(this.coutbut_Click);
            // 
            // canclebutton
            // 
            this.canclebutton.ActiveBorderThickness = 1;
            this.canclebutton.ActiveCornerRadius = 20;
            this.canclebutton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.canclebutton.ActiveForecolor = System.Drawing.Color.Black;
            this.canclebutton.ActiveLineColor = System.Drawing.Color.Black;
            this.canclebutton.BackColor = System.Drawing.SystemColors.Control;
            this.canclebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("canclebutton.BackgroundImage")));
            this.canclebutton.ButtonText = "Cancle";
            this.canclebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.canclebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canclebutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.canclebutton.IdleBorderThickness = 1;
            this.canclebutton.IdleCornerRadius = 20;
            this.canclebutton.IdleFillColor = System.Drawing.Color.White;
            this.canclebutton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.canclebutton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.canclebutton.Location = new System.Drawing.Point(191, 260);
            this.canclebutton.Margin = new System.Windows.Forms.Padding(5);
            this.canclebutton.Name = "canclebutton";
            this.canclebutton.Size = new System.Drawing.Size(125, 39);
            this.canclebutton.TabIndex = 94;
            this.canclebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.canclebutton.Click += new System.EventHandler(this.canbut_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.namelab);
            this.bunifuCards1.Controls.Add(this.namel);
            this.bunifuCards1.Controls.Add(this.roomlab);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(14, 46);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(459, 161);
            this.bunifuCards1.TabIndex = 100;
            // 
            // namelab
            // 
            this.namelab.AutoSize = true;
            this.namelab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelab.Location = new System.Drawing.Point(59, 99);
            this.namelab.Name = "namelab";
            this.namelab.Size = new System.Drawing.Size(65, 20);
            this.namelab.TabIndex = 103;
            this.namelab.Text = "Name :";
            // 
            // namel
            // 
            this.namel.AutoSize = true;
            this.namel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namel.Location = new System.Drawing.Point(268, 99);
            this.namel.Name = "namel";
            this.namel.Size = new System.Drawing.Size(143, 18);
            this.namel.TabIndex = 102;
            this.namel.Text = "bunifuCustomLabel3";
            // 
            // roomlab
            // 
            this.roomlab.AutoSize = true;
            this.roomlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomlab.Location = new System.Drawing.Point(270, 52);
            this.roomlab.Name = "roomlab";
            this.roomlab.Size = new System.Drawing.Size(143, 18);
            this.roomlab.TabIndex = 101;
            this.roomlab.Text = "bunifuCustomLabel4";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(61, 50);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(93, 20);
            this.bunifuCustomLabel1.TabIndex = 100;
            this.bunifuCustomLabel1.Text = "Room No :";
            // 
            // canclewin1
            // 
            this.canclewin1.Location = new System.Drawing.Point(0, 0);
            this.canclewin1.Name = "canclewin1";
            this.canclewin1.Size = new System.Drawing.Size(487, 327);
            this.canclewin1.TabIndex = 101;
            this.canclewin1.Visible = false;
            // 
            // services1
            // 
            this.services1.Location = new System.Drawing.Point(0, 0);
            this.services1.Name = "services1";
            this.services1.Size = new System.Drawing.Size(487, 327);
            this.services1.TabIndex = 102;
            this.services1.Visible = false;
            // 
            // checkout1
            // 
            this.checkout1.Location = new System.Drawing.Point(0, 0);
            this.checkout1.Name = "checkout1";
            this.checkout1.Size = new System.Drawing.Size(487, 327);
            this.checkout1.TabIndex = 103;
            this.checkout1.Visible = false;
            // 
            // filledroomwin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 327);
            this.Controls.Add(this.canclebutton);
            this.Controls.Add(this.checkoutbutton);
            this.Controls.Add(this.servicesbutton);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.canclewin1);
            this.Controls.Add(this.services1);
            this.Controls.Add(this.checkout1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "filledroomwin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "filledroomwin";
            this.Deactivate += new System.EventHandler(this.filledroomwin_Deactivate);
            this.Load += new System.EventHandler(this.filledroomwin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public Bunifu.Framework.UI.BunifuThinButton2 servicesbutton;
        public Bunifu.Framework.UI.BunifuThinButton2 checkoutbutton;
        public Bunifu.Framework.UI.BunifuThinButton2 canclebutton;
        public Bunifu.Framework.UI.BunifuCards bunifuCards1;
        public Bunifu.Framework.UI.BunifuCustomLabel namelab;
        public Bunifu.Framework.UI.BunifuCustomLabel namel;
        public Bunifu.Framework.UI.BunifuCustomLabel roomlab;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public canclewin canclewin1;
        private services services1;
        private checkout checkout1;
    }
}