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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
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
            this.salaryhistoryView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.selecthistorymonthDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchAttendButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PayButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.back = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salaryhistoryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // empname
            // 
            this.empname.BackColor = System.Drawing.Color.Transparent;
            this.empname.BorderRadius = 3;
            this.bunifuTransition1.SetDecoration(this.empname, BunifuAnimatorNS.DecorationType.None);
            this.empname.ForeColor = System.Drawing.Color.Black;
            this.empname.Items = new string[0];
            this.empname.Location = new System.Drawing.Point(212, 109);
            this.empname.Margin = new System.Windows.Forms.Padding(4);
            this.empname.Name = "empname";
            this.empname.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.empname.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.empname.selectedIndex = -1;
            this.empname.Size = new System.Drawing.Size(192, 34);
            this.empname.TabIndex = 81;
            this.empname.onItemSelected += new System.EventHandler(this.post_onItemSelected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 80;
            this.label6.Text = "Employee Name : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Salary : ";
            // 
            // salarytextbox
            // 
            this.salarytextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.salarytextbox, BunifuAnimatorNS.DecorationType.None);
            this.salarytextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.salarytextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salarytextbox.HintForeColor = System.Drawing.Color.Empty;
            this.salarytextbox.HintText = "";
            this.salarytextbox.isPassword = false;
            this.salarytextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.salarytextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.salarytextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.salarytextbox.LineThickness = 3;
            this.salarytextbox.Location = new System.Drawing.Point(212, 202);
            this.salarytextbox.Margin = new System.Windows.Forms.Padding(4);
            this.salarytextbox.Name = "salarytextbox";
            this.salarytextbox.Size = new System.Drawing.Size(192, 43);
            this.salarytextbox.TabIndex = 83;
            this.salarytextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bonustextbox
            // 
            this.bonustextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bonustextbox, BunifuAnimatorNS.DecorationType.None);
            this.bonustextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bonustextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bonustextbox.HintForeColor = System.Drawing.Color.Empty;
            this.bonustextbox.HintText = "";
            this.bonustextbox.isPassword = false;
            this.bonustextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.bonustextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.bonustextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bonustextbox.LineThickness = 3;
            this.bonustextbox.Location = new System.Drawing.Point(212, 266);
            this.bonustextbox.Margin = new System.Windows.Forms.Padding(4);
            this.bonustextbox.Name = "bonustextbox";
            this.bonustextbox.Size = new System.Drawing.Size(192, 43);
            this.bonustextbox.TabIndex = 85;
            this.bonustextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Bonus : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 87;
            this.label3.Text = "Select Month : ";
            // 
            // monthDropdown1
            // 
            this.monthDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.monthDropdown1.BorderRadius = 3;
            this.bunifuTransition1.SetDecoration(this.monthDropdown1, BunifuAnimatorNS.DecorationType.None);
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
            this.monthDropdown1.Location = new System.Drawing.Point(212, 174);
            this.monthDropdown1.Margin = new System.Windows.Forms.Padding(4);
            this.monthDropdown1.Name = "monthDropdown1";
            this.monthDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.monthDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.monthDropdown1.selectedIndex = -1;
            this.monthDropdown1.Size = new System.Drawing.Size(110, 34);
            this.monthDropdown1.TabIndex = 88;
            this.monthDropdown1.onItemSelected += new System.EventHandler(this.monthDropdown1_onItemSelected);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.salaryhistoryView);
            this.panel1.Controls.Add(this.selecthistorymonthDropdown1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SearchAttendButton);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(468, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 514);
            this.panel1.TabIndex = 89;
            // 
            // salaryhistoryView
            // 
            this.salaryhistoryView.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.salaryhistoryView.AllowUserToAddRows = false;
            this.salaryhistoryView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.salaryhistoryView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.salaryhistoryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salaryhistoryView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.salaryhistoryView.BackgroundColor = System.Drawing.Color.White;
            this.salaryhistoryView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salaryhistoryView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.salaryhistoryView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salaryhistoryView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.salaryhistoryView.ColumnHeadersHeight = 30;
            this.bunifuTransition1.SetDecoration(this.salaryhistoryView, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salaryhistoryView.DefaultCellStyle = dataGridViewCellStyle3;
            this.salaryhistoryView.DoubleBuffered = true;
            this.salaryhistoryView.EnableHeadersVisualStyles = false;
            this.salaryhistoryView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.salaryhistoryView.HeaderForeColor = System.Drawing.Color.White;
            this.salaryhistoryView.Location = new System.Drawing.Point(11, 108);
            this.salaryhistoryView.MultiSelect = false;
            this.salaryhistoryView.Name = "salaryhistoryView";
            this.salaryhistoryView.ReadOnly = true;
            this.salaryhistoryView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.salaryhistoryView.RowHeadersVisible = false;
            this.salaryhistoryView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.salaryhistoryView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salaryhistoryView.Size = new System.Drawing.Size(477, 378);
            this.salaryhistoryView.TabIndex = 90;
            // 
            // selecthistorymonthDropdown1
            // 
            this.selecthistorymonthDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.selecthistorymonthDropdown1.BorderRadius = 3;
            this.bunifuTransition1.SetDecoration(this.selecthistorymonthDropdown1, BunifuAnimatorNS.DecorationType.None);
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
            this.selecthistorymonthDropdown1.Location = new System.Drawing.Point(145, 52);
            this.selecthistorymonthDropdown1.Margin = new System.Windows.Forms.Padding(4);
            this.selecthistorymonthDropdown1.Name = "selecthistorymonthDropdown1";
            this.selecthistorymonthDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.selecthistorymonthDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.selecthistorymonthDropdown1.selectedIndex = -1;
            this.selecthistorymonthDropdown1.Size = new System.Drawing.Size(110, 34);
            this.selecthistorymonthDropdown1.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "Salary History";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Select Month : ";
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
            this.bunifuTransition1.SetDecoration(this.SearchAttendButton, BunifuAnimatorNS.DecorationType.None);
            this.SearchAttendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchAttendButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.SearchAttendButton.IdleBorderThickness = 1;
            this.SearchAttendButton.IdleCornerRadius = 20;
            this.SearchAttendButton.IdleFillColor = System.Drawing.Color.White;
            this.SearchAttendButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.SearchAttendButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.SearchAttendButton.Location = new System.Drawing.Point(290, 51);
            this.SearchAttendButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchAttendButton.Name = "SearchAttendButton";
            this.SearchAttendButton.Size = new System.Drawing.Size(104, 33);
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
            this.bunifuTransition1.SetDecoration(this.PayButton, BunifuAnimatorNS.DecorationType.None);
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.PayButton.IdleBorderThickness = 1;
            this.PayButton.IdleCornerRadius = 20;
            this.PayButton.IdleFillColor = System.Drawing.Color.White;
            this.PayButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.PayButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.PayButton.Location = new System.Drawing.Point(156, 355);
            this.PayButton.Margin = new System.Windows.Forms.Padding(5);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(119, 39);
            this.PayButton.TabIndex = 86;
            this.PayButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.back, BunifuAnimatorNS.DecorationType.None);
            this.back.Image = global::WindowsFormsApplication1.Properties.Resources.back;
            this.back.ImageActive = null;
            this.back.Location = new System.Drawing.Point(6, 11);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 32);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 69;
            this.back.TabStop = false;
            this.back.Zoom = 10;
            this.back.Click += new System.EventHandler(this.back_Click);
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.salaryhistoryView;
            // 
            // salary_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "salary_win";
            this.Size = new System.Drawing.Size(972, 509);
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
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 SearchAttendButton;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid salaryhistoryView;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
