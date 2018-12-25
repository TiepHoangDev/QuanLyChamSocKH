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
    public partial class Main : DevComponents.DotNetBar.Office2007Form
    {
        public Main()
        {
            InitializeComponent();
        }
       public static string ChucVu;
       public static string HoTenNhanVien;
       public static string Username;
       public static string Matkhau;
       public void Dongform(object sender, EventArgs e)
       {
           DialogResult DlgHoi = MessageBox.Show("Bạn Có Chắc Đã Hoàn Thành Công Việc ", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if (DlgHoi == DialogResult.Yes)
           {
               Application.Exit();
           }
           
       }
        Boolean kiemtratontai(string Frmname)
        {
            foreach (Form Frm in this.MdiChildren)
            {
                if (Frm.Name.Equals(Frmname))
                {
                    Frm.Activate();
                    return true;
                }
            }
            return false;
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (kiemtratontai("DangNhap") == false)
            {
                DangNhap f = new DangNhap();
                f.MdiParent = this;
                f.Name = "DangNhap";
                f.Show();

            }
            
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        public void chuadangnhap()
        {
            office2007StartButton1.Enabled = true;
            ribbonTabItem1.Enabled = true;
            ribbonTabItem2.Enabled = false;
            ribbonTabItem3.Enabled = false;
            explorerBar1.Enabled = false;
            btnDangXuat.Enabled = false;
            btnNhanVien.Enabled = false;
            btnKhachhang.Enabled = false;
            btnHotro.Enabled = false;
            btnDanhgia.Enabled = false;
            btnTaikhoan.Enabled = false;
            btnDoimatkhau.Enabled = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
                KetNoi.openketnoi();
                chuadangnhap();
                if (ChucVu == PhanQuyen.GiamDoc)
                {
                    ribbonTabItem1.Enabled = true;
                    ribbonTabItem2.Enabled = true;
                    ribbonTabItem3.Enabled = true;
                    explorerBar1.Enabled = true;
                    btnDangXuat.Enabled = true;
                    btnNhanVien.Enabled = true;
                    btnKhachhang.Enabled = true;
                    btnHotro.Enabled = true;
                    btnDanhgia.Enabled = true;
                    btnTaikhoan.Enabled = true;
                    btnDoimatkhau.Enabled = true;

                }
                else if (ChucVu == PhanQuyen.NhanVienChamSoc || ChucVu == PhanQuyen.NhanVienKiThuat||ChucVu==PhanQuyen.TruongPhong)
                {
                    ribbonTabItem1.Enabled = true;
                    ribbonTabItem2.Enabled = true;
                    ribbonTabItem3.Enabled = true;
                    explorerBar1.Enabled = true;
                    btnDangXuat.Enabled = true;
                    btnNhanVien.Enabled = true;
                    btnKhachhang.Enabled = true;
                    btnHotro.Enabled = true;
                    btnDanhgia.Enabled = true;
                    btnDoimatkhau.Enabled = true;
                }
                
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Show();
           // WindowState = FormWindowState.Normal;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }


        private void buttonItem3_Click(object sender, EventArgs e)
        {
            if (kiemtratontai("HoTroYeuCau") == false)
            {
                HoTroYeuCau f = new HoTroYeuCau();
                f.MdiParent = this;
                f.Name = "HoTroYeuCau";
                f.Show();

            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult DlgHoi = MessageBox.Show("Bạn Có Chắc Đã Hoàn Thành Công Việc ", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DlgHoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonItem3_Click_1(object sender, EventArgs e)
        {

            if (kiemtratontai("TaiKhoan") == false)
            {
                TaiKhoan f = new TaiKhoan();
                f.MdiParent = this;
                f.Name = "TaiKhoan";
                f.Show();

            }
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            if (kiemtratontai("KhachHang") == false)
            {
                KhachHang f = new KhachHang();
                f.MdiParent = this;
                f.Name = "KhachHang";
                f.Show();

            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (kiemtratontai("NhanVien") == false)
            {
                NhanVien f = new NhanVien();
                f.MdiParent = this;
                f.Name = "NhanVien";
                f.Show();

            }
        }

        private void btnDanhgia_Click(object sender, EventArgs e)
        {
            if (kiemtratontai("DanhGia") == false)
            {
                DanhGia f = new DanhGia();
                f.MdiParent = this;
                f.Name = "DanhGia";
                f.Show();

            }
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            if (kiemtratontai("ThongKe") == false)
            {
                ThongKe f = new ThongKe();
                f.MdiParent = this;
                f.Name = "ThongKe";
                f.Show();

            }
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            if (kiemtratontai("BaoCao") == false)
            {
                BaoCao f = new BaoCao();
                f.MdiParent = this;
                f.Name = "BaoCao";
                f.Show();

            }
        }

        private void btnMWord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WINWORD.EXE");
        }

        private void btnMExcel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXCEL.EXE");
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            if (kiemtratontai("DoiMatKhau") == false)
            {
                DoiMatKhau f = new DoiMatKhau();
                f.MdiParent = this;
                f.Name = "DoiMatKhau";
                f.Show();

            }
        }
    }
}
