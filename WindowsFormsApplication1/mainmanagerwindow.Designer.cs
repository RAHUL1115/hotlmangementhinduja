namespace WindowsFormsApplication1
{
    partial class mainmanagerwindow
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
            this.switchacc = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTipbutton = new System.Windows.Forms.ToolTip(this.components);
            this.employees = new Bunifu.Framework.UI.BunifuImageButton();
            this.salary = new Bunifu.Framework.UI.BunifuImageButton();
            this.attendence = new Bunifu.Framework.UI.BunifuImageButton();
            this.reports = new Bunifu.Framework.UI.BunifuImageButton();
            this.reports_win1 = new WindowsFormsApplication1.reports_win();
            this.employee_win1 = new WindowsFormsApplication1.employee_win();
            this.attendance_win1 = new WindowsFormsApplication1.attendance_win();
            this.salary_win1 = new WindowsFormsApplication1.salary_win();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchacc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reports)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(202)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.switchacc);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 114);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1128, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(58, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "rahul";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hotel Continental";
            // 
            // switchacc
            // 
            this.switchacc.BackColor = System.Drawing.Color.Transparent;
            this.switchacc.Image = global::WindowsFormsApplication1.Properties.Resources.switchaccount;
            this.switchacc.ImageActive = null;
            this.switchacc.Location = new System.Drawing.Point(1208, 9);
            this.switchacc.Margin = new System.Windows.Forms.Padding(4);
            this.switchacc.Name = "switchacc";
            this.switchacc.Size = new System.Drawing.Size(36, 32);
            this.switchacc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.switchacc.TabIndex = 3;
            this.switchacc.TabStop = false;
            this.switchacc.Zoom = 10;
            this.switchacc.Click += new System.EventHandler(this.switchacc_click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = global::WindowsFormsApplication1.Properties.Resources.shutdown;
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(1252, 9);
            this.close.Margin = new System.Windows.Forms.Padding(4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(36, 32);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_click);
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
            // employees
            // 
            this.employees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(209)))));
            this.employees.Image = global::WindowsFormsApplication1.Properties.Resources.emp;
            this.employees.ImageActive = null;
            this.employees.Location = new System.Drawing.Point(547, 436);
            this.employees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(229, 193);
            this.employees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employees.TabIndex = 5;
            this.employees.TabStop = false;
            this.toolTipbutton.SetToolTip(this.employees, "Employee");
            this.employees.Zoom = 10;
            this.employees.Click += new System.EventHandler(this.employees_Click);
            // 
            // salary
            // 
            this.salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(209)))));
            this.salary.Image = global::WindowsFormsApplication1.Properties.Resources.payroll1;
            this.salary.ImageActive = null;
            this.salary.Location = new System.Drawing.Point(993, 162);
            this.salary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(229, 193);
            this.salary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.salary.TabIndex = 4;
            this.salary.TabStop = false;
            this.toolTipbutton.SetToolTip(this.salary, "Payroll");
            this.salary.Zoom = 10;
            this.salary.Click += new System.EventHandler(this.salary_Click);
            // 
            // attendence
            // 
            this.attendence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(209)))));
            this.attendence.Image = global::WindowsFormsApplication1.Properties.Resources.attend;
            this.attendence.ImageActive = null;
            this.attendence.Location = new System.Drawing.Point(547, 162);
            this.attendence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.attendence.Name = "attendence";
            this.attendence.Size = new System.Drawing.Size(229, 193);
            this.attendence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.attendence.TabIndex = 3;
            this.attendence.TabStop = false;
            this.toolTipbutton.SetToolTip(this.attendence, "Attendence");
            this.attendence.Zoom = 10;
            this.attendence.Click += new System.EventHandler(this.attendence_Click);
            // 
            // reports
            // 
            this.reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(209)))));
            this.reports.Image = global::WindowsFormsApplication1.Properties.Resources.report;
            this.reports.ImageActive = null;
            this.reports.Location = new System.Drawing.Point(104, 162);
            this.reports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(229, 193);
            this.reports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reports.TabIndex = 2;
            this.reports.TabStop = false;
            this.toolTipbutton.SetToolTip(this.reports, "Reports");
            this.reports.Zoom = 10;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // reports_win1
            // 
            this.reports_win1.BackColor = System.Drawing.Color.Transparent;
            this.reports_win1.Location = new System.Drawing.Point(0, 108);
            this.reports_win1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reports_win1.Name = "reports_win1";
            this.reports_win1.Size = new System.Drawing.Size(1296, 632);
            this.reports_win1.TabIndex = 7;
            this.toolTipbutton.SetToolTip(this.reports_win1, "Attendence");
            this.reports_win1.Visible = false;
            // 
            // employee_win1
            // 
            this.employee_win1.Location = new System.Drawing.Point(0, 114);
            this.employee_win1.Margin = new System.Windows.Forms.Padding(5);
            this.employee_win1.Name = "employee_win1";
            this.employee_win1.Size = new System.Drawing.Size(1296, 626);
            this.employee_win1.TabIndex = 10;
            this.employee_win1.Visible = false;
            // 
            // attendance_win1
            // 
            this.attendance_win1.Location = new System.Drawing.Point(0, 116);
            this.attendance_win1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.attendance_win1.Name = "attendance_win1";
            this.attendance_win1.Size = new System.Drawing.Size(1296, 626);
            this.attendance_win1.TabIndex = 8;
            this.attendance_win1.Visible = false;
            // 
            // salary_win1
            // 
            this.salary_win1.Location = new System.Drawing.Point(0, 114);
            this.salary_win1.Margin = new System.Windows.Forms.Padding(5);
            this.salary_win1.Name = "salary_win1";
            this.salary_win1.Size = new System.Drawing.Size(1296, 626);
            this.salary_win1.TabIndex = 9;
            this.salary_win1.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this.reports;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this.attendence;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 25;
            this.bunifuElipse3.TargetControl = this.salary;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 25;
            this.bunifuElipse4.TargetControl = this.employees;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 10;
            this.bunifuElipse5.TargetControl = this;
            // 
            // mainmanagerwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1296, 740);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.attendence);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reports_win1);
            this.Controls.Add(this.attendance_win1);
            this.Controls.Add(this.salary_win1);
            this.Controls.Add(this.employee_win1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainmanagerwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainmanagerwindow";
            this.Load += new System.EventHandler(this.mainmanagerwindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchacc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton switchacc;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton reports;
        private Bunifu.Framework.UI.BunifuImageButton attendence;
        private Bunifu.Framework.UI.BunifuImageButton salary;
        private Bunifu.Framework.UI.BunifuImageButton employees;
        private System.Windows.Forms.ToolTip toolTipbutton;
        private attendance_win attendance_win1;
        private salary_win salary_win1;
        private employee_win employee_win1;
        public reports_win reports_win1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
    }
}