using BookHaven.Models;
using BookHaven.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace BookHaven
{
    public partial class InventoryManagement: Form
    {
        private string connectionString = "Data Source=RASLANS_TUF;Initial Catalog=bookHaven;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public InventoryManagement()
        {
            InitializeComponent();
            ReadInventory();
        }

        string role = "Sales Clark";
        public InventoryManagement(string Role)
        {
            InitializeComponent();
            role = Role;
        }

        private int invId = 0;

        public void UpdateInventory(InventoryModel inv)
        {
            this.cmb_invSuppName.SelectedValue = inv.supId;
            this.cmb_invGenre.SelectedValue = inv.genreId;

            this.txt_invTitle.Text = inv.title;
            this.txt_invAuthor.Text = inv.author;
            this.txt_invQty.Text = inv.qty.ToString();
            this.txt_invIsbn.Text = inv.isbn;
            this.txt_invCost.Text = inv.costPrice.ToString();
            this.txt_invSellPrice.Text = inv.sellPrice.ToString();

            this.invId = inv.id;
        }

        private void ReadInventory()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Supplier Name");
            dt.Columns.Add("Title");
            dt.Columns.Add("Genre");
            dt.Columns.Add("ISBN");
            dt.Columns.Add("Author");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Cost Price");
            dt.Columns.Add("Sell Price");


            var repo = new InventoryRepository();
            var inv = repo.GetInventories();

            foreach (var item in inv)
            {
                var row = dt.NewRow();

                row["ID"] = item.id;
                row["Supplier Name"] = item.supName;
                row["Title"] = item.title;
                row["Genre"] = item.genre;
                row["ISBN"] = item.isbn;
                row["Author"] = item.author;
                row["Qty"] = item.qty;
                row["Cost Price"] = item.costPrice;
                row["Sell Price"] = item.sellPrice;

                
                dt.Rows.Add(row);
            }

            this.invDetails_datagrid.DataSource = dt;

        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            //Code for loading details on ComboBox Gnrplier Name
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    con.Open();
                    //MessageBox.Show("Connection Successful!");

                    string sqlSup = "SELECT ID, Name FROM Supplier";
                    //cmb_customerBranch.Items.Clear(); // Clear existing items
                    using (SqlCommand cmdSup = new SqlCommand(sqlSup, con))
                    {
                        SqlDataAdapter daSup = new SqlDataAdapter(cmdSup);
                        DataTable dtSup = new DataTable();
                        daSup.Fill(dtSup);

                        //setting default value to ComboBox
                        DataRow itemRow = dtSup.NewRow();
                        itemRow[1] = "Select Supplier";
                        dtSup.Rows.InsertAt(itemRow, 0);

                        //Displaying values while keeping the ID
                        cmb_invSuppName.DataSource = dtSup;
                        //Branch is displayed on dropdown
                        cmb_invSuppName.DisplayMember = "Name";
                        //ID is rememberd to use later
                        cmb_invSuppName.ValueMember = "ID";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Supplier Combo : " + ex.ToString());
            }

            //Combobox Gnrplier Code Ends Here
            
            //Code for loading details on ComboBox Genre Name
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    con.Open();
                    //MessageBox.Show("Connection Successful!");

                    string sqlGnr = "SELECT ID, Genre FROM BookGenre";
                    //cmb_customerBranch.Items.Clear(); // Clear existing items
                    using (SqlCommand cmdGnr = new SqlCommand(sqlGnr, con))
                    {
                        SqlDataAdapter daGnr = new SqlDataAdapter(cmdGnr);
                        DataTable dtGnr = new DataTable();
                        daGnr.Fill(dtGnr);

                        //setting default value to ComboBox
                        DataRow itemRow = dtGnr.NewRow();
                        itemRow[1] = "Select Genre";
                        dtGnr.Rows.InsertAt(itemRow, 0);

                        //Displaying values while keeping the ID
                        cmb_invGenre.DataSource = dtGnr;
                        //Branch is displayed on dropdown
                        cmb_invGenre.DisplayMember = "Genre";
                        //ID is rememberd to use later
                        cmb_invGenre.ValueMember = "ID";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Genre Combo : " + ex.ToString());
            }

            //Combobox Genre Code Ends Here
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            InventoryModel inv = new InventoryModel();
            if (invId != 0)
            {
                inv.id = this.invId;
            }

            inv.id = this.invId;

            
            int x = int.Parse(cmb_invSuppName.SelectedValue.ToString());
            int y = int.Parse(cmb_invGenre.SelectedValue.ToString());
            inv.supId = x;
            inv.genreId = y;
            inv.title = txt_invTitle.Text;
            inv.author = txt_invAuthor.Text;
            int qty = int.Parse(txt_invQty.Text.ToString());
            inv.qty = qty;
            inv.isbn = txt_invIsbn.Text;
            decimal costPrice = decimal.Parse(txt_invCost.Text.ToString());
            inv.costPrice = costPrice;
            decimal sellPrice = decimal.Parse(txt_invSellPrice.Text.ToString());
            inv.sellPrice = sellPrice;

            var repo = new InventoryRepository();

            if (inv.id == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are You sure You Want To Add This New Inventory?", "Add New Inventory", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                repo.CreateInventory(inv);
                //To Refresh the table with newly added record
                ReadInventory();
                cmb_invSuppName.SelectedIndex = 0;
                cmb_invGenre.SelectedIndex = 0;
                txt_invTitle.Clear();
                txt_invAuthor.Clear();
                txt_invQty.Clear();
                txt_invCost.Clear();
                txt_invSellPrice.Clear();
                

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are You sure You Want To Update This Details?", "Update Existing Inventory Record", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                repo.UpdateInventory(inv);
                //To Refresh the table with newly added record
                ReadInventory();
                invId = 0;
                cmb_invSuppName.SelectedIndex = 0;
                cmb_invGenre.SelectedIndex = 0;
                txt_invTitle.Clear();
                txt_invAuthor.Clear();
                txt_invQty.Clear();
                txt_invCost.Clear();
                txt_invSellPrice.Clear();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var val = this.invDetails_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int invId = int.Parse(val);

            var repo = new InventoryRepository();
            var inv = repo.GetInventory(invId);

            if (inv == null) return;

            this.UpdateInventory(inv);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var val = this.invDetails_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int invId = int.Parse(val);

            //Showing Confirmation Dialog
            DialogResult dialogResult = MessageBox.Show("Are You sure You Want To Delete This Record?", "Delete Inventory Record", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var repo = new InventoryRepository();
            repo.DeleteInventory(invId);

            //Update the Data Grid
            ReadInventory();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                MessageBox.Show("The Search Textbox is empty");
                ReadInventory();
            }
            else
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("ID");
                dt.Columns.Add("Supplier Name");
                dt.Columns.Add("Title");
                dt.Columns.Add("Genre");
                dt.Columns.Add("ISBN");
                dt.Columns.Add("Author");
                dt.Columns.Add("Qty");
                dt.Columns.Add("Cost Price");
                dt.Columns.Add("Sell Price");



                var repo = new InventoryRepository();
                var inv = repo.SearchInventories(txt_search.Text);

                foreach (var item in inv)
                {
                    var row = dt.NewRow();

                    row["ID"] = item.id;
                    row["Supplier Name"] = item.supName;
                    row["Title"] = item.title;
                    row["Genre"] = item.genre;
                    row["ISBN"] = item.isbn;
                    row["Author"] = item.author;
                    row["Qty"] = item.qty;
                    row["Cost Price"] = item.costPrice;
                    row["Sell Price"] = item.sellPrice;

                    dt.Rows.Add(row);
                }

                this.invDetails_datagrid.DataSource = dt;
            }
        }
    }
}
