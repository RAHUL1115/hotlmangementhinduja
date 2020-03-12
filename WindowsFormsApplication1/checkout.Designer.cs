namespace WindowsFormsApplication1
{
    partial class checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkout));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.MainCheckoutButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label4 = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.discounttextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.amountlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.roomlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.slabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuCards1.SuspendLayout();
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
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // MainCheckoutButton
            // 
            this.MainCheckoutButton.ActiveBorderThickness = 1;
            this.MainCheckoutButton.ActiveCornerRadius = 20;
            this.MainCheckoutButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.MainCheckoutButton.ActiveForecolor = System.Drawing.Color.Black;
            this.MainCheckoutButton.ActiveLineColor = System.Drawing.Color.Black;
            this.MainCheckoutButton.BackColor = System.Drawing.SystemColors.Control;
            this.MainCheckoutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainCheckoutButton.BackgroundImage")));
            this.MainCheckoutButton.ButtonText = "Check Out";
            this.MainCheckoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainCheckoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainCheckoutButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.MainCheckoutButton.IdleBorderThickness = 1;
            this.MainCheckoutButton.IdleCornerRadius = 20;
            this.MainCheckoutButton.IdleFillColor = System.Drawing.Color.White;
            this.MainCheckoutButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.MainCheckoutButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.MainCheckoutButton.Location = new System.Drawing.Point(180, 255);
            this.MainCheckoutButton.Margin = new System.Windows.Forms.Padding(5);
            this.MainCheckoutButton.Name = "MainCheckoutButton";
            this.MainCheckoutButton.Size = new System.Drawing.Size(125, 39);
            this.MainCheckoutButton.TabIndex = 91;
            this.MainCheckoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainCheckoutButton.Click += new System.EventHandler(this.MainCheckoutButton_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.slabel);
            this.bunifuCards1.Controls.Add(this.label7);
            this.bunifuCards1.Controls.Add(this.totallabel);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.label9);
            this.bunifuCards1.Controls.Add(this.discounttextbox);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.amountlabel);
            this.bunifuCards1.Controls.Add(this.label6);
            this.bunifuCards1.Controls.Add(this.namelabel);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.roomlabel);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(12, 86);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(459, 161);
            this.bunifuCards1.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 112;
            this.label4.Text = "%";
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallabel.Location = new System.Drawing.Point(364, 107);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(36, 16);
            this.totallabel.TabIndex = 111;
            this.totallabel.Text = "2000";
            this.totallabel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(245, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 110;
            this.label9.Text = "Total : ";
            // 
            // discounttextbox
            // 
            this.discounttextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.discounttextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.discounttextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.discounttextbox.HintForeColor = System.Drawing.Color.Empty;
            this.discounttextbox.HintText = "";
            this.discounttextbox.isPassword = false;
            this.discounttextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.discounttextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.discounttextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.discounttextbox.LineThickness = 3;
            this.discounttextbox.Location = new System.Drawing.Point(117, 98);
            this.discounttextbox.Margin = new System.Windows.Forms.Padding(4);
            this.discounttextbox.Name = "discounttextbox";
            this.discounttextbox.Size = new System.Drawing.Size(59, 33);
            this.discounttextbox.TabIndex = 109;
            this.discounttextbox.Text = "0";
            this.discounttextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.discounttextbox.OnValueChanged += new System.EventHandler(this.discounttextbox_OnValueChanged_1);
            // 
            // amountlabel
            // 
            this.amountlabel.AutoSize = true;
            this.amountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlabel.Location = new System.Drawing.Point(358, 41);
            this.amountlabel.Name = "amountlabel";
            this.amountlabel.Size = new System.Drawing.Size(105, 16);
            this.amountlabel.TabIndex = 108;
            this.amountlabel.Text = "Room Number : ";
            this.amountlabel.Visible = false;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(114, 73);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(105, 16);
            this.namelabel.TabIndex = 107;
            this.namelabel.Text = "Room Number : ";
            this.namelabel.Visible = false;
            // 
            // roomlabel
            // 
            this.roomlabel.AutoSize = true;
            this.roomlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomlabel.Location = new System.Drawing.Point(114, 41);
            this.roomlabel.Name = "roomlabel";
            this.roomlabel.Size = new System.Drawing.Size(105, 16);
            this.roomlabel.TabIndex = 106;
            this.roomlabel.Text = "Room Number : ";
            this.roomlabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 105;
            this.label3.Text = "Discount : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 104;
            this.label2.Text = "Amount : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 103;
            this.label1.Text = "Name : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 102;
            this.label6.Text = "Room Number : ";
            // 
            // slabel
            // 
            this.slabel.AutoSize = true;
            this.slabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slabel.Location = new System.Drawing.Point(358, 73);
            this.slabel.Name = "slabel";
            this.slabel.Size = new System.Drawing.Size(105, 16);
            this.slabel.TabIndex = 114;
            this.slabel.Text = "Room Number : ";
            this.slabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 113;
            this.label7.Text = "Service charges : ";
            // 
            // checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainCheckoutButton);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "checkout";
            this.Size = new System.Drawing.Size(487, 327);
            this.Load += new System.EventHandler(this.checkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public Bunifu.Framework.UI.BunifuThinButton2 MainCheckoutButton;
        public Bunifu.Framework.UI.BunifuCards bunifuCards1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label totallabel;
        public System.Windows.Forms.Label label9;
        public Bunifu.Framework.UI.BunifuMaterialTextbox discounttextbox;
        public System.Windows.Forms.Label amountlabel;
        public System.Windows.Forms.Label namelabel;
        public System.Windows.Forms.Label roomlabel;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label slabel;
        public System.Windows.Forms.Label label7;
    }
}
