using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace QuanLyChamSocKH
{
    public partial class HoTroYeuCau : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public HoTroYeuCau()
        {
            InitializeComponent();
        }

        private void tabControlPanel3_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            
        }
        private bool kiemtra()
        {
            if (txtSDT1.Text == "")
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
            gvHotro.DataSource = dt;
        }
        public void load()
        {
            KetNoi.openketnoi();
            gvHotro.DataSource = KetNoi.gettable("layhotro");
            KetNoi.dongketnoi();
        }
        private void HoTroYeuCau_Load(object sender, EventArgs e)
        {
            txtTennhanvien1.Text= Main.HoTenNhanVien;
            txtMaYC1.Enabled = false;
            txtKhachHang1.Enabled = false;
            txtTennhanvien1.Enabled = false;
            txtKhachHang1.Enabled = false;
            if (Main.ChucVu ==PhanQuyen.NhanVienKiThuat)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = false;
            }
            load();
        }

        private void gvHotro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int t = gvHotro.CurrentCell.RowIndex;
            txtMaYC.Text = gvHotro.Rows[t].Cells[0].Value.ToString();
            txtSDT.Text = gvHotro.Rows[t].Cells[1].Value.ToString();
            txtNoiDungYC.Text = gvHotro.Rows[t].Cells[2].Value.ToString();
            txtNoiDungPH.Text = gvHotro.Rows[t].Cells[3].Value.ToString();
            txtTinhtrang.Text = gvHotro.Rows[t].Cells[4].Value.ToString();
            DateTime dt = DateTime.ParseExact(gvHotro.Rows[t].Cells[5].Value.ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            datengay.Value = dt;
            txtThoiGianHT.Text = gvHotro.Rows[t].Cells[6].Value.ToString();
            txtNguyennhan.Text = gvHotro.Rows[t].Cells[7].Value.ToString();
            txtTennhanvien.Text = gvHotro.Rows[t].Cells[8].Value.ToString();
            txtGhichu.Text = gvHotro.Rows[t].Cells[9].Value.ToString();
            txtKhachHang.Text = gvHotro.Rows[t].Cells[10].Value.ToString();

            txtMaYC1.Text = gvHotro.Rows[t].Cells[0].Value.ToString();
            txtSDT1.Text = gvHotro.Rows[t].Cells[1].Value.ToString();
            txtNoidungyc1.Text = gvHotro.Rows[t].Cells[2].Value.ToString();
            txtNoidungph1.Text = gvHotro.Rows[t].Cells[3].Value.ToString();
            cbbtinhtrang.Text = gvHotro.Rows[t].Cells[4].Value.ToString();
            DateTime dt1 = DateTime.ParseExact(gvHotro.Rows[t].Cells[5].Value.ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            datengay1.Value = dt1;
            txtThoiGianHT1.Text = gvHotro.Rows[t].Cells[6].Value.ToString();
            txtNguyennhan1.Text = gvHotro.Rows[t].Cells[7].Value.ToString();
            txtGhichu1.Text = gvHotro.Rows[t].Cells[9].Value.ToString();
            txtKhachHang1.Text = gvHotro.Rows[t].Cells[10].Value.ToString();

        }

        private void gvHotro_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (!kiemtra())
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);

                return;

            }
            try
            {
                KetNoi.openketnoi();
                SqlCommand cmd = new SqlCommand("themyeucau", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sodienthoai", txtSDT1.Text);
                cmd.Parameters.AddWithValue("@noidungyc", txtNoidungyc1.Text);
                cmd.Parameters.AddWithValue("@noidungph", txtNoidungph1.Text);
                cmd.Parameters.AddWithValue("@tinhtrang", cbbtinhtrang.Text);
                cmd.Parameters.AddWithValue("@ngayyc", datengay1.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@thoigianht", txtThoiGianHT1.Text);
                cmd.Parameters.AddWithValue("@nguyennhan", txtNguyennhan1.Text);
                cmd.Parameters.AddWithValue("@hotennhanvien", txtTennhanvien1.Text);
                cmd.Parameters.AddWithValue("@ghichu", txtGhichu1.Text);
                cmd.ExecuteNonQuery();
                load();
                txtSDT1.Text = "";
                txtNoidungyc1.Text = "";
                txtNoidungph1.Text = "";
                cbbtinhtrang.Text = "";
                txtThoiGianHT1.Text = "";
                txtNguyennhan1.Text = "";
                txtGhichu1.Text = "";
                MessageBox.Show("Thêm mới thành công !", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Thêm không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn Có Chắc Đã Hoàn Thành Công Việc Trong Form Hỗ Trợ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

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
                SqlCommand cmd = new SqlCommand("suayeucau", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mayeucau", txtMaYC1.Text);
                cmd.Parameters.AddWithValue("@noidungyc", txtNoidungyc1.Text);
                cmd.Parameters.AddWithValue("@noidungph", txtNoidungph1.Text);
                cmd.Parameters.AddWithValue("@tinhtrang", cbbtinhtrang.Text);
                cmd.Parameters.AddWithValue("@ngayyc", datengay1.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@thoigianht", txtThoiGianHT1.Text);
                cmd.Parameters.AddWithValue("@nguyennhan", txtNguyennhan1.Text);
                cmd.Parameters.AddWithValue("@hotennhanvien", txtTennhanvien1.Text);
                cmd.Parameters.AddWithValue("@ghichu", txtGhichu1.Text);
                cmd.ExecuteNonQuery();
                load();
                txtMaYC1.Text = "";
                txtSDT1.Text = "";
                txtNoidungyc1.Text = "";
                txtNoidungph1.Text = "";
                cbbtinhtrang.Text = "";
                txtThoiGianHT1.Text = "";
                txtNguyennhan1.Text = "";
                txtGhichu1.Text = "";
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
                SqlCommand cmd = new SqlCommand("xoayeucau", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mayeucau", txtMaYC1.Text);
                cmd.ExecuteNonQuery();
                load();
                txtMaYC1.Text = "";
                txtSDT1.Text = "";
                txtNoidungyc1.Text = "";
                txtNoidungph1.Text = "";
                cbbtinhtrang.Text = "";
                txtThoiGianHT1.Text = "";
                txtNguyennhan1.Text = "";
                MessageBox.Show("Xóathành công !", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimkiem_Click_1(object sender, EventArgs e)
        {
            if (txtSdt4.Text != "")
            {
                try
                {
                    KetNoi.openketnoi();
                    SqlCommand cmd = new SqlCommand("timkiemsdthotro", KetNoi.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sodienthoai", txtSdt4.Text.Trim());
                    cmd.ExecuteNonQuery();
                    data(cmd);
                    txtSdt4.Text = "";
                }
                catch
                {
                    MessageBox.Show("Tìm kiếm không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else if (txtNoidungyc4.Text != "")
            {
                try
                {
                    KetNoi.openketnoi();
                    SqlCommand cmd = new SqlCommand("timkiemnoidungychotro", KetNoi.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@noidungyeucau", txtNoidungyc4.Text.Trim());
                    cmd.ExecuteNonQuery();
                    data(cmd);
                    txtNoidungyc4.Text = "";
                }
                catch
                {
                    MessageBox.Show("Tìm kiếm không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else if (cbbTinhtrang1.Text != "")
            {
                try
                {
                    KetNoi.openketnoi();
                    SqlCommand cmd = new SqlCommand("timkiemtinhtranghotro", KetNoi.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tinhtrang", cbbTinhtrang1.Text.Trim());
                    cmd.ExecuteNonQuery();
                    data(cmd);
                    txtNoidungyc4.Text = "";
                }
                catch
                {
                    MessageBox.Show("Tìm kiếm không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

    }
}
