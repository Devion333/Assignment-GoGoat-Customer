using Manager_asm.Pages;
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
    public partial class Page_PI : UserControl
    {
        private string username;
        public Page_PI(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btneditprofile_Click(object sender, EventArgs e)
        {
           Page_PI_Profile_Edit obj = new Page_PI_Profile_Edit(username);
            obj.Show();

        }

        private void Page_PI_Load(object sender, EventArgs e)
        {
            Manager obj = new Manager(username);
            Manager.viewProfile(obj);

            lblName.Text = obj.ManName;
            lblEmail.Text = obj.Email;
            lblPhoneNum.Text = obj.PhoneNum;
            lblAddress.Text = obj.Address;

        }
    }
}
