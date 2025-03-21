namespace BookHaven
{
    partial class ReportView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Load = new FontAwesome.Sharp.IconButton();
            this.rdb_daily = new System.Windows.Forms.RadioButton();
            this.rdb_weekly = new System.Windows.Forms.RadioButton();
            this.rdb_monthly = new System.Windows.Forms.RadioButton();
            this.sales_rptViewr = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label15);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(30, 11);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(944, 31);
            this.panel4.TabIndex = 58;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(377, 3);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 23);
            this.label15.TabIndex = 21;
            this.label15.Text = "Report View";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdb_monthly);
            this.panel2.Controls.Add(this.rdb_weekly);
            this.panel2.Controls.Add(this.rdb_daily);
            this.panel2.Controls.Add(this.btn_Load);
            this.panel2.Location = new System.Drawing.Point(30, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 50);
            this.panel2.TabIndex = 57;
            // 
            // btn_Load
            // 
            this.btn_Load.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Load.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Load.FlatAppearance.BorderSize = 0;
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Load.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Load.ForeColor = System.Drawing.Color.White;
            this.btn_Load.IconChar = FontAwesome.Sharp.IconChar.Reorder;
            this.btn_Load.IconColor = System.Drawing.Color.White;
            this.btn_Load.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Load.IconSize = 32;
            this.btn_Load.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Load.Location = new System.Drawing.Point(203, 6);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Padding = new System.Windows.Forms.Padding(5, 0, 8, 0);
            this.btn_Load.Size = new System.Drawing.Size(169, 38);
            this.btn_Load.TabIndex = 12;
            this.btn_Load.Text = "Load Report";
            this.btn_Load.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // rdb_daily
            // 
            this.rdb_daily.AutoSize = true;
            this.rdb_daily.Location = new System.Drawing.Point(14, 18);
            this.rdb_daily.Name = "rdb_daily";
            this.rdb_daily.Size = new System.Drawing.Size(48, 17);
            this.rdb_daily.TabIndex = 13;
            this.rdb_daily.TabStop = true;
            this.rdb_daily.Text = "Daily";
            this.rdb_daily.UseVisualStyleBackColor = true;
            // 
            // rdb_weekly
            // 
            this.rdb_weekly.AutoSize = true;
            this.rdb_weekly.Location = new System.Drawing.Point(67, 18);
            this.rdb_weekly.Name = "rdb_weekly";
            this.rdb_weekly.Size = new System.Drawing.Size(61, 17);
            this.rdb_weekly.TabIndex = 14;
            this.rdb_weekly.TabStop = true;
            this.rdb_weekly.Text = "Weekly";
            this.rdb_weekly.UseVisualStyleBackColor = true;
            // 
            // rdb_monthly
            // 
            this.rdb_monthly.AutoSize = true;
            this.rdb_monthly.Location = new System.Drawing.Point(132, 18);
            this.rdb_monthly.Name = "rdb_monthly";
            this.rdb_monthly.Size = new System.Drawing.Size(62, 17);
            this.rdb_monthly.TabIndex = 15;
            this.rdb_monthly.TabStop = true;
            this.rdb_monthly.Text = "Monthly";
            this.rdb_monthly.UseVisualStyleBackColor = true;
            // 
            // sales_rptViewr
            // 
            this.sales_rptViewr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sales_rptViewr.Location = new System.Drawing.Point(30, 120);
            this.sales_rptViewr.Name = "sales_rptViewr";
            this.sales_rptViewr.ServerReport.BearerToken = null;
            this.sales_rptViewr.Size = new System.Drawing.Size(944, 469);
            this.sales_rptViewr.TabIndex = 59;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1006, 601);
            this.Controls.Add(this.sales_rptViewr);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "ReportView";
            this.Text = "ReportView";
            this.Load += new System.EventHandler(this.ReportView_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_Load;
        private System.Windows.Forms.RadioButton rdb_monthly;
        private System.Windows.Forms.RadioButton rdb_weekly;
        private System.Windows.Forms.RadioButton rdb_daily;
        private Microsoft.Reporting.WinForms.ReportViewer sales_rptViewr;
    }
}