using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XeDapShop
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form ChildForm)
        {
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.pnDisplay.Controls.Add(ChildForm);
            this.pnDisplay.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            
        }
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChangepass());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
