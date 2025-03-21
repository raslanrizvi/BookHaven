using BookHaven.Models;
using BookHaven.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven
{
    public partial class CreateOrder: Form
    {
        private string connectionString = "Data Source=RASLANS_TUF;Initial Catalog=bookHaven;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public CreateOrder()
        {
            InitializeComponent();
        }

        int updOrdId = 0;

        public CreateOrder(int ordId)
        {
            InitializeComponent();
            updOrdId = ordId;
            ReadOrderItems();

            if (updOrdId != 0)
            {
                cmb_book.Enabled = false;
                nud_qty.Enabled = false;
                billItems_datagrid.Enabled = false;
                btn_addItem.Enabled = false;
                btn_deleteItem.Enabled = false;

                var repo = new OrderRepository();
                var ord = repo.GetOrder(updOrdId);
                if (ord == null) return;


                this.UpdateOrder(ord);
            }

        }

        int itmNo = 0;
        decimal subTot = 0;
        decimal netTot = 0;
        int indexRow = 0;
        int custId = 0;

        public void ReadOrderItems()
        {
            if (updOrdId != 0)
            {
                var repo = new OrderItemRepository();
                var ordItm = repo.GetOrderItems(updOrdId);

                foreach (var item in ordItm)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(billItems_datagrid);
                    newRow.Cells[0].Value = itmNo + 1;
                    newRow.Cells[1].Value = item.bookId;
                    newRow.Cells[2].Value = item.title;
                    newRow.Cells[3].Value = item.qty;
                    newRow.Cells[4].Value = item.price;
                    newRow.Cells[5].Value = item.tot;
                    billItems_datagrid.Rows.Add(newRow);
                    itmNo++;
                }
            }
        }

        //Code to Load data for Update Order
        public void UpdateOrder(OrdersModel ord)
        {

            custId = ord.custId;


            //conditon to fill Order type
            if (ord.ordType == "InStore")
            {
                this.chb_inStore.Checked = true;
            }
            else
            {
                this.chb_delivery.Checked = true;
                this.chb_delFree.Enabled = true;
            }

            //Condition to fill payment type
            if (ord.pytMethod == "Cash")
            {
                this.chb_cash.Checked = true;
            }
            else if (ord.pytMethod == "Card")
            {
                this.chb_card.Checked = true;
            }
            else
            {
                this.chb_payLater.Checked = true;
            }

            this.txt_discnt.Text = ord.discount.ToString();

            // to set delivery free 
            if (ord.deliveryFree == true)
            {
                chb_delFree.Checked = true;
            }
            else
            {
                chb_delFree.Checked = false;
                lbl_deliveryPrice.Show();
            }

            subTot = ord.tot + ord.discount;

            if (chb_delivery.Checked == true && chb_delFree.Checked == false)
            {
                subTot += 350;
            }
            netTot = ord.tot;
            lbl_subTotal.Text = subTot.ToString();
            lbl_netTotal.Text = ord.tot.ToString();

            txt_pymt.Text = ord.payAmt.ToString();
            lbl_balance.Text = Convert.ToString(ord.payAmt - ord.tot);



        }



        private void CreateOrder_Load(object sender, EventArgs e)
        {
            

            //Disabling by default
                chb_delFree.Enabled = false;
                lbl_deliveryPrice.Enabled = false;
                chb_cash.Enabled = false;
                chb_card.Enabled = false;
                chb_payLater.Enabled = false;
                lbl_deliveryPrice.Hide();

            


            //Code for loading details on ComboBox Customer
            try
            {
               

                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    con.Open();
                    //MessageBox.Show("Connection Successful!");

                    string sqlCstmr = "select ID, Name from Customer";
                    //cmb_customerBranch.Items.Clear(); // Clear existing items
                    using (SqlCommand cmdCstmr = new SqlCommand(sqlCstmr, con))
                    {
                        SqlDataAdapter daCstmr = new SqlDataAdapter(cmdCstmr);
                        DataTable dtCstmr = new DataTable();
                        daCstmr.Fill(dtCstmr);

                        //setting default value to ComboBox
                        DataRow itemRow = dtCstmr.NewRow();
                        itemRow[1] = "Select Customer";
                        dtCstmr.Rows.InsertAt(itemRow, 0);

                        //Displaying values while keeping the ID
                        cmb_cstmr.DataSource = dtCstmr;
                        //Branch is displayed on dropdown
                        cmb_cstmr.DisplayMember = "Name";
                        //ID is rememberd to use later
                        cmb_cstmr.ValueMember = "ID";
                    }
                }

                if (updOrdId != 0)
                {
                    this.cmb_cstmr.SelectedValue = custId;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception cstmr ComboBox : " + ex.ToString());
            }

            //Combobox Customer Code Ends Here 

            //Code for loading details on ComboBox Books
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    con.Open();
                    //MessageBox.Show("Connection Successful!");

                    string sqlItm = "select ID, Title from Books";
                    //cmb_customerBranch.Items.Clear(); // Clear existing items
                    using (SqlCommand cmdItm = new SqlCommand(sqlItm, con))
                    {
                        SqlDataAdapter daItm = new SqlDataAdapter(cmdItm);
                        DataTable dtItm = new DataTable();
                        daItm.Fill(dtItm);

                        //setting default value to ComboBox
                        DataRow itemRow = dtItm.NewRow();
                        itemRow[1] = "Select Book";
                        dtItm.Rows.InsertAt(itemRow, 0);

                        //Displaying values while keeping the ID
                        cmb_book.DataSource = dtItm;
                        //Branch is displayed on dropdown
                        cmb_book.DisplayMember = "Title";
                        //ID is rememberd to use later
                        cmb_book.ValueMember = "ID";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Book ComboBox : " + ex.ToString());
            }

            //Combobox Books Code Ends Here

        }

        //Load Necessory data when Customer is selected
        private void cmb_cstmr_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                int id = 0;
                if (int.TryParse(cmb_cstmr.SelectedValue?.ToString(), out id))
                {
                    string sql = "SELECT Mobile, Email, IsActive FROM Customer WHERE ID=@id";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //id = int.Parse(cmb_cstmr.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lbl_cstMobile.Text = reader.GetString(0);
                                lbl_cstEmail.Text = reader.GetString(1);

                                Boolean status = reader.GetBoolean(2);
                                if (status == true)
                                {
                                    lbl_mebStatus.Text = "Active";
                                }
                                else
                                {
                                    lbl_mebStatus.Text = "InActive";
                                }

                            }
                        }
                    }
                }
            }
        }

        //Load Necessory data when book is selected
        private void cmb_book_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                int id = 0;
                if (int.TryParse(cmb_book.SelectedValue?.ToString(), out id))
                {
                    string sql = "SELECT Qty FROM Books WHERE ID=@id";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int qty = reader.GetInt32(0);
                                lbl_avlbQty.Text = qty.ToString();
                                nud_qty.Maximum = qty;
                            }
                        }
                    }
                }
            }
        }

       
        private void btn_addItem_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string sql = "SELECT * FROM Books WHERE ID = @id";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", cmb_book.SelectedValue);
                    DataGridViewRow newRow = new DataGridViewRow();
                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        int qty = Convert.ToInt32(nud_qty.Value);
                        decimal total = reader.GetDecimal(8) * qty;
                        newRow.CreateCells(billItems_datagrid);
                        newRow.Cells[0].Value = itmNo + 1;
                        newRow.Cells[1].Value = reader.GetInt32(0);
                        newRow.Cells[2].Value = reader.GetString(3);
                        newRow.Cells[3].Value = qty;
                        newRow.Cells[4].Value = reader.GetDecimal(8);
                        newRow.Cells[5].Value = total;
                        billItems_datagrid.Rows.Add(newRow);
                        itmNo++;

                        subTot = subTot + total;
                        netTot = netTot + total;
                        lbl_netTotal.Text = "RS. " + netTot.ToString();
                        lbl_subTotal.Text = "RS. " + subTot.ToString();
                    }
                    cmb_book.SelectedIndex = 0;
                    nud_qty.Value = 0;
                    lbl_avlbQty.Text = "";



                }
            }
        }

        private void chb_inStore_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_inStore.Checked == true)
            {
                chb_delivery.Enabled = false;
                chb_cash.Enabled = true;
                chb_card.Enabled = true;
                chb_payLater.Enabled = true;
            }
            else if (chb_inStore.Checked == false)
            {
                chb_delivery.Enabled = true;
                chb_cash.Enabled = false;
                chb_card.Enabled = false;
                chb_payLater.Enabled = false;
            }
        }

        private void chb_delivery_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_delivery.Checked == true)
            {
                chb_inStore.Enabled = false;
                chb_delFree.Enabled = true;
                lbl_deliveryPrice.Show();
                chb_cash.Enabled = true;
                chb_card.Enabled = true;
                chb_payLater.Enabled = true;

                netTot = netTot + 350;
                lbl_netTotal.Text = "RS. " + netTot.ToString();
            }
            else if (chb_delivery.Checked == false)
            {
                chb_inStore.Enabled = true;
                chb_cash.Enabled = false;
                chb_card.Enabled = false;
                chb_payLater.Enabled = false;
                lbl_deliveryPrice.Hide();

                netTot = netTot - 350;
                lbl_netTotal.Text = "RS. " + netTot.ToString();
            }
        }

        private void chb_delFree_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_delFree.Checked == true)
            {
                lbl_deliveryPrice.Hide();
                netTot = netTot - 350;
                lbl_netTotal.Text = "RS. " + netTot.ToString();
            }
            else if (chb_delFree.Checked == false)
            {
                lbl_deliveryPrice.Show();
                netTot = netTot + 350;
                lbl_netTotal.Text = "RS. " + netTot.ToString();
            }
        }


        decimal discount;
        private void txt_discnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txt_discnt.Text == "")
                {
                    MessageBox.Show("Please Enter Discount Amount", "Discount Field Empty");
                }
                else
                {
                    discount = Convert.ToDecimal(txt_discnt.Text);
                    netTot = netTot - discount;
                    lbl_netTotal.Text = "RS. " + netTot.ToString();
                }
            }
        }

        private void txt_pymt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txt_discnt.Text == "")
                {
                    MessageBox.Show("Please Enter Payment Amount", "Payment Field Empty");
                }
                else
                {
                    decimal pymt = decimal.Parse(txt_pymt.Text);
                    decimal balance = pymt - netTot;
                    
                    lbl_balance.Text = balance.ToString();
                }
            }
        }

        private void billItems_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow slctRow = billItems_datagrid.Rows[indexRow];

            cmb_book.SelectedValue = slctRow.Cells[1].Value;
        }

        private void btn_deleteItem_Click(object sender, EventArgs e)
        {
            int rowIndex = billItems_datagrid.CurrentCell.RowIndex;

            DataGridViewRow slctRow = billItems_datagrid.Rows[indexRow];

            decimal itmTot = Convert.ToDecimal(slctRow.Cells[5].Value);

            subTot = subTot - itmTot;
            netTot = netTot = subTot;
            lbl_netTotal.Text = "RS. " + netTot.ToString();
            lbl_subTotal.Text = "RS. " + subTot.ToString();

            billItems_datagrid.Rows.RemoveAt(rowIndex);
            indexRow = 0;
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (updOrdId == 0)
            {
                //If it is a New Record then Create new order

                //Adding records to Order Model
                OrdersModel ord = new OrdersModel();
                ord.empId = 1;
                ord.custId = int.Parse(cmb_cstmr.SelectedValue.ToString());

                if (chb_inStore.Checked == true)
                {
                    ord.ordType = "inStore";
                }
                else
                {
                    ord.ordType = "Delivery";
                }

                if (chb_cash.Checked == true)
                {
                    ord.pytMethod = "Cash";
                }
                else if (chb_card.Checked == true)
                {
                    ord.pytMethod = "Card";
                }
                else if (chb_payLater.Checked == true)
                {
                    ord.pytMethod = "Pay Later";
                }

                ord.discount = discount;


                if (chb_delFree.Checked == true)
                {
                    ord.deliveryFree = true;
                }
                else
                {
                    ord.deliveryFree = false;
                }

                ord.tot = netTot;
                ord.payAmt = Convert.ToDecimal(txt_pymt.Text);

                if (ord.payAmt > 0 && ord.payAmt < netTot)
                {
                    ord.status = "Partial Payment";
                }
                else if (chb_delivery.Checked == true && ord.payAmt >= netTot)
                {
                    ord.status = "Deliverd";
                }
                else if (ord.payAmt >= netTot)
                {
                    ord.status = "Paid";
                }
                else
                {
                    ord.status = "Pending";
                }

                ord.cretedAt = DateTime.Now;
                //Order Model End

                //Showing Confirmation Dialog
                DialogResult dialogResult = MessageBox.Show("Are You sure You Want To Create This Order?", "Create Order", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }


                var OrdItmRepo = new OrderItemRepository();
                var OrdRepo = new OrderRepository();
                

                //Adding Items to Order Item Model
                foreach (DataGridViewRow row in billItems_datagrid.Rows)
                {
                    int rowItmNo = Convert.ToInt32(row.Cells["itemNo"].Value);
                    if (rowItmNo != 0)
                    {
                        OrderItemsModel ordItm = new OrderItemsModel();
                        ordItm.bookId = Convert.ToInt32(row.Cells["bookId"].Value);
                        ordItm.qty = Convert.ToInt32(row.Cells["bookQty"].Value);
                        ordItm.price = Convert.ToDecimal(row.Cells["pricePI"].Value);
                        ordItm.tot = Convert.ToDecimal(row.Cells["itmTotal"].Value);

                        //reating new Item Record for order
                        OrdItmRepo.CreateNewOrderItem(ordItm);
                        //Updating the QTY or Book record
                        OrdItmRepo.UpdateOrderItemQty(ordItm.bookId, ordItm.qty);
                    }
                }

                OrdRepo.CreateNewOrder(ord);
                itmNo = 0;
                subTot = 0;
                //netTot = 0;
            }
            else
            {
                //Else it is an existing order, Update Details
                //Updating records to Order Model
                OrdersModel ord = new OrdersModel();

                ord.ordId = updOrdId;
                
                if (chb_inStore.Checked == true)
                {
                    ord.ordType = "inStore";
                }
                else
                {
                    ord.ordType = "Delivery";
                }

                if (chb_cash.Checked == true)
                {
                    ord.pytMethod = "Cash";
                }
                else if (chb_card.Checked == true)
                {
                    ord.pytMethod = "Card";
                }
                else if (chb_payLater.Checked == true)
                {
                    ord.pytMethod = "Pay Later";
                }

                ord.discount = discount;

                if (chb_delFree.Checked == true)
                {
                    ord.deliveryFree = true;
                }
                else
                {
                    ord.deliveryFree = false;
                }

                ord.tot = netTot;
                ord.payAmt = Convert.ToDecimal(txt_pymt.Text);

                if (ord.payAmt > 0 && ord.payAmt < netTot)
                {
                    ord.status = "Partial Payment";
                }
                else if (chb_delivery.Checked == true && ord.payAmt >= netTot)
                {
                    ord.status = "Deliverd";
                }
                else if (ord.payAmt >= netTot)
                {
                    ord.status = "Paid";
                }
                else
                {
                    ord.status = "Pending";
                }

                ord.cretedAt = DateTime.Now;
                //Order Model End


                //Showing Confirmation Dialog
                DialogResult dialogResult = MessageBox.Show("Are You sure You Want To Update This Order?", "Update Order", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                var OrdRepo = new OrderRepository();
                OrdRepo.UpdateOrder(ord);

                itmNo = 0;
                subTot = 0;
                netTot = 0;
                updOrdId = 0;

            }



        }
    }
}
