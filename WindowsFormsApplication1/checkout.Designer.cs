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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roomlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.amountlabel = new System.Windows.Forms.Label();
            this.discounttextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.totallabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MainCheckoutButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
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
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 20);
            this.label6.TabIndex = 81;
            this.label6.Text = "Room Number : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 83;
            this.label2.Text = "Amount : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Discount : ";
            // 
            // roomlabel
            // 
            this.roomlabel.AutoSize = true;
            this.roomlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomlabel.Location = new System.Drawing.Point(136, 66);
            this.roomlabel.Name = "roomlabel";
            this.roomlabel.Size = new System.Drawing.Size(138, 20);
            this.roomlabel.TabIndex = 85;
            this.roomlabel.Text = "Room Number : ";
            this.roomlabel.Visible = false;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(136, 105);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(138, 20);
            this.namelabel.TabIndex = 86;
            this.namelabel.Text = "Room Number : ";
            this.namelabel.Visible = false;
            // 
            // amountlabel
            // 
            this.amountlabel.AutoSize = true;
            this.amountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlabel.Location = new System.Drawing.Point(134, 149);
            this.amountlabel.Name = "amountlabel";
            this.amountlabel.Size = new System.Drawing.Size(138, 20);
            this.amountlabel.TabIndex = 87;
            this.amountlabel.Text = "Room Number : ";
            this.amountlabel.Visible = false;
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
            this.discounttextbox.Location = new System.Drawing.Point(140, 178);
            this.discounttextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.discounttextbox.Name = "discounttextbox";
            this.discounttextbox.Size = new System.Drawing.Size(59, 33);
            this.discounttextbox.TabIndex = 88;
            this.discounttextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallabel.Location = new System.Drawing.Point(134, 236);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(49, 20);
            this.totallabel.TabIndex = 90;
            this.totallabel.Text = "2000";
            this.totallabel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 89;
            this.label9.Text = "Total : ";
            // 
            // MainCheckoutButton
            // 
            this.MainCheckoutButton.ActiveBorderThickness = 1;
            this.MainCheckoutButton.ActiveCornerRadius = 20;
            this.MainCheckoutButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.MainCheckoutButton.ActiveForecolor = System.Drawing.Color.White;
            this.MainCheckoutButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
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
            this.MainCheckoutButton.Location = new System.Drawing.Point(64, 281);
            this.MainCheckoutButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MainCheckoutButton.Name = "MainCheckoutButton";
            this.MainCheckoutButton.Size = new System.Drawing.Size(125, 39);
            this.MainCheckoutButton.TabIndex = 91;
            this.MainCheckoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainCheckoutButton.Click += new System.EventHandler(this.MainCheckoutButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 92;
            this.label4.Text = "%";
            // 
            // checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MainCheckoutButton);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.discounttextbox);
            this.Controls.Add(this.amountlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.roomlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuImageButton1);
            this.Name = "checkout";
            this.Size = new System.Drawing.Size(272, 348);
            this.Load += new System.EventHandler(this.checkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label roomlabel;
        public System.Windows.Forms.Label namelabel;
        public System.Windows.Forms.Label amountlabel;
        public Bunifu.Framework.UI.BunifuMaterialTextbox discounttextbox;
        public System.Windows.Forms.Label totallabel;
        public System.Windows.Forms.Label label9;
        public Bunifu.Framework.UI.BunifuThinButton2 MainCheckoutButton;
        public System.Windows.Forms.Label label4;
    }
}
