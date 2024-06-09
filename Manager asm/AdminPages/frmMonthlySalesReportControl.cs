using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_asm.AdminPages
{
    public partial class frmMonthlySalesReportControl : UserControl
    {
        public frmMonthlySalesReportControl()
        {
            InitializeComponent();
            LoadChefs();
        }

        private void LoadChefs()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT UserID, Username FROM Users WHERE Role = 'Chef'", con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbChef.Items.Add(new ComboBoxItem(reader["Username"].ToString(), reader["UserID"].ToString()));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void GenerateReport()
        {
            string selectedMonth = cmbMonth.SelectedItem != null ? cmbMonth.SelectedItem.ToString() : null;
            string selectedChefId = cmbChef.SelectedItem != null ? ((ComboBoxItem)cmbChef.SelectedItem).Value : null;

            if (selectedMonth == null && selectedChefId == null)
            {
                MessageBox.Show("Please select a month or a chef.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    string query = "SELECT o.OrderID, s.SalesID, s.Price, s.Date, u.Username AS ChefName " +
                                   "FROM Sales s " +
                                   "JOIN [Order] o ON s.OrderID = o.OrderID " +
                                   "JOIN Users u ON o.ChefID = u.UserID " +
                                   "WHERE 1=1";

                    if (selectedMonth != null)
                    {
                        int monthNumber = DateTime.ParseExact(selectedMonth, "MMMM", System.Globalization.CultureInfo.InvariantCulture).Month;
                        query += " AND MONTH(s.Date) = @month";
                    }

                    if (selectedChefId != null)
                    {
                        query += " AND o.ChefID = @chefId";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (selectedMonth != null)
                        {
                            int monthNumber = DateTime.ParseExact(selectedMonth, "MMMM", System.Globalization.CultureInfo.InvariantCulture).Month;
                            cmd.Parameters.AddWithValue("@month", monthNumber);
                        }

                        if (selectedChefId != null)
                        {
                            cmd.Parameters.AddWithValue("@chefId", selectedChefId);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvSalesReport.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public ComboBoxItem(string text, string value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport();   
        }
    }
}