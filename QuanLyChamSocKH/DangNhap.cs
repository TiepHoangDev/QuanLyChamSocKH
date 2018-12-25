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
    public partial class DangNhap : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public DataTable checklog(string user, string pass)
        {
            KetNoi.openketnoi();
            SqlCommand cmd = new SqlCommand("kiemtradn", KetNoi.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tendangnhap", txtTenDangNhap.Text);
            cmd.Parameters.AddWithValue("@matkhau", txtMatKhau.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (this.txtTenDangNhap.Text == "" || this.txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                DataTable dt = new DataTable();
                dt = checklog(this.txtTenDangNhap.Text, this.txtMatKhau.Text);
                if (dt.Rows.Count > 0)
                {
                    // dang nhap thanh cong dong form dn mo form main
                    Main.ChucVu = dt.Rows[0][0].ToString().Trim();
                    Main.HoTenNhanVien = dt.Rows[0][1].ToString().Trim();
                    Main.Username = dt.Rows[0][2].ToString().Trim();
                    Main.Matkhau = dt.Rows[0][3].ToString().Trim();
                    this.Hide();
                    
                   Main mn = new Main();
                    mn.Show();

                      MessageBox.Show("Xin Chúc Mừng, Bạn Đã Đăng Nhập Thành Công Với Chức Vụ "+Main.ChucVu+"", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK);
                    txtTenDangNhap.Text = "";
                    txtTenDangNhap.Text = "";
                    this.txtTenDangNhap.Focus();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongBao;
            thongBao = (MessageBox.Show("Bạn có thực sự muốn thoát?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning));
            if (thongBao == DialogResult.Yes)
                Application.Exit();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
