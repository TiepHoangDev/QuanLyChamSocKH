using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Management;

namespace QuanLyChamSocKH
{
    class KetNoi
    {
        //Khai báo chuỗi kết nối
        //public static string chuoiketnoi = @"server=THANGTRAN\SQLEXPRESS;uid=sa;pwd=123456;database=webchamsoc1";
        public static string chuoiketnoi = System.Configuration.ConfigurationManager.ConnectionStrings["QuanLyChamSocKH.Properties.Settings.webchamsoc1ConnectionString"].ConnectionString;

        //Khai báo biến kết nối
        public static SqlConnection con;
        //Khai báo biến thực hiện một lệnh sql 
        public static SqlCommand cmd;
        public static SqlDataAdapter da;
        //Phương thức mở kết nối
        public static void openketnoi()
        {
            con = new SqlConnection(chuoiketnoi);
            con.Open();
        }
        //Phương thức đóng kết nối
        public static void dongketnoi()
        {
            con.Close();
        }
        //Phương thức đổ dữ liệu lên gridview
        public static DataTable gettable(string sql)
        {
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            DataTable db = new DataTable();
            da.Fill(db);
            return db;
        }

        //Phương thức thực hiện một câu lệnh sql nào đó
        public static void executeQuery(string sql)
        {
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }
}
