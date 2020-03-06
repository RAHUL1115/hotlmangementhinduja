namespace WindowsFormsApplication1
{
    partial class findwindow
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
            this.findsearchbutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.findtextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.findView = new System.Windows.Forms.DataGridView();
            this.tableselect = new Bunifu.Framework.UI.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.findsearchbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findView)).BeginInit();
            this.SuspendLayout();
            // 
            // findsearchbutton
            // 
            this.findsearchbutton.BackColor = System.Drawing.Color.Transparent;
            this.findsearchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.findsearchbutton.Image = global::WindowsFormsApplication1.Properties.Resources.search;
            this.findsearchbutton.ImageActive = null;
            this.findsearchbutton.Location = new System.Drawing.Point(579, 31);
            this.findsearchbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findsearchbutton.Name = "findsearchbutton";
            this.findsearchbutton.Size = new System.Drawing.Size(43, 37);
            this.findsearchbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.findsearchbutton.TabIndex = 68;
            this.findsearchbutton.TabStop = false;
            this.findsearchbutton.Zoom = 10;
            this.findsearchbutton.Click += new System.EventHandler(this.findsearchbutton_Click);
            // 
            // findtextbox
            // 
            this.findtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.findtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.findtextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.findtextbox.HintForeColor = System.Drawing.Color.Empty;
            this.findtextbox.HintText = "";
            this.findtextbox.isPassword = false;
            this.findtextbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.findtextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.findtextbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.findtextbox.LineThickness = 3;
            this.findtextbox.Location = new System.Drawing.Point(67, 20);
            this.findtextbox.Margin = new System.Windows.Forms.Padding(5);
            this.findtextbox.Name = "findtextbox";
            this.findtextbox.Size = new System.Drawing.Size(560, 54);
            this.findtextbox.TabIndex = 67;
            this.findtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.findtextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.findtextbox_KeyDown);
            // 
            // findView
            // 
            this.findView.AllowUserToAddRows = false;
            this.findView.AllowUserToDeleteRows = false;
            this.findView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.findView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.findView.Location = new System.Drawing.Point(56, 98);
            this.findView.Name = "findView";
            this.findView.ReadOnly = true;
            this.findView.RowHeadersWidth = 51;
            this.findView.RowTemplate.Height = 24;
            this.findView.Size = new System.Drawing.Size(1211, 551);
            this.findView.TabIndex = 69;
            this.findView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.findView_KeyDown);
            // 
            // tableselect
            // 
            this.tableselect.BackColor = System.Drawing.Color.Transparent;
            this.tableselect.BorderRadius = 3;
            this.tableselect.ForeColor = System.Drawing.Color.Black;
            this.tableselect.Items = new string[] {
        "Current Bookings",
        "Pre Bookings",
        "History"};
            this.tableselect.Location = new System.Drawing.Point(649, 42);
            this.tableselect.Margin = new System.Windows.Forms.Padding(5);
            this.tableselect.Name = "tableselect";
            this.tableselect.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.tableselect.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.tableselect.selectedIndex = 0;
            this.tableselect.Size = new System.Drawing.Size(201, 32);
            this.tableselect.TabIndex = 70;
            // 
            // findwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableselect);
            this.Controls.Add(this.findView);
            this.Controls.Add(this.findsearchbutton);
            this.Controls.Add(this.findtextbox);
            this.Name = "findwindow";
            this.Size = new System.Drawing.Size(1331, 679);
            this.Load += new System.EventHandler(this.findwindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.findsearchbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton findsearchbutton;
        public Bunifu.Framework.UI.BunifuMaterialTextbox findtextbox;
        private System.Windows.Forms.DataGridView findView;
        private Bunifu.Framework.UI.BunifuDropdown tableselect;
    }
}
