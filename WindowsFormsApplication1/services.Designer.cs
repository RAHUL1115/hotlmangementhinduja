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
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.fooddropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.addbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.servicecancle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.roomcleancheckBox = new System.Windows.Forms.CheckBox();
            this.quantitydropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.serviceview = new System.Windows.Forms.DataGridView();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedback_dbDataSet3 = new WindowsFormsApplication1.feedback_dbDataSet3();
            this.feedback_dbDataSet2 = new WindowsFormsApplication1.feedback_dbDataSet2();
            this.servicesTableAdapter = new WindowsFormsApplication1.feedback_dbDataSet2TableAdapters.servicesTableAdapter();
            this.servicesTableAdapter1 = new WindowsFormsApplication1.feedback_dbDataSet3TableAdapters.servicesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedback_dbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedback_dbDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::WindowsFormsApplication1.Properties.Resources.back;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(16, 15);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4);
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
            this.fooddropdown.Location = new System.Drawing.Point(8, 72);
            this.fooddropdown.Margin = new System.Windows.Forms.Padding(5);
            this.fooddropdown.Name = "fooddropdown";
            this.fooddropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.fooddropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.fooddropdown.selectedIndex = -1;
            this.fooddropdown.Size = new System.Drawing.Size(146, 32);
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
            this.addbutton.Location = new System.Drawing.Point(249, 66);
            this.addbutton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(105, 43);
            this.addbutton.TabIndex = 8;
            this.addbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addbutton.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // servicecancle
            // 
            this.servicecancle.ActiveBorderThickness = 1;
            this.servicecancle.ActiveCornerRadius = 20;
            this.servicecancle.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.servicecancle.ActiveForecolor = System.Drawing.Color.Black;
            this.servicecancle.ActiveLineColor = System.Drawing.Color.Black;
            this.servicecancle.BackColor = System.Drawing.SystemColors.Control;
            this.servicecancle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("servicecancle.BackgroundImage")));
            this.servicecancle.ButtonText = "Cancle";
            this.servicecancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.servicecancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicecancle.ForeColor = System.Drawing.Color.SeaGreen;
            this.servicecancle.IdleBorderThickness = 1;
            this.servicecancle.IdleCornerRadius = 20;
            this.servicecancle.IdleFillColor = System.Drawing.Color.White;
            this.servicecancle.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.servicecancle.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.servicecancle.Location = new System.Drawing.Point(109, 379);
            this.servicecancle.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.servicecancle.Name = "servicecancle";
            this.servicecancle.Size = new System.Drawing.Size(147, 43);
            this.servicecancle.TabIndex = 9;
            this.servicecancle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.servicecancle.Click += new System.EventHandler(this.servicecancle_Click);
            // 
            // roomcleancheckBox
            // 
            this.roomcleancheckBox.AutoSize = true;
            this.roomcleancheckBox.Location = new System.Drawing.Point(8, 343);
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
            this.quantitydropdown.Location = new System.Drawing.Point(164, 72);
            this.quantitydropdown.Margin = new System.Windows.Forms.Padding(5);
            this.quantitydropdown.Name = "quantitydropdown";
            this.quantitydropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.quantitydropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.quantitydropdown.selectedIndex = -1;
            this.quantitydropdown.Size = new System.Drawing.Size(79, 32);
            this.quantitydropdown.TabIndex = 11;
            // 
            // serviceview
            // 
            this.serviceview.AllowUserToAddRows = false;
            this.serviceview.AllowUserToDeleteRows = false;
            this.serviceview.AutoGenerateColumns = false;
            this.serviceview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.serviceview.DataSource = this.servicesBindingSource;
            this.serviceview.Location = new System.Drawing.Point(8, 118);
            this.serviceview.Name = "serviceview";
            this.serviceview.ReadOnly = true;
            this.serviceview.RowHeadersWidth = 51;
            this.serviceview.RowTemplate.Height = 24;
            this.serviceview.Size = new System.Drawing.Size(346, 219);
            this.serviceview.TabIndex = 12;
            this.serviceview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serviceview_CellContentClick);
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Service";
            this.snameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.ReadOnly = true;
            this.snameDataGridViewTextBoxColumn.Width = 84;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 90;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeDataGridViewTextBoxColumn.Width = 68;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Width = 70;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serviceview);
            this.Controls.Add(this.quantitydropdown);
            this.Controls.Add(this.roomcleancheckBox);
            this.Controls.Add(this.servicecancle);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.fooddropdown);
            this.Controls.Add(this.bunifuImageButton1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "services";
            this.Size = new System.Drawing.Size(363, 428);
            this.Load += new System.EventHandler(this.services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedback_dbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedback_dbDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDropdown fooddropdown;
        private Bunifu.Framework.UI.BunifuThinButton2 addbutton;
        private Bunifu.Framework.UI.BunifuThinButton2 servicecancle;
        private System.Windows.Forms.CheckBox roomcleancheckBox;
        private Bunifu.Framework.UI.BunifuDropdown quantitydropdown;
        private System.Windows.Forms.DataGridView serviceview;
        private feedback_dbDataSet2 feedback_dbDataSet2;
        private feedback_dbDataSet2TableAdapters.servicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private feedback_dbDataSet3 feedback_dbDataSet3;
        private feedback_dbDataSet3TableAdapters.servicesTableAdapter servicesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}
