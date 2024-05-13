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
namespace ACT1C_CRUD
{
    public partial class admin : Form
    {
        private MySqlConnection connection;
        public admin()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=calmadb;username=root;password=;");
        }

        private void admin_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            try
            {
                connection.Open();
                string showallrecordsquery = "SELECT ID, username, name, role FROM users ORDER BY ID ASC";
                MySqlCommand command = new MySqlCommand(showallrecordsquery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtUsername.Text = row.Cells["username"].Value.ToString();
                cbRole.Text = row.Cells["role"].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtSearch.Text;
                connection.Open();
                string showallrecordsquery = "SELECT ID, username, name, role FROM users WHERE username LIKE CONCAT ('%', @search, '%')";
                MySqlCommand command = new MySqlCommand(showallrecordsquery, connection);
                command.Parameters.AddWithValue("@search", search);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
                catch (Exception ex)
            {
                MessageBox.Show("Error:" +ex.Message);
            }
            finally 
            {
                if(connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Sanitized data to remove white-space
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string name = txtName.Text;
            string role = cbRole.Text;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)|| string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter role, name, username" +
                    " and password");
                return;
            }

            try
            {
                connection.Open();
                string loginquery = "INSERT INTO users (name, username, password, role) VALUES (@name, @username, @password, @role)";
                MySqlCommand command = new MySqlCommand(loginquery, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@role", role);
                int rawaffected = command.ExecuteNonQuery();
                if(rawaffected > 0)
                {
                    MessageBox.Show("Registered Successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to Registered Account");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            loaddata();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string ID =txtID.Text;
                if (string.IsNullOrEmpty(ID) )
                {
                    MessageBox.Show("No Record Found!");
                }

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginpage = new Form1();
            loginpage.Show();
            this.Hide();
        }
    }
}
