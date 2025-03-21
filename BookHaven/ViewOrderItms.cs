using BookHaven.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven
{
    public partial class ViewOrderItms: Form
    {
        int ordid = 0;
        public ViewOrderItms(int ordId)
        {
            InitializeComponent();
            ordid = ordId;
        }
        public ViewOrderItms()
        {
            InitializeComponent();
        }

        

        

        private void ReadOrdItms()
        {

            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Book ID");
            dt.Columns.Add("Book Title");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Price/Item");
            dt.Columns.Add("Total");

            var ordItmRepo = new OrderItemRepository();
            var readOrdItm = ordItmRepo.GetOrderItems(ordid);

            foreach (var item in readOrdItm)
            {
                var row = dt.NewRow();

                row["ID"] = item.id;
                row["Book ID"] = item.bookId;
                row["Book Title"] = item.title;
                row["Qty"] = item.qty;
                row["Price/Item"] = item.price;
                row["Total"] = item.tot;

                dt.Rows.Add(row);
            }

            this.ordItmDetails_datagrid.DataSource = dt;
        }

        private void ViewOrderItms_Load(object sender, EventArgs e)
        {
            lbl_orderId.Text = "Order ID : " + ordid;
            ReadOrdItms();

        }
    }
}
