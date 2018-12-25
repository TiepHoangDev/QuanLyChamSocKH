using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyChamSocKH
{
    public partial class TaiKhoan : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }
        private bool kiemtra()
        {
            if (txtUsername.Text == "")
            {
                return false;
            }
            else if (txtManhanvien.Text == "")
            {
                return false;
            }
            return true;
        }
        public void data(SqlCommand cmd)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvTaikhoan.DataSource = dt;
        }
        public void load()
        {
            KetNoi.openketnoi();
            gvTaikhoan.DataSource = KetNoi.gettable("laytaikhoan");
            KetNoi.dongketnoi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn Có Chắc Đã Hoàn Thành Công Việc Trong Form Tài Khoản?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);

                return;

            }
            try
            {
                KetNoi.openketnoi();
                SqlCommand cmd = new SqlCommand("themtaikhoan", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@manv", txtManhanvien.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@chucvu", txtChucvu.Text);

                cmd.ExecuteNonQuery();
                load();
                txtUsername.Text = "";
                txtManhanvien.Text = "";
                txtPassword.Text = "";
                txtEmail.Text = "";
                txtChucvu.Text = "";
                MessageBox.Show("Thêm mới thành công !", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Thêm không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);

                return;

            }
            try
            {
                KetNoi.openketnoi();
                SqlCommand cmd = new SqlCommand("suataikhoan", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@manv", txtManhanvien.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@chucvu", txtChucvu.Text);

                cmd.ExecuteNonQuery();
                load();
                txtUsername.Text = "";
                txtManhanvien.Text = "";
                txtPassword.Text = "";
                txtEmail.Text = "";
                txtChucvu.Text = "";
                MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Sửa không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!kiemtra())
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);

                return;

            }
            try
            {
                KetNoi.openketnoi();
                SqlCommand cmd = new SqlCommand("xoataikhoan", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.ExecuteNonQuery();
                load();
                txtUsername.Text = "";
                txtManhanvien.Text = "";
                txtPassword.Text = "";
                txtEmail.Text = "";
                txtChucvu.Text = "";
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            load();
        }

        private void gvTaikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = gvTaikhoan.CurrentCell.RowIndex;
            txtUsername.Text = gvTaikhoan.Rows[t].Cells[0].Value.ToString();
            txtManhanvien.Text = gvTaikhoan.Rows[t].Cells[1].Value.ToString();
            txtEmail.Text = gvTaikhoan.Rows[t].Cells[2].Value.ToString();
            txtChucvu.Text = gvTaikhoan.Rows[t].Cells[3].Value.ToString();
            txtTennhanvien.Text = gvTaikhoan.Rows[t].Cells[4].Value.ToString();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
