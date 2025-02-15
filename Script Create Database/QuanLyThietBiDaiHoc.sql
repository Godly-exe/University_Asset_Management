USE [master]
GO
/****** Object:  Database [SQLQLTS]    Script Date: 12/25/2022 5:33:09 AM ******/
CREATE DATABASE [SQLQLTS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SQLQLTS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SQLQLTS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SQLQLTS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SQLQLTS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SQLQLTS] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SQLQLTS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SQLQLTS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SQLQLTS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SQLQLTS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SQLQLTS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SQLQLTS] SET ARITHABORT OFF 
GO
ALTER DATABASE [SQLQLTS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SQLQLTS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SQLQLTS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SQLQLTS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SQLQLTS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SQLQLTS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SQLQLTS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SQLQLTS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SQLQLTS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SQLQLTS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SQLQLTS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SQLQLTS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SQLQLTS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SQLQLTS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SQLQLTS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SQLQLTS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SQLQLTS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SQLQLTS] SET RECOVERY FULL 
GO
ALTER DATABASE [SQLQLTS] SET  MULTI_USER 
GO
ALTER DATABASE [SQLQLTS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SQLQLTS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SQLQLTS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SQLQLTS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SQLQLTS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SQLQLTS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SQLQLTS', N'ON'
GO
ALTER DATABASE [SQLQLTS] SET QUERY_STORE = OFF
GO
USE [SQLQLTS]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[UserName] [nchar](10) NOT NULL,
	[Password] [nchar](128) NOT NULL,
	[DisplayName] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDatPhong]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDatPhong](
	[MaDatPhong] [varchar](20) NOT NULL,
	[MaNguoiDatPhong] [varchar](20) NULL,
	[MaPhong] [varchar](20) NULL,
	[NgayDatPhong] [varchar](50) NULL,
 CONSTRAINT [PK_ChiTietDatPhong] PRIMARY KEY CLUSTERED 
(
	[MaDatPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatPhong]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatPhong](
	[MaDatPhong] [varchar](20) NOT NULL,
	[MaPhong] [varchar](20) NULL,
	[MaNhanVien] [varchar](20) NULL,
	[ThoiGianDatPhong] [varchar](50) NULL,
	[ThoiGianTraPhong] [varchar](50) NULL,
	[GhiChu] [varchar](150) NULL,
 CONSTRAINT [PK_DatPhong1] PRIMARY KEY CLUSTERED 
(
	[MaDatPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[MaDonViTinh] [varchar](20) NOT NULL,
	[TenDonViTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_DONVITINH] PRIMARY KEY CLUSTERED 
(
	[MaDonViTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KiemKeTaiSan]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KiemKeTaiSan](
	[MaKiemKe] [varchar](20) NOT NULL,
	[MaTaiSan] [varchar](20) NULL,
	[NguyenGia] [int] NULL,
	[ThoiGianKKhauHau] [date] NULL,
	[MucKhauHau] [nvarchar](50) NULL,
	[NgayDuaVaoSuDung] [date] NULL,
	[ThoiGianSuDung] [nvarchar](50) NULL,
 CONSTRAINT [PK_KIEMKETAISAN] PRIMARY KEY CLUSTERED 
(
	[MaKiemKe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiTaiSan]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiTaiSan](
	[MaLoaiTaiSan] [varchar](20) NOT NULL,
	[TenLoaiTaiSan] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LOAITAISAN] PRIMARY KEY CLUSTERED 
(
	[MaLoaiTaiSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [varchar](20) NOT NULL,
	[TenNhaCungCap] [nvarchar](150) NULL,
	[DiaChiNhaCungCap] [nvarchar](350) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [varchar](20) NOT NULL,
	[TenNhanVien] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](350) NULL,
	[SDT] [nchar](14) NULL,
	[ChucVu] [nvarchar](100) NULL,
	[MaPhongBan] [varchar](20) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuThanhLy]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThanhLy](
	[MaThanhLy] [varchar](20) NOT NULL,
	[MaTaiSan] [varchar](20) NOT NULL,
	[SoLuongThanhLy] [int] NOT NULL,
	[GiaThanhLy] [int] NOT NULL,
	[NgayThanhLy] [varchar](100) NOT NULL,
	[NguoiThanhLy] [varchar](20) NOT NULL,
	[NguoiMua] [nvarchar](250) NULL,
 CONSTRAINT [PK_PHIEUTHANHLY] PRIMARY KEY CLUSTERED 
(
	[MaThanhLy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] [varchar](20) NOT NULL,
	[TenPhong] [nvarchar](150) NULL,
	[DienTich] [decimal](18, 0) NULL,
	[ViTri] [nvarchar](150) NULL,
	[TrangThai] [tinyint] NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPhong] [varchar](20) NOT NULL,
	[TenPhong] [nvarchar](150) NOT NULL,
	[SoPhong] [int] NOT NULL,
	[DienTich] [float] NULL,
	[ViTri] [nvarchar](150) NOT NULL,
	[TrangThaiPhong] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_PHONGBAN] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuaChuaTaiSan]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuaChuaTaiSan](
	[MaSuaChua] [varchar](20) NOT NULL,
	[MaTaiSan] [varchar](20) NULL,
	[NgaySuaChua] [datetime] NULL,
	[GiaSuaChua] [int] NULL,
	[NguoiSuaChua] [varchar](20) NULL,
	[HinhThucSuaChua] [nvarchar](150) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TrangThai] [varchar](10) NULL,
 CONSTRAINT [PK_SUACHUATAISAN] PRIMARY KEY CLUSTERED 
(
	[MaSuaChua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiSan]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiSan](
	[MaTaiSan] [varchar](20) NOT NULL,
	[TenTaiSan] [nvarchar](150) NULL,
	[Gia] [int] NULL,
	[MaLoaiTaiSan] [varchar](20) NULL,
	[MaDonViTinh] [varchar](20) NULL,
	[MaNhaCungCap] [varchar](20) NULL,
	[HinhMinhHoa] [nvarchar](250) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[TrangThai] [nvarchar](50) NULL,
	[NgayNhap] [datetime] NULL,
	[MaNguoiNhap] [varchar](20) NULL,
	[ThongSoKyThuat] [nvarchar](50) NULL,
	[ThoiGianTinhKhauHau] [datetime] NULL,
	[ThoiGianBaoHanh] [nchar](10) NULL,
	[MaPhong] [varchar](20) NULL,
 CONSTRAINT [PK_TAISAN] PRIMARY KEY CLUSTERED 
(
	[MaTaiSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Accounts] ([UserName], [Password], [DisplayName]) VALUES (N'cuong     ', N'202CB962AC59075B964B07152D234B70                                                                                                ', N'cuong user')
INSERT [dbo].[Accounts] ([UserName], [Password], [DisplayName]) VALUES (N'hoa       ', N'32CACB2F994F6B42183A1300D9A3E8D6                                                                                                ', N'admin3')
INSERT [dbo].[Accounts] ([UserName], [Password], [DisplayName]) VALUES (N'huy       ', N'202CB962AC59075B964B07152D234B70                                                                                                ', N'ad')
INSERT [dbo].[Accounts] ([UserName], [Password], [DisplayName]) VALUES (N'huy2      ', N'202CB962AC59075B964B07152D234B70                                                                                                ', N'ad2')
INSERT [dbo].[Accounts] ([UserName], [Password], [DisplayName]) VALUES (N'huy3      ', N'202CB962AC59075B964B07152D234B70                                                                                                ', N'admin')
INSERT [dbo].[Accounts] ([UserName], [Password], [DisplayName]) VALUES (N'luan      ', N'202CB962AC59075B964B07152D234B70                                                                                                ', N'ngài')
INSERT [dbo].[Accounts] ([UserName], [Password], [DisplayName]) VALUES (N'nam       ', N'C84258E9C39059A89AB77D846DDAB909                                                                                                ', N'admin2')
GO
INSERT [dbo].[DatPhong] ([MaDatPhong], [MaPhong], [MaNhanVien], [ThoiGianDatPhong], [ThoiGianTraPhong], [GhiChu]) VALUES (N'MDP_EQLIFIV', N'P_GCAOLOG', N'NV_HICRORK', N'10/13/2022 6:04:00 PM', N'2022-10-13 18:03:56', N'cc')
INSERT [dbo].[DatPhong] ([MaDatPhong], [MaPhong], [MaNhanVien], [ThoiGianDatPhong], [ThoiGianTraPhong], [GhiChu]) VALUES (N'MDP_FXCIEDH', N'P_IVWFYXP', N'NV_HICRORK', N'10/21/2022 2:17:50 PM', N'2022-10-21 14:17:40', N'dsda')
INSERT [dbo].[DatPhong] ([MaDatPhong], [MaPhong], [MaNhanVien], [ThoiGianDatPhong], [ThoiGianTraPhong], [GhiChu]) VALUES (N'MDP_GWKITHE', N'P_NPLEMJD', N'NV_HICRORK', N'10/13/2022 6:05:03 PM', N'2022-10-13 18:04:56', N'cc')
INSERT [dbo].[DatPhong] ([MaDatPhong], [MaPhong], [MaNhanVien], [ThoiGianDatPhong], [ThoiGianTraPhong], [GhiChu]) VALUES (N'MDP_HCWCGHJ', N'P_NPLEMJD', N'NV_PPGCXUJ', N'10/13/2022 8:57:43 PM', N'2022-10-14 20:57:31', N'ee')
INSERT [dbo].[DatPhong] ([MaDatPhong], [MaPhong], [MaNhanVien], [ThoiGianDatPhong], [ThoiGianTraPhong], [GhiChu]) VALUES (N'MDP_TPFWBHA', N'P_GCAOLOG', N'NV_HICRORK', N'10/13/2022 8:57:29 PM', N'2022-10-13 20:57:20', N'aa')
INSERT [dbo].[DatPhong] ([MaDatPhong], [MaPhong], [MaNhanVien], [ThoiGianDatPhong], [ThoiGianTraPhong], [GhiChu]) VALUES (N'MDP_UGXNLGV', N'P_NPLEMJD', N'NV_GDUFWIQ', N'12/16/2022 1:47:06 AM', N'2022-12-16 01:46:56', N'dá')
GO
INSERT [dbo].[DonViTinh] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DVT_ECORNPK', N'Bộ ')
INSERT [dbo].[DonViTinh] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DVT_KDNNKOS', N'Cái')
INSERT [dbo].[DonViTinh] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DVT_NVLJHEA', N'FullBox 99%')
INSERT [dbo].[DonViTinh] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DVT_OUFKSHX', N'NewSeal ')
INSERT [dbo].[DonViTinh] ([MaDonViTinh], [TenDonViTinh]) VALUES (N'DVT_TANYDPC', N'FullBox 100%')
GO
INSERT [dbo].[LoaiTaiSan] ([MaLoaiTaiSan], [TenLoaiTaiSan]) VALUES (N'LTS_AKYGKOB', N'Thiết Bị Quân Sự')
INSERT [dbo].[LoaiTaiSan] ([MaLoaiTaiSan], [TenLoaiTaiSan]) VALUES (N'LTS_BTIVRMY', N'Thiết Bị Điện Tử')
INSERT [dbo].[LoaiTaiSan] ([MaLoaiTaiSan], [TenLoaiTaiSan]) VALUES (N'LTS_BVHOPJJ', N'Thiết Bị Giảng Dạy')
INSERT [dbo].[LoaiTaiSan] ([MaLoaiTaiSan], [TenLoaiTaiSan]) VALUES (N'LTS_HLLYUYS', N'Thiết Bị Y Tế')
GO
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChiNhaCungCap]) VALUES (N'NCC_CNEXCAD', N'OverWatching', N'HCM')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChiNhaCungCap]) VALUES (N'NCC_EQFBTKV', N'HeHeBoi', N'Mỹ Tho')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChiNhaCungCap]) VALUES (N'NCC_HHNAUFH', N'ApexLegion', N'HaNoi')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChiNhaCungCap]) VALUES (N'NCC_VJIWBYT', N'GTAVI', N'QuyNhon')
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [DiaChi], [SDT], [ChucVu], [MaPhongBan]) VALUES (N'NV_GDUFWIQ', N'Thái', N'ko biết ', N'23213123123   ', N'1', N'PB_CFOYPGR')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [DiaChi], [SDT], [ChucVu], [MaPhongBan]) VALUES (N'NV_HICRORK', N'Thành Nam Báo', N'Khu E', N'0123456789    ', N'0', N'PB_YINTMGY')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [DiaChi], [SDT], [ChucVu], [MaPhongBan]) VALUES (N'NV_PPGCXUJ', N'Thái Hoà', N'Khu E', N'0987654321    ', N'0', N'PB_YINTMGY')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [DiaChi], [SDT], [ChucVu], [MaPhongBan]) VALUES (N'NV_SGALYPR', N'hoà ', N'khu e', N'2120500151    ', N'1', N'PB_CFOYPGR')
INSERT [dbo].[NhanVien] ([MaNhanVien], [TenNhanVien], [DiaChi], [SDT], [ChucVu], [MaPhongBan]) VALUES (N'NV_XWUEJDN', N'Lâm Huy', N'Khu AB', N'0935154301    ', N'1', N'PB_AGFSAHT')
GO
INSERT [dbo].[PhieuThanhLy] ([MaThanhLy], [MaTaiSan], [SoLuongThanhLy], [GiaThanhLy], [NgayThanhLy], [NguoiThanhLy], [NguoiMua]) VALUES (N'TL_BBYBQQE', N'TS_IYJRISP', 1, 20000000, N'12/15/2022 6:04:13 PM', N'NV_GDUFWIQ', N'dgfd')
INSERT [dbo].[PhieuThanhLy] ([MaThanhLy], [MaTaiSan], [SoLuongThanhLy], [GiaThanhLy], [NgayThanhLy], [NguoiThanhLy], [NguoiMua]) VALUES (N'TL_GDGLRLY', N'TS_IOHRSRK', 1, 500000, N'12/15/2022 5:35:20 PM', N'NV_GDUFWIQ', N'')
INSERT [dbo].[PhieuThanhLy] ([MaThanhLy], [MaTaiSan], [SoLuongThanhLy], [GiaThanhLy], [NgayThanhLy], [NguoiThanhLy], [NguoiMua]) VALUES (N'TL_QXGUABU', N'TS_NVSUQWP', 1, 5000000, N'10/13/2022 6:20:43 PM', N'NV_HICRORK', N'Ngài Luân ')
GO
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [DienTich], [ViTri], [TrangThai]) VALUES (N'P_FUSJKPX', N'B.05.04', CAST(100 AS Decimal(18, 0)), N'Tầng 5', 0)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [DienTich], [ViTri], [TrangThai]) VALUES (N'P_GCAOLOG', N'E.02.01', CAST(60 AS Decimal(18, 0)), N'Tầng 2', 0)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [DienTich], [ViTri], [TrangThai]) VALUES (N'P_IVWFYXP', N'h?c ', CAST(50 AS Decimal(18, 0)), N'khu e', 0)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [DienTich], [ViTri], [TrangThai]) VALUES (N'P_NPLEMJD', N'E.01.02', CAST(50 AS Decimal(18, 0)), N'Tầng 1', 1)
INSERT [dbo].[Phong] ([MaPhong], [TenPhong], [DienTich], [ViTri], [TrangThai]) VALUES (N'P_XKOKMEL', N'A.03.06', CAST(100 AS Decimal(18, 0)), N'Tầng 3', 0)
GO
INSERT [dbo].[PhongBan] ([MaPhong], [TenPhong], [SoPhong], [DienTich], [ViTri], [TrangThaiPhong]) VALUES (N'PB_AGFSAHT', N'Phòng Họp', 2, 100, N'Tầng 2', N'1')
INSERT [dbo].[PhongBan] ([MaPhong], [TenPhong], [SoPhong], [DienTich], [ViTri], [TrangThaiPhong]) VALUES (N'PB_CFOYPGR', N'Phòng Thí Nghiệm', 5, 50, N'Tầng 3', N'0')
INSERT [dbo].[PhongBan] ([MaPhong], [TenPhong], [SoPhong], [DienTich], [ViTri], [TrangThaiPhong]) VALUES (N'PB_RDXIIQG', N'Phòng Thể Chất', 10, 500, N'Tầng 11', N'1')
INSERT [dbo].[PhongBan] ([MaPhong], [TenPhong], [SoPhong], [DienTich], [ViTri], [TrangThaiPhong]) VALUES (N'PB_YHKYWNY', N'Phòng Học ', 20, 50, N'Tầng 4', N'0')
INSERT [dbo].[PhongBan] ([MaPhong], [TenPhong], [SoPhong], [DienTich], [ViTri], [TrangThaiPhong]) VALUES (N'PB_YINTMGY', N'Hội Trường', 5, 200, N'Tầng 5', N'0')
GO
INSERT [dbo].[SuaChuaTaiSan] ([MaSuaChua], [MaTaiSan], [NgaySuaChua], [GiaSuaChua], [NguoiSuaChua], [HinhThucSuaChua], [GhiChu], [TrangThai]) VALUES (N'SC_HCSVYNC', N'TS_DMVKUNR', CAST(N'2022-10-13T20:52:25.000' AS DateTime), 998999, N'NV_HICRORK', N'Bảo Hành', N'no', N'Ðã s?a')
INSERT [dbo].[SuaChuaTaiSan] ([MaSuaChua], [MaTaiSan], [NgaySuaChua], [GiaSuaChua], [NguoiSuaChua], [HinhThucSuaChua], [GhiChu], [TrangThai]) VALUES (N'SC_RMWCRKC', N'TS_BWXAIGC', CAST(N'2022-10-21T14:14:58.000' AS DateTime), 333333333, N'NV_XWUEJDN', N'', N'ađá', N'Ðã s?a')
GO
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_BWXAIGC', N'máy lạnh âm tường', 99999, N'LTS_BTIVRMY', N'DVT_NVLJHEA', N'NCC_EQFBTKV', N'\Image\may-lanh-am-tran-1.jpg', N'jkj', N'0', CAST(N'2022-10-21T00:00:00.000' AS DateTime), N'NV_HICRORK', N'dsda', CAST(N'2022-10-21T00:00:00.000' AS DateTime), N'2022-10-21', N'P_NPLEMJD')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_IOHRSRK', N'Bàn ghế đôi ', 500000, N'LTS_AKYGKOB', N'DVT_TANYDPC', N'NCC_VJIWBYT', N'\Image\banghe2.jpg', N'Full Box ', N'0', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'NV_HICRORK', N'Bàn G? Thông, Gh? Thép', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'2022-10-13', N'P_GCAOLOG')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_IYJRISP', N'PC Extreme', 20000000, N'LTS_BTIVRMY', N'DVT_TANYDPC', N'NCC_EQFBTKV', N'\Image\Pc master.png', N'New 99% ', N'0', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'NV_XWUEJDN', N'i11 18900H 
RTX 5090ti
256GB ram
50TB SSHD
 ', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'2022-10-13', N'P_XKOKMEL')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_JXVNVLW', N'Air pỏ bro', 50000, N'LTS_BTIVRMY', N'DVT_TANYDPC', N'NCC_EQFBTKV', N'\Image\airpodpro.jpg', N'Alo', N'1', CAST(N'2022-12-25T00:00:00.000' AS DateTime), N'NV_HICRORK', N'???', CAST(N'2022-12-25T00:00:00.000' AS DateTime), N'2022-12-25', N'P_GCAOLOG')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_NVSUQWP', N'AirPod Bro', 5000000, N'LTS_BVHOPJJ', N'DVT_OUFKSHX', N'NCC_CNEXCAD', N'\Image\airpodpro.jpg', N'Chôm của SV', N'0', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'NV_XWUEJDN', N'Noise Cancelling', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'2022-10-13', N'P_NPLEMJD')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_PDORVOI', N'Ống Nhựa PVC', 100000, N'LTS_BVHOPJJ', N'DVT_KDNNKOS', N'NCC_EQFBTKV', N'\Image\pvc.jpg', N'Chắc là không giòn đâu', N'1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'NV_XWUEJDN', N'4x10m', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'2022-10-13', N'P_NPLEMJD')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_SDJQJEF', N'Máy Chiếu', 5000000, N'LTS_BVHOPJJ', N'DVT_ECORNPK', N'NCC_CNEXCAD', N'\Image\may chieu.jpg', N'NewSeal', N'1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'NV_PPGCXUJ', N'4k 60FPS', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'2022-10-13', N'P_NPLEMJD')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_WTWITAG', N'Router Wifi 6', 10000000, N'LTS_BTIVRMY', N'DVT_ECORNPK', N'NCC_HHNAUFH', N'\Image\cua.jpg', N'New Seal', N'1', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'NV_HICRORK', N'Range 100m', CAST(N'2022-10-13T00:00:00.000' AS DateTime), N'2022-10-13', N'P_GCAOLOG')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan], [Gia], [MaLoaiTaiSan], [MaDonViTinh], [MaNhaCungCap], [HinhMinhHoa], [GhiChu], [TrangThai], [NgayNhap], [MaNguoiNhap], [ThongSoKyThuat], [ThoiGianTinhKhauHau], [ThoiGianBaoHanh], [MaPhong]) VALUES (N'TS_YHNAGJQ', N'Airpod BRO', 5000000, N'LTS_BVHOPJJ', N'DVT_OUFKSHX', N'NCC_CNEXCAD', N'\Image\airpodpro.jpg', N'Chôm của SV', N'1', CAST(N'2022-10-21T00:00:00.000' AS DateTime), N'NV_HICRORK', N'Noise cancelling', CAST(N'2022-10-21T00:00:00.000' AS DateTime), N'2022-10-21', N'P_FUSJKPX')
