namespace ClassConnectDesktop.Forms
{
    partial class frmAddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirebaseAuthSecret = new System.Windows.Forms.Label();
            this.lblFirebaseUrl = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassoword = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirebaseAuthSecret = new System.Windows.Forms.TextBox();
            this.txtFirebaseUrl = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEmailPass = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmailPass = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.45098F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.54902F));
            this.tableLayoutPanel1.Controls.Add(this.lblLogin, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblLastName, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFirebaseAuthSecret, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFirebaseUrl, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtLogin, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPassoword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFirstName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtLastName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtFirebaseAuthSecret, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtFirebaseUrl, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtEmailPass, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblEmailPass, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(565, 319);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogin.Location = new System.Drawing.Point(20, 20);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(132, 31);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.Location = new System.Drawing.Point(20, 51);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(132, 31);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstName.Location = new System.Drawing.Point(20, 82);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(132, 31);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastName.Location = new System.Drawing.Point(20, 113);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(132, 31);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name :";
            // 
            // lblFirebaseAuthSecret
            // 
            this.lblFirebaseAuthSecret.AutoSize = true;
            this.lblFirebaseAuthSecret.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirebaseAuthSecret.Location = new System.Drawing.Point(20, 144);
            this.lblFirebaseAuthSecret.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblFirebaseAuthSecret.Name = "lblFirebaseAuthSecret";
            this.lblFirebaseAuthSecret.Size = new System.Drawing.Size(132, 31);
            this.lblFirebaseAuthSecret.TabIndex = 0;
            this.lblFirebaseAuthSecret.Text = "Firebase AutSecret :";
            // 
            // lblFirebaseUrl
            // 
            this.lblFirebaseUrl.AutoSize = true;
            this.lblFirebaseUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirebaseUrl.Location = new System.Drawing.Point(20, 175);
            this.lblFirebaseUrl.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblFirebaseUrl.Name = "lblFirebaseUrl";
            this.lblFirebaseUrl.Size = new System.Drawing.Size(132, 31);
            this.lblFirebaseUrl.TabIndex = 0;
            this.lblFirebaseUrl.Text = "Firebase Url :";
            // 
            // txtLogin
            // 
            this.txtLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLogin.Location = new System.Drawing.Point(158, 23);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(387, 22);
            this.txtLogin.TabIndex = 2;
            // 
            // txtPassoword
            // 
            this.txtPassoword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassoword.Location = new System.Drawing.Point(158, 54);
            this.txtPassoword.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtPassoword.Name = "txtPassoword";
            this.txtPassoword.Size = new System.Drawing.Size(387, 22);
            this.txtPassoword.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Location = new System.Drawing.Point(158, 85);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(387, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Location = new System.Drawing.Point(158, 116);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(387, 22);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirebaseAuthSecret
            // 
            this.txtFirebaseAuthSecret.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirebaseAuthSecret.Location = new System.Drawing.Point(158, 147);
            this.txtFirebaseAuthSecret.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtFirebaseAuthSecret.Name = "txtFirebaseAuthSecret";
            this.txtFirebaseAuthSecret.Size = new System.Drawing.Size(387, 22);
            this.txtFirebaseAuthSecret.TabIndex = 2;
            // 
            // txtFirebaseUrl
            // 
            this.txtFirebaseUrl.Location = new System.Drawing.Point(158, 178);
            this.txtFirebaseUrl.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtFirebaseUrl.Name = "txtFirebaseUrl";
            this.txtFirebaseUrl.Size = new System.Drawing.Size(387, 22);
            this.txtFirebaseUrl.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSubmit.Location = new System.Drawing.Point(158, 271);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 34);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(158, 209);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(387, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // txtEmailPass
            // 
            this.txtEmailPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmailPass.Location = new System.Drawing.Point(158, 240);
            this.txtEmailPass.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.txtEmailPass.Name = "txtEmailPass";
            this.txtEmailPass.Size = new System.Drawing.Size(387, 22);
            this.txtEmailPass.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Location = new System.Drawing.Point(20, 206);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(132, 31);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email :";
            // 
            // lblEmailPass
            // 
            this.lblEmailPass.AutoSize = true;
            this.lblEmailPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmailPass.Location = new System.Drawing.Point(20, 237);
            this.lblEmailPass.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblEmailPass.Name = "lblEmailPass";
            this.lblEmailPass.Size = new System.Drawing.Size(132, 31);
            this.lblEmailPass.TabIndex = 3;
            this.lblEmailPass.Text = "Email Password :";
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 319);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "frmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add User";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirebaseAuthSecret;
        private System.Windows.Forms.Label lblFirebaseUrl;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassoword;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirebaseAuthSecret;
        private System.Windows.Forms.TextBox txtFirebaseUrl;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEmailPass;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEmailPass;
    }
}