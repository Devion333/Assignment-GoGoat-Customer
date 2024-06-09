using Manager_asm.CustomerPages;
using Manager_asm.Pages;
using Manager_asm.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_asm
{
    public partial class frmCustomerUI : Form
    {
        private string username;
        private int customerID;

        public frmCustomerUI() { }

        public frmCustomerUI(string username, int customerID)
        {
            InitializeComponent();
            this.username = username;
            this.customerID = customerID;
        }
        private void addpage(UserControl Page)
        {
            Page.Dock = DockStyle.Fill;
            panelCustomer.Controls.Clear();
            panelCustomer.Controls.Add(Page);
            Page.BringToFront();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Page_Menu page_Menu = new Page_Menu(customerID);
            addpage(page_Menu);
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Page_Feedback page_Feedback = new Page_Feedback(customerID);  
            addpage(page_Feedback);
        }

        private void btnreservation_Click(object sender, EventArgs e)
        {
            Page_Request page_Request = new Page_Request(customerID);
            addpage(page_Request);
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            Page_ProfileCus page_Profile = new Page_ProfileCus(customerID, username);
            addpage(page_Profile);
        }

        private void frmCustomerUI_Load(object sender, EventArgs e)
        {
            Page_Menu page_Menu = new Page_Menu(customerID);
            addpage(page_Menu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnOrders_Click(object sender, EventArgs e)
        {
            Page_Orders page_Orders = new Page_Orders(customerID);
            addpage(page_Orders);
        }
    }
}
