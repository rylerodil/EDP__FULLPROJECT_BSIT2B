using MySql.Data.MySqlClient;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    

        string[,] userCredentials =
       {
            {"admin","admin1","Rylee Rodil" },
            {"cashier","password","kontol" }
        };
        DataTable dataTable = new DataTable();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Please enter username!", "Validation");
                tbUsername.Focus();

            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Please enter password!", "Validation");
                tbPassword.Focus();
            }

            else
            {
                DataTable dt = db.ExecuteReturnQuery("select * from tblLoginCredentials WHERE user_username = @uname AND user_password = @pword",
                  new MySqlParameter("@uname", tbUsername.Text),
                  new MySqlParameter("@pword", tbPassword.Text));
                if (dt.Rows.Count == 1)
                {
                    frmHome frm = new frmHome();
                    this.Hide();
                    frm.Show(); 
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }

        }
        MyDatabase db = new MyDatabase();
        private void Form1_Load(object sender, EventArgs e)
        {
            if (db.TestConnection() == true)
            {
                MessageBox.Show("Connected Successfully");
            }
            else
            {
                MessageBox.Show("Failed to Connect!");
            }
        }
    }
}