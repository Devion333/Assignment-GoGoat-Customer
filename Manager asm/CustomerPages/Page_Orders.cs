using Org.BouncyCastle.Asn1.X509;
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
    public partial class Page_Orders : UserControl
    {
        private Order order;
        private int customerid;
        public Page_Orders(int customerid)
        {
            InitializeComponent();
            order = new Order();
            this.customerid = customerid;
        }

        private void Page_Orders_Load(object sender, EventArgs e)
        {
            DataTable orderData =order.GetOrder(customerid);
            dataOrder.DataSource = orderData;
        }
    }
}
