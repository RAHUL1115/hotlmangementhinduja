namespace WindowsFormsApplication1
{
    partial class services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(services));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.fooddropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.addbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.roomcleancheckBox = new System.Windows.Forms.CheckBox();
            this.quantitydropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedback_dbDataSet3 = new WindowsFormsApplication1.feedback_dbDataSet3();
            this.feedback_dbDataSet2 = new WindowsFormsApplication1.feedback_dbDataSet2();
            this.servicesTableAdapter = new WindowsFormsApplication1.feedback_dbDataSet2TableAdapters.servicesTableAdapter();
            this.servicesTableAdapter1 = new WindowsFormsApplication1.feedback_dbDataSet3TableAdapters.servicesTableAdapter();
            this.serviceview = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedback_dbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedback_dbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceview)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::WindowsFormsApplication1.Properties.Resources.back;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(16, 15);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // fooddropdown
            // 
            this.fooddropdown.BackColor = System.Drawing.Color.Transparent;
            this.fooddropdown.BorderRadius = 3;
            this.fooddropdown.ForeColor = System.Drawing.Color.Black;
            this.fooddropdown.Items = new string[] {
        "Breakfast",
        "Lunch",
        "Dinner"};
            this.fooddropdown.Location = new System.Drawing.Point(21, 77);
            this.fooddropdown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fooddropdown.Name = "fooddropdown";
            this.fooddropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.fooddropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.fooddropdown.selectedIndex = -1;
            this.fooddropdown.Size = new System.Drawing.Size(147, 32);
            this.fooddropdown.TabIndex = 7;
            // 
            // addbutton
            // 
            this.addbutton.ActiveBorderThickness = 1;
            this.addbutton.ActiveCornerRadius = 20;
            this.addbutton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.addbutton.ActiveForecolor = System.Drawing.Color.Black;
            this.addbutton.ActiveLineColor = System.Drawing.Color.Black;
            this.addbutton.BackColor = System.Drawing.SystemColors.Control;
            this.addbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addbutton.BackgroundImage")));
            this.addbutton.ButtonText = "Add";
            this.addbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.addbutton.IdleBorderThickness = 1;
            this.addbutton.IdleCornerRadius = 20;
            this.addbutton.IdleFillColor = System.Drawing.Color.White;
            this.addbutton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.addbutton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.addbutton.Location = new System.Drawing.Point(404, 66);
            this.addbutton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(105, 43);
            this.addbutton.TabIndex = 8;
            this.addbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addbutton.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // roomcleancheckBox
            // 
            this.roomcleancheckBox.AutoSize = true;
            this.roomcleancheckBox.Location = new System.Drawing.Point(264, 88);
            this.roomcleancheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomcleancheckBox.Name = "roomcleancheckBox";
            this.roomcleancheckBox.Size = new System.Drawing.Size(126, 21);
            this.roomcleancheckBox.TabIndex = 10;
            this.roomcleancheckBox.Text = "Room Cleaning";
            this.roomcleancheckBox.UseVisualStyleBackColor = true;
            // 
            // quantitydropdown
            // 
            this.quantitydropdown.BackColor = System.Drawing.Color.Transparent;
            this.quantitydropdown.BorderRadius = 3;
            this.quantitydropdown.ForeColor = System.Drawing.Color.Black;
            this.quantitydropdown.Items = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5"};
            this.quantitydropdown.Location = new System.Drawing.Point(177, 77);
            this.quantitydropdown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.quantitydropdown.Name = "quantitydropdown";
            this.quantitydropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.quantitydropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.quantitydropdown.selectedIndex = -1;
            this.quantitydropdown.Size = new System.Drawing.Size(79, 32);
            this.quantitydropdown.TabIndex = 11;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "services";
            this.servicesBindingSource.DataSource = this.feedback_dbDataSet3;
            // 
            // feedback_dbDataSet3
            // 
            this.feedback_dbDataSet3.DataSetName = "feedback_dbDataSet3";
            this.feedback_dbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedback_dbDataSet2
            // 
            this.feedback_dbDataSet2.DataSetName = "feedback_dbDataSet2";
            this.feedback_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // servicesTableAdapter1
            // 
            this.servicesTableAdapter1.ClearBeforeFill = true;
            // 
            // serviceview
            // 
            this.serviceview.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.serviceview.AllowUserToAddRows = false;
            this.serviceview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.serviceview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.serviceview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serviceview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.serviceview.BackgroundColor = System.Drawing.Color.White;
            this.serviceview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.serviceview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.serviceview.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serviceview.DefaultCellStyle = dataGridViewCellStyle3;
            this.serviceview.DoubleBuffered = true;
            this.serviceview.EnableHeadersVisualStyles = false;
            this.serviceview.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.serviceview.HeaderForeColor = System.Drawing.Color.White;
            this.serviceview.Location = new System.Drawing.Point(21, 118);
            this.serviceview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serviceview.MultiSelect = false;
            this.serviceview.Name = "serviceview";
            this.serviceview.ReadOnly = true;
            this.serviceview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.serviceview.RowHeadersVisible = false;
            this.serviceview.RowHeadersWidth = 51;
            this.serviceview.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.serviceview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.serviceview.Size = new System.Drawing.Size(601, 224);
            this.serviceview.TabIndex = 73;
            this.serviceview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serviceview_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 74;
            this.label1.Text = "Select Service :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 75;
            this.label2.Text = "Quantity:";
            // 
            // services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serviceview);
            this.Controls.Add(this.quantitydropdown);
            this.Controls.Add(this.roomcleancheckBox);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.fooddropdown);
            this.Controls.Add(this.bunifuImageButton1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "services";
            this.Size = new System.Drawing.Size(649, 402);
            this.Load += new System.EventHandler(this.services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedback_dbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedback_dbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDropdown fooddropdown;
        private Bunifu.Framework.UI.BunifuThinButton2 addbutton;
        private System.Windows.Forms.CheckBox roomcleancheckBox;
        private Bunifu.Framework.UI.BunifuDropdown quantitydropdown;
        private feedback_dbDataSet2 feedback_dbDataSet2;
        private feedback_dbDataSet2TableAdapters.servicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private feedback_dbDataSet3 feedback_dbDataSet3;
        private feedback_dbDataSet3TableAdapters.servicesTableAdapter servicesTableAdapter1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid serviceview;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
    }
}
