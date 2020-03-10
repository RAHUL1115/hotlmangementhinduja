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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.findsearchbutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.findtextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tableselect = new Bunifu.Framework.UI.BunifuDropdown();
            this.findView2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.findsearchbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.findView2)).BeginInit();
            this.SuspendLayout();
            // 
            // findsearchbutton
            // 
            this.findsearchbutton.BackColor = System.Drawing.Color.Transparent;
            this.findsearchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.findsearchbutton.Image = global::WindowsFormsApplication1.Properties.Resources.search;
            this.findsearchbutton.ImageActive = null;
            this.findsearchbutton.Location = new System.Drawing.Point(434, 25);
            this.findsearchbutton.Margin = new System.Windows.Forms.Padding(2);
            this.findsearchbutton.Name = "findsearchbutton";
            this.findsearchbutton.Size = new System.Drawing.Size(32, 30);
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
            this.findtextbox.Location = new System.Drawing.Point(50, 16);
            this.findtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.findtextbox.Name = "findtextbox";
            this.findtextbox.Size = new System.Drawing.Size(420, 44);
            this.findtextbox.TabIndex = 67;
            this.findtextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.findtextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.findtextbox_KeyDown);
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
            this.tableselect.Location = new System.Drawing.Point(568, 39);
            this.tableselect.Margin = new System.Windows.Forms.Padding(5);
            this.tableselect.Name = "tableselect";
            this.tableselect.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.tableselect.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.tableselect.selectedIndex = 0;
            this.tableselect.Size = new System.Drawing.Size(176, 30);
            this.tableselect.TabIndex = 70;
            // 
            // findView2
            // 
            this.findView2.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.findView2.AllowUserToAddRows = false;
            this.findView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.findView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.findView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.findView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.findView2.BackgroundColor = System.Drawing.Color.White;
            this.findView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.findView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.findView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.findView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.findView2.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.findView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.findView2.DoubleBuffered = true;
            this.findView2.EnableHeadersVisualStyles = false;
            this.findView2.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.findView2.HeaderForeColor = System.Drawing.Color.White;
            this.findView2.Location = new System.Drawing.Point(42, 80);
            this.findView2.MultiSelect = false;
            this.findView2.Name = "findView2";
            this.findView2.ReadOnly = true;
            this.findView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.findView2.RowHeadersVisible = false;
            this.findView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.findView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.findView2.Size = new System.Drawing.Size(908, 448);
            this.findView2.TabIndex = 71;
            this.findView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.findView2_CellClick);
            this.findView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.findView_KeyDown);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.findView2;
            // 
            // findwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.findView2);
            this.Controls.Add(this.tableselect);
            this.Controls.Add(this.findsearchbutton);
            this.Controls.Add(this.findtextbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "findwindow";
            this.Size = new System.Drawing.Size(998, 552);
            this.Load += new System.EventHandler(this.findwindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.findsearchbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.findView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton findsearchbutton;
        public Bunifu.Framework.UI.BunifuMaterialTextbox findtextbox;
        private Bunifu.Framework.UI.BunifuDropdown tableselect;
        private Bunifu.Framework.UI.BunifuCustomDataGrid findView2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
