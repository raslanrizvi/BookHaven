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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.btn_Edit = new FontAwesome.Sharp.IconButton();
            this.btn_Save = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_isAccountActive = new System.Windows.Forms.ComboBox();
            this.lbl_customerMemStatus = new System.Windows.Forms.Label();
            this.cmb_customerBranch = new System.Windows.Forms.ComboBox();
            this.txt_supplierName = new System.Windows.Forms.TextBox();
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
            this.userDetails_datagrid = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDetails_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btn_Delete);
            this.panel4.Controls.Add(this.btn_Edit);
            this.panel4.Controls.Add(this.btn_Save);
            this.panel4.Location = new System.Drawing.Point(203, 503);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(514, 72);
            this.panel4.TabIndex = 49;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(129)))), ((int)(((byte)(71)))));
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_Delete.IconColor = System.Drawing.Color.White;
            this.btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Delete.IconSize = 32;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(358, 17);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btn_Delete.Size = new System.Drawing.Size(120, 39);
            this.btn_Delete.TabIndex = 28;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btn_Edit.IconColor = System.Drawing.Color.White;
            this.btn_Edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Edit.IconSize = 32;
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.Location = new System.Drawing.Point(199, 17);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btn_Edit.Size = new System.Drawing.Size(99, 39);
            this.btn_Edit.TabIndex = 28;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Edit.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btn_Save.IconColor = System.Drawing.Color.White;
            this.btn_Save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Save.IconSize = 32;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(32, 17);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btn_Save.Size = new System.Drawing.Size(107, 39);
            this.btn_Save.TabIndex = 28;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cmb_isAccountActive);
            this.panel3.Controls.Add(this.lbl_customerMemStatus);
            this.panel3.Controls.Add(this.cmb_customerBranch);
            this.panel3.Controls.Add(this.txt_supplierName);
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
            this.panel3.Location = new System.Drawing.Point(31, 84);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 394);
            this.panel3.TabIndex = 47;
            // 
            // cmb_isAccountActive
            // 
            this.cmb_isAccountActive.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.cmb_isAccountActive.FormattingEnabled = true;
            this.cmb_isAccountActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmb_isAccountActive.Location = new System.Drawing.Point(232, 178);
            this.cmb_isAccountActive.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_isAccountActive.Name = "cmb_isAccountActive";
            this.cmb_isAccountActive.Size = new System.Drawing.Size(163, 25);
            this.cmb_isAccountActive.TabIndex = 7;
            // 
            // lbl_customerMemStatus
            // 
            this.lbl_customerMemStatus.AutoSize = true;
            this.lbl_customerMemStatus.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_customerMemStatus.Location = new System.Drawing.Point(230, 157);
            this.lbl_customerMemStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_customerMemStatus.Name = "lbl_customerMemStatus";
            this.lbl_customerMemStatus.Size = new System.Drawing.Size(153, 15);
            this.lbl_customerMemStatus.TabIndex = 6;
            this.lbl_customerMemStatus.Text = "Is Membership Active";
            this.lbl_customerMemStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmb_customerBranch
            // 
            this.cmb_customerBranch.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.cmb_customerBranch.FormattingEnabled = true;
            this.cmb_customerBranch.Items.AddRange(new object[] {
            "Admin",
            "User",
            "Sales Clark"});
            this.cmb_customerBranch.Location = new System.Drawing.Point(29, 50);
            this.cmb_customerBranch.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_customerBranch.Name = "cmb_customerBranch";
            this.cmb_customerBranch.Size = new System.Drawing.Size(163, 25);
            this.cmb_customerBranch.TabIndex = 4;
            // 
            // txt_supplierName
            // 
            this.txt_supplierName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supplierName.Location = new System.Drawing.Point(232, 50);
            this.txt_supplierName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_supplierName.Name = "txt_supplierName";
            this.txt_supplierName.Size = new System.Drawing.Size(163, 25);
            this.txt_supplierName.TabIndex = 0;
            // 
            // lbl_customerName
            // 
            this.lbl_customerName.AutoSize = true;
            this.lbl_customerName.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customerName.Location = new System.Drawing.Point(230, 27);
            this.lbl_customerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_customerName.Name = "lbl_customerName";
            this.lbl_customerName.Size = new System.Drawing.Size(115, 15);
            this.lbl_customerName.TabIndex = 2;
            this.lbl_customerName.Text = "Customer Name";
            // 
            // txt_customerNic
            // 
            this.txt_customerNic.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerNic.Location = new System.Drawing.Point(28, 113);
            this.txt_customerNic.Margin = new System.Windows.Forms.Padding(2);
            this.txt_customerNic.Name = "txt_customerNic";
            this.txt_customerNic.Size = new System.Drawing.Size(163, 25);
            this.txt_customerNic.TabIndex = 2;
            // 
            // txt_customerMobile
            // 
            this.txt_customerMobile.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerMobile.Location = new System.Drawing.Point(232, 113);
            this.txt_customerMobile.Margin = new System.Windows.Forms.Padding(2);
            this.txt_customerMobile.Name = "txt_customerMobile";
            this.txt_customerMobile.Size = new System.Drawing.Size(163, 25);
            this.txt_customerMobile.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(26, 92);
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
            this.label4.Location = new System.Drawing.Point(230, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mobile No.";
            // 
            // txt_customerEmail
            // 
            this.txt_customerEmail.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerEmail.Location = new System.Drawing.Point(28, 178);
            this.txt_customerEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txt_customerEmail.Name = "txt_customerEmail";
            this.txt_customerEmail.Size = new System.Drawing.Size(163, 25);
            this.txt_customerEmail.TabIndex = 1;
            // 
            // txt_customerAddress
            // 
            this.txt_customerAddress.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customerAddress.Location = new System.Drawing.Point(28, 241);
            this.txt_customerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txt_customerAddress.Name = "txt_customerAddress";
            this.txt_customerAddress.Size = new System.Drawing.Size(368, 25);
            this.txt_customerAddress.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(26, 155);
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
            this.label11.Location = new System.Drawing.Point(26, 218);
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
            this.label10.Location = new System.Drawing.Point(26, 27);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Branch Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(31, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 31);
            this.panel1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Customer Details";
            // 
            // userDetails_datagrid
            // 
            this.userDetails_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.userDetails_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDetails_datagrid.Location = new System.Drawing.Point(461, 84);
            this.userDetails_datagrid.Margin = new System.Windows.Forms.Padding(2);
            this.userDetails_datagrid.Name = "userDetails_datagrid";
            this.userDetails_datagrid.RowHeadersWidth = 51;
            this.userDetails_datagrid.RowTemplate.Height = 24;
            this.userDetails_datagrid.Size = new System.Drawing.Size(514, 394);
            this.userDetails_datagrid.TabIndex = 46;
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1006, 601);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userDetails_datagrid);
            this.Name = "CustomerDetails";
            this.Text = "CustomerDetails";
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDetails_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private FontAwesome.Sharp.IconButton btn_Edit;
        private FontAwesome.Sharp.IconButton btn_Save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmb_customerBranch;
        private System.Windows.Forms.TextBox txt_supplierName;
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
        private System.Windows.Forms.DataGridView userDetails_datagrid;
        private System.Windows.Forms.TextBox txt_customerNic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_isAccountActive;
        private System.Windows.Forms.Label lbl_customerMemStatus;
    }
}