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
    public partial class NhanVien : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public NhanVien()
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
            gvNhanvien.DataSource = dt;
        }
        public void load()
        {
            KetNoi.openketnoi();
           
            gvNhanvien.DataSource = KetNoi.gettable("laychucvu");
            KetNoi.dongketnoi();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn Có Chắc Đã Hoàn Thành Công Việc Trong Form Nhân Viên ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            txtManhanvien1.Enabled = false;
            txtChucvu1.Enabled = false;
            if (Main.ChucVu == PhanQuyen.NhanVienChamSoc|| Main.ChucVu ==PhanQuyen.NhanVienKiThuat)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            load();
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
            //try
            //{
               KetNoi.openketnoi();
                SqlCommand cmd = new SqlCommand("themnhanvien", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sodienthoai", txtSdt1.Text);
                cmd.Parameters.AddWithValue("@hoten", txtTennhanvien1.Text);
                cmd.Parameters.AddWithValue("@diachi", txtDiachi1.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", datengay1.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@gioitinh", cbbGioitinh2.Text);
                cmd.Parameters.AddWithValue("@luong", txtLuong1.Text);
                cmd.ExecuteNonQuery();
                load();
                txtSdt1.Text = "";
                txtTennhanvien1.Text = "";
                txtDiachi1.Text = "";
                datengay1.Text = "";
                txtGiotinh.Text = "";
                txtLuong1.Text = "";
                MessageBox.Show("Thêm mới thành công !", "Thông báo", MessageBoxButtons.OK);
                gvNhanvien.DataSource = KetNoi.gettable("laynhanvien");
            //}
            //catch
            //{
            //    MessageBox.Show("Thêm không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
            //}
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
                SqlCommand cmd = new SqlCommand("suanhanvien", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@manv", txtManhanvien1.Text);
                cmd.Parameters.AddWithValue("@hoten", txtTennhanvien1.Text);
                cmd.Parameters.AddWithValue("@diachi", txtDiachi1.Text);
                cmd.Parameters.AddWithValue("@ngaysinh", datengay1.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@gioitinh", cbbGioitinh2.Text);
                cmd.Parameters.AddWithValue("@luong", txtLuong1.Text);

                cmd.ExecuteNonQuery();
                load();
                txtManhanvien1.Text = "";
                txtSdt1.Text = "";
                txtTennhanvien1.Text = "";
                txtDiachi1.Text = "";
                datengay1.Text = "";
                txtGiotinh.Text = "";
                txtLuong1.Text = "";
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
                SqlCommand cmd = new SqlCommand("xoanhanvien", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@manv", txtManhanvien1.Text);
                cmd.ExecuteNonQuery();
                load();
                txtManhanvien1.Text = "";
                txtSdt1.Text = "";
                txtTennhanvien1.Text = "";
                txtDiachi1.Text = "";
                datengay1.Text = "";
                txtGiotinh.Text = "";
                txtLuong1.Text = "";
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void gvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = gvNhanvien.CurrentCell.RowIndex;
            txtManhanvien.Text = gvNhanvien.Rows[t].Cells[0].Value.ToString();
            txtSdt.Text = gvNhanvien.Rows[t].Cells[1].Value.ToString();
            txtTennhanvien.Text = gvNhanvien.Rows[t].Cells[2].Value.ToString();
            txtDiachi.Text = gvNhanvien.Rows[t].Cells[3].Value.ToString();
             DateTime dt = DateTime.ParseExact(gvNhanvien.Rows[t].Cells[4].Value.ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            datengay.Value = dt;
            txtGiotinh.Text = gvNhanvien.Rows[t].Cells[5].Value.ToString();
            txtLuong.Text = gvNhanvien.Rows[t].Cells[6].Value.ToString();
            txtChucvu.Text = gvNhanvien.Rows[t].Cells[7].Value.ToString();
            txtManhanvien1.Text = gvNhanvien.Rows[t].Cells[0].Value.ToString();
            txtSdt1.Text = gvNhanvien.Rows[t].Cells[1].Value.ToString();
            txtTennhanvien1.Text = gvNhanvien.Rows[t].Cells[2].Value.ToString();
            txtDiachi1.Text = gvNhanvien.Rows[t].Cells[3].Value.ToString();
            DateTime dt1 = DateTime.ParseExact(gvNhanvien.Rows[t].Cells[4].Value.ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            datengay1.Value = dt;
            cbbGioitinh2.Text = gvNhanvien.Rows[t].Cells[5].Value.ToString();
            txtLuong1.Text = gvNhanvien.Rows[t].Cells[6].Value.ToString();
            txtChucvu1.Text = gvNhanvien.Rows[t].Cells[7].Value.ToString();

            txtManhanvien2.Text = gvNhanvien.Rows[t].Cells[0].Value.ToString();
            txtSdt2.Text = gvNhanvien.Rows[t].Cells[1].Value.ToString();
            txtTennhanvien2.Text = gvNhanvien.Rows[t].Cells[2].Value.ToString();
            txtDiachi2.Text = gvNhanvien.Rows[t].Cells[3].Value.ToString();
            DateTime dt2 = DateTime.ParseExact(gvNhanvien.Rows[t].Cells[4].Value.ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            datengay.Value = dt2;
            txtGiotinh2.Text = gvNhanvien.Rows[t].Cells[5].Value.ToString();
            txtLuong2.Text = gvNhanvien.Rows[t].Cells[6].Value.ToString();
            txtChucvu2.Text = gvNhanvien.Rows[t].Cells[7].Value.ToString();


        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtTennhanvien3.Text != "")
            {
                try
                {
                    KetNoi.openketnoi();
                    SqlCommand cmd = new SqlCommand("timkiemtennhanvien", KetNoi.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tennhanvien", txtTennhanvien3.Text.Trim());
                    cmd.ExecuteNonQuery();
                    data(cmd);
                    txtTennhanvien3.Text = "";
                }
                catch
                {
                    MessageBox.Show("Tìm kiếm không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else if (txtChucvu3.Text != "")
            {
                try
                {
                    KetNoi.openketnoi();
                    SqlCommand cmd = new SqlCommand("timkiemchucvunhanvien", KetNoi.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@chucvu", txtChucvu3.Text.Trim());
                    cmd.ExecuteNonQuery();
                    data(cmd);
                    txtChucvu3.Text = "";
                }
                catch
                {
                    MessageBox.Show("Tìm kiếm không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}
