namespace WindowsFormsApplication1
{
    partial class salary_win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salary_win));
            this.empname = new Bunifu.Framework.UI.BunifuDropdown();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salarytextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bonustextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.salaryhistoryView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selecthistorymonthDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.SearchAttendButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PayButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.back = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryhistoryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // empname
            // 
            this.empname.BackColor = System.Drawing.Color.Transparent;
            this.empname.BorderRadius = 3;
            this.empname.ForeColor = System.Drawing.Color.Black;
            this.empname.Items = new string[0];
            this.empname.Location = new System.Drawing.Point(283, 134);
            this.empname.Margin = new System.Windows.Forms.Padding(5);
            this.empname.Name = "empname";
            this.empname.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.empname.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.empname.selectedIndex = -1;
            this.empname.Size = new System.Drawing.Size(256, 42);
            this.empname.TabIndex = 81;
            this.empname.onItemSelected += new System.EventHandler(this.post_onItemSelected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 151);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 25);
            this.label6.TabIndex = 80;
            this.label6.Text = "Employee Name : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 277);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "Salary : ";
            // 
            // salarytextbox
            // 
            this.salarytextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salarytextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.salarytextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salarytextbox.HintForeColor = System.Drawing.Color.Empty;
            this.salarytextbox.HintText = "";
            this.salarytextbox.isPassword = false;
            this.salarytextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.salarytextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.salarytextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.salarytextbox.LineThickness = 3;
            this.salarytextbox.Location = new System.Drawing.Point(283, 249);
            this.salarytextbox.Margin = new System.Windows.Forms.Padding(5);
            this.salarytextbox.Name = "salarytextbox";
            this.salarytextbox.Size = new System.Drawing.Size(256, 53);
            this.salarytextbox.TabIndex = 83;
            this.salarytextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bonustextbox
            // 
            this.bonustextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bonustextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bonustextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bonustextbox.HintForeColor = System.Drawing.Color.Empty;
            this.bonustextbox.HintText = "";
            this.bonustextbox.isPassword = false;
            this.bonustextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.bonustextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.bonustextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bonustextbox.LineThickness = 3;
            this.bonustextbox.Location = new System.Drawing.Point(283, 327);
            this.bonustextbox.Margin = new System.Windows.Forms.Padding(5);
            this.bonustextbox.Name = "bonustextbox";
            this.bonustextbox.Size = new System.Drawing.Size(256, 53);
            this.bonustextbox.TabIndex = 85;
            this.bonustextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 355);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 84;
            this.label2.Text = "Bonus : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 87;
            this.label3.Text = "Select Month : ";
            // 
            // monthDropdown1
            // 
            this.monthDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.monthDropdown1.BorderRadius = 3;
            this.monthDropdown1.ForeColor = System.Drawing.Color.Black;
            this.monthDropdown1.Items = new string[] {
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
            this.monthDropdown1.Location = new System.Drawing.Point(283, 214);
            this.monthDropdown1.Margin = new System.Windows.Forms.Padding(5);
            this.monthDropdown1.Name = "monthDropdown1";
            this.monthDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.monthDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.monthDropdown1.selectedIndex = -1;
            this.monthDropdown1.Size = new System.Drawing.Size(147, 42);
            this.monthDropdown1.TabIndex = 88;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.selecthistorymonthDropdown1);
            this.panel1.Controls.Add(this.salaryhistoryView);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SearchAttendButton);
            this.panel1.Location = new System.Drawing.Point(624, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 632);
            this.panel1.TabIndex = 89;
            // 
            // salaryhistoryView
            // 
            this.salaryhistoryView.AllowUserToAddRows = false;
            this.salaryhistoryView.AllowUserToDeleteRows = false;
            this.salaryhistoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salaryhistoryView.Location = new System.Drawing.Point(15, 133);
            this.salaryhistoryView.Name = "salaryhistoryView";
            this.salaryhistoryView.ReadOnly = true;
            this.salaryhistoryView.RowHeadersWidth = 51;
            this.salaryhistoryView.RowTemplate.Height = 24;
            this.salaryhistoryView.Size = new System.Drawing.Size(637, 470);
            this.salaryhistoryView.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 78;
            this.label5.Text = "Salary History";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 78;
            this.label4.Text = "Select Month : ";
            // 
            // selecthistorymonthDropdown1
            // 
            this.selecthistorymonthDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.selecthistorymonthDropdown1.BorderRadius = 3;
            this.selecthistorymonthDropdown1.ForeColor = System.Drawing.Color.Black;
            this.selecthistorymonthDropdown1.Items = new string[] {
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
            this.selecthistorymonthDropdown1.Location = new System.Drawing.Point(193, 64);
            this.selecthistorymonthDropdown1.Margin = new System.Windows.Forms.Padding(5);
            this.selecthistorymonthDropdown1.Name = "selecthistorymonthDropdown1";
            this.selecthistorymonthDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.selecthistorymonthDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.selecthistorymonthDropdown1.selectedIndex = -1;
            this.selecthistorymonthDropdown1.Size = new System.Drawing.Size(147, 42);
            this.selecthistorymonthDropdown1.TabIndex = 89;
            // 
            // SearchAttendButton
            // 
            this.SearchAttendButton.ActiveBorderThickness = 1;
            this.SearchAttendButton.ActiveCornerRadius = 20;
            this.SearchAttendButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.SearchAttendButton.ActiveForecolor = System.Drawing.Color.Black;
            this.SearchAttendButton.ActiveLineColor = System.Drawing.Color.Black;
            this.SearchAttendButton.BackColor = System.Drawing.Color.White;
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
            this.SearchAttendButton.Location = new System.Drawing.Point(387, 63);
            this.SearchAttendButton.Margin = new System.Windows.Forms.Padding(5);
            this.SearchAttendButton.Name = "SearchAttendButton";
            this.SearchAttendButton.Size = new System.Drawing.Size(138, 41);
            this.SearchAttendButton.TabIndex = 74;
            this.SearchAttendButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchAttendButton.Click += new System.EventHandler(this.SearchAttendButton_Click);
            // 
            // PayButton
            // 
            this.PayButton.ActiveBorderThickness = 1;
            this.PayButton.ActiveCornerRadius = 20;
            this.PayButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.PayButton.ActiveForecolor = System.Drawing.Color.Black;
            this.PayButton.ActiveLineColor = System.Drawing.Color.Black;
            this.PayButton.BackColor = System.Drawing.Color.White;
            this.PayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PayButton.BackgroundImage")));
            this.PayButton.ButtonText = "Pay";
            this.PayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.PayButton.IdleBorderThickness = 1;
            this.PayButton.IdleCornerRadius = 20;
            this.PayButton.IdleFillColor = System.Drawing.Color.White;
            this.PayButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.PayButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.PayButton.Location = new System.Drawing.Point(208, 437);
            this.PayButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(159, 48);
            this.PayButton.TabIndex = 86;
            this.PayButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
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
            this.back.TabIndex = 69;
            this.back.TabStop = false;
            this.back.Zoom = 10;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // salary_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthDropdown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.bonustextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salarytextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.back);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "salary_win";
            this.Size = new System.Drawing.Size(1296, 626);
            this.Load += new System.EventHandler(this.salary_win_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryhistoryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuImageButton back;
        private Bunifu.Framework.UI.BunifuDropdown empname;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox salarytextbox;
        public Bunifu.Framework.UI.BunifuMaterialTextbox bonustextbox;
        public System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuThinButton2 PayButton;
        public System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDropdown monthDropdown1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDropdown selecthistorymonthDropdown1;
        private System.Windows.Forms.DataGridView salaryhistoryView;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 SearchAttendButton;
    }
}
