namespace WindowsFormsApplication1
{
    partial class attendance_win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(attendance_win));
            this.back = new Bunifu.Framework.UI.BunifuImageButton();
            this.AddAttendanceName = new Bunifu.Framework.UI.BunifuDropdown();
            this.AddButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SearchName = new Bunifu.Framework.UI.BunifuDropdown();
            this.SearchMonth = new Bunifu.Framework.UI.BunifuDropdown();
            this.SearchAttendButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.historyattendView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.todayattendView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyattendView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayattendView)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back.Image = global::WindowsFormsApplication1.Properties.Resources.back;
            this.back.ImageActive = null;
            this.back.Location = new System.Drawing.Point(8, 14);
            this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(45, 39);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 68;
            this.back.TabStop = false;
            this.back.Zoom = 10;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // AddAttendanceName
            // 
            this.AddAttendanceName.BackColor = System.Drawing.Color.Transparent;
            this.AddAttendanceName.BorderRadius = 3;
            this.AddAttendanceName.ForeColor = System.Drawing.Color.White;
            this.AddAttendanceName.Items = new string[0];
            this.AddAttendanceName.Location = new System.Drawing.Point(75, 85);
            this.AddAttendanceName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddAttendanceName.Name = "AddAttendanceName";
            this.AddAttendanceName.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.AddAttendanceName.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.AddAttendanceName.selectedIndex = -1;
            this.AddAttendanceName.Size = new System.Drawing.Size(280, 43);
            this.AddAttendanceName.TabIndex = 69;
            // 
            // AddButton
            // 
            this.AddButton.ActiveBorderThickness = 1;
            this.AddButton.ActiveCornerRadius = 20;
            this.AddButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.AddButton.ActiveForecolor = System.Drawing.Color.White;
            this.AddButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.ButtonText = "Add";
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddButton.IdleBorderThickness = 1;
            this.AddButton.IdleCornerRadius = 20;
            this.AddButton.IdleFillColor = System.Drawing.Color.White;
            this.AddButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.AddButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.AddButton.Location = new System.Drawing.Point(392, 84);
            this.AddButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(181, 41);
            this.AddButton.TabIndex = 70;
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchName
            // 
            this.SearchName.BackColor = System.Drawing.Color.Transparent;
            this.SearchName.BorderRadius = 3;
            this.SearchName.ForeColor = System.Drawing.Color.White;
            this.SearchName.Items = new string[0];
            this.SearchName.Location = new System.Drawing.Point(15, 81);
            this.SearchName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchName.Name = "SearchName";
            this.SearchName.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SearchName.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.SearchName.selectedIndex = -1;
            this.SearchName.Size = new System.Drawing.Size(270, 43);
            this.SearchName.TabIndex = 72;
            // 
            // SearchMonth
            // 
            this.SearchMonth.BackColor = System.Drawing.Color.Transparent;
            this.SearchMonth.BorderRadius = 3;
            this.SearchMonth.ForeColor = System.Drawing.Color.White;
            this.SearchMonth.Items = new string[] {
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
        "11",
        "12"};
            this.SearchMonth.Location = new System.Drawing.Point(319, 81);
            this.SearchMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchMonth.Name = "SearchMonth";
            this.SearchMonth.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.SearchMonth.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.SearchMonth.selectedIndex = -1;
            this.SearchMonth.Size = new System.Drawing.Size(149, 43);
            this.SearchMonth.TabIndex = 73;
            // 
            // SearchAttendButton
            // 
            this.SearchAttendButton.ActiveBorderThickness = 1;
            this.SearchAttendButton.ActiveCornerRadius = 20;
            this.SearchAttendButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.SearchAttendButton.ActiveForecolor = System.Drawing.Color.White;
            this.SearchAttendButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.SearchAttendButton.BackColor = System.Drawing.SystemColors.Control;
            this.SearchAttendButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchAttendButton.BackgroundImage")));
            this.SearchAttendButton.ButtonText = "Search";
            this.SearchAttendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchAttendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAttendButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.SearchAttendButton.IdleBorderThickness = 1;
            this.SearchAttendButton.IdleCornerRadius = 20;
            this.SearchAttendButton.IdleFillColor = System.Drawing.Color.White;
            this.SearchAttendButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.SearchAttendButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.SearchAttendButton.Location = new System.Drawing.Point(496, 81);
            this.SearchAttendButton.Margin = new System.Windows.Forms.Padding(5);
            this.SearchAttendButton.Name = "SearchAttendButton";
            this.SearchAttendButton.Size = new System.Drawing.Size(138, 41);
            this.SearchAttendButton.TabIndex = 74;
            this.SearchAttendButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchAttendButton.Click += new System.EventHandler(this.SearchAttendButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.historyattendView);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SearchName);
            this.panel1.Controls.Add(this.SearchAttendButton);
            this.panel1.Controls.Add(this.SearchMonth);
            this.panel1.Location = new System.Drawing.Point(624, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 632);
            this.panel1.TabIndex = 75;
            // 
            // historyattendView
            // 
            this.historyattendView.AllowUserToAddRows = false;
            this.historyattendView.AllowUserToDeleteRows = false;
            this.historyattendView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyattendView.Location = new System.Drawing.Point(15, 165);
            this.historyattendView.Name = "historyattendView";
            this.historyattendView.ReadOnly = true;
            this.historyattendView.RowHeadersWidth = 51;
            this.historyattendView.RowTemplate.Height = 24;
            this.historyattendView.Size = new System.Drawing.Size(637, 444);
            this.historyattendView.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 25);
            this.label5.TabIndex = 78;
            this.label5.Text = "Attendance History";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(314, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 78;
            this.label3.Text = "Select Month : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 25);
            this.label2.TabIndex = 77;
            this.label2.Text = "Select Employee Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 76;
            this.label1.Text = "Select Employee Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 25);
            this.label4.TabIndex = 77;
            this.label4.Text = "Today\'s Attendance";
            // 
            // todayattendView
            // 
            this.todayattendView.AllowUserToAddRows = false;
            this.todayattendView.AllowUserToDeleteRows = false;
            this.todayattendView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todayattendView.Location = new System.Drawing.Point(25, 160);
            this.todayattendView.Name = "todayattendView";
            this.todayattendView.ReadOnly = true;
            this.todayattendView.RowHeadersWidth = 51;
            this.todayattendView.RowTemplate.Height = 24;
            this.todayattendView.Size = new System.Drawing.Size(580, 444);
            this.todayattendView.TabIndex = 80;
            // 
            // attendance_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.todayattendView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddAttendanceName);
            this.Controls.Add(this.back);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "attendance_win";
            this.Size = new System.Drawing.Size(1296, 626);
            this.Load += new System.EventHandler(this.attendance_win_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyattendView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todayattendView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Bunifu.Framework.UI.BunifuImageButton back;
        private Bunifu.Framework.UI.BunifuDropdown AddAttendanceName;
        private Bunifu.Framework.UI.BunifuThinButton2 AddButton;
        private Bunifu.Framework.UI.BunifuDropdown SearchName;
        private Bunifu.Framework.UI.BunifuDropdown SearchMonth;
        private Bunifu.Framework.UI.BunifuThinButton2 SearchAttendButton;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView historyattendView;
        private System.Windows.Forms.DataGridView todayattendView;
    }
}
