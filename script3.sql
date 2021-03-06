USE [master]
GO
/****** Object:  Database [webchamsoc1]    Script Date: 2019-01-03 15:35:35 ******/
CREATE DATABASE [webchamsoc1]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'webchamsoc1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\webchamsoc1.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
-- LOG ON 
--( NAME = N'webchamsoc1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\webchamsoc1_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [webchamsoc1] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [webchamsoc1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [webchamsoc1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [webchamsoc1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [webchamsoc1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [webchamsoc1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [webchamsoc1] SET ARITHABORT OFF 
GO
ALTER DATABASE [webchamsoc1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [webchamsoc1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [webchamsoc1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [webchamsoc1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [webchamsoc1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [webchamsoc1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [webchamsoc1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [webchamsoc1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [webchamsoc1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [webchamsoc1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [webchamsoc1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [webchamsoc1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [webchamsoc1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [webchamsoc1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [webchamsoc1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [webchamsoc1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [webchamsoc1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [webchamsoc1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [webchamsoc1] SET  MULTI_USER 
GO
ALTER DATABASE [webchamsoc1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [webchamsoc1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [webchamsoc1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [webchamsoc1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [webchamsoc1] SET DELAYED_DURABILITY = DISABLED 
GO
USE [webchamsoc1]
GO
/****** Object:  DatabaseRole [NhanVien]    Script Date: 2019-01-03 15:35:36 ******/
CREATE ROLE [NhanVien]
GO
/****** Object:  DatabaseRole [GiamDoc]    Script Date: 2019-01-03 15:35:36 ******/
CREATE ROLE [GiamDoc]
GO
/****** Object:  FullTextCatalog [Timkiemhotro]    Script Date: 2019-01-03 15:35:36 ******/
CREATE FULLTEXT CATALOG [Timkiemhotro]WITH ACCENT_SENSITIVITY = ON

GO
/****** Object:  Table [dbo].[DanhGia]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhGia](
	[MaDG] [int] IDENTITY(1,1) NOT NULL,
	[SDT] [nvarchar](50) NOT NULL,
	[NoiDungDG] [nvarchar](max) NULL,
	[NgayDG] [date] NULL,
 CONSTRAINT [PK_DanhGia] PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoTroYC]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoTroYC](
	[MaYC] [int] IDENTITY(1,1) NOT NULL,
	[SDT] [nvarchar](50) NOT NULL,
	[NoiDungYC] [nvarchar](max) NULL,
	[NoiDungPH] [nvarchar](max) NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[NgayYC] [date] NULL,
	[ThoiGianHoanThanh] [nvarchar](50) NULL,
	[NguyenNhan] [nvarchar](max) NULL,
	[NhanVienHoTro] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_HoTroYC] PRIMARY KEY CLUSTERED 
(
	[MaYC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[SDT] [nvarchar](50) NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[CMTND] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[SDT] [nvarchar](50) NULL,
	[HoTenNhanVien] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[Luong] [float] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Username] [nvarchar](50) NOT NULL,
	[MaNV] [int] NOT NULL,
	[Password] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[DanhGia] ON 

GO
INSERT [dbo].[DanhGia] ([MaDG], [SDT], [NoiDungDG], [NgayDG]) VALUES (1, N'0127404704', N'Rất hài lòng về dịch vụ chăm sóc ở đây, nhân viên  hỗ trợ nhiệt tình ', CAST(N'2018-09-05' AS Date))
GO
INSERT [dbo].[DanhGia] ([MaDG], [SDT], [NoiDungDG], [NgayDG]) VALUES (2, N'0125404704', N'đối với tôi nhưng tôi thấy rất hài lòng về nhân viên chăm sóc đối với khách hàng', CAST(N'2018-11-05' AS Date))
GO
INSERT [dbo].[DanhGia] ([MaDG], [SDT], [NoiDungDG], [NgayDG]) VALUES (3, N'0126404704', N'Điều lớn nhất tôi cảm nhận được là sự tận tình, chu đáo và hết mình của các nhân viên chăm sóc đối với khách hàng', CAST(N'2018-11-03' AS Date))
GO
INSERT [dbo].[DanhGia] ([MaDG], [SDT], [NoiDungDG], [NgayDG]) VALUES (5, N'0128404704', N'Chúng tôi đánh giá cao về tinh thần trách nhiệm của nhân viên chăm sóc đối với khách hàng', CAST(N'2018-11-05' AS Date))
GO
INSERT [dbo].[DanhGia] ([MaDG], [SDT], [NoiDungDG], [NgayDG]) VALUES (13, N'0914948330', N'nhân viên chăm sóc luôn tạo cho khách bầu không khí thoải mái nhất và giúp đỡ khách khi gặp vấn đề', CAST(N'2018-11-05' AS Date))
GO
INSERT [dbo].[DanhGia] ([MaDG], [SDT], [NoiDungDG], [NgayDG]) VALUES (14, N'0924948330', N'nhân viên chăm sóc đối với khách hàng phục vụ nhiệt tình, kiến thức tốt', CAST(N'2018-09-22' AS Date))
GO
INSERT [dbo].[DanhGia] ([MaDG], [SDT], [NoiDungDG], [NgayDG]) VALUES (15, N'0934948330', N'Chất lượng dịch vụ tốt', CAST(N'2018-08-08' AS Date))
GO
INSERT [dbo].[DanhGia] ([MaDG], [SDT], [NoiDungDG], [NgayDG]) VALUES (17, N'0944948330', N'Điều lớn nhất tôi cảm nhận được là sự tận tình, chu đáo và hết mình của các nhân viên chăm sóc đối với khách hàng', CAST(N'2018-06-04' AS Date))
GO
INSERT [dbo].[DanhGia] ([MaDG], [SDT], [NoiDungDG], [NgayDG]) VALUES (18, N'0954948330', N'Điều lớn nhất tôi cảm nhận được là sự tận tình, chu đáo và hết mình của các nhân viên chăm sóc đối với khách hàng', CAST(N'2018-11-01' AS Date))
GO
INSERT [dbo].[DanhGia] ([MaDG], [SDT], [NoiDungDG], [NgayDG]) VALUES (19, N'0987654321', N'KH: , SDT: 0987654321, Email: , Đánh giá: asdadaada good', CAST(N'2018-12-25' AS Date))
GO
SET IDENTITY_INSERT [dbo].[DanhGia] OFF
GO
SET IDENTITY_INSERT [dbo].[HoTroYC] ON 

GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (1, N'0125404704', N'Đầu thu không thu được chương trình nào, hiển thị thông báo “E48 – Không có tín hiệu” hoặc “E52- Đang dò tín hiệu”', N'- Kiểm tra lại đầu nối ănten, kiểm tra ănten xem có hướng về đài phát hay không, cáp anten có bị đứt hay không ?
- Sau khi sửa chữa và khắc phục sự có, Kiểm tra mức tín hiệu: vào Menu --> Cài đặt người dùng --> Dò chương trình. Nếu phẩm chất tín hiệu trên 70% là đạt yêu cầu.', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'-Tín hiệu ăn ten vào chưa tốt hoặc không có tín hiệu vào từ ănten', N'Lê Anh Tuấn', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (2, N'0126404704', N'Đầu thu không thu được chương trình nào, hiển thị thông báo “E50 – Không có dịch vụ”', N'- Kiểm tra mức tín hiệu: vào: Menu --> Cài đặt người dùng --> Dò chương trình. Nếu phẩm chất tín hiệu thấp (dưới 70%), cần kiểm tra và khắc phụ lại ănten, đầu nối và dây cáp (ănten chưa hướng về phía đài phát, cáp bị đứt, đầu nối bị hỏng...)
- Nếu phẩm chất tín hiệu ổn định và trên 70%, chương trình bị gián đoạn từ đài phát. bạn không cần điều chỉnh máy thu hoặc ănten, chờ cho đài phát khắc phục sự cố.', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'-Tín hiệu ăn ten vào chưa tốt
-Hoặc có gián đoạn từ đài phát', N'Lê Anh Tuấn', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (6, N'0128404704', N'Đầu thu không thu được chương trình nào, hiển thị thông báo “E50 – Không có dịch vụ”', N'- Kiểm tra mức tín hiệu: vào: Menu --> Cài đặt người dùng --> Dò chương trình. Nếu phẩm chất tín hiệu thấp (dưới 70%), cần kiểm tra và khắc phụ lại ănten, đầu nối và dây cáp (ănten chưa hướng về phía đài phát, cáp bị đứt, đầu nối bị hỏng...)', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'4', N'-Tín hiệu ăn ten vào chưa tốt', N'Trần Chiến Thắng', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (7, N'0914948330', N'Tôi nhập mã thẻ theo hướng dẫn nhưng vẫn không nạp được tiền vào tài khoản?', N'Chúng tôi sẽ liên hệ với nhân viên kỹ thuật hỗ trợ bạn sớm nhất', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'5 ngày', N'', N'Trần Chiến Thắng', N'Chúng tôi sẽ liên hệ với nhân viên kỹ thuật hỗ trợ bạn sớm nhất')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (9, N'0924948330', N'Tôi  không nhận được mà kích hoạt, tôi cổ gắng đăng kí V2V nhưng không nhận được mã sms kích hoạt', N'', N'Chưa Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (10, N'0934948330', N'MS 487 tôi không thể gọi hoặc nhận tin nhắn', N'', N'Chưa Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (11, N'0944948330', N'Đầu thu không thu được chương trình nào, hiển thị thông báo “E50 – Không có dịch vụ”', N'- Kiểm tra mức tín hiệu: vào: Menu --> Cài đặt người dùng --> Dò chương trình. Nếu phẩm chất tín hiệu thấp (dưới 70%), cần kiểm tra và khắc phụ lại ănten, đầu nối và dây cáp (ănten chưa hướng về phía đài phát, cáp bị đứt, đầu nối bị hỏng...)', N'Chưa Hoàn Thành', CAST(N'2018-11-11' AS Date), N'5', N'-Tín hiệu ăn ten vào chưa tốt', N'Đỗ Tú Tài', N'-chưa sửa chữa xong')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (12, N'0954948330', N'Tôi đã dùng app một thời gian và hiện tại số tôi đang sử dụng thông báo rằng nó không thể hoàn thiện và bị lỗi code 503', N'', N'Chưa Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (13, N'0964948330', N'Để xác nhận mọi thông tin và được hỗ trợ bởi V2V, tôi phải liên hệ với ai? Như thế nào?', N'Xin vui lòng liên lạc theo số điện thoại và địa chi email ở phẩn cuối của trang.', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (15, N'0974948330', N'TÔI muốn cài số ảo thành số chính của mình thay vì số của V2V.', N'Chúng tôi thực sự không cho phép người sử dụng cho số ảo của họ làm số chính, mỗi tài khoản phải có một số V2V. Số ảo chỉ là để nhận cuộc gọi vả chuyển tiếp đến số V2V của bạn, họ không cho tin nhắn SMS hoặc thực hiện cuộc gọi ra bên ngoài', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (16, N'0984948330', N'Tôi muốn thay đổi số V2V của mình', N'Chúng tôi thực sự không cho phép người dùng thay đổi số V2V miễn phí của họ. Nên bạn cần một số trong một mã vùng khác nhau mà bạn có thể mua một sổ ảo đó sẽ chuyển tiếp đến số V2V của bạn bằng cách vào V2V.com.vn và đăng nhập vào tài khoản của bạn', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (17, N'0994948330', N'V2V có hỗ trợ cho điện thoại Windows 10 hoặc Blackberry?', N'Không, chúng tôi hiện không có ứng dụng cho Windows  và điện thoại Blackberry', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (19, N'0914948331', N'Tại sao khi lỗi đăng nhập bị thoát ra ngoài ?', N'Việc này có thể xảy ra vì điện thoại của bạn không có hỗ trợ Google Play hay Dịch vụ Google đang chạy.', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (20, N'0924948331', N'Số V2V của tôi có phải là miễn phi mãi mãi ?', N'Số V2V của bạn hoàn toàn miễn phí. Chúng tôi không tính phí, miễn là bạn còn sử dụng nó, bạn có thể giữ nó bao lâu tùy thích.', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (21, N'0934948330', N'Tôi không muốn nhận voice mail thư thoại, có cách nào để tắt nó đi?', N'Không có cách nào để tắt thư thoại đi, trừ phi bạn tắt cuộc gọi', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (22, N'0934948331', N'Làm thế nào đề tôi có thể gọi về VN mà không sử dụng internet?', N'', N'Chưa Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (23, N'0944948331', N'V2V có chức năng gì khác biệt?', N'Đặc trưng của V2V:
•	Sở hữu sốVN(Không phải dùng điện thọai khác hoặc đổi sim Việt Nam.
•	Có thể gọi được nếu bạn ở Việt Nam. (Với giá cước phải chăng)
•	Gọi cho nguời Việt với giá cước phải Chăng.
•	Nhìn tin miễn phí (chỉ khi Online)
', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (24, N'0954948331', N'V2V có thể sử dụng trên những hệ điều hành nào?', N'V2V đưọc hỗ trợ trên 2 hệ điều hành chính là; iOS, Android.', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (25, N'0964948331', N'Làm thế nào để tôi phân biệt được đâu là bạn bè V2V với bạn bè bình thường trong danh bạ của mình?', N'Thông tin người dùng V2V trong danh bạ của bạn sẽ được phân biệt bởi avatar V2V
icon
', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (26, N'0974948331', N'Tôi muốn dùng V2V gọi về cho gia đình ở Việt Nam?', N'Bạn vào giao diện gọi thoai bấm số cá nhân của gia đình ở VN, ở giao diện đã mặc định sẵn mã vùng VN (+84)', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (27, N'0984948331', N'Làm thế nào để đăng nhập V2V?', N'Hiện tại bạn có thể dùng số điện thoại cá nhân để đăng nhập V2V. Bấm vào giao diện, bấm nút đăng nhập (sign in), điền số điện thọai và mật khẩu của bạn', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (28, N'0994948331', N'Làm thế nào để đăng xuất V2V?', N'để đăng xuất tài khoản V2V, bạn có thể vào Cài đặt chọn Đăng xuất.', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (29, N'0914948330', N'Tôi quên mật khẩu của mình, vậy phải làm thế nào?', N'Tại giao diện, bấm vào " quên mật khẩu" (forgot password), bạn điền lại số điện thọai, tổng đài sẽ gửi tin nhắn hướng dẫn khôi phục một khẩu cho bạn', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (30, N'0924948330', N'V2V là gì?', N'V2V là ứng dụng trò chuyện đa phương tiện. Người dùng có thể nhắn tin và sử dụng các tiện ích trong ứng dụng miễn phí trong môi trưởng 3G và Wifi. Cuộc trò chuyện của bạn sẽ không bao giờ bị gián đoạn, giúp kết nối bạn bè trọn vẹn mọi lúc mọi nơi.
Các tính năng chính: (1) Sở hữu số VN(Không phải dùng diện thoại khác hoặc đổi sim Việt Nam, (2) Có thể gọi được nếu bạn ở Việt Nam (với gói cước phải chăng), (3) Gọi cho người Việt với giá cước phải chăng, (4) Nhắn tin miễn phí (chỉ khi Online).
', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (31, N'0934948330', N'Đăng ký tài khoản V2V như thế nào?', N'Đăng ký bằng ứng dụng V2V:
- Người dùng sử dụng chính số điện thoại cá nhân của mình để đăng ký và kích hoạt tài khoản V2V theo các bước:
B1: Vào giao diện của V2V, bấm đăng ký (sign up)
', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Đỗ Tú Tài', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (32, N'0123456789', N'dau thu bi hong', N'', N'Chưa Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'', N'Bùi Thanh Tùng', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (33, N'1234', N'Đầu thu không thu được chương trình nào, hiển thị thông báo “E50 – Không có dịch vụ”', N'- Kiểm tra mức tín hiệu: vào: Menu --> Cài đặt người dùng --> Dò chương trình. Nếu phẩm chất tín hiệu thấp (dưới 70%), cần kiểm tra và khắc phụ lại ănten, đầu nối và dây cáp (ănten chưa hướng về phía đài phát, cáp bị đứt, đầu nối bị hỏng...)
- Nếu phẩm chất tín hiệu ổn định và trên 70%, chương trình bị gián đoạn từ đài phát. bạn không cần điều chỉnh máy thu hoặc ănten, chờ cho đài phát khắc phục sự cố.', N'Chưa Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'-Tín hiệu ăn ten vào chưa tốt
-Hoặc có gián đoạn từ đài phát', N'Bùi Thanh Tùng', N'cần nv kt đến kiểm tra')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (34, N'0987654321', N'Đầu thu không thu được chương trình nào, hiển thị thông báo “E50 – Không có dịch vụ”', N'- Kiểm tra mức tín hiệu: vào: Menu --> Cài đặt người dùng --> Dò chương trình. Nếu phẩm chất tín hiệu thấp (dưới 70%), cần kiểm tra và khắc phụ lại ănten, đầu nối và dây cáp (ănten chưa hướng về phía đài phát, cáp bị đứt, đầu nối bị hỏng...)
- Nếu phẩm chất tín hiệu ổn định và trên 70%, chương trình bị gián đoạn từ đài phát. bạn không cần điều chỉnh máy thu hoặc ănten, chờ cho đài phát khắc phục sự cố.', N'Chưa Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'-Tín hiệu ăn ten vào chưa tốt
-Hoặc có gián đoạn từ đài phát', N'Bùi Thanh Tùng', N'cần nv kt đến kiểm tra')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (35, N'056321', N'Đầu thu không thu được chương trình nào, hiển thị thông báo “E50 – Không có dịch vụ”', N'- Kiểm tra mức tín hiệu: vào: Menu --> Cài đặt người dùng --> Dò chương trình. Nếu phẩm chất tín hiệu thấp (dưới 70%), cần kiểm tra và khắc phụ lại ănten, đầu nối và dây cáp (ănten chưa hướng về phía đài phát, cáp bị đứt, đầu nối bị hỏng...)
- Nếu phẩm chất tín hiệu ổn định và trên 70%, chương trình bị gián đoạn từ đài phát. bạn không cần điều chỉnh máy thu hoặc ănten, chờ cho đài phát khắc phục sự cố.', N'Chưa Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'-Tín hiệu ăn ten vào chưa tốt
-Hoặc có gián đoạn từ đài phát', N'Bùi Thanh Tùng', N'cần nv kt đến gấp')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (36, N'0456', N'loi mat internet', N'', N'Chưa Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'tran chien thang', N'Trần Chiến Thắng', N'nv kt den kiem tra')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (37, N'056321', N'Đầu thu không thu được chương trình nào, hiển thị thông báo “E50 – Không có dịch vụ”', N'- Kiểm tra mức tín hiệu: vào: Menu --> Cài đặt người dùng --> Dò chương trình. Nếu phẩm chất tín hiệu thấp (dưới 70%), cần kiểm tra và khắc phụ lại ănten, đầu nối và dây cáp (ănten chưa hướng về phía đài phát, cáp bị đứt, đầu nối bị hỏng...)
- Nếu phẩm chất tín hiệu ổn định và trên 70%, chương trình bị gián đoạn từ đài phát. bạn không cần điều chỉnh máy thu hoặc ănten, chờ cho đài phát khắc phục sự cố.', N'Chưa Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'-Tín hiệu ăn ten vào chưa tốt
-Hoặc có gián đoạn từ đài phát', N'Trần Chiến Thắng', N'cần nv kt đến gấp')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (38, N'0934948331', N'mất mạng internet', N'', N'Chưa Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'mất mạng', N'Trần Chiến Thắng', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (41, N'0989898169', N'mất mạng internet', N'', N'Đang Sửa Chữa', CAST(N'2018-11-11' AS Date), N'', N'mất mạng', N'Trần Chiến Thắng', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (42, N'0989898169', N'đầu thu bị hỏng', N'nvkt sẽ đến kiểm tra', N'Đang Sửa Chữa', CAST(N'2018-11-11' AS Date), N'', N'đầu thu bị hỏng', N'Trần Chiến Thắng', N'')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (43, N'0914948330', N'Tôi nhập mã thẻ theo hướng dẫn nhưng vẫn không nạp được tiền vào tài khoản?', N'Chúng tôi sẽ liên hệ với nhân viên kỹ thuật hỗ trợ bạn sớm nhất', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'5 ngày', N'', N'Nguyễn Thị Trang', N'Chúng tôi sẽ liên hệ với nhân viên kỹ thuật hỗ trợ bạn sớm nhất')
GO
INSERT [dbo].[HoTroYC] ([MaYC], [SDT], [NoiDungYC], [NoiDungPH], [TinhTrang], [NgayYC], [ThoiGianHoanThanh], [NguyenNhan], [NhanVienHoTro], [GhiChu]) VALUES (44, N'0125404704', N'Đầu thu không thu được chương trình nào, hiển thị thông báo “E48 – Không có tín hiệu” hoặc “E52- Đang dò tín hiệu”', N'- Kiểm tra lại đầu nối ănten, kiểm tra ănten xem có hướng về đài phát hay không, cáp anten có bị đứt hay không ?
- Sau khi sửa chữa và khắc phục sự có, Kiểm tra mức tín hiệu: vào Menu --> Cài đặt người dùng --> Dò chương trình. Nếu phẩm chất tín hiệu trên 70% là đạt yêu cầu.', N'Đã Hoàn Thành', CAST(N'2018-11-11' AS Date), N'', N'-Tín hiệu ăn ten vào chưa tốt hoặc không có tín hiệu vào từ ănten', N'Nguyễn Thị Trang', N'')
GO
SET IDENTITY_INSERT [dbo].[HoTroYC] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (1, N'0127404704', N'Nam', N'lao cai', N'163359585', N'0127404704')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (3, N'0125404704', N'Hai', N'HaNoi', N'163359856', N'0125404704')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (4, N'0128404704', N'Nghĩa', N'NamDinh', N'163359587', N'0128404704')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (5, N'0126404704', N'Toan', N'NamDinh', N'163359588', N'0126404704')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (6, N'0914948330', N'Sơn', N'HaNam', N'165559585', N'0914948330')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (11, N'0924948330', N'Son', N'HaNam', N'165559585', N'0924948330')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (12, N'0934948330', N'Thái', N'Ha Noi', N'165559586', N'0934948330')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (13, N'0944948330', N'Thư', N'Ha Noi', N'165559587', N'0944948330')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (14, N'0954948330', N'Thủy', N'Ha Noi', N'165559587', N'0954948330')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (16, N'0964948330', N'Thọ', N'Ha Noi', N'163359589', N'0964948330')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (17, N'0974948330', N'Toàn', N'Ha Noi', N'163359590', N'0974948330')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (18, N'0984948330', N'Triều', N'Hà Nội', N'163359589', N'0984948330')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (19, N'0994948330', N'Tuấn Anh', N'Hà Nội', N'163359890', N'0994948330')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (20, N'0914948331', N'Chung', N'Hà Nội', N'163359591', N'0914948331')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (21, N'0924948331', N'Đức', N'Hà Nội', N'163359592', N'0924948331')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (22, N'0934948331', N'Đại', N'Hà Nội', N'163359593', N'0934948331')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (23, N'0944948331', N'Hùng', N'Hà Nội', N'163359594', N'0944948331')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (24, N'0954948331', N'Hưng', N'Hà Nội', N'163359595', N'0954948331')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (25, N'0964948331', N'Hải', N'Hà Nội', N'163359596', N'0964948331')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (26, N'0974948331', N'Tú', N'Hà Nội', N'163359597', N'0974948331')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (27, N'0984948331', N'Toàn', N'Hà Nội', N'163359598', N'0984948331')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (28, N'0994948331', N'Trang', N'Hà Nội', N'163359599', N'0994948331')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (30, N'0123456789', N'Nam', N'HaNoi', N'163359585', N'0123456789')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (31, N'1234', N'Nam', N'HaNoi', N'163359585', N'1234')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (32, N'0987654321', N'', N'', N'', N'0987654321')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (34, N'056123', N'', N'', N'', N'056123')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (35, N'056321', N'', N'hn', N'', N'056321')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (36, N'0456', N'', N'', N'', N'0456')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (39, N'01233333333', N'linh', N'', N'', N'01233333333')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (41, N'099999999', N'chi hang', N'0000', N'', N'099999999')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (42, N'099888', N'anh long', N'hn', N'', N'099888')
GO
INSERT [dbo].[KhachHang] ([MaKH], [SDT], [TenKH], [DiaChi], [CMTND], [MatKhau]) VALUES (43, N'0989898169', N'Hoang', N'HN', N'0998989898', N'0989898169')
GO
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

GO
INSERT [dbo].[NhanVien] ([MaNV], [SDT], [HoTenNhanVien], [DiaChi], [NgaySinh], [GioiTinh], [Luong]) VALUES (1, N'0362136838', N'Vũ Hoàng Hải', N'Ha Noi', CAST(N'1996-05-11' AS Date), N'Nam', 10000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [SDT], [HoTenNhanVien], [DiaChi], [NgaySinh], [GioiTinh], [Luong]) VALUES (2, N'0125407248', N'Đỗ Tú Tài', N'Ha Noi', CAST(N'1995-07-31' AS Date), N'Nam', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [SDT], [HoTenNhanVien], [DiaChi], [NgaySinh], [GioiTinh], [Luong]) VALUES (4, N'0168404704', N'Lê Anh Tuấn', N'Nam Dinh', CAST(N'1995-12-08' AS Date), N'Nam', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [SDT], [HoTenNhanVien], [DiaChi], [NgaySinh], [GioiTinh], [Luong]) VALUES (5, N'01275223795', N'Phạm Thị Lan', N'Ha Noi', CAST(N'1995-01-03' AS Date), N'Nữ', 7000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [SDT], [HoTenNhanVien], [DiaChi], [NgaySinh], [GioiTinh], [Luong]) VALUES (6, N'0128948330', N'ngô lương', N'23 phố hiế', CAST(N'2018-12-04' AS Date), N'Nam', 4123123123)
GO
INSERT [dbo].[NhanVien] ([MaNV], [SDT], [HoTenNhanVien], [DiaChi], [NgaySinh], [GioiTinh], [Luong]) VALUES (8, N'0123456', N'Trần Chiến Thắng', N'hn', CAST(N'2016-10-19' AS Date), N'Nam', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [SDT], [HoTenNhanVien], [DiaChi], [NgaySinh], [GioiTinh], [Luong]) VALUES (10, N'0123', N'chi hong', N'', CAST(N'2016-12-30' AS Date), N'Nữ', 6666666)
GO
INSERT [dbo].[NhanVien] ([MaNV], [SDT], [HoTenNhanVien], [DiaChi], [NgaySinh], [GioiTinh], [Luong]) VALUES (11, N'0972689457', N'Hoang', N'Hà Nội', CAST(N'2017-01-15' AS Date), N'Nam', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [SDT], [HoTenNhanVien], [DiaChi], [NgaySinh], [GioiTinh], [Luong]) VALUES (12, N'', NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[NhanVien] ([MaNV], [SDT], [HoTenNhanVien], [DiaChi], [NgaySinh], [GioiTinh], [Luong]) VALUES (13, N'0128948330', N'Nguyễn Thị Trang', N'Nam Định', CAST(N'1995-08-22' AS Date), N'Nữ', 5000000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [SDT], [HoTenNhanVien], [DiaChi], [NgaySinh], [GioiTinh], [Luong]) VALUES (14, N'213546871', N'hoàng văn nam', N'45 tây sơn', CAST(N'2018-12-04' AS Date), N'Nam', 2222222)
GO
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
INSERT [dbo].[TaiKhoan] ([Username], [MaNV], [Password], [Email], [ChucVu]) VALUES (N'admin', 1, N'admin', N'trang@gmail.com', N'Giám Đốc')
GO
INSERT [dbo].[TaiKhoan] ([Username], [MaNV], [Password], [Email], [ChucVu]) VALUES (N'chi hong', 10, N'123', N'c', N'Nhân Viên Chăm Sóc')
GO
INSERT [dbo].[TaiKhoan] ([Username], [MaNV], [Password], [Email], [ChucVu]) VALUES (N'Hoang', 11, N'1', N'hoang@gmail.com', N'Nhân Viên')
GO
INSERT [dbo].[TaiKhoan] ([Username], [MaNV], [Password], [Email], [ChucVu]) VALUES (N'lan', 5, N'1', N'lan@gmail.com', N'Trưởng Phòng')
GO
INSERT [dbo].[TaiKhoan] ([Username], [MaNV], [Password], [Email], [ChucVu]) VALUES (N'qưe', 4, N's', N'tuan@gmail.com', N'Nhân Viên Kĩ Thuật')
GO
INSERT [dbo].[TaiKhoan] ([Username], [MaNV], [Password], [Email], [ChucVu]) VALUES (N'tai', 2, N's', N'tai@gmail.com', N'Nhân Viên Chăm Sóc')
GO
INSERT [dbo].[TaiKhoan] ([Username], [MaNV], [Password], [Email], [ChucVu]) VALUES (N'tung', 6, N'tung', N'tung@gmail.com', N'Nhân viên')
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_KhachHang]    Script Date: 2019-01-03 15:35:36 ******/
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [IX_KhachHang] UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DanhGia]  WITH CHECK ADD  CONSTRAINT [FK_DanhGia_KhachHang] FOREIGN KEY([SDT])
REFERENCES [dbo].[KhachHang] ([SDT])
GO
ALTER TABLE [dbo].[DanhGia] CHECK CONSTRAINT [FK_DanhGia_KhachHang]
GO
ALTER TABLE [dbo].[HoTroYC]  WITH CHECK ADD  CONSTRAINT [FK_HoTroYC_KhachHang] FOREIGN KEY([SDT])
REFERENCES [dbo].[KhachHang] ([SDT])
GO
ALTER TABLE [dbo].[HoTroYC] CHECK CONSTRAINT [FK_HoTroYC_KhachHang]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[doimatkhau]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[doimatkhau]
(
@username nvarchar(50),
@password nvarchar(50)
)
as
begin
update TaiKhoan set Password=@password WHERE Username=@username
end

GO
/****** Object:  StoredProcedure [dbo].[kiemtradn]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[kiemtradn]
@tendangnhap nvarchar(50),
@matkhau nvarchar(50)
as
begin
select ChucVu,NhanVien.HoTenNhanVien,Username,Password from TaiKhoan,NhanVien where Username = @tendangnhap and Password =@matkhau and TaiKhoan.MaNV=NhanVien.MaNV
end

GO
/****** Object:  StoredProcedure [dbo].[laychucvu]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[laychucvu]
as
begin
select NhanVien.*,TaiKhoan.ChucVu from NhanVien,TaiKhoan where NhanVien.MaNV=TaiKhoan.MaNV
end

GO
/****** Object:  StoredProcedure [dbo].[laydanhgia]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[laydanhgia]
as
begin
select DanhGia.*,KhachHang.TenKH from DanhGia,KhachHang where KhachHang.SDT=DanhGia.SDT
end

GO
/****** Object:  StoredProcedure [dbo].[layhotro]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[layhotro]
as
begin
select HoTroYC.*,KhachHang.TenKH from HoTroYC,KhachHang where HoTroYC.SDT=KhachHang.SDT
end

GO
/****** Object:  StoredProcedure [dbo].[laykhachhang]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[laykhachhang]
as
begin select * from KhachHang 
end

GO
/****** Object:  StoredProcedure [dbo].[laynhanvien]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[laynhanvien]
as
begin
select NhanVien.* from NhanVien
end

GO
/****** Object:  StoredProcedure [dbo].[laytaikhoan]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[laytaikhoan]
as
begin
select TaiKhoan.Username,TaiKhoan.MaNV,TaiKhoan.Email,TaiKhoan.ChucVu,NhanVien.HoTenNhanVien from TaiKhoan,NhanVien where TaiKhoan.MaNV=NhanVien.MaNV
end

GO
/****** Object:  StoredProcedure [dbo].[suadanhgia]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suadanhgia]
(
@madanhgia int,
@noidungdg nvarchar(MAX),
@ngaydanhgia date

)
as
begin
update DanhGia set NoiDungDG=@noidungdg,NgayDG=@ngaydanhgia where MaDG=@madanhgia
end

GO
/****** Object:  StoredProcedure [dbo].[suakhachhang]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suakhachhang]
(
@makhachhang int,
@tenkhachhang nvarchar(50),
@diachi nvarchar(MAX),
@cmtnd nvarchar(50)
)
as
begin
update KhachHang set TenKH=@tenkhachhang,DiaChi=@diachi,CMTND=@cmtnd where MaKH=@makhachhang
end

GO
/****** Object:  StoredProcedure [dbo].[suanhanvien]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suanhanvien]
(
@manv int,
@hoten nvarchar(MAX),
@diachi nvarchar(MAX),
@ngaysinh date,
@gioitinh nvarchar(50),
@luong float

)
as
begin
update NhanVien set HoTenNhanVien=@hoten,DiaChi=@diachi,NgaySinh=@ngaysinh,GioiTinh=@gioitinh,Luong=@luong where MaNV=@manv
end

GO
/****** Object:  StoredProcedure [dbo].[suataikhoan]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suataikhoan]
(
@username nvarchar(50),
@manv int,
@password nvarchar(50),
@email nvarchar(50),
@chucvu nvarchar(50)

)
as
begin
update TaiKhoan set Username=@username,MaNV=@manv,Password=@password,Email=@email,ChucVu=@chucvu WHERE Username=@username
end

GO
/****** Object:  StoredProcedure [dbo].[suayeucau]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suayeucau]
(
@mayeucau int,
@noidungyc nvarchar(MAX),
@noidungph nvarchar(MAX),
@tinhtrang nvarchar(50),
@ngayyc date,
@thoigianht nvarchar(50),
@nguyennhan nvarchar(MAX),
@hotennhanvien nvarchar(50),
@ghichu nvarchar(MAX)
)
as
begin
update HoTroYC set NoiDungYC=@noidungyc,NoiDungPH=@noidungph,TinhTrang=@tinhtrang,NgayYC=@ngayyc,ThoiGianHoanThanh=@thoigianht,NguyenNhan=@nguyennhan,NhanVienHoTro=@hotennhanvien,GhiChu=@ghichu where MaYC=@mayeucau
end

GO
/****** Object:  StoredProcedure [dbo].[themdanhgia]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themdanhgia]
(
@sodienthoai nvarchar(50),
@noidungdg nvarchar(MAX),
@ngaydanhgia date

)
as
begin
insert into DanhGia(SDT,NoiDungDG,NgayDG)
values(@sodienthoai,@noidungdg,@ngaydanhgia)
end

GO
/****** Object:  StoredProcedure [dbo].[themkhachhang]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themkhachhang]
(
@sodienthoai nvarchar(50),
@tenkhachhang nvarchar(50),
@diachi nvarchar(MAX),
@cmtnd nvarchar(50)
)
as
begin
insert into KhachHang(SDT,TenKH,DiaChi,CMTND,MatKhau)
values(@sodienthoai,@tenkhachhang,@diachi,@cmtnd,@sodienthoai)
end

GO
/****** Object:  StoredProcedure [dbo].[themnhanvien]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themnhanvien]
(
@sodienthoai nvarchar(50),
@hoten nvarchar(MAX),
@diachi nvarchar(MAX),
@ngaysinh date,
@gioitinh nvarchar(50),
@luong float

)
as
begin
insert into NhanVien(SDT,HoTenNhanVien,DiaChi,NgaySinh,GioiTinh,Luong)
values(@sodienthoai,@hoten,@diachi,@ngaysinh,@gioitinh,@luong)
end

GO
/****** Object:  StoredProcedure [dbo].[themtaikhoan]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themtaikhoan]
(
@username nvarchar(50),
@manv int,
@password nvarchar(50),
@email nvarchar(50),
@chucvu nvarchar(50)

)
as
begin
insert into TaiKhoan(Username,MaNV,Password,Email,ChucVu)
values(@username,@manv,@password,@email,@chucvu)
end

GO
/****** Object:  StoredProcedure [dbo].[themyeucau]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themyeucau]
(
@sodienthoai nvarchar(50),
@noidungyc nvarchar(MAX),
@noidungph nvarchar(MAX),
@tinhtrang nvarchar(50),
@ngayyc date,
@thoigianht nvarchar(50),
@nguyennhan nvarchar(MAX),
@hotennhanvien nvarchar(50),
@ghichu nvarchar(MAX)

)
as
begin
insert into HoTroYC(SDT,NoiDungYC,NoiDungPH,TinhTrang,NgayYC,ThoiGianHoanThanh,NguyenNhan,NhanVienHoTro,GhiChu)
values(@sodienthoai,@noidungyc,@noidungph,@tinhtrang,@ngayyc,@thoigianht,@nguyennhan,@hotennhanvien,@ghichu)
end

GO
/****** Object:  StoredProcedure [dbo].[thongkedanhgia]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[thongkedanhgia]
(
@tungay nvarchar(50),
@denngay nvarchar(50)
)
as
begin
select DanhGia.*,KhachHang.TenKH from DanhGia,KhachHang where DanhGia.SDT=KhachHang.SDT and (NgayDG>=@tungay) and (NgayDG<=@denngay)
end

GO
/****** Object:  StoredProcedure [dbo].[thongkehotro]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[thongkehotro]
(
@tungay nvarchar(50),
@denngay nvarchar(50),
@tinhtrang nvarchar(50)
)
as
begin
select HoTroYC.*,KhachHang.TenKH from HoTroYC,KhachHang where HoTroYC.SDT=KhachHang.SDT and (NgayYC>=@tungay) and (NgayYC<=@denngay)and TinhTrang=@tinhtrang
end

GO
/****** Object:  StoredProcedure [dbo].[xoadanhgia]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoadanhgia]
(
@madanhgia int
)
as
begin
delete DanhGia where MaDG=@madanhgia
end

GO
/****** Object:  StoredProcedure [dbo].[xoakhachhang]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoakhachhang]
(
@makhachhang int
)
as
begin
delete from KhachHang where MaKH=@makhachhang
end

GO
/****** Object:  StoredProcedure [dbo].[xoanhanvien]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoanhanvien]
(
@manv int
)
as
begin
delete NhanVien where MaNV=@manv
end

GO
/****** Object:  StoredProcedure [dbo].[xoataikhoan]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoataikhoan]
(
@username nvarchar(50)
)

as
begin
delete TaiKhoan where Username=@username
end

GO
/****** Object:  StoredProcedure [dbo].[xoayeucau]    Script Date: 2019-01-03 15:35:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[xoayeucau]
(
@mayeucau int
)
as
begin
delete HoTroYC where MaYC=@mayeucau
end

GO
USE [master]
GO
ALTER DATABASE [webchamsoc1] SET  READ_WRITE 
GO
