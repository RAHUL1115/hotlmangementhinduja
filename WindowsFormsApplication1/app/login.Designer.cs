﻿namespace WindowsFormsApplication1
{
    partial class loginwindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.logintxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.forget = new System.Windows.Forms.Label();
            this.databaseloading = new WindowsFormsApplication1.loadingcontrol();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.forget1 = new WindowsFormsApplication1.forget();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipseform = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipsebutton = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(128, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "header";
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 134);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.user1;
            this.pictureBox3.Location = new System.Drawing.Point(123, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(91, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::WindowsFormsApplication1.Properties.Resources.shutdown;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(281, 15);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // logintxt
            // 
            this.logintxt.BackColor = System.Drawing.Color.White;
            this.logintxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logintxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logintxt.Location = new System.Drawing.Point(80, 53);
            this.logintxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logintxt.Name = "logintxt";
            this.logintxt.Size = new System.Drawing.Size(221, 29);
            this.logintxt.TabIndex = 1;
            // 
            // passtxt
            // 
            this.passtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.Location = new System.Drawing.Point(81, 116);
            this.passtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passtxt.MaxLength = 30;
            this.passtxt.Name = "passtxt";
            this.passtxt.ShortcutsEnabled = false;
            this.passtxt.Size = new System.Drawing.Size(225, 29);
            this.passtxt.TabIndex = 2;
            this.passtxt.UseSystemPasswordChar = true;
            this.passtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passtxt_KeyDown);
            // 
            // loginbutton
            // 
            this.loginbutton.AutoEllipsis = true;
            this.loginbutton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.loginbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginbutton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginbutton.FlatAppearance.BorderSize = 0;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.Location = new System.Drawing.Point(27, 190);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(280, 38);
            this.loginbutton.TabIndex = 5;
            this.loginbutton.Text = "LogIn";
            this.loginbutton.UseMnemonic = false;
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.forget);
            this.panel2.Controls.Add(this.databaseloading);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.loginbutton);
            this.panel2.Controls.Add(this.passtxt);
            this.panel2.Controls.Add(this.logintxt);
            this.panel2.Controls.Add(this.forget1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 295);
            this.panel2.TabIndex = 6;
            // 
            // forget
            // 
            this.forget.AutoSize = true;
            this.forget.Location = new System.Drawing.Point(193, 231);
            this.forget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forget.Name = "forget";
            this.forget.Size = new System.Drawing.Size(113, 17);
            this.forget.TabIndex = 11;
            this.forget.Text = "Forget password";
            this.forget.Click += new System.EventHandler(this.forget_Click);
            // 
            // databaseloading
            // 
            this.databaseloading.BackColor = System.Drawing.Color.Black;
            this.databaseloading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.databaseloading.Location = new System.Drawing.Point(11, 69);
            this.databaseloading.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.databaseloading.Name = "databaseloading";
            this.databaseloading.Size = new System.Drawing.Size(311, 113);
            this.databaseloading.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.password1;
            this.pictureBox2.Location = new System.Drawing.Point(33, 114);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(32, 154);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 2);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(32, 92);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 2);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.user2;
            this.pictureBox1.Location = new System.Drawing.Point(32, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // forget1
            // 
            this.forget1.BackColor = System.Drawing.Color.White;
            this.forget1.Location = new System.Drawing.Point(0, 15);
            this.forget1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.forget1.Name = "forget1";
            this.forget1.Size = new System.Drawing.Size(335, 281);
            this.forget1.TabIndex = 12;
            this.forget1.Visible = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipseform
            // 
            this.bunifuElipseform.ElipseRadius = 20;
            this.bunifuElipseform.TargetControl = this;
            // 
            // bunifuElipsebutton
            // 
            this.bunifuElipsebutton.ElipseRadius = 10;
            this.bunifuElipsebutton.TargetControl = this.loginbutton;
            // 
            // loginwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(336, 416);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "loginwindow";
            this.Padding = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hotel Managment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox logintxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipseform;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipsebutton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private loadingcontrol databaseloading;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label forget;
        private forget forget1;
    }
}

