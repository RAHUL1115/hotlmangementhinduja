namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectedtabpannel = new System.Windows.Forms.Panel();
            this.checkoutbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.canclebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.homebutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.prebookingbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.currentbookingbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.findbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.find1 = new WindowsFormsApplication1.find();
            this.hometab1 = new WindowsFormsApplication1.hometab();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 93);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(897, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.selectedtabpannel);
            this.panel2.Controls.Add(this.checkoutbutton);
            this.panel2.Controls.Add(this.canclebutton);
            this.panel2.Controls.Add(this.homebutton);
            this.panel2.Controls.Add(this.prebookingbutton);
            this.panel2.Controls.Add(this.currentbookingbutton);
            this.panel2.Controls.Add(this.findbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 476);
            this.panel2.TabIndex = 1;
            // 
            // selectedtabpannel
            // 
            this.selectedtabpannel.BackColor = System.Drawing.SystemColors.Desktop;
            this.selectedtabpannel.Location = new System.Drawing.Point(0, 0);
            this.selectedtabpannel.Name = "selectedtabpannel";
            this.selectedtabpannel.Size = new System.Drawing.Size(10, 48);
            this.selectedtabpannel.TabIndex = 1;
            // 
            // checkoutbutton
            // 
            this.checkoutbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkoutbutton.BorderRadius = 0;
            this.checkoutbutton.ButtonText = "Check Out";
            this.checkoutbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutbutton.DisabledColor = System.Drawing.Color.Gray;
            this.checkoutbutton.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold);
            this.checkoutbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.checkoutbutton.Iconimage = null;
            this.checkoutbutton.Iconimage_right = null;
            this.checkoutbutton.Iconimage_right_Selected = null;
            this.checkoutbutton.Iconimage_Selected = null;
            this.checkoutbutton.IconMarginLeft = 0;
            this.checkoutbutton.IconMarginRight = 0;
            this.checkoutbutton.IconRightVisible = true;
            this.checkoutbutton.IconRightZoom = 0D;
            this.checkoutbutton.IconVisible = true;
            this.checkoutbutton.IconZoom = 90D;
            this.checkoutbutton.IsTab = false;
            this.checkoutbutton.Location = new System.Drawing.Point(0, 240);
            this.checkoutbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkoutbutton.Name = "checkoutbutton";
            this.checkoutbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkoutbutton.OnHovercolor = System.Drawing.Color.DimGray;
            this.checkoutbutton.OnHoverTextColor = System.Drawing.Color.White;
            this.checkoutbutton.selected = false;
            this.checkoutbutton.Size = new System.Drawing.Size(177, 48);
            this.checkoutbutton.TabIndex = 6;
            this.checkoutbutton.Text = "Check Out";
            this.checkoutbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkoutbutton.Textcolor = System.Drawing.Color.White;
            this.checkoutbutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutbutton.Click += new System.EventHandler(this.checkoutbutton_Click);
            // 
            // canclebutton
            // 
            this.canclebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.canclebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.canclebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.canclebutton.BorderRadius = 0;
            this.canclebutton.ButtonText = "Cancle Booking";
            this.canclebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.canclebutton.DisabledColor = System.Drawing.Color.Gray;
            this.canclebutton.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold);
            this.canclebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.canclebutton.Iconimage = null;
            this.canclebutton.Iconimage_right = null;
            this.canclebutton.Iconimage_right_Selected = null;
            this.canclebutton.Iconimage_Selected = null;
            this.canclebutton.IconMarginLeft = 0;
            this.canclebutton.IconMarginRight = 0;
            this.canclebutton.IconRightVisible = true;
            this.canclebutton.IconRightZoom = 0D;
            this.canclebutton.IconVisible = true;
            this.canclebutton.IconZoom = 90D;
            this.canclebutton.IsTab = false;
            this.canclebutton.Location = new System.Drawing.Point(0, 192);
            this.canclebutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.canclebutton.Name = "canclebutton";
            this.canclebutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.canclebutton.OnHovercolor = System.Drawing.Color.DimGray;
            this.canclebutton.OnHoverTextColor = System.Drawing.Color.White;
            this.canclebutton.selected = false;
            this.canclebutton.Size = new System.Drawing.Size(177, 48);
            this.canclebutton.TabIndex = 5;
            this.canclebutton.Text = "Cancle Booking";
            this.canclebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.canclebutton.Textcolor = System.Drawing.Color.White;
            this.canclebutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canclebutton.Click += new System.EventHandler(this.canclebutton_Click);
            // 
            // homebutton
            // 
            this.homebutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homebutton.BorderRadius = 0;
            this.homebutton.ButtonText = "Home";
            this.homebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homebutton.DisabledColor = System.Drawing.Color.Gray;
            this.homebutton.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold);
            this.homebutton.Iconcolor = System.Drawing.Color.Transparent;
            this.homebutton.Iconimage = null;
            this.homebutton.Iconimage_right = null;
            this.homebutton.Iconimage_right_Selected = null;
            this.homebutton.Iconimage_Selected = null;
            this.homebutton.IconMarginLeft = 0;
            this.homebutton.IconMarginRight = 0;
            this.homebutton.IconRightVisible = true;
            this.homebutton.IconRightZoom = 0D;
            this.homebutton.IconVisible = true;
            this.homebutton.IconZoom = 90D;
            this.homebutton.IsTab = false;
            this.homebutton.Location = new System.Drawing.Point(0, 0);
            this.homebutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.homebutton.Name = "homebutton";
            this.homebutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.homebutton.OnHovercolor = System.Drawing.Color.DimGray;
            this.homebutton.OnHoverTextColor = System.Drawing.Color.White;
            this.homebutton.selected = false;
            this.homebutton.Size = new System.Drawing.Size(177, 48);
            this.homebutton.TabIndex = 4;
            this.homebutton.Text = "Home";
            this.homebutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homebutton.Textcolor = System.Drawing.Color.White;
            this.homebutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // prebookingbutton
            // 
            this.prebookingbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prebookingbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prebookingbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prebookingbutton.BorderRadius = 0;
            this.prebookingbutton.ButtonText = "Pre Booking";
            this.prebookingbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prebookingbutton.DisabledColor = System.Drawing.Color.Gray;
            this.prebookingbutton.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold);
            this.prebookingbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.prebookingbutton.Iconimage = null;
            this.prebookingbutton.Iconimage_right = null;
            this.prebookingbutton.Iconimage_right_Selected = null;
            this.prebookingbutton.Iconimage_Selected = null;
            this.prebookingbutton.IconMarginLeft = 0;
            this.prebookingbutton.IconMarginRight = 0;
            this.prebookingbutton.IconRightVisible = true;
            this.prebookingbutton.IconRightZoom = 0D;
            this.prebookingbutton.IconVisible = true;
            this.prebookingbutton.IconZoom = 90D;
            this.prebookingbutton.IsTab = false;
            this.prebookingbutton.Location = new System.Drawing.Point(0, 144);
            this.prebookingbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.prebookingbutton.Name = "prebookingbutton";
            this.prebookingbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prebookingbutton.OnHovercolor = System.Drawing.Color.DimGray;
            this.prebookingbutton.OnHoverTextColor = System.Drawing.Color.White;
            this.prebookingbutton.selected = false;
            this.prebookingbutton.Size = new System.Drawing.Size(177, 48);
            this.prebookingbutton.TabIndex = 3;
            this.prebookingbutton.Text = "Pre Booking";
            this.prebookingbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prebookingbutton.Textcolor = System.Drawing.Color.White;
            this.prebookingbutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prebookingbutton.Click += new System.EventHandler(this.prebookingbutton_Click);
            // 
            // currentbookingbutton
            // 
            this.currentbookingbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currentbookingbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currentbookingbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.currentbookingbutton.BorderRadius = 0;
            this.currentbookingbutton.ButtonText = "Current Booking";
            this.currentbookingbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currentbookingbutton.DisabledColor = System.Drawing.Color.Gray;
            this.currentbookingbutton.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold);
            this.currentbookingbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.currentbookingbutton.Iconimage = null;
            this.currentbookingbutton.Iconimage_right = null;
            this.currentbookingbutton.Iconimage_right_Selected = null;
            this.currentbookingbutton.Iconimage_Selected = null;
            this.currentbookingbutton.IconMarginLeft = 0;
            this.currentbookingbutton.IconMarginRight = 0;
            this.currentbookingbutton.IconRightVisible = true;
            this.currentbookingbutton.IconRightZoom = 0D;
            this.currentbookingbutton.IconVisible = true;
            this.currentbookingbutton.IconZoom = 90D;
            this.currentbookingbutton.IsTab = false;
            this.currentbookingbutton.Location = new System.Drawing.Point(0, 96);
            this.currentbookingbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.currentbookingbutton.Name = "currentbookingbutton";
            this.currentbookingbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.currentbookingbutton.OnHovercolor = System.Drawing.Color.DimGray;
            this.currentbookingbutton.OnHoverTextColor = System.Drawing.Color.White;
            this.currentbookingbutton.selected = false;
            this.currentbookingbutton.Size = new System.Drawing.Size(177, 48);
            this.currentbookingbutton.TabIndex = 2;
            this.currentbookingbutton.Text = "Current Booking";
            this.currentbookingbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.currentbookingbutton.Textcolor = System.Drawing.Color.White;
            this.currentbookingbutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentbookingbutton.Click += new System.EventHandler(this.currentbookingbutton_Click);
            // 
            // findbutton
            // 
            this.findbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.findbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.findbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.findbutton.BorderRadius = 0;
            this.findbutton.ButtonText = "Find";
            this.findbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findbutton.DisabledColor = System.Drawing.Color.Gray;
            this.findbutton.Font = new System.Drawing.Font("Algerian", 10F, System.Drawing.FontStyle.Bold);
            this.findbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.findbutton.Iconimage = null;
            this.findbutton.Iconimage_right = null;
            this.findbutton.Iconimage_right_Selected = null;
            this.findbutton.Iconimage_Selected = null;
            this.findbutton.IconMarginLeft = 0;
            this.findbutton.IconMarginRight = 0;
            this.findbutton.IconRightVisible = true;
            this.findbutton.IconRightZoom = 0D;
            this.findbutton.IconVisible = true;
            this.findbutton.IconZoom = 90D;
            this.findbutton.IsTab = false;
            this.findbutton.Location = new System.Drawing.Point(0, 48);
            this.findbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.findbutton.Name = "findbutton";
            this.findbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.findbutton.OnHovercolor = System.Drawing.Color.DimGray;
            this.findbutton.OnHoverTextColor = System.Drawing.Color.White;
            this.findbutton.selected = false;
            this.findbutton.Size = new System.Drawing.Size(177, 48);
            this.findbutton.TabIndex = 1;
            this.findbutton.Text = "Find";
            this.findbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.findbutton.Textcolor = System.Drawing.Color.White;
            this.findbutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.hometab1);
            this.panel3.Controls.Add(this.find1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(177, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 476);
            this.panel3.TabIndex = 2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // find1
            // 
            this.find1.BackColor = System.Drawing.SystemColors.Window;
            this.find1.Location = new System.Drawing.Point(0, 0);
            this.find1.Name = "find1";
            this.find1.Size = new System.Drawing.Size(750, 476);
            this.find1.TabIndex = 1;
            // 
            // hometab1
            // 
            this.hometab1.BackColor = System.Drawing.SystemColors.Window;
            this.hometab1.Location = new System.Drawing.Point(0, 0);
            this.hometab1.Name = "hometab1";
            this.hometab1.Size = new System.Drawing.Size(750, 476);
            this.hometab1.TabIndex = 0;
            // 
            // mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(927, 569);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "emphome";
            this.Load += new System.EventHandler(this.emphome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel3;
        private hometab hometab1;
        private Bunifu.Framework.UI.BunifuFlatButton findbutton;
        private Bunifu.Framework.UI.BunifuFlatButton prebookingbutton;
        private Bunifu.Framework.UI.BunifuFlatButton currentbookingbutton;
        private Bunifu.Framework.UI.BunifuFlatButton homebutton;
        private Bunifu.Framework.UI.BunifuFlatButton checkoutbutton;
        private Bunifu.Framework.UI.BunifuFlatButton canclebutton;
        private System.Windows.Forms.Panel selectedtabpannel;
        private find find1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}