namespace BookHaven
{
    partial class UserDetails
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
            this.dtp_userDOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_userIsAccountActive = new System.Windows.Forms.ComboBox();
            this.cmb_userStoreId = new System.Windows.Forms.ComboBox();
            this.cmb_userType = new System.Windows.Forms.ComboBox();
            this.txt_userLastName = new System.Windows.Forms.TextBox();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.txt_userFirstName = new System.Windows.Forms.TextBox();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.txt_userConfirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_userMobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_userPassword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_userEmail = new System.Windows.Forms.TextBox();
            this.txt_userUName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_delete = new FontAwesome.Sharp.IconButton();
            this.btn_save = new FontAwesome.Sharp.IconButton();
            this.btn_edit = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.userDetails_datagrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDetails_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_userDOB
            // 
            this.dtp_userDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_userDOB.CalendarFont = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_userDOB.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.dtp_userDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_userDOB.Location = new System.Drawing.Point(212, 82);
            this.dtp_userDOB.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtp_userDOB.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtp_userDOB.Name = "dtp_userDOB";
            this.dtp_userDOB.Size = new System.Drawing.Size(163, 25);
            this.dtp_userDOB.TabIndex = 6;
            this.dtp_userDOB.Value = new System.DateTime(2025, 3, 9, 0, 0, 0, 0);
            // 
            // cmb_userIsAccountActive
            // 
            this.cmb_userIsAccountActive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_userIsAccountActive.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.cmb_userIsAccountActive.FormattingEnabled = true;
            this.cmb_userIsAccountActive.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cmb_userIsAccountActive.Location = new System.Drawing.Point(333, 142);
            this.cmb_userIsAccountActive.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_userIsAccountActive.Name = "cmb_userIsAccountActive";
            this.cmb_userIsAccountActive.Size = new System.Drawing.Size(163, 25);
            this.cmb_userIsAccountActive.TabIndex = 9;
            // 
            // cmb_userStoreId
            // 
            this.cmb_userStoreId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_userStoreId.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.cmb_userStoreId.FormattingEnabled = true;
            this.cmb_userStoreId.Location = new System.Drawing.Point(533, 142);
            this.cmb_userStoreId.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_userStoreId.Name = "cmb_userStoreId";
            this.cmb_userStoreId.Size = new System.Drawing.Size(163, 25);
            this.cmb_userStoreId.TabIndex = 10;
            // 
            // cmb_userType
            // 
            this.cmb_userType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_userType.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.cmb_userType.FormattingEnabled = true;
            this.cmb_userType.Location = new System.Drawing.Point(129, 142);
            this.cmb_userType.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_userType.Name = "cmb_userType";
            this.cmb_userType.Size = new System.Drawing.Size(163, 25);
            this.cmb_userType.TabIndex = 8;
            // 
            // txt_userLastName
            // 
            this.txt_userLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_userLastName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userLastName.Location = new System.Drawing.Point(212, 30);
            this.txt_userLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_userLastName.Name = "txt_userLastName";
            this.txt_userLastName.Size = new System.Drawing.Size(163, 25);
            this.txt_userLastName.TabIndex = 2;
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastName.Location = new System.Drawing.Point(207, 7);
            this.lbl_lastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(78, 15);
            this.lbl_lastName.TabIndex = 2;
            this.lbl_lastName.Text = "Last Name";
            // 
            // txt_userFirstName
            // 
            this.txt_userFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_userFirstName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userFirstName.Location = new System.Drawing.Point(8, 30);
            this.txt_userFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_userFirstName.Name = "txt_userFirstName";
            this.txt_userFirstName.Size = new System.Drawing.Size(163, 25);
            this.txt_userFirstName.TabIndex = 1;
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstName.Location = new System.Drawing.Point(3, 7);
            this.lbl_firstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(80, 15);
            this.lbl_firstName.TabIndex = 2;
            this.lbl_firstName.Text = "First Name";
            // 
            // txt_userConfirmPassword
            // 
            this.txt_userConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_userConfirmPassword.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userConfirmPassword.Location = new System.Drawing.Point(617, 86);
            this.txt_userConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_userConfirmPassword.Name = "txt_userConfirmPassword";
            this.txt_userConfirmPassword.PasswordChar = '*';
            this.txt_userConfirmPassword.Size = new System.Drawing.Size(163, 25);
            this.txt_userConfirmPassword.TabIndex = 7;
            this.txt_userConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(204, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date Of Birth";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(611, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Confirm Password";
            // 
            // txt_userMobile
            // 
            this.txt_userMobile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_userMobile.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userMobile.Location = new System.Drawing.Point(8, 82);
            this.txt_userMobile.Margin = new System.Windows.Forms.Padding(2);
            this.txt_userMobile.Name = "txt_userMobile";
            this.txt_userMobile.Size = new System.Drawing.Size(163, 25);
            this.txt_userMobile.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mobile No.";
            // 
            // txt_userPassword
            // 
            this.txt_userPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_userPassword.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userPassword.Location = new System.Drawing.Point(413, 86);
            this.txt_userPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_userPassword.Name = "txt_userPassword";
            this.txt_userPassword.PasswordChar = '*';
            this.txt_userPassword.Size = new System.Drawing.Size(163, 25);
            this.txt_userPassword.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(409, 65);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Password";
            // 
            // txt_userEmail
            // 
            this.txt_userEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_userEmail.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userEmail.Location = new System.Drawing.Point(617, 30);
            this.txt_userEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txt_userEmail.Name = "txt_userEmail";
            this.txt_userEmail.Size = new System.Drawing.Size(163, 25);
            this.txt_userEmail.TabIndex = 4;
            // 
            // txt_userUName
            // 
            this.txt_userUName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_userUName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userUName.Location = new System.Drawing.Point(415, 30);
            this.txt_userUName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_userUName.Name = "txt_userUName";
            this.txt_userUName.Size = new System.Drawing.Size(163, 25);
            this.txt_userUName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(327, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Is Account Active";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(611, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(527, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Store ID";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(408, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "User Name";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(124, 121);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "User Type";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmb_userStoreId);
            this.panel1.Controls.Add(this.cmb_userIsAccountActive);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtp_userDOB);
            this.panel1.Controls.Add(this.cmb_userType);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_userLastName);
            this.panel1.Controls.Add(this.txt_userConfirmPassword);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_firstName);
            this.panel1.Controls.Add(this.txt_userPassword);
            this.panel1.Controls.Add(this.txt_userFirstName);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_lastName);
            this.panel1.Controls.Add(this.txt_userEmail);
            this.panel1.Controls.Add(this.txt_userMobile);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_userUName);
            this.panel1.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.panel1.Location = new System.Drawing.Point(39, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 173);
            this.panel1.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Location = new System.Drawing.Point(817, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 164);
            this.panel2.TabIndex = 8;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btn_delete.Location = new System.Drawing.Point(10, 116);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_delete.Size = new System.Drawing.Size(102, 39);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btn_save.Location = new System.Drawing.Point(10, 9);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_save.Size = new System.Drawing.Size(102, 37);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btn_edit.Location = new System.Drawing.Point(10, 62);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Padding = new System.Windows.Forms.Padding(5, 0, 8, 0);
            this.btn_edit.Size = new System.Drawing.Size(102, 38);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "Edit";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(52)))), ((int)(((byte)(66)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label15);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(39, 36);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(944, 31);
            this.panel4.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(403, 3);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 23);
            this.label15.TabIndex = 21;
            this.label15.Text = "User Details";
            // 
            // userDetails_datagrid
            // 
            this.userDetails_datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userDetails_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDetails_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.userDetails_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDetails_datagrid.Location = new System.Drawing.Point(39, 258);
            this.userDetails_datagrid.Margin = new System.Windows.Forms.Padding(2);
            this.userDetails_datagrid.MultiSelect = false;
            this.userDetails_datagrid.Name = "userDetails_datagrid";
            this.userDetails_datagrid.RowHeadersVisible = false;
            this.userDetails_datagrid.RowHeadersWidth = 51;
            this.userDetails_datagrid.RowTemplate.Height = 24;
            this.userDetails_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDetails_datagrid.Size = new System.Drawing.Size(944, 347);
            this.userDetails_datagrid.TabIndex = 49;
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1022, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.userDetails_datagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Details";
            this.Load += new System.EventHandler(this.UserDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDetails_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_userIsAccountActive;
        private System.Windows.Forms.ComboBox cmb_userType;
        private System.Windows.Forms.TextBox txt_userFirstName;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.TextBox txt_userConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_userPassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_userUName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_userLastName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.TextBox txt_userEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_userDOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_userMobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_userStoreId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_delete;
        private FontAwesome.Sharp.IconButton btn_save;
        private FontAwesome.Sharp.IconButton btn_edit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView userDetails_datagrid;
    }
}