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
    public partial class frmReservationfbck : UserControl
    {
        public frmReservationfbck()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.frmReservationfbck_Load);
        }

        private void frmReservationfbck_Load(object sender, EventArgs e)
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
                    string query = "SELECT Atmosphere, Cleanliness, Music, EaseOfReservation, Flexibility, Comments FROM FeedbackReservation";
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
                dgvFeedbackReservation.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No feedback data found.");
            }
        }
    }
}