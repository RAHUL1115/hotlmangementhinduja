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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(canclewin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.cancleroombut = new Bunifu.Framework.UI.BunifuThinButton2();
            this.canclelist = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canclelist)).BeginInit();
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
            // cancleroombut
            // 
            this.cancleroombut.ActiveBorderThickness = 1;
            this.cancleroombut.ActiveCornerRadius = 20;
            this.cancleroombut.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.cancleroombut.ActiveForecolor = System.Drawing.Color.Black;
            this.cancleroombut.ActiveLineColor = System.Drawing.Color.Black;
            this.cancleroombut.BackColor = System.Drawing.SystemColors.Control;
            this.cancleroombut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancleroombut.BackgroundImage")));
            this.cancleroombut.ButtonText = "cancle";
            this.cancleroombut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancleroombut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancleroombut.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancleroombut.IdleBorderThickness = 1;
            this.cancleroombut.IdleCornerRadius = 20;
            this.cancleroombut.IdleFillColor = System.Drawing.Color.White;
            this.cancleroombut.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.cancleroombut.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.cancleroombut.Location = new System.Drawing.Point(156, 286);
            this.cancleroombut.Margin = new System.Windows.Forms.Padding(5);
            this.cancleroombut.Name = "cancleroombut";
            this.cancleroombut.Size = new System.Drawing.Size(181, 41);
            this.cancleroombut.TabIndex = 8;
            this.cancleroombut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancleroombut.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // canclelist
            // 
            this.canclelist.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.canclelist.AllowUserToAddRows = false;
            this.canclelist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.canclelist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.canclelist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.canclelist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.canclelist.BackgroundColor = System.Drawing.Color.White;
            this.canclelist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.canclelist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.canclelist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.canclelist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.canclelist.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.canclelist.DefaultCellStyle = dataGridViewCellStyle3;
            this.canclelist.DoubleBuffered = true;
            this.canclelist.EnableHeadersVisualStyles = false;
            this.canclelist.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.canclelist.HeaderForeColor = System.Drawing.Color.White;
            this.canclelist.Location = new System.Drawing.Point(12, 46);
            this.canclelist.MultiSelect = false;
            this.canclelist.Name = "canclelist";
            this.canclelist.ReadOnly = true;
            this.canclelist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.canclelist.RowHeadersVisible = false;
            this.canclelist.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.canclelist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.canclelist.Size = new System.Drawing.Size(462, 232);
            this.canclelist.TabIndex = 72;
            this.canclelist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.canclelist_CellClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.canclelist;
            // 
            // canclewin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.canclelist);
            this.Controls.Add(this.cancleroombut);
            this.Controls.Add(this.bunifuImageButton1);
            this.Name = "canclewin";
            this.Size = new System.Drawing.Size(487, 327);
            this.Load += new System.EventHandler(this.canclewin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canclelist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public Bunifu.Framework.UI.BunifuThinButton2 cancleroombut;
        private Bunifu.Framework.UI.BunifuCustomDataGrid canclelist;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
