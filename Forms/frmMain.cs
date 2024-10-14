using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassConnectDesktop
{
    public partial class frmMain : Form
    {
        private float navBarActualWidth = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            int columnIndex = 0;
            if (tlpMain.ColumnStyles[columnIndex].Width != 0)
                navBarActualWidth = tlpMain.ColumnStyles[columnIndex].Width;
            float newWidth = (tlpMain.ColumnStyles[columnIndex].SizeType == SizeType.Absolute &&
                    tlpMain.ColumnStyles[columnIndex].Width == 0) ? navBarActualWidth : 0;

            tlpMain.ColumnStyles[columnIndex].SizeType = SizeType.Absolute;
            tlpMain.ColumnStyles[columnIndex].Width = newWidth;
            if(tlpMain.ColumnStyles[columnIndex].Width == 0)
            {
                btnShowHide.Text = ">>";
            }
            else
            {
                btnShowHide.Text = "<<";
            }
        }

        private void tmsShowUsers_Click(object sender, EventArgs e)
        {
            AddShowUserTab();
        }
        private void AddShowUserTab()
        {
            ctrlUser user = new ctrlUser();
            TabPages.TabPage page = new TabPages.TabPage("Show Users", user, "");
            pgc.Add(page);
            pgc.CurrentPage = pgc[pgc.Count - 1];
        }

        private void ShowUsers_Click(object sender, EventArgs e)
        {
            AddShowUserTab();
        }
    }
}
