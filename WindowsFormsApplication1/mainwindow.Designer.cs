﻿namespace WindowsFormsApplication1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.user_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.switchbutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.exitbutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.hometab1 = new WindowsFormsApplication1.hometab();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitbutton)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.user_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.switchbutton);
            this.panel1.Controls.Add(this.exitbutton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 93);
            this.panel1.TabIndex = 0;
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(861, 15);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(47, 21);
            this.user_name.TabIndex = 5;
            this.user_name.Text = "rahul";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hotel Management System";
            // 
            // switchbutton
            // 
            this.switchbutton.BackColor = System.Drawing.Color.Transparent;
            this.switchbutton.Image = global::WindowsFormsApplication1.Properties.Resources.switchaccount;
            this.switchbutton.ImageActive = null;
            this.switchbutton.Location = new System.Drawing.Point(916, 12);
            this.switchbutton.Name = "switchbutton";
            this.switchbutton.Size = new System.Drawing.Size(27, 26);
            this.switchbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.switchbutton.TabIndex = 3;
            this.switchbutton.TabStop = false;
            this.switchbutton.Zoom = 10;
            this.switchbutton.Click += new System.EventHandler(this.switchbutton_click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Transparent;
            this.exitbutton.Image = global::WindowsFormsApplication1.Properties.Resources.shutdown;
            this.exitbutton.ImageActive = null;
            this.exitbutton.Location = new System.Drawing.Point(949, 12);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(27, 26);
            this.exitbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitbutton.TabIndex = 2;
            this.exitbutton.TabStop = false;
            this.exitbutton.Zoom = 10;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 36);
            this.label2.TabIndex = 1;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.hometab1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(988, 552);
            this.panel3.TabIndex = 2;
            // 
            // hometab1
            // 
            this.hometab1.BackColor = System.Drawing.SystemColors.Window;
            this.hometab1.Location = new System.Drawing.Point(0, 0);
            this.hometab1.Margin = new System.Windows.Forms.Padding(4);
            this.hometab1.Name = "hometab1";
            this.hometab1.Size = new System.Drawing.Size(998, 552);
            this.hometab1.TabIndex = 0;
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(988, 640);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emphome";
            this.Load += new System.EventHandler(this.mainwindow_load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitbutton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton exitbutton;
        private Bunifu.Framework.UI.BunifuImageButton switchbutton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Panel panel3;
        private hometab hometab1;
    }
}