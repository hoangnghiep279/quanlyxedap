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
    public partial class frmChangepass : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter dap;
        public frmChangepass()
        {
            InitializeComponent();
        }
        private void frmChangepass_Load(object sender, EventArgs e)
        {

            con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QLXeDap;
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string user = txtAcount.Text;
            string newpass = txtNewpass.Text;
            string cfpass = txtConfirmPass.Text;

            if (user.Trim() == "") { MessageBox.Show("vui lòng nhập tài khoản của bạn"); }
            else if (newpass.Trim() == "") { MessageBox.Show("vui lòng nhập mật khẩu mới của bạn"); }
            else if (cfpass.Trim() == "") { MessageBox.Show("vui lòng nhập lại mật khẩu mới của bạn"); }
            else
            {
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from tblAccount where TaiKhoan ='" + user + "' ";
                cmd.Parameters.AddWithValue("TaiKhoan", user);
                dap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                errorProvider1.Clear();//xuất hiện dấu x khi thao tác sai
                if (dt.Rows.Count>0)
                {
                    if(txtNewpass.Text==txtConfirmPass.Text)
                    {
                        ds = new DataSet();
                        cmd = new SqlCommand();
                        cmd.CommandText = "ChangePass";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@TaiKHoan", txtAcount.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", txtNewpass.Text);
                        cmd.ExecuteNonQuery();
                        dap = new SqlDataAdapter(cmd);
                        dap.Fill(ds);
                        MessageBox.Show("Đổi Mật khẩu thành công");
                    }
                    else
                    {
                        errorProvider1.SetError(txtConfirmPass, "Nhập lại mật khẩu sai");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtAcount, "Tên tài khoản sai");
                }
            }
            

        }

        
    }
}
