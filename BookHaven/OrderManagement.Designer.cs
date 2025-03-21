namespace BookHaven
{
    partial class OrderManagement
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
            this.orderDetails_datagrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_delete = new FontAwesome.Sharp.IconButton();
            this.btn_edit = new FontAwesome.Sharp.IconButton();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new FontAwesome.Sharp.IconButton();
            this.btn_viwItms = new FontAwesome.Sharp.IconButton();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetails_datagrid)).BeginInit();
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
            this.panel4.Location = new System.Drawing.Point(34, 19);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(944, 31);
            this.panel4.TabIndex = 56;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(377, 3);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(220, 23);
            this.label15.TabIndex = 21;
            this.label15.Text = "Order Management";
            // 
            // orderDetails_datagrid
            // 
            this.orderDetails_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDetails_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDetails_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.orderDetails_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetails_datagrid.Location = new System.Drawing.Point(34, 163);
            this.orderDetails_datagrid.Margin = new System.Windows.Forms.Padding(2);
            this.orderDetails_datagrid.MultiSelect = false;
            this.orderDetails_datagrid.Name = "orderDetails_datagrid";
            this.orderDetails_datagrid.RowHeadersVisible = false;
            this.orderDetails_datagrid.RowHeadersWidth = 51;
            this.orderDetails_datagrid.RowTemplate.Height = 24;
            this.orderDetails_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDetails_datagrid.Size = new System.Drawing.Size(944, 414);
            this.orderDetails_datagrid.TabIndex = 55;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Location = new System.Drawing.Point(376, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 50);
            this.panel2.TabIndex = 54;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_delete.IconColor = System.Drawing.Color.White;
            this.btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_delete.IconSize = 25;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(140, 4);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_delete.Size = new System.Drawing.Size(104, 39);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_edit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btn_edit.IconColor = System.Drawing.Color.White;
            this.btn_edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_edit.IconSize = 32;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(24, 5);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Padding = new System.Windows.Forms.Padding(5, 0, 8, 0);
            this.btn_edit.Size = new System.Drawing.Size(93, 38);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "Edit";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstName.Location = new System.Drawing.Point(44, 126);
            this.lbl_firstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(53, 15);
            this.lbl_firstName.TabIndex = 58;
            this.lbl_firstName.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(101, 122);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(225, 25);
            this.txt_search.TabIndex = 57;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.DarkGray;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_search.IconColor = System.Drawing.Color.White;
            this.btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_search.IconSize = 25;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(336, 114);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_search.Size = new System.Drawing.Size(43, 37);
            this.btn_search.TabIndex = 59;
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_viwItms
            // 
            this.btn_viwItms.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_viwItms.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_viwItms.FlatAppearance.BorderSize = 0;
            this.btn_viwItms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viwItms.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btn_viwItms.ForeColor = System.Drawing.Color.White;
            this.btn_viwItms.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            this.btn_viwItms.IconColor = System.Drawing.Color.White;
            this.btn_viwItms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_viwItms.IconSize = 32;
            this.btn_viwItms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_viwItms.Location = new System.Drawing.Point(400, 114);
            this.btn_viwItms.Margin = new System.Windows.Forms.Padding(2);
            this.btn_viwItms.Name = "btn_viwItms";
            this.btn_viwItms.Padding = new System.Windows.Forms.Padding(5, 0, 8, 0);
            this.btn_viwItms.Size = new System.Drawing.Size(153, 38);
            this.btn_viwItms.TabIndex = 14;
            this.btn_viwItms.Text = "View Items";
            this.btn_viwItms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_viwItms.UseVisualStyleBackColor = false;
            this.btn_viwItms.Click += new System.EventHandler(this.btn_viwItms_Click);
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1006, 601);
            this.Controls.Add(this.btn_viwItms);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_firstName);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.orderDetails_datagrid);
            this.Controls.Add(this.panel2);
            this.Name = "OrderManagement";
            this.Text = "OrderManagement";
            this.Load += new System.EventHandler(this.OrderManagement_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetails_datagrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView orderDetails_datagrid;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_delete;
        private FontAwesome.Sharp.IconButton btn_edit;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.TextBox txt_search;
        private FontAwesome.Sharp.IconButton btn_search;
        private FontAwesome.Sharp.IconButton btn_viwItms;
    }
}