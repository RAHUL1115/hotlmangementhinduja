namespace WindowsFormsApplication1
{
    partial class canclewin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(canclewin));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cancleroombut = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::WindowsFormsApplication1.Properties.Resources.back;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(28, 28);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 251);
            this.listBox1.TabIndex = 7;
            // 
            // cancleroombut
            // 
            this.cancleroombut.ActiveBorderThickness = 1;
            this.cancleroombut.ActiveCornerRadius = 20;
            this.cancleroombut.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.cancleroombut.ActiveForecolor = System.Drawing.Color.White;
            this.cancleroombut.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.cancleroombut.BackColor = System.Drawing.SystemColors.Control;
            this.cancleroombut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancleroombut.BackgroundImage")));
            this.cancleroombut.ButtonText = "cancle";
            this.cancleroombut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancleroombut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancleroombut.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancleroombut.IdleBorderThickness = 1;
            this.cancleroombut.IdleCornerRadius = 20;
            this.cancleroombut.IdleFillColor = System.Drawing.Color.White;
            this.cancleroombut.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.cancleroombut.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.cancleroombut.Location = new System.Drawing.Point(43, 302);
            this.cancleroombut.Margin = new System.Windows.Forms.Padding(5);
            this.cancleroombut.Name = "cancleroombut";
            this.cancleroombut.Size = new System.Drawing.Size(181, 41);
            this.cancleroombut.TabIndex = 8;
            this.cancleroombut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancleroombut.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // canclewin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancleroombut);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Name = "canclewin";
            this.Size = new System.Drawing.Size(272, 348);
            this.Load += new System.EventHandler(this.canclewin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public System.Windows.Forms.ListBox listBox1;
        public Bunifu.Framework.UI.BunifuThinButton2 cancleroombut;
    }
}
