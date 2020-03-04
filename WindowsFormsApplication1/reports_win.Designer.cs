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
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back.Image = global::WindowsFormsApplication1.Properties.Resources.back;
            this.back.ImageActive = null;
            this.back.Location = new System.Drawing.Point(20, 25);
            this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(45, 39);
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
            this.report.ActiveForecolor = System.Drawing.Color.White;
            this.report.ActiveLineColor = System.Drawing.Color.Black;
            this.report.BackColor = System.Drawing.SystemColors.Control;
            this.report.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("report.BackgroundImage")));
            this.report.ButtonText = "Generate Report";
            this.report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.Color.SeaGreen;
            this.report.IdleBorderThickness = 1;
            this.report.IdleCornerRadius = 20;
            this.report.IdleFillColor = System.Drawing.Color.White;
            this.report.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.report.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.report.Location = new System.Drawing.Point(580, 540);
            this.report.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(174, 80);
            this.report.TabIndex = 1;
            this.report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numbers of Check in\'s";
            // 
            // label1_1
            // 
            this.label1_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1_1.AutoSize = true;
            this.label1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_1.Location = new System.Drawing.Point(873, 21);
            this.label1_1.Name = "label1_1";
            this.label1_1.Size = new System.Drawing.Size(26, 29);
            this.label1_1.TabIndex = 1;
            this.label1_1.Text = "0";
            this.label1_1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numbers of  Pre bookings";
            // 
            // label2_1
            // 
            this.label2_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2_1.AutoSize = true;
            this.label2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_1.Location = new System.Drawing.Point(873, 93);
            this.label2_1.Name = "label2_1";
            this.label2_1.Size = new System.Drawing.Size(26, 29);
            this.label2_1.TabIndex = 3;
            this.label2_1.Text = "0";
            this.label2_1.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numbers of Check out";
            // 
            // label3_1
            // 
            this.label3_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3_1.AutoSize = true;
            this.label3_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_1.Location = new System.Drawing.Point(873, 165);
            this.label3_1.Name = "label3_1";
            this.label3_1.Size = new System.Drawing.Size(26, 29);
            this.label3_1.TabIndex = 5;
            this.label3_1.Text = "0";
            this.label3_1.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Employee Salary";
            // 
            // label4_1
            // 
            this.label4_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4_1.AutoSize = true;
            this.label4_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4_1.Location = new System.Drawing.Point(873, 237);
            this.label4_1.Name = "label4_1";
            this.label4_1.Size = new System.Drawing.Size(26, 29);
            this.label4_1.TabIndex = 7;
            this.label4_1.Text = "0";
            this.label4_1.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Revenue";
            // 
            // label5_1
            // 
            this.label5_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5_1.AutoSize = true;
            this.label5_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5_1.Location = new System.Drawing.Point(873, 309);
            this.label5_1.Name = "label5_1";
            this.label5_1.Size = new System.Drawing.Size(26, 29);
            this.label5_1.TabIndex = 9;
            this.label5_1.Text = "0";
            this.label5_1.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Profit";
            // 
            // label6_1
            // 
            this.label6_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6_1.AutoSize = true;
            this.label6_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_1.Location = new System.Drawing.Point(873, 381);
            this.label6_1.Name = "label6_1";
            this.label6_1.Size = new System.Drawing.Size(26, 29);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(71, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.32664F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.32665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.32665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.32665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.32665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.32665F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.04012F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 508);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(256, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Month";
            // 
            // selectmonth
            // 
            this.selectmonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectmonth.BackColor = System.Drawing.Color.Transparent;
            this.selectmonth.BorderRadius = 3;
            this.selectmonth.ForeColor = System.Drawing.Color.Black;
            this.selectmonth.Items = new string[0];
            this.selectmonth.Location = new System.Drawing.Point(742, 448);
            this.selectmonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectmonth.Name = "selectmonth";
            this.selectmonth.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.selectmonth.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.selectmonth.selectedIndex = -1;
            this.selectmonth.Size = new System.Drawing.Size(289, 43);
            this.selectmonth.TabIndex = 14;
            // 
            // reports_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back);
            this.Controls.Add(this.report);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "reports_win";
            this.Size = new System.Drawing.Size(1296, 626);
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
    }
}
