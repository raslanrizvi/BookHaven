namespace BookHaven
{
    partial class Settings
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new FontAwesome.Sharp.IconButton();
            this.cmb_isMembActive = new System.Windows.Forms.ComboBox();
            this.lbl_customerMemStatus = new System.Windows.Forms.Label();
            this.cmb_customerBranch = new System.Windows.Forms.ComboBox();
            this.txt_storeName = new System.Windows.Forms.TextBox();
            this.lbl_storeName = new System.Windows.Forms.Label();
            this.txt_storeAddress = new System.Windows.Forms.TextBox();
            this.txt_storeMobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_storeEmail = new System.Windows.Forms.TextBox();
            this.txt_customerAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panel4.Location = new System.Drawing.Point(25, 11);
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
            this.label15.Size = new System.Drawing.Size(235, 23);
            this.label15.TabIndex = 21;
            this.label15.Text = "Update Store Details";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.cmb_isMembActive);
            this.panel3.Controls.Add(this.lbl_customerMemStatus);
            this.panel3.Controls.Add(this.cmb_customerBranch);
            this.panel3.Controls.Add(this.txt_storeName);
            this.panel3.Controls.Add(this.lbl_storeName);
            this.panel3.Controls.Add(this.txt_storeAddress);
            this.panel3.Controls.Add(this.txt_storeMobile);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_storeEmail);
            this.panel3.Controls.Add(this.txt_customerAddress);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.panel3.Location = new System.Drawing.Point(25, 79);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 138);
            this.panel3.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Location = new System.Drawing.Point(817, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 130);
            this.panel1.TabIndex = 8;
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
            this.btn_save.Location = new System.Drawing.Point(12, 47);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_save.Size = new System.Drawing.Size(102, 37);
            this.btn_save.TabIndex = 28;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
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
            // txt_storeName
            // 
            this.txt_storeName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_storeName.Location = new System.Drawing.Point(227, 36);
            this.txt_storeName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_storeName.Name = "txt_storeName";
            this.txt_storeName.Size = new System.Drawing.Size(163, 25);
            this.txt_storeName.TabIndex = 0;
            // 
            // lbl_storeName
            // 
            this.lbl_storeName.AutoSize = true;
            this.lbl_storeName.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_storeName.Location = new System.Drawing.Point(225, 13);
            this.lbl_storeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_storeName.Name = "lbl_storeName";
            this.lbl_storeName.Size = new System.Drawing.Size(87, 15);
            this.lbl_storeName.TabIndex = 2;
            this.lbl_storeName.Text = "Store Name";
            // 
            // txt_storeAddress
            // 
            this.txt_storeAddress.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_storeAddress.Location = new System.Drawing.Point(425, 36);
            this.txt_storeAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txt_storeAddress.Name = "txt_storeAddress";
            this.txt_storeAddress.Size = new System.Drawing.Size(163, 25);
            this.txt_storeAddress.TabIndex = 2;
            // 
            // txt_storeMobile
            // 
            this.txt_storeMobile.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_storeMobile.Location = new System.Drawing.Point(629, 36);
            this.txt_storeMobile.Margin = new System.Windows.Forms.Padding(2);
            this.txt_storeMobile.Name = "txt_storeMobile";
            this.txt_storeMobile.Size = new System.Drawing.Size(163, 25);
            this.txt_storeMobile.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(423, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
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
            // txt_storeEmail
            // 
            this.txt_storeEmail.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_storeEmail.Location = new System.Drawing.Point(24, 93);
            this.txt_storeEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txt_storeEmail.Name = "txt_storeEmail";
            this.txt_storeEmail.Size = new System.Drawing.Size(163, 25);
            this.txt_storeEmail.TabIndex = 1;
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
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1004, 601);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_save;
        private System.Windows.Forms.ComboBox cmb_isMembActive;
        private System.Windows.Forms.Label lbl_customerMemStatus;
        private System.Windows.Forms.ComboBox cmb_customerBranch;
        private System.Windows.Forms.TextBox txt_storeName;
        private System.Windows.Forms.Label lbl_storeName;
        private System.Windows.Forms.TextBox txt_storeAddress;
        private System.Windows.Forms.TextBox txt_storeMobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_storeEmail;
        private System.Windows.Forms.TextBox txt_customerAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}