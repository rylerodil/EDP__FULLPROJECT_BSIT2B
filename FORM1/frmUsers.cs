using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace FORM1
{
    public partial class frmUsers : Form
    {
        string connectionString = "server=localhost;database=rodil_db;uid=root;pwd=;";

        int selectedUserId = 0;

        public frmUsers()
        {
            InitializeComponent();
        }
        private void LoadUsers()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT * FROM users";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dgvUsers.DataSource = dt;
            }
        }

        MyDatabase db = new MyDatabase();
        bool isUpdate = false;

        private void frmUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmHome frm = new frmHome();
            frm.Show();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            isUpdate = false;
            string query = "SELECT tbluserinformation.userID, tbllogincredentials.LoginID, tbluserinformation.firstname, " +
                "tbluserinformation.middlename, tbluserinformation.lastname, tbluserinformation.emailAddress," +
                " tbluserinformation.homeAddress, tbluserinformation.birthDate, tbllogincredentials.user_username as 'Username'," +
                " tbllogincredentials.user_password as 'Password' FROM tbllogincredentials INNER JOIN tbluserinformation" +
                " ON tbllogincredentials.userID = tbluserinformation.userID;";

            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsers.DataSource = db.ExecuteReturnQuery(query);
            dgvUsers.Columns[0].Visible = false;
            dgvUsers.Columns[1].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn =
   new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO users
        (first_name, middle_name, last_name,
        email, home_address, birth_date,
        username, password)

        VALUES
        (@first, @middle, @last,
        @email, @address, @birth,
        @username, @password)";

                MySqlCommand cmd =
                new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@first",
                tbFname.Text);

                cmd.Parameters.AddWithValue("@middle",
                tbMname.Text);

                cmd.Parameters.AddWithValue("@last",
                tbLname.Text);

                cmd.Parameters.AddWithValue("@email",
                tbEmailAdd.Text);

                cmd.Parameters.AddWithValue("@address",
                tbHomeAdd.Text);

                cmd.Parameters.AddWithValue("@birth",
                dtBirthDate.Value);

                cmd.Parameters.AddWithValue("@username",
                tbUsername.Text);

                cmd.Parameters.AddWithValue("@password",
                tbPassword.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved!");

                LoadUsers();
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn =
    new MySqlConnection(connectionString))
            {
                conn.Open();

                string query =
                "UPDATE users SET status='Inactive' WHERE id=@id";

                MySqlCommand cmd =
                new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id",
                selectedUserId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Account Deactivated!");

                LoadUsers();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn =
      new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"UPDATE users SET
        first_name=@first,
        middle_name=@middle,
        last_name=@last,
        email=@email,
        home_address=@address,
        birth_date=@birth,
        username=@username,
        password=@password

        WHERE id=@id";

                MySqlCommand cmd =
                new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@first",
                tbFname.Text);

                cmd.Parameters.AddWithValue("@middle",
                tbFname.Text);

                cmd.Parameters.AddWithValue("@last",
                tbLname.Text);

                cmd.Parameters.AddWithValue("@email",
                tbEmailAdd.Text);

                cmd.Parameters.AddWithValue("@address",
                tbHomeAdd.Text);

                cmd.Parameters.AddWithValue("@birth",
                dtBirthDate.Value);

                cmd.Parameters.AddWithValue("@username",
                tbUsername.Text);

                cmd.Parameters.AddWithValue("@password",
                tbPassword.Text);

                cmd.Parameters.AddWithValue("@id",
                selectedUserId);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Updated!");

                LoadUsers();
            }
        }


        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                dgvUsers.Rows[e.RowIndex];

                selectedUserId =
                Convert.ToInt32(row.Cells["id"].Value);

                tbFname.Text =
                row.Cells["first_name"].Value.ToString();

                tbMname.Text =
                row.Cells["middle_name"].Value.ToString();

                tbLname.Text =
                row.Cells["last_name"].Value.ToString();

                tbEmailAdd.Text =
                row.Cells["email"].Value.ToString();

                tbHomeAdd.Text =
                row.Cells["home_address"].Value.ToString();

                dtBirthDate.Value =
                Convert.ToDateTime(row.Cells["birth_date"].Value);

                tbUsername.Text =
                row.Cells["username"].Value.ToString();

                tbPassword.Text =
                row.Cells["password"].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                DialogResult result =
                MessageBox.Show(
                    "Delete user?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conn =
                    new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        string query =
                        "DELETE FROM users WHERE id=@id";

                        MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@id",
                        selectedUserId);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Deleted!");

                        LoadUsers();
                    }
                }
            }
        }
    }
}
