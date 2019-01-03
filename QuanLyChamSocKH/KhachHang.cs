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
    public partial class KhachHang : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        public void data(SqlCommand cmd)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvHotro.DataSource = dt;
        }
        public void datakhachhang(SqlCommand cmd)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvKhachhang1.DataSource = dt;
        }
        public void load()
        {
            KetNoi.openketnoi();
            gvKhachhang1.DataSource = KetNoi.gettable("laykhachhang");
            gvKhachhang.DataSource = KetNoi.gettable("laykhachhang");
            gvHotro.DataSource = KetNoi.gettable("layhotro");
            KetNoi.dongketnoi();
        }
        private bool kiemtra()
        {
            if (txtSdt1.Text == "")
            {
                return false;
            }
            return true;
        }
        private bool kiemtrahotro()
        {
            if (txtSDT2.Text == "")
            {
                return false;
            }
            return true;
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            txtTennhanvien1.Text = Main.HoTenNhanVien;
            txtMakhachhang1.Enabled = false;
            txtTennhanvien1.Enabled = false;
            txtMaYC1.Enabled = false;
            txtKhachHang1.Enabled = false;
            if (Main.ChucVu == PhanQuyen.NhanVienKiThuat)
            {
                btnThemhotro.Enabled = false;
                btnXoahotro.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            load();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = gvKhachhang1.CurrentCell.RowIndex;
            txtMakhachhang1.Text = gvKhachhang1.Rows[t].Cells[0].Value.ToString();
            txtSdt1.Text = gvKhachhang1.Rows[t].Cells[1].Value.ToString();
            txtTenkhachhang1.Text = gvKhachhang1.Rows[t].Cells[2].Value.ToString();
            txtDiachi1.Text = gvKhachhang1.Rows[t].Cells[3].Value.ToString();
            txtCmtnd1.Text = gvKhachhang1.Rows[t].Cells[4].Value.ToString();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn Có Chắc Đã Hoàn Thành Công Việc Trong Form Khách Hàng ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
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
                SqlCommand cmd = new SqlCommand("themkhachhang", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sodienthoai", txtSdt1.Text);
                cmd.Parameters.AddWithValue("@tenkhachhang", txtTenkhachhang1.Text);
                cmd.Parameters.AddWithValue("@diachi", txtDiachi1.Text);
                cmd.Parameters.AddWithValue("@cmtnd", txtCmtnd1.Text);

                cmd.ExecuteNonQuery();
                load();
                txtSdt1.Text = "";
                txtTenkhachhang1.Text = "";
                txtDiachi1.Text = "";
                txtCmtnd1.Text = "";
                MessageBox.Show("Thêm mới thành công !\nChú ý: Mật khẩu đăng nhập website đánh giá của khách hàng trùng với Số điện thoại", "Thông báo", MessageBoxButtons.OK);
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
                SqlCommand cmd = new SqlCommand("suakhachhang", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@makhachhang", txtMakhachhang1.Text);
                cmd.Parameters.AddWithValue("@tenkhachhang", txtTenkhachhang1.Text);
                cmd.Parameters.AddWithValue("@diachi", txtDiachi1.Text);
                cmd.Parameters.AddWithValue("@cmtnd", txtCmtnd1.Text);

                cmd.ExecuteNonQuery();
                load();
                txtMakhachhang1.Text = "";
                txtSdt1.Text = "";
                txtTenkhachhang1.Text = "";
                txtDiachi1.Text = "";
                txtCmtnd1.Text = "";
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
                SqlCommand cmd = new SqlCommand("xoakhachhang", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@makhachhang", txtMakhachhang1.Text);
                cmd.ExecuteNonQuery();
                load();
                txtMakhachhang1.Text = "";
                txtSdt1.Text = "";
                txtTenkhachhang1.Text = "";
                txtDiachi1.Text = "";
                txtCmtnd1.Text = "";
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
            }
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load();
        }

        private void gvKhachhang_Click(object sender, EventArgs e)
        {

        }

        private void gvKhachhang_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int t = gvKhachhang.CurrentCell.RowIndex;
            txtMakhachhang.Text = gvKhachhang.Rows[t].Cells[0].Value.ToString();
            txtSdt.Text = gvKhachhang.Rows[t].Cells[1].Value.ToString();
            txtTenkhachhang.Text = gvKhachhang.Rows[t].Cells[2].Value.ToString();
            txtDiachi.Text = gvKhachhang.Rows[t].Cells[3].Value.ToString();
            txtCmtnd.Text = gvKhachhang.Rows[t].Cells[4].Value.ToString();
        }

        private void gvHotro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = gvHotro.CurrentCell.RowIndex;
            txtMaYC1.Text = gvHotro.Rows[t].Cells[0].Value.ToString();
            txtSDT2.Text = gvHotro.Rows[t].Cells[1].Value.ToString();
            txtNoidungyc1.Text = gvHotro.Rows[t].Cells[2].Value.ToString();
            txtNoidungph1.Text = gvHotro.Rows[t].Cells[3].Value.ToString();
            cbbtinhtrang.Text = gvHotro.Rows[t].Cells[4].Value.ToString();
            DateTime dt1 = DateTime.ParseExact(gvHotro.Rows[t].Cells[5].Value.ToString(), new string[] { "dd/MM/yyyy hh:mm:ss", "yyyy-MM-dd hh:mm:ss" }, CultureInfo.InvariantCulture, DateTimeStyles.None);
            datengay1.Value = dt1;
            txtThoiGianHT1.Text = gvHotro.Rows[t].Cells[6].Value.ToString();
            txtNguyennhan1.Text = gvHotro.Rows[t].Cells[7].Value.ToString();
            txtGhichu1.Text = gvHotro.Rows[t].Cells[9].Value.ToString();
            txtKhachHang1.Text = gvHotro.Rows[t].Cells[10].Value.ToString();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemhotro_Click(object sender, EventArgs e)
        {
            if (!kiemtrahotro())
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);

                return;

            }
            try
            {
                KetNoi.openketnoi();
                SqlCommand cmd = new SqlCommand("themyeucau", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sodienthoai", txtSDT2.Text);
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
                txtSDT2.Text = "";
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

        private void btnSuahotro_Click(object sender, EventArgs e)
        {

            if (!kiemtrahotro())
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
                txtSDT2.Text = "";
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

        private void btnXoahotro_Click(object sender, EventArgs e)
        {
            if (!kiemtrahotro())
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
                txtSDT2.Text = "";
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

        private void cbbTinhtrang1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimkiemkh_Click(object sender, EventArgs e)
        {
            if (txtSdt3.Text != "")
            {
                try
                {
                    KetNoi.openketnoi();
                    SqlCommand cmd = new SqlCommand("timkiemsdtkhachhang", KetNoi.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sodienthoai", txtSdt3.Text.Trim());
                    cmd.ExecuteNonQuery();
                    datakhachhang(cmd);
                    txtSdt3.Text = "";
                }
                catch
                {
                    MessageBox.Show("Tìm kiếm không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else if (txtTenkhachhang3.Text != "")
            {
                try
                {
                    KetNoi.openketnoi();
                    SqlCommand cmd = new SqlCommand("timkiemtenkhachhang", KetNoi.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tenkhachhang", txtTenkhachhang3.Text.Trim());
                    cmd.ExecuteNonQuery();
                    datakhachhang(cmd);
                    txtTenkhachhang3.Text = "";
                }
                catch
                {
                    MessageBox.Show("Tìm kiếm không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạm muốn reset mật khẩu khách hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    KetNoi.openketnoi();
                    string query = "UPDATE dbo.KhachHang SET MatKhau = SDT WHERE MaKH = @MaKH;";
                    using (SqlCommand cmd = new SqlCommand(query, KetNoi.con))
                    {
                        cmd.Parameters.AddWithValue("@MaKH", txtMakhachhang1.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Reset mật khẩu thành công. Mật khẩu trùng với SDT của khách hàng!");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
