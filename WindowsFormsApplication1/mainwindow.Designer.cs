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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainwindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.user_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.switchbutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitbutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rightimgbutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.leftimgbutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.hometab1 = new WindowsFormsApplication1.hometab();
            this.findwindow1 = new WindowsFormsApplication1.findwindow();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.anitab = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.anitab1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolTipbutton = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitbutton)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightimgbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftimgbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(202)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.user_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.switchbutton);
            this.panel1.Controls.Add(this.exitbutton);
            this.panel1.Controls.Add(this.label2);
            this.anitab.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.anitab1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1331, 108);
            this.panel1.TabIndex = 0;
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.anitab1.SetDecoration(this.user_name, BunifuAnimatorNS.DecorationType.None);
            this.anitab.SetDecoration(this.user_name, BunifuAnimatorNS.DecorationType.None);
            this.user_name.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(1171, 18);
            this.user_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(58, 26);
            this.user_name.TabIndex = 5;
            this.user_name.Text = "rahul";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.anitab1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.anitab.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hotel Continental";
            // 
            // switchbutton
            // 
            this.switchbutton.BackColor = System.Drawing.Color.Transparent;
            this.anitab1.SetDecoration(this.switchbutton, BunifuAnimatorNS.DecorationType.None);
            this.anitab.SetDecoration(this.switchbutton, BunifuAnimatorNS.DecorationType.None);
            this.switchbutton.Image = global::WindowsFormsApplication1.Properties.Resources.switchaccount;
            this.switchbutton.ImageActive = null;
            this.switchbutton.Location = new System.Drawing.Point(1243, 15);
            this.switchbutton.Margin = new System.Windows.Forms.Padding(4);
            this.switchbutton.Name = "switchbutton";
            this.switchbutton.Size = new System.Drawing.Size(36, 32);
            this.switchbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.switchbutton.TabIndex = 3;
            this.switchbutton.TabStop = false;
            this.toolTipbutton.SetToolTip(this.switchbutton, "Switch User");
            this.switchbutton.Zoom = 10;
            this.switchbutton.Click += new System.EventHandler(this.switchbutton_click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Transparent;
            this.anitab1.SetDecoration(this.exitbutton, BunifuAnimatorNS.DecorationType.None);
            this.anitab.SetDecoration(this.exitbutton, BunifuAnimatorNS.DecorationType.None);
            this.exitbutton.Image = global::WindowsFormsApplication1.Properties.Resources.shutdown;
            this.exitbutton.ImageActive = null;
            this.exitbutton.Location = new System.Drawing.Point(1287, 15);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(4);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(36, 32);
            this.exitbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitbutton.TabIndex = 2;
            this.exitbutton.TabStop = false;
            this.toolTipbutton.SetToolTip(this.exitbutton, "Close");
            this.exitbutton.Zoom = 10;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.anitab1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.anitab.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 42);
            this.label2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rightimgbutton);
            this.panel3.Controls.Add(this.leftimgbutton);
            this.panel3.Controls.Add(this.hometab1);
            this.panel3.Controls.Add(this.findwindow1);
            this.anitab.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.anitab1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 109);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1331, 679);
            this.panel3.TabIndex = 2;
            // 
            // rightimgbutton
            // 
            this.rightimgbutton.BackColor = System.Drawing.Color.Transparent;
            this.anitab1.SetDecoration(this.rightimgbutton, BunifuAnimatorNS.DecorationType.None);
            this.anitab.SetDecoration(this.rightimgbutton, BunifuAnimatorNS.DecorationType.None);
            this.rightimgbutton.Image = global::WindowsFormsApplication1.Properties.Resources.rback;
            this.rightimgbutton.ImageActive = null;
            this.rightimgbutton.Location = new System.Drawing.Point(1281, 298);
            this.rightimgbutton.Margin = new System.Windows.Forms.Padding(4);
            this.rightimgbutton.Name = "rightimgbutton";
            this.rightimgbutton.Size = new System.Drawing.Size(49, 58);
            this.rightimgbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rightimgbutton.TabIndex = 6;
            this.rightimgbutton.TabStop = false;
            this.toolTipbutton.SetToolTip(this.rightimgbutton, "Search");
            this.rightimgbutton.Zoom = 10;
            this.rightimgbutton.Click += new System.EventHandler(this.rightimgbutton_Click);
            // 
            // leftimgbutton
            // 
            this.leftimgbutton.BackColor = System.Drawing.Color.Transparent;
            this.anitab1.SetDecoration(this.leftimgbutton, BunifuAnimatorNS.DecorationType.None);
            this.anitab.SetDecoration(this.leftimgbutton, BunifuAnimatorNS.DecorationType.None);
            this.leftimgbutton.Image = global::WindowsFormsApplication1.Properties.Resources.back;
            this.leftimgbutton.ImageActive = null;
            this.leftimgbutton.Location = new System.Drawing.Point(0, 298);
            this.leftimgbutton.Margin = new System.Windows.Forms.Padding(4);
            this.leftimgbutton.Name = "leftimgbutton";
            this.leftimgbutton.Size = new System.Drawing.Size(49, 58);
            this.leftimgbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftimgbutton.TabIndex = 5;
            this.leftimgbutton.TabStop = false;
            this.toolTipbutton.SetToolTip(this.leftimgbutton, "Home");
            this.leftimgbutton.Zoom = 10;
            this.leftimgbutton.Click += new System.EventHandler(this.leftimgbutton_Click);
            // 
            // hometab1
            // 
            this.hometab1.BackColor = System.Drawing.Color.White;
            this.anitab1.SetDecoration(this.hometab1, BunifuAnimatorNS.DecorationType.None);
            this.anitab.SetDecoration(this.hometab1, BunifuAnimatorNS.DecorationType.None);
            this.hometab1.Location = new System.Drawing.Point(0, 0);
            this.hometab1.Margin = new System.Windows.Forms.Padding(5);
            this.hometab1.Name = "hometab1";
            this.hometab1.Size = new System.Drawing.Size(1331, 679);
            this.hometab1.TabIndex = 0;
            // 
            // findwindow1
            // 
            this.anitab1.SetDecoration(this.findwindow1, BunifuAnimatorNS.DecorationType.None);
            this.anitab.SetDecoration(this.findwindow1, BunifuAnimatorNS.DecorationType.None);
            this.findwindow1.Location = new System.Drawing.Point(0, 0);
            this.findwindow1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findwindow1.Name = "findwindow1";
            this.findwindow1.Size = new System.Drawing.Size(1331, 679);
            this.findwindow1.TabIndex = 1;
            this.findwindow1.Visible = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // anitab
            // 
            this.anitab.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.anitab.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.anitab.DefaultAnimation = animation2;
            this.anitab.MaxAnimationTime = 1000;
            this.anitab.TimeStep = 0.05F;
            // 
            // anitab1
            // 
            this.anitab1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.anitab1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.anitab1.DefaultAnimation = animation1;
            this.anitab1.MaxAnimationTime = 1000;
            this.anitab1.TimeStep = 0.05F;
            // 
            // toolTipbutton
            // 
            this.toolTipbutton.AutoPopDelay = 5000;
            this.toolTipbutton.InitialDelay = 50;
            this.toolTipbutton.ReshowDelay = 100;
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1331, 788);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.anitab1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.anitab.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emphome";
            this.Load += new System.EventHandler(this.mainwindow_load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitbutton)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightimgbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftimgbutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label user_name;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuImageButton exitbutton;
        public Bunifu.Framework.UI.BunifuImageButton switchbutton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel3;
        public hometab hometab1;
        private findwindow findwindow1;
        public Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton rightimgbutton;
        private Bunifu.Framework.UI.BunifuImageButton leftimgbutton;
        private BunifuAnimatorNS.BunifuTransition anitab;
        private BunifuAnimatorNS.BunifuTransition anitab1;
        private System.Windows.Forms.ToolTip toolTipbutton;
    }
}