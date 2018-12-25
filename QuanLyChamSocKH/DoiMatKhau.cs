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
    public partial class DoiMatKhau : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn Có Chắc Đã Hoàn Thành Công Việc Trong Form Đổi Mật Khẩu?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatkhau.Text == Main.Matkhau)
                {
                    if (txtMatkhaumoi.Text == txtNhaplaimatkhau.Text)
                    {
                        KetNoi.openketnoi();
                        SqlCommand cmd = new SqlCommand("doimatkhau", KetNoi.con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@password", txtMatkhaumoi.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đổi mật khẩu thành công. Mời bạn đăng nhập lại !", "Thông báo", MessageBoxButtons.OK);
                       
                    }
                    else
                    {
                        MessageBox.Show("Mật Khẩu bạn nhập không giống nhau", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mật Khẩu bạn nhập không chính xác", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Đổi mật khẩu không thành công vui lòng kiểm tra lại dữ liệu đã nhập !", "Thông báo", MessageBoxButtons.OK);
            }
            
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Main.Username;
            txtUsername.Enabled = false;
        }
    }
}
