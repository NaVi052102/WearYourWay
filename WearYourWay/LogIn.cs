using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.Common;
using System.Data.OleDb;

namespace WearYourWay
{
    public partial class LogIn : Form
    {

        public LogIn()
        {
            InitializeComponent();

        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Elementz\\Desktop\\OOP2 PROJECT\\dbWEARYOURWAY.mdb\"");
        OleDbCommand cmd = new OleDbCommand();

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            txtBox2.UseSystemPasswordChar = true;
            btnHideLogInPassword.Visible = false;
        }

        private void btnShowLogInPassword_Click(object sender, EventArgs e)
        {
            txtBox2.UseSystemPasswordChar = false;
            btnShowLogInPassword.Visible = false;
            btnHideLogInPassword.Visible = true;
        }

        private void btnHideLogInPassword_Click(object sender, EventArgs e)
        {
            txtBox2.UseSystemPasswordChar = true;
            btnShowLogInPassword.Visible = true;
            btnHideLogInPassword.Visible = false;
        }

        private void signInToCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM [Account] WHERE username='" + txtBox1.Text + "' and password= '" + txtBox2.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                string username = GetLoggedInUsername();
                bool isAdmin = dr["IsAdmin"].ToString() == "Yes";

                if (isAdmin)
                {
                    MessageBox.Show($"Welcome Admin {username}!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ADMINVIEW adminForm = new ADMINVIEW(); 
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show($"Welcome {username}!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form3 homeForm = new Form3();
                    homeForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBox2.Text = "";
                txtBox1.Text = "";
                txtBox1.Focus();
            }
            con.Close();
        }

        private string GetLoggedInUsername()
        {
            return txtBox1.Text;
        }
    }
    
    
 }



