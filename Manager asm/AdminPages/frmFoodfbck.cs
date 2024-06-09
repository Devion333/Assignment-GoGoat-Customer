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
    public partial class frmFoodfbck : UserControl
    {
        public frmFoodfbck()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.frmFoodfbck_Load);
        }

        private void frmFoodfbck_Load(object sender, EventArgs e)
        {
            LoadFeedback();
        }

        private void LoadFeedback()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    string query = "SELECT FoodQuality, Staff, Price, PortionSize, MenuVariety, Comments FROM FeedbackFood";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading feedback data: " + ex.Message);
                return;
            }

            if (dt.Rows.Count > 0)
            {
                dgvFeedbackFood.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No feedback data found.");
            }
        }
    }
}