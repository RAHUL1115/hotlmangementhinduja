namespace WindowsFormsApplication1
{
    partial class mainwindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectedtabpannel = new System.Windows.Forms.Panel();
            this.Servicesbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cancleservice = new Bunifu.Framework.UI.BunifuFlatButton();
            this.homebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.findbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.hometab2 = new WindowsFormsApplication1.hometab();
            this.find2 = new WindowsFormsApplication1.find();
            this.checkout1 = new WindowsFormsApplication1.Checkout();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1317, 114);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1133, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "rahul";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hotel Management System";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = global::WindowsFormsApplication1.Properties.Resources.switchaccount;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1221, 15);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(36, 32);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::WindowsFormsApplication1.Properties.Resources.shutdown;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1265, 15);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(36, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 42);
            this.label2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.selectedtabpannel);
            this.panel2.Controls.Add(this.Servicesbutton);
            this.panel2.Controls.Add(this.cancleservice);
            this.panel2.Controls.Add(this.homebutton);
            this.panel2.Controls.Add(this.findbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(0, 114);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 674);
            this.panel2.TabIndex = 1;
            // 
            // selectedtabpannel
            // 
            this.selectedtabpannel.BackColor = System.Drawing.Color.Black;
            this.selectedtabpannel.Location = new System.Drawing.Point(0, 0);
            this.selectedtabpannel.Margin = new System.Windows.Forms.Padding(4);
            this.selectedtabpannel.Name = "selectedtabpannel";
            this.selectedtabpannel.Size = new System.Drawing.Size(13, 59);
            this.selectedtabpannel.TabIndex = 1;
            // 
            // Servicesbutton
            // 
            this.Servicesbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Servicesbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Servicesbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Servicesbutton.BorderRadius = 0;
            this.Servicesbutton.ButtonText = "Services";
            this.Servicesbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Servicesbutton.DisabledColor = System.Drawing.Color.Gray;
            this.Servicesbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Servicesbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.Servicesbutton.Iconimage = null;
            this.Servicesbutton.Iconimage_right = null;
            this.Servicesbutton.Iconimage_right_Selected = null;
            this.Servicesbutton.Iconimage_Selected = null;
            this.Servicesbutton.IconMarginLeft = 0;
            this.Servicesbutton.IconMarginRight = 0;
            this.Servicesbutton.IconRightVisible = true;
            this.Servicesbutton.IconRightZoom = 0D;
            this.Servicesbutton.IconVisible = true;
            this.Servicesbutton.IconZoom = 90D;
            this.Servicesbutton.IsTab = false;
            this.Servicesbutton.Location = new System.Drawing.Point(0, 118);
            this.Servicesbutton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Servicesbutton.Name = "Servicesbutton";
            this.Servicesbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Servicesbutton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Servicesbutton.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.Servicesbutton.selected = false;
            this.Servicesbutton.Size = new System.Drawing.Size(236, 59);
            this.Servicesbutton.TabIndex = 8;
            this.Servicesbutton.Text = "Services";
            this.Servicesbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Servicesbutton.Textcolor = System.Drawing.Color.Black;
            this.Servicesbutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Servicesbutton.Click += new System.EventHandler(this.tabbuttonclick);
            // 
            // cancleservice
            // 
            this.cancleservice.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancleservice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cancleservice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancleservice.BorderRadius = 0;
            this.cancleservice.ButtonText = "Cancle service";
            this.cancleservice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancleservice.DisabledColor = System.Drawing.Color.Gray;
            this.cancleservice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cancleservice.Iconcolor = System.Drawing.Color.Transparent;
            this.cancleservice.Iconimage = null;
            this.cancleservice.Iconimage_right = null;
            this.cancleservice.Iconimage_right_Selected = null;
            this.cancleservice.Iconimage_Selected = null;
            this.cancleservice.IconMarginLeft = 0;
            this.cancleservice.IconMarginRight = 0;
            this.cancleservice.IconRightVisible = true;
            this.cancleservice.IconRightZoom = 0D;
            this.cancleservice.IconVisible = true;
            this.cancleservice.IconZoom = 90D;
            this.cancleservice.IsTab = false;
            this.cancleservice.Location = new System.Drawing.Point(0, 177);
            this.cancleservice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cancleservice.Name = "cancleservice";
            this.cancleservice.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cancleservice.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cancleservice.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.cancleservice.selected = false;
            this.cancleservice.Size = new System.Drawing.Size(236, 59);
            this.cancleservice.TabIndex = 7;
            this.cancleservice.Text = "Cancle service";
            this.cancleservice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancleservice.Textcolor = System.Drawing.Color.Black;
            this.cancleservice.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancleservice.Click += new System.EventHandler(this.tabbuttonclick);
            // 
            // homebutton
            // 
            this.homebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.homebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homebutton.BorderRadius = 0;
            this.homebutton.ButtonText = "Home";
            this.homebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homebutton.DisabledColor = System.Drawing.Color.Gray;
            this.homebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.homebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.homebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.homebutton.Iconimage = null;
            this.homebutton.Iconimage_right = null;
            this.homebutton.Iconimage_right_Selected = null;
            this.homebutton.Iconimage_Selected = null;
            this.homebutton.IconMarginLeft = 0;
            this.homebutton.IconMarginRight = 0;
            this.homebutton.IconRightVisible = true;
            this.homebutton.IconRightZoom = 0D;
            this.homebutton.IconVisible = true;
            this.homebutton.IconZoom = 90D;
            this.homebutton.IsTab = false;
            this.homebutton.Location = new System.Drawing.Point(0, 0);
            this.homebutton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.homebutton.Name = "homebutton";
            this.homebutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.homebutton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.homebutton.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.homebutton.selected = false;
            this.homebutton.Size = new System.Drawing.Size(236, 59);
            this.homebutton.TabIndex = 4;
            this.homebutton.Text = "Home";
            this.homebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homebutton.Textcolor = System.Drawing.Color.Black;
            this.homebutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebutton.Click += new System.EventHandler(this.tabbuttonclick);
            // 
            // findbutton
            // 
            this.findbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.findbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.findbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.findbutton.BorderRadius = 0;
            this.findbutton.ButtonText = "Find";
            this.findbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findbutton.DisabledColor = System.Drawing.Color.Gray;
            this.findbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.findbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.findbutton.Iconimage = null;
            this.findbutton.Iconimage_right = null;
            this.findbutton.Iconimage_right_Selected = null;
            this.findbutton.Iconimage_Selected = null;
            this.findbutton.IconMarginLeft = 0;
            this.findbutton.IconMarginRight = 0;
            this.findbutton.IconRightVisible = true;
            this.findbutton.IconRightZoom = 0D;
            this.findbutton.IconVisible = true;
            this.findbutton.IconZoom = 90D;
            this.findbutton.IsTab = false;
            this.findbutton.Location = new System.Drawing.Point(0, 59);
            this.findbutton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.findbutton.Name = "findbutton";
            this.findbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.findbutton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.findbutton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.findbutton.selected = false;
            this.findbutton.Size = new System.Drawing.Size(236, 59);
            this.findbutton.TabIndex = 1;
            this.findbutton.Text = "Find";
            this.findbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.findbutton.Textcolor = System.Drawing.Color.Black;
            this.findbutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findbutton.Click += new System.EventHandler(this.tabbuttonclick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.hometab2);
            this.panel3.Controls.Add(this.find2);
            this.panel3.Controls.Add(this.checkout1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(236, 114);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1081, 674);
            this.panel3.TabIndex = 2;
            // 
            // hometab2
            // 
            this.hometab2.BackColor = System.Drawing.SystemColors.Window;
            this.hometab2.Location = new System.Drawing.Point(0, 0);
            this.hometab2.Margin = new System.Windows.Forms.Padding(5);
            this.hometab2.Name = "hometab2";
            this.hometab2.Size = new System.Drawing.Size(1081, 679);
            this.hometab2.TabIndex = 0;
            // 
            // find2
            // 
            this.find2.BackColor = System.Drawing.Color.White;
            this.find2.Location = new System.Drawing.Point(0, 0);
            this.find2.Margin = new System.Windows.Forms.Padding(5);
            this.find2.Name = "find2";
            this.find2.Size = new System.Drawing.Size(1081, 679);
            this.find2.TabIndex = 1;
            // 
            // checkout1
            // 
            this.checkout1.Location = new System.Drawing.Point(0, -1);
            this.checkout1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkout1.Name = "checkout1";
            this.checkout1.Size = new System.Drawing.Size(1081, 679);
            this.checkout1.TabIndex = 3;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1317, 788);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emphome";
            this.Load += new System.EventHandler(this.emphome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton findbutton;
        private Bunifu.Framework.UI.BunifuFlatButton homebutton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton Servicesbutton;
        private Bunifu.Framework.UI.BunifuFlatButton cancleservice;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private hometab hometab2;
        private System.Windows.Forms.Panel selectedtabpannel;
        private System.Windows.Forms.Label label1;
        private Checkout checkout1;
        public System.Windows.Forms.Label label3;
        public find find2;
    }
}