using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_asm.CustomerPages
{
    public partial class frmPayment : Form
    {
        private Order currentOrder;
        private double totalPrice;
        private int customerId;

        public frmPayment(Order order, int customerId)
        {
            InitializeComponent();
            currentOrder = order;
            this.customerId = customerId;
            totalPrice = currentOrder.CalculateTotal();
            txtTotalPrice.Text = totalPrice.ToString("C2");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // Save the order to the database
                currentOrder.SaveOrderToDatabase(customerId);
                MessageBox.Show("Payment confirmed! Order placed successfully.");
                currentOrder.ConfirmPayment();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }
        }
    }
}
