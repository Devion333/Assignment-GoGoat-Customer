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
    public partial class Page_ProfileCus : UserControl
    {
        private int customerid;
        private string username;
        
        public Page_ProfileCus(int customerid, string username)
        {
            InitializeComponent();
            this.customerid = customerid;
            this.username = username;
        }
        private void addpage(UserControl Page)
        {
            Page.Dock = DockStyle.Fill;
            panelProfile.Controls.Clear();
            panelProfile.Controls.Add(Page);
            Page.BringToFront();
        }
        private void btn_PI_Click(object sender, EventArgs e)
        {
            Page_ProfileCus_PI page_ProfileCus_PI = new Page_ProfileCus_PI(customerid);
            addpage(page_ProfileCus_PI );

        }

        private void btn_Password_Click(object sender, EventArgs e)
        {
            Page_ProfileCusLogin obj = new Page_ProfileCusLogin(customerid, username);
            addpage(obj);
        }
    }
}
