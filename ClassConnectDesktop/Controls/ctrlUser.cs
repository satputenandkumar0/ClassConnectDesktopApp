using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassConnectDesktop.Forms;
using FireSharp.Response;
using ClassConnectDesktop.Class;

namespace ClassConnectDesktop
{
    public partial class ctrlUser : UserControl
    {
        private Users selectedUser;
        public ctrlUser()
        {
            InitializeComponent();
            FillUserDetails();
        }
        private async void FillUserDetails()
        {
            FirebaseManager manager = new FirebaseManager();
            FirebaseResponse responseGetAllUser = await manager.client.GetAsync("Users");
            List<Users> lstUsers = responseGetAllUser.ResultAs<List<Users>>();
            lstUsers.RemoveAll(x => x == null);
            dgvUsers.Rows.Clear();
            foreach (Users user in lstUsers)
            {
                dgvUsers.Rows.Add();
                int rowIndex = dgvUsers.Rows.Count - 1;
                dgvUsers.Rows[rowIndex].Cells[UserId.Index].Value = user.Id;
                dgvUsers.Rows[rowIndex].Cells[Login.Index].Value = user.Login;
                dgvUsers.Rows[rowIndex].Cells[Password.Index].Value = user.Password;
                dgvUsers.Rows[rowIndex].Cells[FirstName.Index].Value = user.FirstName;
                dgvUsers.Rows[rowIndex].Cells[LastName.Index].Value = user.LastName;
                dgvUsers.Rows[rowIndex].Cells[FirebaseAuthSecret.Index].Value = user.FirebaseAuthSecret;
                dgvUsers.Rows[rowIndex].Cells[FirebaseUrl.Index].Value = user.FirebaseUrl;
                dgvUsers.Rows[rowIndex].Cells[Email.Index].Value = user.Email;
                dgvUsers.Rows[rowIndex].Cells[EmailPassword.Index].Value = user.EmailPassword;
                dgvUsers.Rows[rowIndex].Cells[Update.Index].Value = "Update";
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (frmAddUser frm = new frmAddUser())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    FillUserDetails();                
            }
        }

        private async void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 9)
            {
              await  UpdateUser(e);
                using (frmAddUser frm = new frmAddUser(selectedUser))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        FillUserDetails();
                }
                selectedUser = null;
            }
        }
        private async Task UpdateUser(DataGridViewCellEventArgs e)
        {
            int userId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[UserId.Index].Value);
            FirebaseManager manager = new FirebaseManager();
            FirebaseResponse responseGetAllUser = await manager.client.GetAsync($"Users/{userId}");
            selectedUser = responseGetAllUser.ResultAs<Users>();
        }
    }
}
