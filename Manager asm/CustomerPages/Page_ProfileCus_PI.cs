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
    public partial class Page_ProfileCus_PI : UserControl
    {
        private int customerid;
        public Page_ProfileCus_PI(int customerid)
        {
            InitializeComponent();
            this.customerid = customerid;   

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Page_ProfileCusPIEdit obj = new Page_ProfileCusPIEdit(customerid);
            obj.ShowDialog();
        }

        private void Page_ProfileCus_PI_Load(object sender, EventArgs e)
        {
            Customer customer = new Customer(customerid);
            customer.viewProfile();

            lblName.Text = customer.Name;
            lblAddress.Text = customer.Address;
            lblEmail.Text = customer.Email;
            lblPhoneNum.Text = customer.Phonenum;
        }
    }
}
