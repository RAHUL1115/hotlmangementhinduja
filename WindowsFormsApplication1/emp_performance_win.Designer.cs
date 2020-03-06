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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emp_performance_win));
            this.back = new Bunifu.Framework.UI.BunifuImageButton();
            this.feedbackview = new System.Windows.Forms.DataGridView();
            this.emp_perform = new Bunifu.Framework.UI.BunifuThinButton2();
            this.show_feedback = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackview)).BeginInit();
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
            // feedbackview
            // 
            this.feedbackview.BackgroundColor = System.Drawing.Color.White;
            this.feedbackview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedbackview.GridColor = System.Drawing.Color.Black;
            this.feedbackview.Location = new System.Drawing.Point(44, 58);
            this.feedbackview.Name = "feedbackview";
            this.feedbackview.RowHeadersWidth = 51;
            this.feedbackview.RowTemplate.Height = 24;
            this.feedbackview.Size = new System.Drawing.Size(1196, 481);
            this.feedbackview.TabIndex = 70;
            this.feedbackview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.feedbackview_KeyDown);
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
            this.emp_perform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_perform.ForeColor = System.Drawing.Color.SeaGreen;
            this.emp_perform.IdleBorderThickness = 1;
            this.emp_perform.IdleCornerRadius = 20;
            this.emp_perform.IdleFillColor = System.Drawing.Color.White;
            this.emp_perform.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.emp_perform.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.emp_perform.Location = new System.Drawing.Point(738, 548);
            this.emp_perform.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.emp_perform.Name = "emp_perform";
            this.emp_perform.Size = new System.Drawing.Size(255, 56);
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
            this.show_feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_feedback.ForeColor = System.Drawing.Color.SeaGreen;
            this.show_feedback.IdleBorderThickness = 1;
            this.show_feedback.IdleCornerRadius = 20;
            this.show_feedback.IdleFillColor = System.Drawing.Color.White;
            this.show_feedback.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.show_feedback.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.show_feedback.Location = new System.Drawing.Point(404, 548);
            this.show_feedback.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.show_feedback.Name = "show_feedback";
            this.show_feedback.Size = new System.Drawing.Size(174, 56);
            this.show_feedback.TabIndex = 72;
            this.show_feedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.show_feedback.Click += new System.EventHandler(this.show_feedback_Click);
            // 
            // emp_performance_win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.show_feedback);
            this.Controls.Add(this.emp_perform);
            this.Controls.Add(this.feedbackview);
            this.Controls.Add(this.back);
            this.Name = "emp_performance_win";
            this.Size = new System.Drawing.Size(1296, 626);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuImageButton back;
        private System.Windows.Forms.DataGridView feedbackview;
        public Bunifu.Framework.UI.BunifuThinButton2 emp_perform;
        public Bunifu.Framework.UI.BunifuThinButton2 show_feedback;
    }
}
