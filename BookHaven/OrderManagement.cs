using BookHaven.Repositories;
using POSSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;
using MessageBox = System.Windows.Forms.MessageBox;

namespace BookHaven
{
    public partial class OrderManagement: Form
    {
        public OrderManagement()
        {
            InitializeComponent();
            ReadOrders();
        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {

        }


        //Code to Display Order on Data Grid
        private void ReadOrders()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Employee ID");
            dt.Columns.Add("Customer ID");
            dt.Columns.Add("Order Type");
            dt.Columns.Add("Payment Method");
            dt.Columns.Add("Total");
            dt.Columns.Add("Pay Amount");
            dt.Columns.Add("Status");
            dt.Columns.Add("Created At");
            


            var repo = new OrderRepository();
            var ord = repo.GetOrders();

            foreach (var item in ord)
            {
                var row = dt.NewRow();

                row["ID"] = item.ordId;
                row["Employee ID"] = item.empId;
                row["Customer ID"] = item.custId;
                row["Order Type"] = item.ordType;
                row["Payment Method"] = item.pytMethod;
                row["Total"] = item.tot;
                row["Pay Amount"] = item.payAmt;
                row["Status"] = item.status;
                row["Created At"] = item.cretedAt;
                dt.Rows.Add(row);
            }

            this.orderDetails_datagrid.DataSource = dt;

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var val = this.orderDetails_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int ordId = int.Parse(val);

            var repo = new OrderRepository();
            var ord = repo.GetOrder(ordId);
            if (ord == null) return;

            CreateOrder crtOrd = new CreateOrder(ordId);
            //this.Hide();
            crtOrd.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var val = this.orderDetails_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int ordId = int.Parse(val);

            //Showing Confirmation Dialog
            DialogResult dialogResult = MessageBox.Show("Are You sure You Want To Delete This Record?", "Delete Order Record", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var orderRepo = new OrderRepository();
            var itemRepo = new OrderItemRepository();
            var ordItmRead = itemRepo.GetOrderItems(ordId);

            //For deleting each item with same ordId
            foreach (var item in ordItmRead)
            {
                int itmId = item.id;
                itemRepo.DeleteOrderItem(itmId);
            }

            //Deleting Orders Table record
            orderRepo.DeleteOrder(ordId);

            //Update the Data Grid
            ReadOrders();
        }

        private void btn_viwItms_Click(object sender, EventArgs e)
        {
            var val = this.orderDetails_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int ordId = int.Parse(val);

            ViewOrderItms voi = new ViewOrderItms(ordId);
            voi.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                MessageBox.Show("The Search Textbox is empty");
                ReadOrders();
            }
            else
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("ID");
                dt.Columns.Add("Employee ID");
                dt.Columns.Add("Customer ID");
                dt.Columns.Add("Order Type");
                dt.Columns.Add("Payment Method");
                dt.Columns.Add("Total");
                dt.Columns.Add("Pay Amount");
                dt.Columns.Add("Status");
                dt.Columns.Add("Created At");



                var repo = new OrderRepository();
                var ord = repo.SearchOrders(txt_search.Text);

                foreach (var item in ord)
                {
                    var row = dt.NewRow();

                    row["ID"] = item.ordId;
                    row["Employee ID"] = item.empId;
                    row["Customer ID"] = item.custId;
                    row["Order Type"] = item.ordType;
                    row["Payment Method"] = item.pytMethod;
                    row["Total"] = item.tot;
                    row["Pay Amount"] = item.payAmt;
                    row["Status"] = item.status;
                    row["Created At"] = item.cretedAt;
                    dt.Rows.Add(row);
                }

                this.orderDetails_datagrid.DataSource = dt;
            }
        }
    }
}
