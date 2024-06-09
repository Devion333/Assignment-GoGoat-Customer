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

namespace Manager_asm.CustomerPages
{
    public partial class Page_Feedback_Reservation : UserControl
    {
        Customer customer;
        private string con = ConfigurationManager.ConnectionStrings["myCS"].ToString();
        private int customerID;
        public Page_Feedback_Reservation(int customerID)
        {
            InitializeComponent();
            this.customerID = customerID;
        }

        private void Page_Feedback_Reservation_Load(object sender, EventArgs e)
        {
          
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected values from the radio buttons
                string atmosphere = GetSelectedValue(grpAtmosphere);
                string cleanliness = GetSelectedValue(grpCleanliness);
                string ease = GetSelectedValue(grpEase);
                string flexibility = GetSelectedValue(grpFlexibility);
                string music = GetSelectedValue(grpMusic);

                // Get the comments from the text box
                string comments = richResFeedback.Text;

                // Create an instance of the Customer class
                customer = new Customer(customerID);

                // Call the SubmitFeedbackReservation method
                string result = customer.SubmitFeedbackReservation(atmosphere, cleanliness, music, ease, flexibility, comments);

                // Display the result
                MessageBox.Show(result);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    }

