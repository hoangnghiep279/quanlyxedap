using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XeDapShop
{
    public partial class frmLogin : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter dap;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if (user.Trim() == "") { MessageBox.Show("vui lòng nhập tài khoản của bạn"); }
            else if (pass.Trim() == "") { MessageBox.Show("vui lòng nhập mật khẩu của bạn"); }
            else
            {

                con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.QLXeDap;
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from tblAccount where TaiKhoan ='" + user + "' and MatKhau = '" + pass + "' ";
                cmd.Parameters.AddWithValue("TaiKhoan", user);
                cmd.Parameters.AddWithValue("MatKhau", pass);
                dap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                  
                    frmHome hm = new frmHome();
                    hm.ShowDialog();
               
                }
                else
                {
                    MessageBox.Show("TÀI KHOẢN MẬT KHẨU SAI");
                }

            }
        }
    }
}
