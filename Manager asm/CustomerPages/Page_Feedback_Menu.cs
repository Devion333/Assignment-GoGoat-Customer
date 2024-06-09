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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Manager_asm.CustomerPages
{
    public partial class Page_Feedback_Menu : UserControl
    {
        //Customer customer;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        static SqlCommand cmd;
        private int customerID;

        public Page_Feedback_Menu(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected values from the radio buttons
            string food = GetSelectedValue(grpFood);
            string staff = GetSelectedValue(grpStaff);
            string price = GetSelectedValue(grpPrice);
            string portion = GetSelectedValue(GrpPortion);
            string menu = GetSelectedValue(grpMenu);

            // Get the comments from the text box
            string comments = richFoodFeedback.Text;

            // Validation check
            string status = "";
            if (string.IsNullOrWhiteSpace(food) || string.IsNullOrWhiteSpace(staff) || string.IsNullOrWhiteSpace(price) || string.IsNullOrWhiteSpace(portion) || string.IsNullOrWhiteSpace(menu))
            {
                status = "Please select all rating options before submitting.";
                MessageBox.Show(status, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO FeedbackFood (CustomerID, FoodQuality, Staff, Price, PortionSize, MenuVariety, Comments) VALUES (@CustomerID, @FoodQuality, @Staff, @Price, @PortionSize, @MenuVariety, @Comments)", con);

                // Add parameters to the SQL command
                cmd.Parameters.AddWithValue("@CustomerID", 1);
                cmd.Parameters.AddWithValue("@FoodQuality", food);
                cmd.Parameters.AddWithValue("@Staff", staff);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@PortionSize", portion);
                cmd.Parameters.AddWithValue("@MenuVariety", menu);
                cmd.Parameters.AddWithValue("@Comments", comments);

                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    status = "Feedback submitted successfully.";
                }
                else
                {
                    status = "Unable to submit feedback.";
                }
            }
            catch (Exception ex)
            {
                status = "An error occurred: " + ex.Message;
                MessageBox.Show(status, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            MessageBox.Show(status, "Submission Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private string GetSelectedValue(GroupBox groupBox)
        {
            foreach (RadioButton radioButton in groupBox.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }

            return "";
        }
        private void Page_Feedback_Food_Load(object sender, EventArgs e)
        {
           
        }
    }


}
