namespace BookHaven
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_login = new FontAwesome.Sharp.IconButton();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.txtb_password = new System.Windows.Forms.TextBox();
            this.txtb_userName = new System.Windows.Forms.TextBox();
            this.lbl_errorMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(252, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Controls.Add(this.lbl_password);
            this.panel2.Controls.Add(this.lbl_userName);
            this.panel2.Controls.Add(this.txtb_password);
            this.panel2.Controls.Add(this.txtb_userName);
            this.panel2.Controls.Add(this.lbl_errorMsg);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(171, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 197);
            this.panel2.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Green;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.btn_login.IconColor = System.Drawing.Color.White;
            this.btn_login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_login.IconSize = 32;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(128, 159);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btn_login.Size = new System.Drawing.Size(110, 36);
            this.btn_login.TabIndex = 30;
            this.btn_login.Text = "Login";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(53, 110);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(86, 18);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.Location = new System.Drawing.Point(53, 71);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(93, 18);
            this.lbl_userName.TabIndex = 2;
            this.lbl_userName.Text = "UserName";
            // 
            // txtb_password
            // 
            this.txtb_password.Font = new System.Drawing.Font("Lucida Sans", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtb_password.Location = new System.Drawing.Point(152, 108);
            this.txtb_password.Name = "txtb_password";
            this.txtb_password.Size = new System.Drawing.Size(155, 22);
            this.txtb_password.TabIndex = 2;
            this.txtb_password.UseSystemPasswordChar = true;
            // 
            // txtb_userName
            // 
            this.txtb_userName.Font = new System.Drawing.Font("Lucida Sans", 9.25F, System.Drawing.FontStyle.Bold);
            this.txtb_userName.Location = new System.Drawing.Point(152, 69);
            this.txtb_userName.Name = "txtb_userName";
            this.txtb_userName.Size = new System.Drawing.Size(155, 22);
            this.txtb_userName.TabIndex = 1;
            // 
            // lbl_errorMsg
            // 
            this.lbl_errorMsg.AutoSize = true;
            this.lbl_errorMsg.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbl_errorMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_errorMsg.Location = new System.Drawing.Point(32, 136);
            this.lbl_errorMsg.Name = "lbl_errorMsg";
            this.lbl_errorMsg.Size = new System.Drawing.Size(0, 19);
            this.lbl_errorMsg.TabIndex = 0;
            this.lbl_errorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login to your Account";
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Maroon;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btn_Exit.IconColor = System.Drawing.Color.White;
            this.btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Exit.IconSize = 32;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(589, 390);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btn_Exit.Size = new System.Drawing.Size(94, 38);
            this.btn_Exit.TabIndex = 29;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(117)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(704, 439);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.TextBox txtb_userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtb_password;
        private FontAwesome.Sharp.IconButton btn_Exit;
        private FontAwesome.Sharp.IconButton btn_login;
        private System.Windows.Forms.Label lbl_errorMsg;
    }
}