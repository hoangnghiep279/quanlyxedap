using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace XeDapShop
{
    public partial class frmBCNhapXD : Form
    {
        public frmBCNhapXD()
        {
            InitializeComponent();
        }

        private void frmBCNhapXD_Load(object sender, EventArgs e)
        {

            this.rpvBCNhapXD.RefreshReport();
            this.rpvBCNhapXD.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QLXeDap;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BCXDNhapTheoNgay";
            cmd.CommandType = CommandType.StoredProcedure; 
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@Ngaynhap", dtpNgayGH.Value.Date));
            DataSet ds = new DataSet(); 
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            rpvBCNhapXD.ProcessingMode = ProcessingMode.Local;
            rpvBCNhapXD.LocalReport.ReportPath = "rptBCXDNhap.rdlc";
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsBCNgayNhapXD";
                rds.Value = ds.Tables[0];
                rpvBCNhapXD.LocalReport.DataSources.Clear();
                rpvBCNhapXD.LocalReport.DataSources.Add(rds);
                rpvBCNhapXD.RefreshReport();
         
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
