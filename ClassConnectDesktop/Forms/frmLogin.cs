using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassConnectDesktop;

namespace ClassConnectDesktop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            // Subscribe to the KeyPress event for textboxes
            txtUsername.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            txtPassword.KeyPress += new KeyPressEventHandler(txt_KeyPress);
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Call the login method when Enter key is pressed
                btnLogin_Click(null,null);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string providedUsername = txtUsername.Text;
            string providedPassword = txtPassword.Text;

            // Check if the provided credentials are correct
            if ( UserDetails.AuthenticateUser(providedUsername, providedPassword))
            {
                // Open the main form
                frmMain mainForm = new frmMain();
                mainForm.Show();

                // Hide the login form
                this.Hide();
            }
            else
            {
                // Authentication failed
                MessageBox.Show("Invalid username or password. Please try again.");
                // Clear the textboxes
                txtUsername.Text = "";
                txtPassword.Text = "";

                // Set focus back to the username textbox
                txtUsername.Focus();
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
