using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM1
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister f = new frmRegister();
            f.Show();

        }

        private void btnStoreStatus_Click(object sender, EventArgs e)
        {
            frmStoreStatus f = new frmStoreStatus();
            f.Show();

        }

        private void btnPricebook_Click(object sender, EventArgs e)
        {
            frmPricebook f = new frmPricebook();
            f.Show();

        }

        private void btnVendors_Click(object sender, EventArgs e)
        {
            frmVendors f = new frmVendors();
            f.Show();

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers f = new frmUsers();
            f.Show();

        }

        private void btnTimeClock_Click(object sender, EventArgs e)
        {
            frmTimeClock f = new frmTimeClock();
            f.Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout?",
                                          "Logout",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }

        }
    }
}
