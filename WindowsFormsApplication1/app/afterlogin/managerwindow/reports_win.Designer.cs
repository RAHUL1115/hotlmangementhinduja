namespace WindowsFormsApplication1
{
    partial class reports_win
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reports_win));
            this.back = new Bunifu.Framework.UI.BunifuImageButton();
            this.report = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label1_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label2_1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label3_1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label4_1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label5_1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label6_1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.selectmonth = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.back, BunifuAnimatorNS.DecorationType.None);
            this.back.Image = global::WindowsFormsApplication1.Properties.Resources.back;
            this.back.ImageActive = null;
            this.back.Location = new System.Drawing.Point(15, 20);
            this.back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 32);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 67;
            this.back.TabStop = false;
            this.back.Zoom = 10;
            this.back.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // report
            // 
            this.report.ActiveBorderThickness = 1;
            this.report.ActiveCornerRadius = 20;
            this.report.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.report.ActiveForecolor = System.Drawing.Color.Black;
            this.report.ActiveLineColor = System.Drawing.Color.Black;
            this.report.BackColor = System.Drawing.SystemColors.Control;
            this.report.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("report.BackgroundImage")));
            this.report.ButtonText = "Generate Report";
            this.report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.report, BunifuAnimatorNS.DecorationType.None);
            this.report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.Color.SeaGreen;
            this.report.IdleBorderThickness = 1;
            this.report.IdleCornerRadius = 20;
            this.report.IdleFillColor = System.Drawing.Color.White;
            this.report.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.report.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.report.Location = new System.Drawing.Point(435, 439);
            this.report.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(130, 65);
            this.report.TabIndex = 1;
            this.report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Check in\'s";
            // 
            // label1_1
            // 
            this.label1_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1_1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1_1, BunifuAnimatorNS.DecorationType.None);
            this.label1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_1.Location = new System.Drawing.Point(654, 17);
            this.label1_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1_1.Name = "label1_1";
            this.label1_1.Size = new System.Drawing.Size(20, 24);
            this.label1_1.TabIndex = 1;
            this.label1_1.Text = "0";
            this.label1_1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of  Cancle";
            // 
            // label2_1
            // 
            this.label2_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2_1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2_1, BunifuAnimatorNS.DecorationType.None);
            this.label2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_1.Location = new System.Drawing.Point(654, 76);
            this.label2_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2_1.Name = "label2_1";
            this.label2_1.Size = new System.Drawing.Size(20, 24);
            this.label2_1.TabIndex = 3;
            this.label2_1.Text = "0";
            this.label2_1.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of Check out";
            // 
            // label3_1
            // 
            this.label3_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3_1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3_1, BunifuAnimatorNS.DecorationType.None);
            this.label3_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_1.Location = new System.Drawing.Point(654, 135);
            this.label3_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3_1.Name = "label3_1";
            this.label3_1.Size = new System.Drawing.Size(20, 24);
            this.label3_1.TabIndex = 5;
            this.label3_1.Text = "0";
            this.label3_1.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Employee Salary";
            // 
            // label4_1
            // 
            this.label4_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4_1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4_1, BunifuAnimatorNS.DecorationType.None);
            this.label4_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4_1.Location = new System.Drawing.Point(654, 194);
            this.label4_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4_1.Name = "label4_1";
            this.label4_1.Size = new System.Drawing.Size(20, 24);
            this.label4_1.TabIndex = 7;
            this.label4_1.Text = "0";
            this.label4_1.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 253);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Revenue";
            // 
            // label5_1
            // 
            this.label5_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5_1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5_1, BunifuAnimatorNS.DecorationType.None);
            this.label5_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5_1.Location = new System.Drawing.Point(654, 253);
            this.label5_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5_1.Name = "label5_1";
            this.label5_1.Size = new System.Drawing.Size(20, 24);
            this.label5_1.TabIndex = 9;
            this.label5_1.Text = "0";
            this.label5_1.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(196, 312);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Profit";
            // 
            // label6_1
            // 
            this.label6_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6_1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label6_1, BunifuAnimatorNS.DecorationType.None);
            this.label6_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_1.Location = new System.Drawing.Point(654, 312);
            this.label6_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6_1.Name = "label6_1";
            this.label6_1.Size = new System.Drawing.Size(20, 24);
            this.label6_1.TabIndex = 12;
            this.label6_1.Text = "0";
            this.label6_1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6_1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5_1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4_1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3_1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2_1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1_1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.selectmonth, 1, 6);
            this.bunifuTransition1.SetDecoration(this.tableLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.32664F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.32665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.32665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.32665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.32665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.32665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.04012F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 413);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(190, 371);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Month";
            // 
            // selectmonth
            // 
            this.selectmonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectmonth.BackColor = System.Drawing.Color.Transparent;
            this.selectmonth.BorderRadius = 3;
            this.bunifuTransition1.SetDecoration(this.selectmonth, BunifuAnimatorNS.DecorationType.None);
            this.selectmonth.ForeColor = System.Drawing.Color.Black;
            this.selectmonth.Items = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11"};
            this.selectmonth.Location = new System.Drawing.Point(556, 366);
            this.selectmonth.Name = "selectmonth";
            this.selectmonth.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.selectmonth.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.selectmonth.selectedIndex = -1;
            this.selectmonth.Size = new System.Drawing.Size(217, 35);
            this.selectmonth.TabIndex = 14;
            this.selectmonth.TabStop = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
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
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 5;
            this.bunifuTransition1.MaxAnimationTime = 1000;
            this.bunifuTransition1.TimeStep = 0.05F;
            // 
            // reports_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back);
            this.Controls.Add(this.report);
            this.Controls.Add(this.tableLayoutPanel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "reports_win";
            this.Size = new System.Drawing.Size(972, 509);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Bunifu.Framework.UI.BunifuThinButton2 report;
        public Bunifu.Framework.UI.BunifuImageButton back;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label1_1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label2_1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label3_1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label4_1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label5_1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label6_1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDropdown selectmonth;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}
