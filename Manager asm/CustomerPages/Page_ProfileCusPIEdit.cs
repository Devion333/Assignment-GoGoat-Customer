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
    public partial class Page_ProfileCusPIEdit : Form
    {
        private int customerid;
        public Page_ProfileCusPIEdit(int customerid)
        {
            InitializeComponent();
            this.customerid = customerid;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(customerid);
            MessageBox.Show(customer.UpdateProfile(txtEmail.Text, txtPhoneNum.Text, txtAddress.Text));
        } 

        private void ProfileCus_PIEdit_Load(object sender, EventArgs e)
        {
            Customer customer = new Customer(customerid);
            customer.viewProfile();

            txtAddress.Text = customer.Address;
            txtEmail.Text = customer.Email;
            txtPhoneNum.Text = customer.Phonenum;
        }
    }
}
