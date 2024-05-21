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
    public partial class frmNguoiDung : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter dap;
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QLXeDap;
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            loadData();
        }
        public void loadData()
        {
            ds = new DataSet();
            cmd = new SqlCommand();
            cmd.CommandText = "HienThiUser";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            dgvUser.DataSource = ds.Tables[0];
            dgvUser.Refresh();
        }
        public void resetTextBox()
        {
            txtSearchName.Text = "";
            txtSearchId.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            dtpBirthday.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtPass.Text = "";
            dtpNgayDk.Text = "";
            lblMassage.Text = "";

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name=txtName.Text;
            string email =txtEmail.Text;
            string sdt =txtContact.Text;
            string addess=txtAddress.Text;
            string pass = txtPass.Text;

            if (name.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập họ tên");
            }
            else if (email.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập email");
            }
            else if (sdt.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập sdt");
            }
            else if (addess.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập địa chỉ");
            }
            else if (pass.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập mật khẩu");
            }
            else
            {
                cmd = new SqlCommand();
                cmd.CommandText = "InsertUser";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@HoTen", txtName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpBirthday.Value.Date);
                cmd.Parameters.AddWithValue("@SDT", txtContact.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                cmd.Parameters.AddWithValue("@NgayDK", dtpNgayDk.Value.Date);
                cmd.ExecuteNonQuery();
                loadData();
                lblMassage.Text = "thêm người dùng thành công";
            }
        }
        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvUser.CurrentRow.Index;
            txtId.Text = dgvUser.Rows[i].Cells[0].Value.ToString();
            txtName.Text = dgvUser.Rows[i].Cells[1].Value.ToString();
            txtEmail.Text = dgvUser.Rows[i].Cells[2].Value.ToString();
            dtpBirthday.Text = dgvUser.Rows[i].Cells[3].Value.ToString();
            txtContact.Text = dgvUser.Rows[i].Cells[4].Value.ToString();
            txtAddress.Text = dgvUser.Rows[i].Cells[5].Value.ToString();
            txtPass.Text = dgvUser.Rows[i].Cells[6].Value.ToString();
            dtpNgayDk.Text = dgvUser.Rows[i].Cells[7].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string sdt = txtContact.Text;
            string addess = txtAddress.Text;
            string pass = txtPass.Text;

            if (name.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập họ tên");
            }
            else if (email.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập email");
            }
            else if (sdt.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập sdt");
            }
            else if (addess.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập địa chỉ");
            }
            else if (pass.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập mật khẩu");
            }
            else
            {
                cmd = new SqlCommand();
                cmd.CommandText = "UpdateUser";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpBirthday.Value.Date);
                cmd.Parameters.AddWithValue("@SDT", txtContact.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Password", txtPass.Text);
                cmd.Parameters.AddWithValue("@NgayDK", dtpNgayDk.Value.Date);
                cmd.ExecuteNonQuery();
                loadData();
                lblMassage.Text = "sửa người dùng thành công";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "DeleteUser";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@Id", txtId.Text);
            cmd.ExecuteNonQuery();
            loadData();
            lblMassage.Text = "xóa người dùng thành công";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "SearchUser";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@Id", txtSearchId.Text);
            cmd.Parameters.AddWithValue("@HoTen", txtSearchName.Text);

            cmd.ExecuteNonQuery();
            ds = new DataSet();
            dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            dgvUser.DataSource = ds.Tables[0];
            dgvUser.Refresh();
        }

        private void btnResert_Click(object sender, EventArgs e)
        {
            resetTextBox();
            loadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
