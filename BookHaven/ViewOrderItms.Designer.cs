namespace BookHaven
{
    partial class ViewOrderItms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrderItms));
            this.ordItmDetails_datagrid = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_orderId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordItmDetails_datagrid)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordItmDetails_datagrid
            // 
            this.ordItmDetails_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordItmDetails_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordItmDetails_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.ordItmDetails_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordItmDetails_datagrid.Location = new System.Drawing.Point(11, 143);
            this.ordItmDetails_datagrid.Margin = new System.Windows.Forms.Padding(2);
            this.ordItmDetails_datagrid.MultiSelect = false;
            this.ordItmDetails_datagrid.Name = "ordItmDetails_datagrid";
            this.ordItmDetails_datagrid.RowHeadersVisible = false;
            this.ordItmDetails_datagrid.RowHeadersWidth = 51;
            this.ordItmDetails_datagrid.RowTemplate.Height = 24;
            this.ordItmDetails_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordItmDetails_datagrid.Size = new System.Drawing.Size(1159, 475);
            this.ordItmDetails_datagrid.TabIndex = 53;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label15);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(109, 11);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(944, 31);
            this.panel4.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(367, 3);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(198, 23);
            this.label15.TabIndex = 21;
            this.label15.Text = "View Order Items";
            // 
            // lbl_orderId
            // 
            this.lbl_orderId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_orderId.AutoSize = true;
            this.lbl_orderId.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orderId.Location = new System.Drawing.Point(527, 77);
            this.lbl_orderId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_orderId.Name = "lbl_orderId";
            this.lbl_orderId.Size = new System.Drawing.Size(0, 23);
            this.lbl_orderId.TabIndex = 22;
            // 
            // ViewOrderItms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1181, 629);
            this.Controls.Add(this.lbl_orderId);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ordItmDetails_datagrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewOrderItms";
            this.Text = "ViewOrderItms";
            this.Load += new System.EventHandler(this.ViewOrderItms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordItmDetails_datagrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ordItmDetails_datagrid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_orderId;
    }
}