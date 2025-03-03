using System;
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

        public string GetUserSession()
        {
            var loggedInUserName = lbl_loggedInUser.Text;
            return loggedInUserName;
        }

        private void MainPageDetails_Load(object sender, EventArgs e)
        {
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

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            //OpenChildForm(new Dashboard());
        }

        private void btn_stock_management_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new UserDetails());
        }

        private void btn_supplier_management_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            //OpenChildForm(new SupplierPage());
        }

        private void btn_cheque_management_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            //OpenChildForm(new ChequeDetailsPage());
        }

        private void btn_billing_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            //OpenChildForm(new BillingPage());
        }

        private void btn_user_management_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            //OpenChildForm(new UserDetails());
        }

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

        public void SetUserSession(string userType, string userName)
        {
            lbl_userType.Text = userType;
            lbl_loggedInUser.Text = userName;
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color9);
            //OpenChildForm(new CustomerDetailsPage());
        }

        private void btn_expanses_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color10);
            //OpenChildForm(new DailyExpensesPage());
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color10);
            //OpenChildForm(new OrderDetailsPage());
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color10);
            //OpenChildForm(new ReportingMainPage());
        }

        private void btn_Measurements_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color10);
            //OpenChildForm(new MeasurementMainDetail());
        }
    }
}
