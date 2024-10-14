namespace ClassConnectDesktop
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tmsUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsShowUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMenu = new System.Windows.Forms.ToolStrip();
            this.pgc = new TabPages.PageCollection();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ShowUsers = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlpMain.SuspendLayout();
            this.msMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.btnShowHide, 1, 2);
            this.tlpMain.Controls.Add(this.msMain, 0, 0);
            this.tlpMain.Controls.Add(this.tlpMenu, 0, 1);
            this.tlpMain.Controls.Add(this.pgc, 2, 2);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1624, 723);
            this.tlpMain.TabIndex = 0;
            // 
            // btnShowHide
            // 
            this.btnShowHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShowHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowHide.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHide.Location = new System.Drawing.Point(211, 64);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(24, 656);
            this.btnShowHide.TabIndex = 0;
            this.btnShowHide.Text = "<<";
            this.btnShowHide.UseVisualStyleBackColor = false;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // msMain
            // 
            this.tlpMain.SetColumnSpan(this.msMain, 3);
            this.msMain.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsUsers});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1624, 26);
            this.msMain.TabIndex = 2;
            this.msMain.Text = "menuStrip1";
            // 
            // tmsUsers
            // 
            this.tmsUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsShowUsers});
            this.tmsUsers.Name = "tmsUsers";
            this.tmsUsers.Size = new System.Drawing.Size(62, 22);
            this.tmsUsers.Text = "Users";
            // 
            // tmsShowUsers
            // 
            this.tmsShowUsers.Name = "tmsShowUsers";
            this.tmsShowUsers.Size = new System.Drawing.Size(124, 26);
            this.tmsShowUsers.Text = "Show";
            this.tmsShowUsers.Click += new System.EventHandler(this.tmsShowUsers_Click);
            // 
            // tlpMenu
            // 
            this.tlpMain.SetColumnSpan(this.tlpMenu, 3);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlpMenu.Location = new System.Drawing.Point(0, 29);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.Size = new System.Drawing.Size(1624, 32);
            this.tlpMenu.TabIndex = 1;
            this.tlpMenu.Text = "toolStrip1";
            // 
            // pgc
            // 
            this.pgc.BackColor = System.Drawing.SystemColors.Control;
            this.pgc.CurrentPage = null;
            this.pgc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgc.Location = new System.Drawing.Point(242, 65);
            this.pgc.Margin = new System.Windows.Forms.Padding(4);
            this.pgc.Name = "pgc";
            this.pgc.Size = new System.Drawing.Size(1378, 654);
            this.pgc.TabColor = System.Drawing.SystemColors.Control;
            this.pgc.TabIndex = 3;
            this.pgc.Text = "pageCollection1";
            this.pgc.TopMargin = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Orange;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ShowUsers, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(202, 656);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ShowUsers
            // 
            this.ShowUsers.BackColor = System.Drawing.Color.Bisque;
            this.ShowUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ShowUsers.FlatAppearance.BorderSize = 2;
            this.ShowUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowUsers.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowUsers.Location = new System.Drawing.Point(3, 3);
            this.ShowUsers.Name = "ShowUsers";
            this.ShowUsers.Size = new System.Drawing.Size(196, 35);
            this.ShowUsers.TabIndex = 0;
            this.ShowUsers.Text = "Show users";
            this.ShowUsers.UseVisualStyleBackColor = false;
            this.ShowUsers.Click += new System.EventHandler(this.ShowUsers_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 723);
            this.Controls.Add(this.tlpMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.Text = "Class connect user management system";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.ToolStrip tlpMenu;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmsUsers;
        private System.Windows.Forms.ToolStripMenuItem tmsShowUsers;
        public TabPages.PageCollection pgc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ShowUsers;
    }
}

