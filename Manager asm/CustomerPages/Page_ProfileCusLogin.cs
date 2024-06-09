using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Manager_asm.CustomerPages
{
    public partial class Page_ProfileCusLogin : UserControl
    {
        private string username;
        private int customerid;
        public Page_ProfileCusLogin(int customerid, string username)
        {
            InitializeComponent();
            this.username = username;
            this.customerid = customerid;
        }

        private void btneditprofile_Click(object sender, EventArgs e)
        {
            Page_ProfileCusPIEdit obj = new Page_ProfileCusPIEdit(customerid);
            obj.Show;
        }

        private void Page_ProfileCusLogin_Load(object sender, EventArgs e)
        {
            Customer customer = new Customer(customerid);
            User obj1 = new User(username);
            customer.ViewLogin(obj1);

            lblUsername.Text = obj1.username;
            lblPassword.Text = obj1.password;
        }
    }
}
