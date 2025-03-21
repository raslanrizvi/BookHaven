using Microsoft.Reporting.WinForms;
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
    public partial class ReportView: Form
    {
        private string connectionString = "Data Source=RASLANS_TUF;Initial Catalog=bookHaven;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public ReportView()
        {
            InitializeComponent();
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            rdb_monthly.Checked = true;
            ReportDataSource salesRpt = new ReportDataSource("Orders", sales(DateTime.Now.AddDays(-30), DateTime.Now));
            ReportDataSource topBookRpt = new ReportDataSource("TopBookDataset", TopBooks());
            ReportDataSource invRpt = new ReportDataSource("Books", Inventory());

            sales_rptViewr.LocalReport.ReportPath = "SalesReports.rdlc";

            sales_rptViewr.LocalReport.DataSources.Add(salesRpt);
            sales_rptViewr.LocalReport.DataSources.Add(topBookRpt);
            sales_rptViewr.LocalReport.DataSources.Add(invRpt);
            sales_rptViewr.RefreshReport();
            this.sales_rptViewr.RefreshReport();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            sales_rptViewr.LocalReport.DataSources.Clear();

            if (rdb_daily.Checked == true)
            {
                ReportDataSource salesRpt = new ReportDataSource("Orders", sales(DateTime.Now.AddDays(-1), DateTime.Now));
                sales_rptViewr.LocalReport.DataSources.Add(salesRpt);
            }

            else if (rdb_weekly.Checked == true)
            {
                ReportDataSource salesRpt = new ReportDataSource("Orders", sales(DateTime.Now.AddDays(-7), DateTime.Now));
                sales_rptViewr.LocalReport.DataSources.Add(salesRpt);
            }

            else if (rdb_monthly.Checked == true)
            {
                ReportDataSource salesRpt = new ReportDataSource("Orders", sales(DateTime.Now.AddDays(-30), DateTime.Now));
                sales_rptViewr.LocalReport.DataSources.Add(salesRpt);
            }


            ReportDataSource topBookRpt = new ReportDataSource("TopBookDataset", TopBooks());
            ReportDataSource invRpt = new ReportDataSource("Books", Inventory());

            sales_rptViewr.LocalReport.ReportPath = "SalesReports.rdlc";

            sales_rptViewr.LocalReport.DataSources.Add(topBookRpt);
            sales_rptViewr.LocalReport.DataSources.Add(invRpt);
            sales_rptViewr.RefreshReport();
        }

        //Loading Orders table records
        private DataTable sales(DateTime Start, DateTime End)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string sql = "SELECT * FROM Orders WHERE Created_At >= @start AND Created_At <= @end ORDER BY Created_At DESC";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@start", Start);
                    cmd.Parameters.AddWithValue("@end", End);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        dt.Load(rd);
                    }
                }
            }

            return dt;
        }

        //Loading Inventory Table Records
        private DataTable Inventory()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sql = "SELECT * From Books ORDER BY Qty DESC";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            return dt;
        }

        //Loading Order Items Table Records
        private DataTable TopBooks()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string sql = "SELECT TOP 5 BookId, SUM(Ord_qty) AS TotalSold FROM OrderItems GROUP BY BookId ORDER BY TotalSold DESC";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        dt.Load(rd);
                    }
                }
            }

            return dt;
        }

    }
}
