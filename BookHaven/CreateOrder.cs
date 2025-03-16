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

        int itmNo = 0;
        decimal subTot = 0;
        decimal netTot = 0;
        int indexRow = 0;

        

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
                    int discount = int.Parse(txt_discnt.Text);
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

            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
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


            var OrdItmRepo = new OrderItemRepository();
            var OrdRepo = new OrderRepository();
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

                    OrdItmRepo.CreateNewOrderItem(ordItm);
                }
            }

            OrdRepo.CreateNewOrder(ord);

        }
    }
}
