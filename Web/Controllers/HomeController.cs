using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private string _connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QuanLyChamSocKH.Properties.Settings.webchamsoc1ConnectionString"].ConnectionString;

        public ActionResult Index()
        {
            ViewBag.KH = Session["LOGIN"] as KhachHang;
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(DanhGia danhGia)
        {
            try
            {
                var kh = Session["LOGIN"] as KhachHang;
                danhGia.NgayDG = DateTime.Now;
                danhGia.SDT = kh.SDT;
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    danhGia.NoiDungDG = "KH: " + danhGia.HoTen + ", SDT: " + danhGia.SDT + ", Email: " + danhGia.Email + ", Đánh giá: " + danhGia.NoiDungDG + "";
                    string cmdText = "INSERT INTO [dbo].[DanhGia] ([SDT] ,[NoiDungDG] ,[NgayDG]) VALUES (N'" + danhGia.SDT + "' , N'" + danhGia.NoiDungDG + "', N'" + danhGia.NgayDG.ToString("yyyy-MM-dd") + "');";
                    SqlCommand cmd = new SqlCommand(cmdText, con);
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        string content = string.Format("Xin chào {0}, cảm ơn bạn đã gửi đánh giá cho chúng tôi! <br/> Nếu bạn không phải người gửi đóng góp, vui lòng bỏ qua mail này!", danhGia.HoTen);
                        await EmailSender.SendGMail(danhGia.Email, content);
                    }
                    con.Close();
                    con.Dispose();
                }
            }
            catch (Exception ex)
            {
                TempData["message"] = ex.Message;
            }
            return RedirectToAction("Thank");
        }

        public ActionResult Thank()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Login(string SDT, string password)
        {
            string message = "";
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = string.Format("select * FROM dbo.KhachHang WHERE SDT = @SDT AND MatKhau = @password;");
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@SDT", SDT);
                    da.SelectCommand.Parameters.AddWithValue("@password", password);
                    var dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        var row = dt.Rows[0];
                        KhachHang kh = new KhachHang();
                        kh.MaKH = (row["MaKH"] as int?) ?? 0;
                        kh.CMTND = row["CMTND"] as string;
                        kh.SDT = row["SDT"] as string;
                        kh.TenKH = row["TenKH"] as string;
                        kh.DiaChi = row["DiaChi"] as string;
                        kh.MatKhau = row["MatKhau"] as string;

                        if (kh.MaKH > 0)
                        {
                            Session["LOGIN"] = kh;
                            message = string.Format("Xin chào {0}, chào mừng đến với VTC Suport!", kh.TenKH);
                            return Json(new { code = true, data = new { message } });
                        }
                        else
                        {
                            message = "Lỗi dữ liệu khách hàng.";
                        }
                    }
                    else
                    {
                        message = "Đăng nhập thất bại. Sai tên đăng nhập hoặc mật khẩu!";
                    }
                }
            }
            catch (Exception ex)
            {
                message = "Lỗi hệ thống. " + ex.Message;
            }
            return Json(new { code = false, data = new { message } });
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult DoiMatKhau(string oldpassword, string newpassword, string repassword)
        {
            string message = "";
            bool code = true;
            try
            {
                var kh = Session["LOGIN"] as KhachHang;
                if (oldpassword != kh.MatKhau)
                {
                    code = false;
                    message = "+ Mật khẩu cũ không chính xác";
                }
                if (newpassword.Length < 8)
                {
                    code = false;
                    message += "<br/>+ Mật khẩu mới phải ít nhất 08 kí tự!";
                }
                else if (newpassword != repassword)
                {
                    code = false;
                    message += "<br/> Xác nhận mật khẩu không chính xác!";
                }
                if (code)
                {
                    code = false;
                    using (SqlConnection con = new SqlConnection(_connectionString))
                    {
                        string query = string.Format("UPDATE dbo.KhachHang SET MatKhau = @newpassword WHERE MaKH = @MaKH AND MatKhau = @oldpassword ");
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@oldpassword", oldpassword);
                            cmd.Parameters.AddWithValue("@newpassword", newpassword);
                            cmd.Parameters.AddWithValue("@MaKH", kh.MaKH);

                            con.Open();
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                Session.Clear();
                                message += "Đổi mật khẩu thành công. lúc " + DateTime.Now + ". Vui lòng đăng nhập lại để sử dụng hệ thống!";
                                code = true;
                            }
                            else
                            {
                                message += "Đổi mật khẩu thất bại!";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = "Lỗi hệ thống. " + ex.Message;
            }
            return Json(new { code, data = new { message } });
        }
    }
}

namespace Web.Models
{
    public class DanhGia
    {
        public string SDT { get; set; }
        public string NoiDungDG { get; set; }
        public DateTime NgayDG { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
    }

    public class KhachHang
    {
        public int MaKH { get; set; }
        public string SDT { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string CMTND { get; set; }
        public string MatKhau { get; set; }
    }
}