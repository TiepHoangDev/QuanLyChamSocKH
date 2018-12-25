using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(DanhGia danhGia)
        {
            try
            {
                danhGia.NgayDG = DateTime.Now;
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["QuanLyChamSocKH.Properties.Settings.webchamsoc1ConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    danhGia.NoiDungDG = $"KH: {danhGia.HoTen}, SDT: {danhGia.SDT}, Email: {danhGia.Email}, Đánh giá: {danhGia.NoiDungDG}";
                    string cmdText = $"INSERT INTO [dbo].[DanhGia] ([SDT] ,[NoiDungDG] ,[NgayDG]) VALUES (N'{danhGia.SDT}' , N'{danhGia.NoiDungDG}', N'{danhGia.NgayDG}');";
                    SqlCommand cmd = new SqlCommand(cmdText, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
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
    }

    public class DanhGia
    {
        public string SDT { get; set; }
        public string NoiDungDG { get; set; }
        public DateTime NgayDG { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
    }
}