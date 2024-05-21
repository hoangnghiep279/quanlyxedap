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
using System.Xml.Linq;

namespace XeDapShop
{
    public partial class frmXedap : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        DataSet ds;
        SqlDataAdapter dap;
        public frmXedap()
        {
            InitializeComponent();
        }

        private void frmXedap_Load(object sender, EventArgs e)
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
            cmd.CommandText = "HienThiXD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            dgvXeDap.DataSource = ds.Tables[0];
            dgvXeDap.Refresh();
        }
        public void resetTextBox()
        {
            txtSearchMaxd.Text = "";
            txtSearchLoaixd.Text = "";
            txtMaxd.Text = "";
            txtLoaixd.Text = "";
            txtHangxd.Text = "";
            txtGiaxd.Text = "";
            txtSoLg.Text = "";
            txtMausac.Text = "";
            lblMessage.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string masp = txtMaxd.Text;
            if (masp.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập mã xe đạp");
            }
            string loaixd = txtLoaixd.Text;
            string hangxd = txtHangxd.Text;
            string giaxd = txtGiaxd.Text;
            string solg = txtSoLg.Text;
            string mausac = txtMausac.Text;


            if (loaixd.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập loại xe đạp");
            }
            else if (hangxd.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập hãng xe đạp");
            }
            else if (giaxd.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập giá xe đạp");
            }
            else if (solg.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập số lượng xe đạp");
            }
            else if (mausac.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập màu xe đạp");
            }
            else
            {
                // xu ly ngoai le chuong trinh de khong bi dung chuong trinh
                try
                {

                    cmd = new SqlCommand();
                    cmd.CommandText = "InsertXD";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@MaXD", txtMaxd.Text);
                    cmd.Parameters.AddWithValue("@LoaiXD", txtLoaixd.Text);
                    cmd.Parameters.AddWithValue("@HangXD", txtHangxd.Text);
                    cmd.Parameters.AddWithValue("@GiaXD", txtGiaxd.Text);
                    cmd.Parameters.AddWithValue("@SoLuong", txtSoLg.Text);
                    cmd.Parameters.AddWithValue("@MauSac", txtMausac.Text);
                    cmd.ExecuteNonQuery();
                    loadData();
                    lblMessage.Text = "thêm xe đạp thành công";
                    
                }
                catch
                {
                    MessageBox.Show("Mã xd đã tồn tại vui lòng nhập lại");
                }

            }
        }
        private void dgvXeDap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaxd.ReadOnly = true;
            int i;
            i = dgvXeDap.CurrentRow.Index;
            txtMaxd.Text = dgvXeDap.Rows[i].Cells[0].Value.ToString();
            txtLoaixd.Text = dgvXeDap.Rows[i].Cells[1].Value.ToString();
            txtHangxd.Text = dgvXeDap.Rows[i].Cells[2].Value.ToString();
            txtGiaxd.Text = dgvXeDap.Rows[i].Cells[3].Value.ToString();
            txtSoLg.Text = dgvXeDap.Rows[i].Cells[4].Value.ToString();
            txtMausac.Text = dgvXeDap.Rows[i].Cells[5].Value.ToString();
            dtpNgayNhap.Text  = dgvXeDap.Rows[i].Cells[6].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string loaixd = txtLoaixd.Text;
            string hangxd = txtHangxd.Text;
            string giaxd = txtGiaxd.Text;
            string solg = txtSoLg.Text;
            string mausac = txtMausac.Text;
            

            if (loaixd.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập loại xe đạp");
            }
            else if (hangxd.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập hãng xe đạp");
            }
            else if (giaxd.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập giá xe đạp");
            }
            else if (solg.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập số lượng xe đạp");
            }
            else if (mausac.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập màu xe đạp");
            }

            else
            {
                cmd.CommandText = "UpdateXD";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@MaXD", txtMaxd.Text);
                cmd.Parameters.AddWithValue("@LoaiXD", txtLoaixd.Text);
                cmd.Parameters.AddWithValue("@HangXD", txtHangxd.Text);
                cmd.Parameters.AddWithValue("@GiaXD", txtGiaxd.Text);
                cmd.Parameters.AddWithValue("@SoLuong", txtSoLg.Text);
                cmd.Parameters.AddWithValue("@MauSac", txtMausac.Text);
                cmd.Parameters.AddWithValue("@ngayNhap", dtpNgayNhap.Text);

                cmd.ExecuteNonQuery();
                loadData();
                lblMessage.Text = "sửa xe đạp thành công";
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "SearchXD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@MaXD", txtSearchMaxd.Text);
            cmd.Parameters.AddWithValue("@loaiXD", txtSearchLoaixd.Text);

            cmd.ExecuteNonQuery();
            ds = new DataSet();
            dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            dgvXeDap.DataSource = ds.Tables[0];
            dgvXeDap.Refresh();
        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.CommandText = "DeleteXD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@MaXD", txtMaxd.Text);
            cmd.ExecuteNonQuery();
            loadData();
            lblMessage.Text = "đã xóa xe đạp thành công";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResert_Click(object sender, EventArgs e)
        {
            txtMaxd.ReadOnly = false;
            resetTextBox();
            loadData();
        }

        
    }
}
