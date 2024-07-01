using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace WearYourWay
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Elementz\\Desktop\\OOP2 PROJECT\\dbWEARYOURWAY.mdb\"");
        OleDbCommand cmd = new OleDbCommand();
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Register_Load(object sender, EventArgs e)
        {

            txtBoxPassword.UseSystemPasswordChar = true;
            btnHidePassword.Visible = false;

            txtBoxConfirmPassword.UseSystemPasswordChar = true;
            btnHideConfirmPassword.Visible = false;
        }

        private void btnShowPassword_Click_1(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = false;
            btnShowPassword.Visible = false;
            btnHidePassword.Visible = true;
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = true;
            btnShowPassword.Visible = true;
            btnHidePassword.Visible = false;
        }

        private void btnShowConfirmPassword_Click(object sender, EventArgs e)
        {
            txtBoxConfirmPassword.UseSystemPasswordChar = false;
            btnShowConfirmPassword.Visible = false;
            btnHideConfirmPassword.Visible = true;
        }

        private void btnHideConfirmPassword_Click(object sender, EventArgs e)
        {
            txtBoxConfirmPassword.UseSystemPasswordChar = true;
            btnShowConfirmPassword.Visible = true;
            btnHideConfirmPassword.Visible = false;
        }

        private void logInToLogInAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBoxUsername.Text))
            {
                MessageBox.Show("Username cannot be empty.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                MessageBox.Show("Password cannot be empty.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBoxConfirmPassword.Text))
            {
                MessageBox.Show("Confirm Password cannot be empty.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtBoxPassword.Text != txtBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con.Open();
                string username = txtBoxUsername.Text;
                string password = txtBoxPassword.Text;
                string createdAt = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss");

                string checkQuery = "SELECT COUNT(*) FROM Account WHERE Username = ?";
                OleDbCommand checkCmd = new OleDbCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@p1", username);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Username already exists.", "Username Exists.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                    LogIn logIn = new LogIn();
                    logIn.Show();
                    this.Hide();

                    return;
                }

                string insertQuery = "INSERT INTO Account (Username, [Password], DateRegistered) VALUES (?, ?, ?)";
                OleDbCommand cmd = new OleDbCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@p1", username);
                cmd.Parameters.AddWithValue("@p2", password);
                cmd.Parameters.AddWithValue("@p3", createdAt);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Account created successfully!");

                Form3 homeForm = new Form3();
                homeForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
    
