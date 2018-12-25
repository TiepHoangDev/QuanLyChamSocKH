using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyChamSocKH
{
    public partial class DanhGia : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public DanhGia()
        {
            InitializeComponent();
        }
        private bool kiemtra()
        {
            if (txtSdt1.Text == "")
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
            gvDanhgia.DataSource = dt;
        }
        public void load()
        {
            KetNoi.openketnoi();
            gvDanhgia.DataSource = KetNoi.gettable("laydanhgia");
            KetNoi.dongketnoi();
        }

        private void gvDanhgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int t = gvDanhgia.CurrentCell.RowIndex;
            txtMadanhgia.Text = gvDanhgia.Rows[t].Cells[0].Value.ToString();
            txtSdt.Text = gvDanhgia.Rows[t].Cells[1].Value.ToString();
            txtNoidungdg.Text = gvDanhgia.Rows[t].Cells[2].Value.ToString();
            DateTime dt = DateTime.ParseExact(gvDanhgia.Rows[t].Cells[3].Value.ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            datengay.Value = dt;
            txtTenkhachhang.Text = gvDanhgia.Rows[t].Cells[4].Value.ToString();

            txtMadanhgia1.Text = gvDanhgia.Rows[t].Cells[0].Value.ToString();
            txtSdt1.Text = gvDanhgia.Rows[t].Cells[1].Value.ToString();
            txtNoidungdg1.Text = gvDanhgia.Rows[t].Cells[2].Value.ToString();
            DateTime dt1 = DateTime.ParseExact(gvDanhgia.Rows[t].Cells[3].Value.ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            datengay.Value = dt1;
            txtTenkhachhang1.Text = gvDanhgia.Rows[t].Cells[4].Value.ToString();

            txtMadanhgia2.Text = gvDanhgia.Rows[t].Cells[0].Value.ToString();
            txtSdt2.Text = gvDanhgia.Rows[t].Cells[1].Value.ToString();
            txtNoidungdg2.Text = gvDanhgia.Rows[t].Cells[2].Value.ToString();
            DateTime dt2 = DateTime.ParseExact(gvDanhgia.Rows[t].Cells[3].Value.ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            datengay.Value = dt2;
            txtTenkhachhang2.Text = gvDanhgia.Rows[t].Cells[4].Value.ToString();
        }

        private void DanhGia_Load(object sender, EventArgs e)
        {
            if (Main.ChucVu ==PhanQuyen.NhanVienChamSoc|| Main.ChucVu ==PhanQuyen.NhanVienKiThuat)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
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
                SqlCommand cmd = new SqlCommand("themdanhgia", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sodienthoai", txtSdt1.Text);
                cmd.Parameters.AddWithValue("@noidungdg", txtNoidungdg1.Text);
                cmd.Parameters.AddWithValue("@ngaydanhgia", datengay1.Value.ToString("yyyy/MM/dd"));
                cmd.ExecuteNonQuery();
                load();
                txtSdt1.Text = "";
                txtNoidungdg1.Text = "";
                txtTenkhachhang1.Text = "";
                datengay1.Text = "";
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
                SqlCommand cmd = new SqlCommand("suadanhgia", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@madanhgia", txtMadanhgia1.Text);
                cmd.Parameters.AddWithValue("@noidungdg", txtNoidungdg1.Text);
                cmd.Parameters.AddWithValue("@ngaydanhgia", datengay1.Value.ToString("yyyy/MM/dd"));
                cmd.ExecuteNonQuery();
                load();
                txtMadanhgia1.Text = "";
                txtSdt1.Text = "";
                txtNoidungdg1.Text = "";
                txtTenkhachhang1.Text = "";
                datengay1.Text = "";
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
                SqlCommand cmd = new SqlCommand("xoadanhgia", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@madanhgia", txtMadanhgia1.Text);
                cmd.ExecuteNonQuery();
                load();
                txtMadanhgia1.Text = "";
                txtSdt1.Text = "";
                txtNoidungdg1.Text = "";
                txtTenkhachhang1.Text = "";
                datengay1.Text = "";
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn Có Chắc Đã Hoàn Thành Công Việc Trong Form Đánh Giá ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtSdt3.Text != "")
            {
                try
                {
                    KetNoi.openketnoi();
                    SqlCommand cmd = new SqlCommand("timkiemsdtdanhgia", KetNoi.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sodienthoai", txtSdt3.Text.Trim());
                    cmd.ExecuteNonQuery();
                    data(cmd);
                    txtSdt3.Text = "";
                }
                catch
                {
                    MessageBox.Show("Tìm kiếm không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}
