using MySql.Data.MySqlClient;
namespace ACT1C_CRUD
{
    public partial class Form1 : Form
    {
        //Declare variable for handling connection string
        private MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection("server=localhost;database=calmadb;username=root;password=;");
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //Sanitized data to remove white-space
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            //Check if username and password are not empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username" +
                    " and password");
                return;
            }

            try
            {
                //login function
                //Open connection string
                connection.Open();
                //string varible that will handle login query
                string loginquery = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                //Execute loginquery
                MySqlCommand command = new MySqlCommand(loginquery, connection);
                //Sanitize query for sql injection
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                //Get record Total count
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Successfully Login!");
                    admin adminpage = new admin();
                    adminpage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username and password");
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
        }

        private void LinkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register registerpage = new register();
            registerpage.Show();
            this.Hide();
        }
    }
}
