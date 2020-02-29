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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salary_win));
            this.back = new Bunifu.Framework.UI.BunifuImageButton();
            this.post = new Bunifu.Framework.UI.BunifuDropdown();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salarytextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bonustextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.PayButton = new Bunifu.Framework.UI.BunifuThinButton2();
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
            // post
            // 
            this.post.BackColor = System.Drawing.Color.Transparent;
            this.post.BorderRadius = 3;
            this.post.ForeColor = System.Drawing.Color.White;
            this.post.Items = new string[] {
        "Employee",
        "Manager"};
            this.post.Location = new System.Drawing.Point(663, 130);
            this.post.Margin = new System.Windows.Forms.Padding(5);
            this.post.Name = "post";
            this.post.NomalColor = System.Drawing.SystemColors.AppWorkspace;
            this.post.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.post.selectedIndex = -1;
            this.post.Size = new System.Drawing.Size(264, 42);
            this.post.TabIndex = 81;
            this.post.onItemSelected += new System.EventHandler(this.post_onItemSelected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 25);
            this.label6.TabIndex = 80;
            this.label6.Text = "Employee Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "Salary : ";
            // 
            // salarytextbox
            // 
            this.salarytextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salarytextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.salarytextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salarytextbox.HintForeColor = System.Drawing.Color.Empty;
            this.salarytextbox.HintText = "";
            this.salarytextbox.isPassword = false;
            this.salarytextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.salarytextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.salarytextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.salarytextbox.LineThickness = 3;
            this.salarytextbox.Location = new System.Drawing.Point(663, 193);
            this.salarytextbox.Margin = new System.Windows.Forms.Padding(5);
            this.salarytextbox.Name = "salarytextbox";
            this.salarytextbox.Size = new System.Drawing.Size(264, 53);
            this.salarytextbox.TabIndex = 83;
            this.salarytextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bonustextbox
            // 
            this.bonustextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bonustextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bonustextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bonustextbox.HintForeColor = System.Drawing.Color.Empty;
            this.bonustextbox.HintText = "";
            this.bonustextbox.isPassword = false;
            this.bonustextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.bonustextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.bonustextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bonustextbox.LineThickness = 3;
            this.bonustextbox.Location = new System.Drawing.Point(663, 271);
            this.bonustextbox.Margin = new System.Windows.Forms.Padding(5);
            this.bonustextbox.Name = "bonustextbox";
            this.bonustextbox.Size = new System.Drawing.Size(264, 53);
            this.bonustextbox.TabIndex = 85;
            this.bonustextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 299);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 84;
            this.label2.Text = "Bonus : ";
            // 
            // PayButton
            // 
            this.PayButton.ActiveBorderThickness = 1;
            this.PayButton.ActiveCornerRadius = 20;
            this.PayButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.PayButton.ActiveForecolor = System.Drawing.Color.White;
            this.PayButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.PayButton.BackColor = System.Drawing.SystemColors.Control;
            this.PayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PayButton.BackgroundImage")));
            this.PayButton.ButtonText = "Pay";
            this.PayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.PayButton.IdleBorderThickness = 1;
            this.PayButton.IdleCornerRadius = 20;
            this.PayButton.IdleFillColor = System.Drawing.Color.White;
            this.PayButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.PayButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.PayButton.Location = new System.Drawing.Point(588, 381);
            this.PayButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(167, 48);
            this.PayButton.TabIndex = 86;
            this.PayButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salary_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.bonustextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salarytextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.post);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.back);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "salary_win";
            this.Size = new System.Drawing.Size(1296, 626);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuImageButton back;
        private Bunifu.Framework.UI.BunifuDropdown post;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMaterialTextbox salarytextbox;
        public Bunifu.Framework.UI.BunifuMaterialTextbox bonustextbox;
        public System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuThinButton2 PayButton;
    }
}
