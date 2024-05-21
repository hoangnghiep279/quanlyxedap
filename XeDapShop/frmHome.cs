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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form ChildForm)
        {
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            this.ptbMain.Controls.Add(ChildForm);
            this.ptbMain.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }
        private void ptbXedap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmXedap());
        }

        private void ptbUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNguoiDung());
        }

        private void ptbSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSetting());
        }

        private void ptbBaocao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBCNhapXD());
        }
    }
}
