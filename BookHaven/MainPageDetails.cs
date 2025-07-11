﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Media;
using BookHaven;
using FontAwesome.Sharp;

namespace POSSystem
{
    public partial class MainPageDetails : Form
    {
        private Panel leftBoarderBtn;
        private IconButton currentButton;
        private Form currentChildForm;

        public MainPageDetails()
        {
            InitializeComponent();
        }

        int id;
        string  role, userName;
        public MainPageDetails(int userID, string roleType, string name)
        {
            InitializeComponent();
            id = userID;
            role = roleType;
            userName = name;
        }

       

        private void MainPageDetails_Load(object sender, EventArgs e)
        {

            //ActivateButton(sender, RGBColors.color8);
            //OpenChildForm(new Dashboard(role));

            lbl_userType.Text = role;
            lbl_loggedInUser.Text = userName;

            //Hide Buttons Not Used
            btn_expanses.Hide();
            btn_Measurements.Hide();
            btn_reports2.Hide();

            //Restricting Based On Role
            if (role == "Sales Clark")
            {
                btn_supplierManagement.Hide();
                btn_userManagement.Hide();
                btn_inventoryManagement.Hide();
                btn_reports.Hide();
            }

            leftBoarderBtn = new Panel();
            currentButton = new IconButton();
            currentChildForm = new Form();
            leftBoarderBtn.Size = new Size(7, 60);
            panelManue.Controls.Add(leftBoarderBtn);
            btn_dashboard.PerformClick();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Color Collections
        private struct RGBColors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(172,126,241);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(249,118,176);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(253,138,114);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(51,255,255);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(249,85,155);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(24,161,251);
            public static System.Drawing.Color color7 = System.Drawing.Color.FromArgb(245, 129, 71);
            public static System.Drawing.Color color8 = System.Drawing.Color.FromArgb(155, 18, 71);
            public static System.Drawing.Color color9 = System.Drawing.Color.FromArgb(98, 196, 158);
            public static System.Drawing.Color color10 = System.Drawing.Color.FromArgb(233, 196, 15);
        }

        //Button onChange logics
        private void ActivateButton(object senderBtn, System.Drawing.Color color)
        {

            if (senderBtn != null)
            {
                DisableButton();

                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = System.Drawing.Color.FromArgb(37,36,81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                //Left boarder button
                leftBoarderBtn.BackColor = color;
                leftBoarderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBoarderBtn.Visible = true;
                leftBoarderBtn.BringToFront();
                //Icon current chile form
                iconCurrentChildForm.IconChar = currentButton.IconChar;
                iconCurrentChildForm.IconColor = color;
                lbl_Selectedbtn.Text = currentButton.Text;
            }
        }

        private void DisableButton()
        {
            try
            {
                currentButton.BackColor = System.Drawing.Color.FromArgb(124, 52, 66);
                currentButton.ForeColor = System.Drawing.Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = System.Drawing.Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                leftBoarderBtn.BackColor = System.Drawing.Color.FromArgb(124, 52, 66);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region Button Clicks

        

        private void btn_settings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
        }

        #endregion

        private void btn_logo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBoarderBtn.Enabled = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            lbl_Selectedbtn.Text = "DashBoard";

            btn_dashboard.PerformClick();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_form_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_form_resize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btn_form_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        //public void SetUserSession(string role, string name)
        //{
        //    lbl_userType.Text = role;
        //    lbl_loggedInUser.Text = name;
        //}

        

       

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
            
        }

        //Assigning Left Nav Clicks
        private void btn_customerManagement_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new CustomerDetails(role));
        }

        private void btn_supplierManagement_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new SupplierDetails());
        }

        private void btn_userManagement_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new UserDetails());
        }

        private void btn_createOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new CreateOrder());
        }

        private void btn_orderManagement_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new OrderManagement(role));
        }

        private void btn_inventoryManagement_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenChildForm(new InventoryManagement(role));
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenChildForm(new Dashboard(role));
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color9);
            OpenChildForm(new ReportView());
        }
    }
}
