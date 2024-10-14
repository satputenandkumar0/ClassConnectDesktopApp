using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassConnectDesktop.Class;
using FireSharp.Response;

namespace ClassConnectDesktop.Forms
{
    public partial class frmAddUser : Form
    {
        bool isNewUser = false;
        Users user;
        public frmAddUser()
        {
            InitializeComponent();
            isNewUser = true;
        }
        public frmAddUser(Users user)
        {
            InitializeComponent();
            this.user = user;
            FillUserData();
        }
        private void FillUserData()
        {
            txtLogin.Text = user.Login;
            txtPassoword.Text = user.Password;
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtFirebaseAuthSecret.Text = user.FirebaseAuthSecret;
            txtFirebaseUrl.Text = user.FirebaseAuthSecret;
            txtEmail.Text = user.Email;
            txtEmailPass.Text = user.EmailPassword;
        }
        private void UpdateUserData()
        {
            user.Login = txtLogin.Text;
            user.Password = txtPassoword.Text;
            user.FirstName= txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.FirebaseAuthSecret = txtFirebaseAuthSecret.Text;
            user.FirebaseAuthSecret = txtFirebaseUrl.Text;
            user.Email = txtEmail.Text;
            user.EmailPassword = txtEmailPass.Text;
        }
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            FirebaseManager manager = new FirebaseManager();
            if (isNewUser)
            {
                int userId = 1;
                FirebaseResponse responseGetAllUser = await manager.client.GetAsync("Users");
                List<Users> lstUsers = responseGetAllUser.ResultAs<List<Users>>();
                lstUsers.RemoveAll(x => x == null);
                if (lstUsers.Count > 0)
                {
                    userId = lstUsers.Max(x => x.Id) + 1;
                }
                user = new Users()
                {
                    Id = userId,
                    Login = txtLogin.Text,
                    Password = txtPassoword.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    FirebaseAuthSecret = txtFirebaseAuthSecret.Text,
                    FirebaseUrl = txtFirebaseUrl.Text,
                    Email = txtEmail.Text,
                    EmailPassword = txtEmailPass.Text
                };
            }
            else
            {
                UpdateUserData();
            }
            SetResponse response = await manager.client.SetAsync($"Users/{user.Id}", user);
            MessageBox.Show("User added successfully!");
            txtLogin.Clear();
            txtPassoword.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtFirebaseAuthSecret.Clear();
            txtFirebaseUrl.Clear();
            txtEmail.Clear();
            txtEmailPass.Clear();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
