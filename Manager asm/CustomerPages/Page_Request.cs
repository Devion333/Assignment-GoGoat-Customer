using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Manager_asm.CustomerPages
{
    public partial class Page_Request : UserControl
    {   
        Customer customer;
        private int customerId;

        public Page_Request(int customerID)
        {
            InitializeComponent();
            customer = new Customer(customerID);
            this.customerId = customerID;

        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime datetime = datetimepicker.Value.Date;
                int pax = cmbPax.SelectedIndex + 1;
                string type = cmbType.Text;

                string result = customer.RequestReservation(datetime, pax, type);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Page_Request_Load(object sender, EventArgs e)
        {
            customer.GetReservation(dataReserve);
        }
    }
}