GO
ALTER TABLE [dbo].[SuaChuaTaiSan] ADD  CONSTRAINT [DF_SuaChuaTaiSan_TrangThai]  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD  CONSTRAINT [FK_DatPhong_NhanVien] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[DatPhong] CHECK CONSTRAINT [FK_DatPhong_NhanVien]
GO
ALTER TABLE [dbo].[DatPhong]  WITH CHECK ADD  CONSTRAINT [FK_DatPhong_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[DatPhong] CHECK CONSTRAINT [FK_DatPhong_Phong]
GO
ALTER TABLE [dbo].[KiemKeTaiSan]  WITH CHECK ADD  CONSTRAINT [FK_KiemKeTaiSan_TaiSan] FOREIGN KEY([MaTaiSan])
REFERENCES [dbo].[TaiSan] ([MaTaiSan])
GO
ALTER TABLE [dbo].[KiemKeTaiSan] CHECK CONSTRAINT [FK_KiemKeTaiSan_TaiSan]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([MaPhongBan])
REFERENCES [dbo].[PhongBan] ([MaPhong])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
ALTER TABLE [dbo].[PhieuThanhLy]  WITH CHECK ADD  CONSTRAINT [FK_PhieuThanhLy_TaiSan] FOREIGN KEY([MaTaiSan])
REFERENCES [dbo].[TaiSan] ([MaTaiSan])
GO
ALTER TABLE [dbo].[PhieuThanhLy] CHECK CONSTRAINT [FK_PhieuThanhLy_TaiSan]
GO
ALTER TABLE [dbo].[TaiSan]  WITH CHECK ADD  CONSTRAINT [FK_TaiSan_DonViTinh] FOREIGN KEY([MaDonViTinh])
REFERENCES [dbo].[DonViTinh] ([MaDonViTinh])
GO
ALTER TABLE [dbo].[TaiSan] CHECK CONSTRAINT [FK_TaiSan_DonViTinh]
GO
ALTER TABLE [dbo].[TaiSan]  WITH CHECK ADD  CONSTRAINT [FK_TaiSan_LoaiTaiSan] FOREIGN KEY([MaLoaiTaiSan])
REFERENCES [dbo].[LoaiTaiSan] ([MaLoaiTaiSan])
GO
ALTER TABLE [dbo].[TaiSan] CHECK CONSTRAINT [FK_TaiSan_LoaiTaiSan]
GO
ALTER TABLE [dbo].[TaiSan]  WITH CHECK ADD  CONSTRAINT [FK_TaiSan_NhaCungCap] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[TaiSan] CHECK CONSTRAINT [FK_TaiSan_NhaCungCap]
GO
ALTER TABLE [dbo].[TaiSan]  WITH CHECK ADD  CONSTRAINT [FK_TaiSan_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[TaiSan] CHECK CONSTRAINT [FK_TaiSan_Phong]
GO
/****** Object:  StoredProcedure [dbo].[HoaDonTimKiem]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[HoaDonTimKiem]
(
	@MaHD char(30),
	@MaKH char(30)
) 
as select * from HoaDon  where MaHD like '%'+@MaHD+'%' or HoaDon.MaKH like '%'+@MaKH+'%'
GO
/****** Object:  StoredProcedure [dbo].[KhachHangTimKiem]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[KhachHangTimKiem]
(
	@TenKH nvarchar(50),
	@MaKH char(30)
)
as select * from KhachHang where TenKH like N'%'+@TenKH+'%' or MaKH like '%'+@MaKH+'%' 
GO
/****** Object:  StoredProcedure [dbo].[NCCTimKiem]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[NCCTimKiem]
(
	@MaCC char(30),  
	@TenCC Nvarchar(100)
)
as select * from NhaCC
where TenCC like N'%'+@TenCC+'%' or MaCC like '%'+@MaCC+'%'  
GO
/****** Object:  StoredProcedure [dbo].[NhapKhoTimKiem]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[NhapKhoTimKiem]
(
		@MaNK nvarchar(50),
		@MaTB char(30)
)
as select * from NhapKho where MaNK like '%'+@MaNK+'%' or MaTB like '%'+@MaTB+'%'
GO
/****** Object:  StoredProcedure [dbo].[ThietBiTimKiem]    Script Date: 12/25/2022 5:33:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ThietBiTimKiem]
(
	@MaTB char(30) ,
	@MaCC char(30) ,
	@TenTB Nvarchar(100) ,
	@LoaiTB Nvarchar(100)
)
as select * from ThietBi where MaTB like '%'+@MaTB+'%' or MaCC like '%'+@MaCC+'%' or TenTB like '%'+@TenTB+'%' or LoaiTB like '%'+@LoaiTB+'%'
GO
USE [master]
GO
ALTER DATABASE [SQLQLTS] SET  READ_WRITE 
GO
