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
    public partial class ThongKe : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        public void data(SqlCommand cmd)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvHotro.DataSource = dt;
            lblStatus.Text = "Số lượng yêu cầu hỗ trợ là: " + dt.Rows.Count.ToString() + " yêu cầu";
        }
        public void datadanhgia(SqlCommand cmd)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvDanhgia.DataSource = dt;
            lblStatus1.Text = "Số lượng đánh giá là: " + dt.Rows.Count.ToString() + " đánh giá";
        }
       
        private void ThongKe_Load(object sender, EventArgs e)
        {
            cbbtinhtrang.Text = "Đã Hoàn Thành";
        }

        private void btnThongke_Click_1(object sender, EventArgs e)
        {
                KetNoi.openketnoi();
                SqlCommand cmd = new SqlCommand("thongkehotro", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tungay", datetungay.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@denngay", datedenngay.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@tinhtrang", cbbtinhtrang.Text);
                
                cmd.ExecuteNonQuery();
                data(cmd);
                
                KetNoi.dongketnoi();
            
        }

      private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
        private void btnThongke1_Click(object sender, EventArgs e)
        {
                KetNoi.openketnoi();
                SqlCommand cmd = new SqlCommand("thongkedanhgia", KetNoi.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tungay", datetungay1.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@denngay", datedenngay1.Value.ToString("yyyy/MM/dd"));
                cmd.ExecuteNonQuery();
                datadanhgia(cmd);
                KetNoi.dongketnoi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn Có Chắc Đã Hoàn Thành Công Việc Trong Form Thống Kê ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
