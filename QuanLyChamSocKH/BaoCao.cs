using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyChamSocKH
{
    public partial class BaoCao : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'DataSet1.DanhGia' table. You can move, or remove it, as needed.
            //this.DanhGiaTableAdapter.Fill(this.DataSet1.DanhGia);
            //// TODO: This line of code loads data into the 'DataSet1.HoTroYC' table. You can move, or remove it, as needed.
            
            //this.reportViewer2.RefreshReport();

            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn Có Chắc Đã Hoàn Thành Công Việc Trong Form Báo Cáo ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            this.HoTroYCTableAdapter.Fill(this.DataSet1.HoTroYC, datetungay.Value.ToString(), datedenngay.Value.ToString());
            //this.LoiNhuanTableAdapter.Fill(this.DataSet1.LoiNhuan, dtngay.Value.ToString(), dtdenngay.Value.ToString());

            this.reportViewer1.RefreshReport();
           
        }

        private void btnBaocao1_Click(object sender, EventArgs e)
        {
            this.DanhGiaTableAdapter.Fill(this.DataSet1.DanhGia, datetungay.Value.ToString(), datedenngay.Value.ToString());
            // TODO: This line of code loads data into the 'DataSet1.HoTroYC' table. You can move, or remove it, as needed.
            this.reportViewer2.RefreshReport();
        }

        
    }
}
