namespace BookHaven
{
    partial class CustomerDetails
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
            this.btn_delete = new FontAwesome.Sharp.IconButton();
            this.btn_edit = new FontAwesome.Sharp.IconButton();
            this.btn_save = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_isMembActive = new System.Windows.Forms.ComboBox();
            this.lbl_customerMemStatus = new System.Windows.Forms.Label();
            this.cmb_customerBranch = new System.Windows.Forms.ComboBox();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.lbl_customerName = new System.Windows.Forms.Label();
            this.txt_customerNic = new System.Windows.Forms.TextBox();
            this.txt_customerMobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_customerEmail = new System.Windows.Forms.TextBox();
            this.txt_customerAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.customerDetails_datagrid = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetails_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
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
            this.btn_delete.Location = new System.Drawing.Point(10, 89);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_delete.Size = new System.Drawing.Size(102, 39);
            this.btn_delete.TabIndex = 28;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
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
            this.btn_edit.Location = new System.Drawing.Point(10, 45);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Padding = new System.Windows.Forms.Padding(5, 0, 8, 0);
            this.btn_edit.Size = new System.Drawing.Size(102, 38);
            this.btn_edit.TabIndex = 28;
            this.btn_edit.Text = "Edit";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btn_save.IconColor = System.Drawing.Color.White;
            this.btn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_save.IconSize = 32;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(10, 3);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_save.Size = new System.Drawing.Size(102, 37);
            this.btn_save.TabIndex = 28;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.cmb_isMembActive);
            this.panel3.Controls.Add(this.lbl_customerMemStatus);
            this.panel3.Controls.Add(this.cmb_customerBranch);
            this.panel3.Controls.Add(this.txt_customerName);
            this.panel3.Controls.Add(this.lbl_customerName);
            this.panel3.Controls.Add(this.txt_customerNic);
            this.panel3.Controls.Add(this.txt_customerMobile);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_customerEmail);
            this.panel3.Controls.Add(this.txt_customerAddress);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.panel3.Location = new System.Drawing.Point(31, 66);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 138);
            this.panel3.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Location = new System.Drawing.Point(817, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 130);
            this.panel2.TabIndex = 8;
            // 
            // cmb_isMembActive
            // 
            this.cmb_isMembActive.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.cmb_isMembActive.FormattingEnabled = true;
            this.cmb_isMembActive.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cmb_isMembActive.Location = new System.Drawing.Point(228, 93);
            this.cmb_isMembActive.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_isMembActive.Name = "cmb_isMembActive";
            this.cmb_isMembActive.Size = new System.Drawing.Size(163, 25);
            this.cmb_isMembActive.TabIndex = 7;
            // 
            // lbl_customerMemStatus
            // 
            this.lbl_customerMemStatus.AutoSize = true;
            this.lbl_customerMemStatus.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_customerMemStatus.Location = new System.Drawing.Point(226, 72);
            this.lbl_customerMemStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_customerMemStatus.Name = "lbl_customerMemStatus";
            this.lbl_customerMemStatus.Size = new System.Drawing.Size(153, 15);
            this.lbl_customerMemStatus.TabIndex = 6;
            this.lbl_customerMemStatus.Text = "Is Membership Active";
            // 
            // cmb_customerBranch
            // 
            this.cmb_customerBranch.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.cmb_customerBranch.FormattingEnabled = true;
            this.cmb_customerBranch.Location = new System.Drawing.Point(24, 36);
            this.cmb_customerBranch.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_customerBranch.Name = "cmb_customerBranch";
            this.cmb_customerBranch.Size = new System.Drawing.Size(163, 25);
            this.cmb_customerBranch.TabIndex = 4;
            // 
            // txt_customerName
            // 
            this.txt_customerName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerName.Location = new System.Drawing.Point(227, 36);
            this.txt_customerName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(163, 25);
            this.txt_customerName.TabIndex = 0;
            // 
            // lbl_customerName
            // 
            this.lbl_customerName.AutoSize = true;
            this.lbl_customerName.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerName.Location = new System.Drawing.Point(225, 13);
            this.lbl_customerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_customerName.Name = "lbl_customerName";
            this.lbl_customerName.Size = new System.Drawing.Size(115, 15);
            this.lbl_customerName.TabIndex = 2;
            this.lbl_customerName.Text = "Customer Name";
            // 
            // txt_customerNic
            // 
            this.txt_customerNic.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerNic.Location = new System.Drawing.Point(425, 36);
            this.txt_customerNic.Margin = new System.Windows.Forms.Padding(2);
            this.txt_customerNic.Name = "txt_customerNic";
            this.txt_customerNic.Size = new System.Drawing.Size(163, 25);
            this.txt_customerNic.TabIndex = 2;
            // 
            // txt_customerMobile
            // 
            this.txt_customerMobile.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerMobile.Location = new System.Drawing.Point(629, 36);
            this.txt_customerMobile.Margin = new System.Windows.Forms.Padding(2);
            this.txt_customerMobile.Name = "txt_customerMobile";
            this.txt_customerMobile.Size = new System.Drawing.Size(163, 25);
            this.txt_customerMobile.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(423, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "NIC No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(627, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mobile No.";
            // 
            // txt_customerEmail
            // 
            this.txt_customerEmail.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerEmail.Location = new System.Drawing.Point(24, 93);
            this.txt_customerEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txt_customerEmail.Name = "txt_customerEmail";
            this.txt_customerEmail.Size = new System.Drawing.Size(163, 25);
            this.txt_customerEmail.TabIndex = 1;
            // 
            // txt_customerAddress
            // 
            this.txt_customerAddress.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerAddress.Location = new System.Drawing.Point(424, 93);
            this.txt_customerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txt_customerAddress.Name = "txt_customerAddress";
            this.txt_customerAddress.Size = new System.Drawing.Size(368, 25);
            this.txt_customerAddress.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(22, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(422, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(21, 13);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Branch Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(31, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 31);
            this.panel1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Customer Details";
            // 
            // customerDetails_datagrid
            // 
            this.customerDetails_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDetails_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.customerDetails_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDetails_datagrid.Location = new System.Drawing.Point(31, 208);
            this.customerDetails_datagrid.Margin = new System.Windows.Forms.Padding(2);
            this.customerDetails_datagrid.MultiSelect = false;
            this.customerDetails_datagrid.Name = "customerDetails_datagrid";
            this.customerDetails_datagrid.RowHeadersVisible = false;
            this.customerDetails_datagrid.RowHeadersWidth = 51;
            this.customerDetails_datagrid.RowTemplate.Height = 24;
            this.customerDetails_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDetails_datagrid.Size = new System.Drawing.Size(944, 382);
            this.customerDetails_datagrid.TabIndex = 46;
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1006, 601);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customerDetails_datagrid);
            this.Name = "CustomerDetails";
            this.Text = "CustomerDetails";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetails_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_delete;
        private FontAwesome.Sharp.IconButton btn_edit;
        private FontAwesome.Sharp.IconButton btn_save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmb_customerBranch;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.Label lbl_customerName;
        private System.Windows.Forms.TextBox txt_customerMobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_customerEmail;
        private System.Windows.Forms.TextBox txt_customerAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView customerDetails_datagrid;
        private System.Windows.Forms.TextBox txt_customerNic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_isMembActive;
        private System.Windows.Forms.Label lbl_customerMemStatus;
        private System.Windows.Forms.Panel panel2;
    }
}