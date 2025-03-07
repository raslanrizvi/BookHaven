using BookHaven.Models;
using BookHaven.Repositories;
using FontAwesome.Sharp;
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

namespace BookHaven
{
    public partial class SupplierDetails: Form
    {
        private string connectionString = "Data Source=RASLANS_TUF;Initial Catalog=bookHaven;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public SupplierDetails()
        {
            InitializeComponent();
            ReadSuppliers();
        }
        private int suplirId = 0;

        //Code to Display Suppliers on Data Grid
        private void ReadSuppliers()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Type");
            dt.Columns.Add("Mobile");
            dt.Columns.Add("Email");
            dt.Columns.Add("Address");
            dt.Columns.Add("Current Stock");


            var repo = new SupplierRepository();
            var suplir = repo.GetSuppliers();

            foreach (var item in suplir)
            {
                var row = dt.NewRow();

             
                row["ID"] = item.id;
                row["Name"] = item.name;
                row["Type"] = item.typeName;
                row["Mobile"] = item.mobile;
                row["Email"] = item.email;
                row["Address"] = item.address;
                row["Current Stock"] = item.curntStock;
                

                
                dt.Rows.Add(row);
            }

            this.supplierDetails_datagrid.DataSource = dt;

        }

        //To add New or update existing Supplier
        private void btn_save_Click(object sender, EventArgs e)
        {

            SupplierModel suplir = new SupplierModel();

            suplir.id = this.suplirId;


            suplir.name = this.txt_supplierName.Text;

            if (cmb_supplierType.SelectedItem != null)
            {
                int x = int.Parse(cmb_supplierType.SelectedValue.ToString());
                suplir.typeId = x;
            }
            else if (suplirId != 0)
            {
                suplir.id = this.suplirId;
                
            }

            suplir.mobile = this.txt_supplierMobile.Text;
            suplir.email = this.txt_supplierEmail.Text;
            suplir.address = this.txt_supplierAddress.Text;

            var repo = new SupplierRepository();

            if (suplir.id == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are You sure You Want To Add This New Supplier?", "Add New Supplier", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                
                suplir.curntStock = 0;
                repo.CreateSupplier(suplir);
                //To Refresh the table with newly added record
                ReadSuppliers();
                cmb_supplierType.SelectedValue = 1;
                txt_supplierName.Clear();
                txt_supplierMobile.Clear();
                txt_supplierEmail.Clear();
                txt_supplierAddress.Clear();

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are You sure You Want To Update This Details?", "Update Existing Supplier", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                int curntStock = int.Parse(this.lbl_supplierStock.Text);
                suplir.curntStock = curntStock;
                repo.UpdateSupplier(suplir);
                //To Refresh the table with newly added record
                ReadSuppliers();
                cmb_supplierType.SelectedValue = 0;
                txt_supplierName.Clear();
                txt_supplierMobile.Clear();
                txt_supplierEmail.Clear();
                txt_supplierAddress.Clear();
            }

        }

        public void UpdateSupplier(SupplierModel suplir)
        {
            this.cmb_supplierType.SelectedValue = suplir.typeId;
            this.txt_supplierName.Text = suplir.name;
            this.txt_supplierMobile.Text = suplir.mobile;
            this.txt_supplierEmail.Text = suplir.email;
            this.txt_supplierAddress.Text = suplir.address;
            this.lbl_supplierStock.Text = suplir.curntStock.ToString();

            this.suplirId = suplir.id;
        }

        //Button to derive details from data grid to txtboxes
        private void btn_edit_Click(object sender, EventArgs e)
        {
            var val = this.supplierDetails_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int suplirId = int.Parse(val);

            var repo = new SupplierRepository();
            var suplir = repo.GetSupplier(suplirId);

            if (suplir == null) return;

            this.UpdateSupplier(suplir);
        }

        //Pre Load on Form
        private void SupplierDetails_Load(object sender, EventArgs e)
        {
            //Code for loading details on ComboBox Type
            try
            {

                using (SqlConnection con = new SqlConnection(connectionString))
                {

                    con.Open();
                    //MessageBox.Show("Connection Successful!");

                    string sql = "SELECT * FROM SupplierType";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        //setting default value to ComboBox
                        DataRow itemRow = dt.NewRow();
                        itemRow[1] = "Select Type";
                        dt.Rows.InsertAt(itemRow, 0);

                        //Displaying values while keeping the ID
                        cmb_supplierType.DataSource = dt;
                        //Branch is displayed on dropdown
                        cmb_supplierType.DisplayMember = "Type";
                        //ID is rememberd to use later
                        cmb_supplierType.ValueMember = "ID";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
                MessageBox.Show($"Database Connection Error: {ex.Message}");
            }

            //Combobox Type Code Ends Here
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var val = this.supplierDetails_datagrid.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int suplirId = int.Parse(val);

            //Showing Confirmation Dialog
            DialogResult dialogResult = MessageBox.Show("Are You sure You Want To Delete This Record?", "Delete Supplier", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var repo = new SupplierRepository();
            repo.DeleteSupplier(suplirId);

            //Update the Data Grid
            ReadSuppliers();
        }
    }
}
