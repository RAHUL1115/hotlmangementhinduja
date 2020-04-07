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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(attendance_win));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.back = new Bunifu.Framework.UI.BunifuImageButton();
            this.AddAttendanceName = new Bunifu.Framework.UI.BunifuDropdown();
            this.AddButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SearchName = new Bunifu.Framework.UI.BunifuDropdown();
            this.SearchMonth = new Bunifu.Framework.UI.BunifuDropdown();
            this.SearchAttendButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.historyattendView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.attendencesate = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.todayattendView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
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
            this.bunifuTransition1.SetDecoration(this.back, BunifuAnimatorNS.DecorationType.None);
            this.back.Image = global::WindowsFormsApplication1.Properties.Resources.back;
            this.back.ImageActive = null;
            this.back.Location = new System.Drawing.Point(6, 11);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 32);
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
            this.bunifuTransition1.SetDecoration(this.AddAttendanceName, BunifuAnimatorNS.DecorationType.None);
            this.AddAttendanceName.ForeColor = System.Drawing.Color.Black;
            this.AddAttendanceName.Items = new string[0];
            this.AddAttendanceName.Location = new System.Drawing.Point(51, 71);
            this.AddAttendanceName.Margin = new System.Windows.Forms.Padding(4);
            this.AddAttendanceName.Name = "AddAttendanceName";
            this.AddAttendanceName.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.AddAttendanceName.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.AddAttendanceName.selectedIndex = -1;
            this.AddAttendanceName.Size = new System.Drawing.Size(210, 35);
            this.AddAttendanceName.TabIndex = 69;
            // 
            // AddButton
            // 
            this.AddButton.ActiveBorderThickness = 1;
            this.AddButton.ActiveCornerRadius = 20;
            this.AddButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.AddButton.ActiveForecolor = System.Drawing.Color.Black;
            this.AddButton.ActiveLineColor = System.Drawing.Color.Black;
            this.AddButton.BackColor = System.Drawing.Color.White;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.ButtonText = "Add";
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.AddButton, BunifuAnimatorNS.DecorationType.None);
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddButton.IdleBorderThickness = 1;
            this.AddButton.IdleCornerRadius = 20;
            this.AddButton.IdleFillColor = System.Drawing.Color.White;
            this.AddButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.AddButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.AddButton.Location = new System.Drawing.Point(359, 73);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(95, 33);
            this.AddButton.TabIndex = 70;
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SearchName
            // 
            this.SearchName.BackColor = System.Drawing.Color.Transparent;
            this.SearchName.BorderRadius = 3;
            this.bunifuTransition1.SetDecoration(this.SearchName, BunifuAnimatorNS.DecorationType.None);
            this.SearchName.ForeColor = System.Drawing.Color.Black;
            this.SearchName.Items = new string[0];
            this.SearchName.Location = new System.Drawing.Point(11, 66);
            this.SearchName.Margin = new System.Windows.Forms.Padding(4);
            this.SearchName.Name = "SearchName";
            this.SearchName.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.SearchName.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.SearchName.selectedIndex = -1;
            this.SearchName.Size = new System.Drawing.Size(202, 35);
            this.SearchName.TabIndex = 72;
            // 
            // SearchMonth
            // 
            this.SearchMonth.BackColor = System.Drawing.Color.Transparent;
            this.SearchMonth.BorderRadius = 3;
            this.bunifuTransition1.SetDecoration(this.SearchMonth, BunifuAnimatorNS.DecorationType.None);
            this.SearchMonth.ForeColor = System.Drawing.Color.Black;
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
            this.SearchMonth.Location = new System.Drawing.Point(239, 66);
            this.SearchMonth.Margin = new System.Windows.Forms.Padding(4);
            this.SearchMonth.Name = "SearchMonth";
            this.SearchMonth.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.SearchMonth.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.SearchMonth.selectedIndex = -1;
            this.SearchMonth.Size = new System.Drawing.Size(112, 35);
            this.SearchMonth.TabIndex = 73;
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
            this.SearchAttendButton.Location = new System.Drawing.Point(372, 66);
            this.SearchAttendButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchAttendButton.Name = "SearchAttendButton";
            this.SearchAttendButton.Size = new System.Drawing.Size(104, 33);
            this.SearchAttendButton.TabIndex = 74;
            this.SearchAttendButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchAttendButton.Click += new System.EventHandler(this.SearchAttendButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.historyattendView);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SearchName);
            this.panel1.Controls.Add(this.SearchAttendButton);
            this.panel1.Controls.Add(this.SearchMonth);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(468, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 514);
            this.panel1.TabIndex = 75;
            // 
            // historyattendView
            // 
            this.historyattendView.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.historyattendView.AllowUserToAddRows = false;
            this.historyattendView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.historyattendView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.historyattendView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historyattendView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.historyattendView.BackgroundColor = System.Drawing.Color.White;
            this.historyattendView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyattendView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.historyattendView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historyattendView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.historyattendView.ColumnHeadersHeight = 30;
            this.bunifuTransition1.SetDecoration(this.historyattendView, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.historyattendView.DefaultCellStyle = dataGridViewCellStyle3;
            this.historyattendView.DoubleBuffered = true;
            this.historyattendView.EnableHeadersVisualStyles = false;
            this.historyattendView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.historyattendView.HeaderForeColor = System.Drawing.Color.White;
            this.historyattendView.Location = new System.Drawing.Point(12, 134);
            this.historyattendView.MultiSelect = false;
            this.historyattendView.Name = "historyattendView";
            this.historyattendView.ReadOnly = true;
            this.historyattendView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.historyattendView.RowHeadersVisible = false;
            this.historyattendView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.historyattendView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historyattendView.Size = new System.Drawing.Size(477, 361);
            this.historyattendView.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 78;
            this.label5.Text = "Attendance History";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 78;
            this.label3.Text = "Select Month : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "Select Employee Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Select Employee Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 77;
            this.label4.Text = "Today\'s Attendance";
            // 
            // attendencesate
            // 
            this.attendencesate.BackColor = System.Drawing.Color.Transparent;
            this.attendencesate.BorderRadius = 3;
            this.bunifuTransition1.SetDecoration(this.attendencesate, BunifuAnimatorNS.DecorationType.None);
            this.attendencesate.ForeColor = System.Drawing.Color.Black;
            this.attendencesate.Items = new string[] {
        "P",
        "A"};
            this.attendencesate.Location = new System.Drawing.Point(267, 71);
            this.attendencesate.Margin = new System.Windows.Forms.Padding(4);
            this.attendencesate.Name = "attendencesate";
            this.attendencesate.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.attendencesate.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.attendencesate.selectedIndex = 0;
            this.attendencesate.Size = new System.Drawing.Size(77, 35);
            this.attendencesate.TabIndex = 81;
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
            // todayattendView
            // 
            this.todayattendView.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.todayattendView.AllowUserToAddRows = false;
            this.todayattendView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.todayattendView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.todayattendView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.todayattendView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.todayattendView.BackgroundColor = System.Drawing.Color.White;
            this.todayattendView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.todayattendView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.todayattendView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.todayattendView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.todayattendView.ColumnHeadersHeight = 30;
            this.bunifuTransition1.SetDecoration(this.todayattendView, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.todayattendView.DefaultCellStyle = dataGridViewCellStyle6;
            this.todayattendView.DoubleBuffered = true;
            this.todayattendView.EnableHeadersVisualStyles = false;
            this.todayattendView.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.todayattendView.HeaderForeColor = System.Drawing.Color.White;
            this.todayattendView.Location = new System.Drawing.Point(19, 130);
            this.todayattendView.MultiSelect = false;
            this.todayattendView.Name = "todayattendView";
            this.todayattendView.ReadOnly = true;
            this.todayattendView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.todayattendView.RowHeadersVisible = false;
            this.todayattendView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.todayattendView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.todayattendView.Size = new System.Drawing.Size(435, 361);
            this.todayattendView.TabIndex = 82;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.todayattendView;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.historyattendView;
            // 
            // attendance_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.todayattendView);
            this.Controls.Add(this.attendencesate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddAttendanceName);
            this.Controls.Add(this.back);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "attendance_win";
            this.Size = new System.Drawing.Size(972, 509);
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
        private Bunifu.Framework.UI.BunifuDropdown attendencesate;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid todayattendView;
        private Bunifu.Framework.UI.BunifuCustomDataGrid historyattendView;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}
