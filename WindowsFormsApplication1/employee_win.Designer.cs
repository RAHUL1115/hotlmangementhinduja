namespace WindowsFormsApplication1
{
    partial class employee_win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee_win));
            this.back = new Bunifu.Framework.UI.BunifuImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fullnametextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.emailtextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passtextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.idtextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.AddEmpButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EmpName = new Bunifu.Framework.UI.BunifuDropdown();
            this.label7 = new System.Windows.Forms.Label();
            this.RemoveEmpButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addrestextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
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
            this.back.TabIndex = 69;
            this.back.TabStop = false;
            this.back.Zoom = 10;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 77;
            this.label4.Text = "E-mail : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 76;
            this.label3.Text = "Password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 75;
            this.label2.Text = "Full Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "ID : ";
            // 
            // fullnametextbox
            // 
            this.fullnametextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullnametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.fullnametextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullnametextbox.HintForeColor = System.Drawing.Color.Empty;
            this.fullnametextbox.HintText = "";
            this.fullnametextbox.isPassword = false;
            this.fullnametextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.fullnametextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.fullnametextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.fullnametextbox.LineThickness = 3;
            this.fullnametextbox.Location = new System.Drawing.Point(258, 245);
            this.fullnametextbox.Margin = new System.Windows.Forms.Padding(5);
            this.fullnametextbox.Name = "fullnametextbox";
            this.fullnametextbox.Size = new System.Drawing.Size(493, 54);
            this.fullnametextbox.TabIndex = 73;
            this.fullnametextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // emailtextbox
            // 
            this.emailtextbox.AutoScroll = true;
            this.emailtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.emailtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailtextbox.HintForeColor = System.Drawing.Color.Empty;
            this.emailtextbox.HintText = "";
            this.emailtextbox.isPassword = false;
            this.emailtextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.emailtextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.emailtextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.emailtextbox.LineThickness = 3;
            this.emailtextbox.Location = new System.Drawing.Point(258, 175);
            this.emailtextbox.Margin = new System.Windows.Forms.Padding(5);
            this.emailtextbox.Name = "emailtextbox";
            this.emailtextbox.Size = new System.Drawing.Size(493, 54);
            this.emailtextbox.TabIndex = 72;
            this.emailtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passtextbox
            // 
            this.passtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.passtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passtextbox.HintForeColor = System.Drawing.Color.Empty;
            this.passtextbox.HintText = "";
            this.passtextbox.isPassword = false;
            this.passtextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.passtextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.passtextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passtextbox.LineThickness = 3;
            this.passtextbox.Location = new System.Drawing.Point(258, 111);
            this.passtextbox.Margin = new System.Windows.Forms.Padding(5);
            this.passtextbox.Name = "passtextbox";
            this.passtextbox.Size = new System.Drawing.Size(493, 54);
            this.passtextbox.TabIndex = 71;
            this.passtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // idtextbox
            // 
            this.idtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.idtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idtextbox.HintForeColor = System.Drawing.Color.Empty;
            this.idtextbox.HintText = "";
            this.idtextbox.isPassword = false;
            this.idtextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.idtextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.idtextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.idtextbox.LineThickness = 3;
            this.idtextbox.Location = new System.Drawing.Point(259, 49);
            this.idtextbox.Margin = new System.Windows.Forms.Padding(5);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(493, 54);
            this.idtextbox.TabIndex = 70;
            this.idtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 412);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 80;
            this.label5.Text = "Date of Birth : ";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(258, 398);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 81;
            // 
            // AddEmpButton
            // 
            this.AddEmpButton.ActiveBorderThickness = 1;
            this.AddEmpButton.ActiveCornerRadius = 20;
            this.AddEmpButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.AddEmpButton.ActiveForecolor = System.Drawing.Color.Black;
            this.AddEmpButton.ActiveLineColor = System.Drawing.Color.Black;
            this.AddEmpButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddEmpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddEmpButton.BackgroundImage")));
            this.AddEmpButton.ButtonText = "Save";
            this.AddEmpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmpButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddEmpButton.IdleBorderThickness = 1;
            this.AddEmpButton.IdleCornerRadius = 20;
            this.AddEmpButton.IdleFillColor = System.Drawing.Color.White;
            this.AddEmpButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.AddEmpButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.AddEmpButton.Location = new System.Drawing.Point(579, 543);
            this.AddEmpButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.AddEmpButton.Name = "AddEmpButton";
            this.AddEmpButton.Size = new System.Drawing.Size(167, 49);
            this.AddEmpButton.TabIndex = 82;
            this.AddEmpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddEmpButton.Click += new System.EventHandler(this.AddEmpButton_Click);
            // 
            // EmpName
            // 
            this.EmpName.BackColor = System.Drawing.Color.Transparent;
            this.EmpName.BorderRadius = 3;
            this.EmpName.ForeColor = System.Drawing.Color.Black;
            this.EmpName.Items = new string[0];
            this.EmpName.Location = new System.Drawing.Point(976, 81);
            this.EmpName.Margin = new System.Windows.Forms.Padding(5);
            this.EmpName.Name = "EmpName";
            this.EmpName.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.EmpName.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.EmpName.selectedIndex = -1;
            this.EmpName.Size = new System.Drawing.Size(262, 43);
            this.EmpName.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(841, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 83;
            this.label7.Text = "Employee : ";
            // 
            // RemoveEmpButton
            // 
            this.RemoveEmpButton.ActiveBorderThickness = 1;
            this.RemoveEmpButton.ActiveCornerRadius = 20;
            this.RemoveEmpButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.RemoveEmpButton.ActiveForecolor = System.Drawing.Color.Black;
            this.RemoveEmpButton.ActiveLineColor = System.Drawing.Color.Black;
            this.RemoveEmpButton.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveEmpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveEmpButton.BackgroundImage")));
            this.RemoveEmpButton.ButtonText = "Remove";
            this.RemoveEmpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveEmpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveEmpButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.RemoveEmpButton.IdleBorderThickness = 1;
            this.RemoveEmpButton.IdleCornerRadius = 20;
            this.RemoveEmpButton.IdleFillColor = System.Drawing.Color.White;
            this.RemoveEmpButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.RemoveEmpButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.RemoveEmpButton.Location = new System.Drawing.Point(945, 153);
            this.RemoveEmpButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.RemoveEmpButton.Name = "RemoveEmpButton";
            this.RemoveEmpButton.Size = new System.Drawing.Size(167, 49);
            this.RemoveEmpButton.TabIndex = 85;
            this.RemoveEmpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RemoveEmpButton.Click += new System.EventHandler(this.RemoveEmpButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(304, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 25);
            this.label8.TabIndex = 86;
            this.label8.Text = "Add Employee";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(921, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 25);
            this.label9.TabIndex = 87;
            this.label9.Text = "Remove Employee";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(90, 330);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 25);
            this.label10.TabIndex = 89;
            this.label10.Text = "Address : ";
            // 
            // addrestextbox
            // 
            this.addrestextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addrestextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.addrestextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addrestextbox.HintForeColor = System.Drawing.Color.Empty;
            this.addrestextbox.HintText = "";
            this.addrestextbox.isPassword = false;
            this.addrestextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.addrestextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.addrestextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.addrestextbox.LineThickness = 3;
            this.addrestextbox.Location = new System.Drawing.Point(258, 309);
            this.addrestextbox.Margin = new System.Windows.Forms.Padding(5);
            this.addrestextbox.Name = "addrestextbox";
            this.addrestextbox.Size = new System.Drawing.Size(493, 54);
            this.addrestextbox.TabIndex = 88;
            this.addrestextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // employee_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.addrestextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RemoveEmpButton);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddEmpButton);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fullnametextbox);
            this.Controls.Add(this.emailtextbox);
            this.Controls.Add(this.passtextbox);
            this.Controls.Add(this.idtextbox);
            this.Controls.Add(this.back);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "employee_win";
            this.Size = new System.Drawing.Size(1296, 626);
            this.Load += new System.EventHandler(this.employee_win_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuImageButton back;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox fullnametextbox;
        public Bunifu.Framework.UI.BunifuMaterialTextbox emailtextbox;
        public Bunifu.Framework.UI.BunifuMaterialTextbox passtextbox;
        public Bunifu.Framework.UI.BunifuMaterialTextbox idtextbox;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        public Bunifu.Framework.UI.BunifuThinButton2 AddEmpButton;
        private Bunifu.Framework.UI.BunifuDropdown EmpName;
        public System.Windows.Forms.Label label7;
        public Bunifu.Framework.UI.BunifuThinButton2 RemoveEmpButton;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public Bunifu.Framework.UI.BunifuMaterialTextbox addrestextbox;
    }
}
