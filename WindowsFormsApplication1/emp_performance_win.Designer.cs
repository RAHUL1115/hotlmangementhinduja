namespace WindowsFormsApplication1
{
    partial class emp_performance_win
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emp_performance_win));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.back = new Bunifu.Framework.UI.BunifuImageButton();
            this.emp_perform = new Bunifu.Framework.UI.BunifuThinButton2();
            this.show_feedback = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.feedbackview = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackview)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.back, BunifuAnimatorNS.DecorationType.None);
            this.back.Image = global::WindowsFormsApplication1.Properties.Resources.back;
            this.back.ImageActive = null;
            this.back.Location = new System.Drawing.Point(6, 11);
            this.back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 32);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 69;
            this.back.TabStop = false;
            this.back.Zoom = 10;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // emp_perform
            // 
            this.emp_perform.ActiveBorderThickness = 1;
            this.emp_perform.ActiveCornerRadius = 20;
            this.emp_perform.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.emp_perform.ActiveForecolor = System.Drawing.Color.Black;
            this.emp_perform.ActiveLineColor = System.Drawing.Color.Black;
            this.emp_perform.BackColor = System.Drawing.Color.White;
            this.emp_perform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emp_perform.BackgroundImage")));
            this.emp_perform.ButtonText = "Employee Performance";
            this.emp_perform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.emp_perform, BunifuAnimatorNS.DecorationType.None);
            this.emp_perform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_perform.ForeColor = System.Drawing.Color.SeaGreen;
            this.emp_perform.IdleBorderThickness = 1;
            this.emp_perform.IdleCornerRadius = 20;
            this.emp_perform.IdleFillColor = System.Drawing.Color.White;
            this.emp_perform.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.emp_perform.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.emp_perform.Location = new System.Drawing.Point(554, 445);
            this.emp_perform.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.emp_perform.Name = "emp_perform";
            this.emp_perform.Size = new System.Drawing.Size(191, 46);
            this.emp_perform.TabIndex = 71;
            this.emp_perform.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emp_perform.Click += new System.EventHandler(this.emp_perform_Click);
            // 
            // show_feedback
            // 
            this.show_feedback.ActiveBorderThickness = 1;
            this.show_feedback.ActiveCornerRadius = 20;
            this.show_feedback.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(214)))));
            this.show_feedback.ActiveForecolor = System.Drawing.Color.Black;
            this.show_feedback.ActiveLineColor = System.Drawing.Color.Black;
            this.show_feedback.BackColor = System.Drawing.Color.White;
            this.show_feedback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("show_feedback.BackgroundImage")));
            this.show_feedback.ButtonText = "Show Feedback";
            this.show_feedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.show_feedback, BunifuAnimatorNS.DecorationType.None);
            this.show_feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_feedback.ForeColor = System.Drawing.Color.SeaGreen;
            this.show_feedback.IdleBorderThickness = 1;
            this.show_feedback.IdleCornerRadius = 20;
            this.show_feedback.IdleFillColor = System.Drawing.Color.White;
            this.show_feedback.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.show_feedback.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.show_feedback.Location = new System.Drawing.Point(303, 445);
            this.show_feedback.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.show_feedback.Name = "show_feedback";
            this.show_feedback.Size = new System.Drawing.Size(130, 46);
            this.show_feedback.TabIndex = 72;
            this.show_feedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.show_feedback.Click += new System.EventHandler(this.show_feedback_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            this.bunifuTransition1.Interval = 5;
            this.bunifuTransition1.MaxAnimationTime = 1000;
            this.bunifuTransition1.TimeStep = 0.05F;
            // 
            // feedbackview
            // 
            this.feedbackview.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.feedbackview.AllowUserToAddRows = false;
            this.feedbackview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.feedbackview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.feedbackview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.feedbackview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.feedbackview.BackgroundColor = System.Drawing.Color.White;
            this.feedbackview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feedbackview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.feedbackview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.feedbackview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.feedbackview.ColumnHeadersHeight = 30;
            this.bunifuTransition1.SetDecoration(this.feedbackview, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.feedbackview.DefaultCellStyle = dataGridViewCellStyle6;
            this.feedbackview.DoubleBuffered = true;
            this.feedbackview.EnableHeadersVisualStyles = false;
            this.feedbackview.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.feedbackview.HeaderForeColor = System.Drawing.Color.White;
            this.feedbackview.Location = new System.Drawing.Point(33, 47);
            this.feedbackview.MultiSelect = false;
            this.feedbackview.Name = "feedbackview";
            this.feedbackview.ReadOnly = true;
            this.feedbackview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.feedbackview.RowHeadersVisible = false;
            this.feedbackview.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.feedbackview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.feedbackview.Size = new System.Drawing.Size(902, 391);
            this.feedbackview.TabIndex = 73;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this.feedbackview;
            // 
            // emp_performance_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.feedbackview);
            this.Controls.Add(this.show_feedback);
            this.Controls.Add(this.emp_perform);
            this.Controls.Add(this.back);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "emp_performance_win";
            this.Size = new System.Drawing.Size(972, 509);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuImageButton back;
        public Bunifu.Framework.UI.BunifuThinButton2 emp_perform;
        public Bunifu.Framework.UI.BunifuThinButton2 show_feedback;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid feedbackview;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
