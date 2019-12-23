CREATE DATABASE WATCHDB
GO

USE [WATCHDB]
GO
/****** Object:  Table [dbo].[ADMIN]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADMIN](
	[TaiKhoan] [char](20) NOT NULL,
	[MatKhau] [char](16) NOT NULL,
 CONSTRAINT [PK_ADMIN] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETDONDATHANG]   ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETDONDATHANG](
	[MaDatHang] [int] NOT NULL,
	[MaSanPham] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [int] NULL,
 CONSTRAINT [PK_CHITIETDONDATHANG] PRIMARY KEY CLUSTERED 
(
	[MaDatHang] ASC,
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONDATHANG]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONDATHANG](
	[MaDatHang] [int] IDENTITY(1,1) NOT NULL,
	[TinhTrangThanhToan] [bit] NULL,
	[TinhTrangGiao] [bit] NULL,
	[NgayDat] [datetime2](7) NULL,
	[NgayGiao] [datetime2](7) NULL,
	[MaKH] [int] NOT NULL,
 CONSTRAINT [PK_DONDATHANG] PRIMARY KEY CLUSTERED 
(
	[MaDatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONGHO]   ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONGHO](
	[MaDH] [int] IDENTITY(1,1) NOT NULL,
	[TenDH] [nvarchar](50) NULL,
	[XuatSu] [nvarchar](15) NULL,
	[Gia] [int] NULL,
	[MaHang] [char](10) NOT NULL,
	[Image] [nvarchar](50) NULL,
 CONSTRAINT [PK_DONGHO] PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HANG]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANG](
	[MaHang] [char](10) NOT NULL,
	[TenHang] [nvarchar](20) NULL,
	[Detail] [nvarchar](max) NULL,
 CONSTRAINT [PK_HANG] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]   ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[SoDT] [char](10) NOT NULL,
	[Email] [nchar](20) NOT NULL,
	[TenDN] [nchar](20) NOT NULL,
	[MatKhau] [nchar](16) NOT NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ADMIN] ([TaiKhoan], [MatKhau]) VALUES (N'boss                ', N'123456          ')
SET IDENTITY_INSERT [dbo].[DONDATHANG] ON 

INSERT [dbo].[DONDATHANG] ([MaDatHang], [TinhTrangThanhToan], [TinhTrangGiao], [NgayDat], [NgayGiao], [MaKH]) VALUES (0, 0, 0, CAST(N'2019-03-19T19:51:34.9839769' AS DateTime2), NULL, 1)
INSERT [dbo].[DONDATHANG] ([MaDatHang], [TinhTrangThanhToan], [TinhTrangGiao], [NgayDat], [NgayGiao], [MaKH]) VALUES (1, 0, 0, CAST(N'2019-03-22T11:58:48.6994937' AS DateTime2), NULL, 1)
INSERT [dbo].[DONDATHANG] ([MaDatHang], [TinhTrangThanhToan], [TinhTrangGiao], [NgayDat], [NgayGiao], [MaKH]) VALUES (2, 0, 0, CAST(N'2019-03-22T12:04:04.7131584' AS DateTime2), NULL, 1)
SET IDENTITY_INSERT [dbo].[DONDATHANG] OFF
SET IDENTITY_INSERT [dbo].[DONGHO] ON 

INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (0, N'AW-80D-7AVDF-399x399', N'Nhật Bản', 10000000, N'HCS       ', N'AW-80D-7AVDF-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (1, N'CASIO-AW-80D-7AVDF-0-399x399', N'Nhật Bản', 10000000, N'HCS       ', N'CASIO-AW-80D-7AVDF-0-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (2, N'CASIO-AW-80D-7AVDF-0-399x399', N'Nhật Bản', 10000000, N'HCS       ', N'CASIO-AW-80D-7AVDF-1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (3, N'CASIO-AW-80D-7AVDF-2-399x399', N'Nhật Bản', 10000000, N'HCS       ', N'CASIO-AW-80D-7AVDF-2-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (4, N'CASIO-AW-80D-7AVDF-3-399x399', N'Nhật Bản', 10000000, N'HCS       ', N'CASIO-AW-80D-7AVDF-3-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (5, N'CASIO-DBC-32D-1ADF-0-399x399', N'Nhật Bản', 15000000, N'HCS       ', N'CASIO-DBC-32D-1ADF-0-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (6, N'CASIO-DBC-32D-1ADF-2-399x399', N'Nhật Bản', 15000000, N'HCS       ', N'CASIO-DBC-32D-1ADF-2-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (7, N'DBC-32D-1ADF-399x399', N'Nhật Bản', 15000000, N'HCS       ', N'DBC-32D-1ADF-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (8, N'46_MTP-1214A-8AVDF-1-399x399', N'Nhật Bản', 7000000, N'HCS       ', N'46_MTP-1214A-8AVDF-1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (9, N'46_MTP-1214A-8AVDF-2-399x399', N'Nhật Bản', 7000000, N'HCS       ', N'46_MTP-1214A-8AVDF-2-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (10, N'CASIO-MTP-1214A-8AVDF-1-399x399', N'Nhật Bản', 7000000, N'HCS       ', N'CASIO-MTP-1214A-8AVDF-1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (11, N'CASIO-MTP-1214A-8AVDF-2-399x399', N'Nhật Bản', 7000000, N'HCS       ', N'CASIO-MTP-1214A-8AVDF-2-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (12, N'CASIO-MTP-1214A-8AVDF-4-399x399', N'Nhật Bản', 7000000, N'HCS       ', N'CASIO-MTP-1214A-8AVDF-4-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (13, N'50_ECB-800D-1ADR', N'Nhật Bản', 20000000, N'HCS       ', N'50_ECB-800D-1ADR.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (14, N'52_ECB-800DC-1ADR-399x399', N'Nhật Bản', 20000000, N'HCS       ', N'52_ECB-800DC-1ADR-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (15, N'ECB-800DC-1AEF_5m', N'Nhật Bản', 20000000, N'HCS       ', N'ECB-800DC-1AEF_5m.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (16, N'102_W-S200H-1AVDF', N'Nhật Bản', 5000000, N'HCS       ', N'102_W-S200H-1AVDF.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (17, N'103_W-S200H-1BVDF-399x399', N'Nhật Bản', 18000000, N'HCS       ', N'103_W-S200H-1BVDF-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (18, N'CASIO-W-S200H-1BVDF-0-399x399', N'Nhật Bản', 18000000, N'HCS       ', N'CASIO-W-S200H-1BVDF-0-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (19, N'CASIO-W-S200H-1BVDF-1-399x399', N'Nhật Bản', 18000000, N'HCS       ', N'CASIO-W-S200H-1BVDF-1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (20, N'CASIO-W-S200H-1BVDF-2', N'Nhật Bản', 18000000, N'HCS       ', N'CASIO-W-S200H-1BVDF-2.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (21, N'CASIO-W-S200H-1BVDF-3', N'Nhật Bản', 18000000, N'HCS       ', N'CASIO-W-S200H-1BVDF-3.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (22, N'105_AW1370-51B-399x399', N'Nhật Bản', 5000000, N'HCZ       ', N'105_AW1370-51B-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (23, N'106_AW1370-51M-399x399', N'Nhật Bản', 5000000, N'HCZ       ', N'106_AW1370-51M-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (24, N'107_AW1570-87A-399x399', N'Nhật Bản', 5000000, N'HCZ       ', N'107_AW1570-87A-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (25, N'108_AW1570-87H-399x399', N'Nhật Bản', 5000000, N'HCZ       ', N'108_AW1570-87H-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (26, N'109_BH3005-05E-399x399', N'Nhật Bản', 11000000, N'HCZ       ', N'109_BH3005-05E-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (27, N'110_BH3005-56E-399x399', N'Nhật Bản', 11000000, N'HCZ       ', N'110_BH3005-56E-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (28, N'59_BI5014-58E-399x399', N'Nhật Bản', 6000000, N'HCZ       ', N'59_BI5014-58E-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (29, N'111_BI5060-51L-399x399', N'Nhật Bản', 6000000, N'HCZ       ', N'111_BI5060-51L-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (30, N'141_BI5014-58E-1-399x399', N'Nhật Bản', 6000000, N'HCZ       ', N'141_BI5014-58E-1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (31, N'768_BI5014-58E-2-399x399', N'Nhật Bản', 6000000, N'HCZ       ', N'768_BI5014-58E-2-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (32, N'106_EV0052-50P-399x399', N'Nh?t B?n', 11000000, N'HCZ       ', N'106_EV0052-50P-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (33, N'CITIZEN-EV0052-50P-0-399x399', N'Nhật Bản', 11000000, N'HCZ       ', N'CITIZEN-EV0052-50P-0-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (34, N'CITIZEN-EV0052-50P-1-399x399', N'Nhật Bản', 11000000, N'HCZ       ', N'CITIZEN-EV0052-50P-1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (35, N'CITIZEN-EV0052-50P-2-399x399', N'Nhật Bản', 11000000, N'HCZ       ', N'CITIZEN-EV0052-50P-2-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (36, N'CITIZEN-EV0052-50P-3-399x399', N'Nhật Bản', 11000000, N'HCZ       ', N'CITIZEN-EV0052-50P-3-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (37, N'157_DW00100260-1-399x399', N'Thụy Điển', 12000000, N'HDW       ', N'157_DW00100260-1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (38, N'158_DW00100259-1-399x399', N'Thụy Điển', 12000000, N'HDW       ', N'158_DW00100259-1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (39, N'161_DW00100110-399x399', N'Thụy Điển', 12000000, N'HDW       ', N'161_DW00100110-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (40, N'232_DW00100021-399x399', N'Thụy Điển', 12000000, N'HDW       ', N'232_DW00100021-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (41, N'DW00100021-DW00100052-1-399x399', N'Thụy Điển', 12000000, N'HDW       ', N'DW00100021-DW00100052-1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (42, N'134_DW00100135-399x399', N'Thụy Điển', 13000000, N'HDW       ', N'134_DW00100135-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (43, N'176_DW00100128-1-399x399', N'Thụy Điển', 13000000, N'HDW       ', N'176_DW00100128-1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (44, N'176_DW00100128-2-399x399', N'Thụy Điển', 13000000, N'HDW       ', N'176_DW00100128-2-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (45, N'262_DW00100140-399x399', N'Thụy Điển', 13000000, N'HDW       ', N'262_DW00100140-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (46, N'268_DW00100150-399x399', N'Thụy Điển', 13000000, N'HDW       ', N'268_DW00100150-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (47, N'DW00100247-DW00100150-1-399x399', N'Thụy Điển', 13000000, N'HDW       ', N'DW00100247-DW00100150-1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (48, N'167_DW00100117-399x399', N'Thụy Điển', 4000000, N'HDW       ', N'167_DW00100117-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (49, N'168_DW00100118-2-399x399', N'Thụy Điển', 4000000, N'HDW       ', N'168_DW00100118-2-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (50, N'168_DW00100118-399x399', N'Thụy Điển', 4000000, N'HDW       ', N'168_DW00100118-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (51, N'273_DW00100097-2-399x399', N'Thụy Điển', 4000000, N'HDW       ', N'273_DW00100097-2-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (52, N'273_DW00100097-399x399', N'Thụy Điển', 4000000, N'HDW       ', N'273_DW00100097-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (53, N'274_DW00100108-399x399', N'Thụy Điển', 4000000, N'HDW       ', N'274_DW00100108-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (54, N'DW00100108-DW00100096-0-399x399', N'Thụy Điển', 4000000, N'HDW       ', N'DW00100108-DW00100096-0-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (55, N'30_BGA-150PG-5B1DR-399x399', N'Nhật Bản', 3000000, N'HGS       ', N'30_BGA-150PG-5B1DR-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (56, N'CASIO-BGA-150PG-5B1DR-0-399x399', N'Nhật Bản', 3000000, N'HGS       ', N'CASIO-BGA-150PG-5B1DR-0-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (57, N'CASIO-BGA-150PG-5B1DR-1-399x399', N'Nhật Bản', 3000000, N'HGS       ', N'CASIO-BGA-150PG-5B1DR-1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (58, N'CASIO-BGA-150PG-5B1DR-2-399x399', N'Nhật Bản', 3000000, N'HGS       ', N'CASIO-BGA-150PG-5B1DR-2-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (59, N'CASIO-BGA-150PG-5B1DR-3-399x399', N'Nhật Bản', 3000000, N'HGS       ', N'CASIO-BGA-150PG-5B1DR-3-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (60, N'32_BGA-230SA-1ADR-399x399', N'Nhật Bản', 3500000, N'HGS       ', N'32_BGA-230SA-1ADR-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (61, N'CASIO-BGA-230SA-1ADR-0-399x399', N'Nhật Bản', 3500000, N'HGS       ', N'CASIO-BGA-230SA-1ADR-0-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (62, N'CASIO-BGA-230SA-1ADR-1-399x399', N'Nhật Bản', 3500000, N'HGS       ', N'CASIO-BGA-230SA-1ADR-1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (63, N'CASIO-BGA-230SA-1ADR-2-399x399', N'Nhật Bản', 3500000, N'HGS       ', N'CASIO-BGA-230SA-1ADR-2-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (64, N'CASIO-BGA-230SA-1ADR-3-399x399', N'Nhật Bản', 3500000, N'HGS       ', N'CASIO-BGA-230SA-1ADR-3-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (65, N'CASIO-BGA-230SA-1ADR-5-399x399', N'Nhật Bản', 3500000, N'HGS       ', N'CASIO-BGA-230SA-1ADR-5-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (66, N'CASIO-G-100BB-1ADR-0-399x399', N'Nhật Bản', 14000000, N'HGS       ', N'CASIO-G-100BB-1ADR-0-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (67, N'CASIO-G-100BB-1ADR-1-399x399', N'Nhật Bản', 14000000, N'HGS       ', N'CASIO-G-100BB-1ADR-1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (68, N'CASIO-G-100BB-1ADR-2-399x399', N'Nhật Bản', 14000000, N'HGS       ', N'CASIO-G-100BB-1ADR-2-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (69, N'CASIO-G-100BB-1ADR-3-399x399', N'Nhật Bản', 14000000, N'HGS       ', N'CASIO-G-100BB-1ADR-3-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (70, N'G-100BB-1ADR-399x399', N'Nhật Bản', 14000000, N'HGS       ', N'G-100BB-1ADR-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (71, N'7_GBA-800-2A2DR-399x399', N'Nhật Bản', 15000000, N'HGS       ', N'7_GBA-800-2A2DR-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (72, N'dong-ho-nam-casio-g-shock-ga-150-1adr-1', N'Nhật Bản', 15000000, N'HGS       ', N'dong-ho-nam-casio-g-shock-ga-150-1adr-1.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (73, N'g-shock-gba-800-step-tracker-700x525', N'Nhật Bản', 15000000, N'HGS       ', N'g-shock-gba-800-step-tracker-700x525.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (74, N'hqdefault', N'Nhật Bản', 15000000, N'HGS       ', N'hqdefault.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (75, N'70_GSG-100-1A8DR-399x399', N'Nhật Bản', 16000000, N'HGS       ', N'70_GSG-100-1A8DR-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (76, N'CASIO-GSG-100-1A8DR-0-399x399', N'Nhật Bản', 16000000, N'HGS       ', N'CASIO-GSG-100-1A8DR-0-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (77, N'CASIO-GSG-100-1A8DR-1-399x399', N'Nhật Bản', 16000000, N'HGS       ', N'CASIO-GSG-100-1A8DR-1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (78, N'CASIO-GSG-100-1A8DR-2-399x399', N'Nhật Bản', 16000000, N'HGS       ', N'CASIO-GSG-100-1A8DR-2-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (79, N'CASIO-GSG-100-1A8DR-3-399x399', N'Nhật Bản', 16000000, N'HGS       ', N'CASIO-GSG-100-1A8DR-3-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (80, N'CASIO-GSG-100-1A8DR-4-399x399', N'Nhật Bản', 16000000, N'HGS       ', N'CASIO-GSG-100-1A8DR-4-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (81, N'18_SRPB74K1-399x399', N'Nhật Bản', 17000000, N'HSK       ', N'18_SRPB74K1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (82, N'20_SRPC59K1-399x399', N'Nhật Bản', 17000000, N'HSK       ', N'20_SRPC59K1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (83, N'SEIKO-SRPB74K1-0-399x399', N'Nhật Bản', 17000000, N'HSK       ', N'SEIKO-SRPB74K1-0-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (84, N'SEIKO-SRPB74K1-4-399x399', N'Nhật Bản', 17000000, N'HSK       ', N'SEIKO-SRPB74K1-4-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (85, N'SEIKO-SRPC59K1-1-399x399', N'Nhật Bản', 17000000, N'HSK       ', N'SEIKO-SRPC59K1-1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (86, N'SEIKO-SRPC59K1-2-399x399', N'Nhật Bản', 17000000, N'HSK       ', N'SEIKO-SRPC59K1-2-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (87, N'9_SNE423P1-399x399', N'Nhật Bản', 18000000, N'HSK       ', N'9_SNE423P1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (88, N'10_SNE439P1-399x399', N'Nhật Bản', 18000000, N'HSK       ', N'10_SNE439P1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (89, N'127_SNE394P1-399x399', N'Nhật Bản', 18000000, N'HSK       ', N'127_SNE394P1-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (90, N'SEIKO-SNE394P1-3-399x399', N'Nhật Bản', 18000000, N'HSK       ', N'SEIKO-SNE394P1-3-399x399.jpg')
INSERT [dbo].[DONGHO] ([MaDH], [TenDH], [XuatSu], [Gia], [MaHang], [Image]) VALUES (101, N'CITIZEN-DSC02092-min', N'Nhật Bản',11000000 , N'HCZ      ', N'CITIZEN-DSC02092-min.jpg')
SET IDENTITY_INSERT [dbo].[DONGHO] OFF
INSERT [dbo].[HANG] ([MaHang], [TenHang], [Detail]) VALUES (N'HCS       ', N'Casio', N'Đồng hồ Casio được biết đến là thương hiệu lâu đời trong ngành công nghiệp đòng hồ tại Nhật Bản.Những mẫu đồng hồ Casio nam và đồng hồ Casio nữ đều được yêu thích bởi thiết kế đơn giản,lịch sự và được trang bị đầy đủ các công nghệ mới nhất.Ngoài ra đồng hồ Casio chính hãng còn nổi bật bởi chức năng đa dạng giúp ích cho người dùng vào những hoạt động đời sống thường ngày.')
INSERT [dbo].[HANG] ([MaHang], [TenHang], [Detail]) VALUES (N'HCZ       ', N'Citizen', N'Thương hiệu đồng hồ Citizen qua 100 năm thành lập và phát triển, nổi danh toàn cầu là một trong những thương hiệu đồng hồ xuất sắc vượt trội về công nghệ. Sở hữu công nghệ tân tiến cùng cách thiết kế thời trang cho đồng hồ vô cùng sáng tạo là hai điểm mà bạn có thể dễ dàng nhận thấy ở những chiếc đồng hồ thương hiệu đồng hồ Citizen.')
INSERT [dbo].[HANG] ([MaHang], [TenHang], [Detail]) VALUES (N'HDW       ', N'Daniel Wellington', N'Daniel Wellington là một nhãn hiệu thời trang của Thụy Điển phổ biến và được ưa chuộng tại nhiều nước trên thế giới, là một nhãn hiệu lâu đời và hình thành thương hiệu với sự vững chắc trong thị trường thời trang. Sản phẩm của Daniel Wellington không những có thiết kế luôn dẫn đầu trong xu hướng và phong cách thời trang qua từng năm mà còn có nhiều tính năng nổi bật nên vì vậy luôn được rất nhiều nghệ sĩ, nhân vật nổi tiếng sử dụng.')
INSERT [dbo].[HANG] ([MaHang], [TenHang], [Detail]) VALUES (N'HGS       ', N'G-Shock', N'Đồng hồ Casio G-Shock hội đủ tinh hoa của nhiều dòng sản phẩm hiện nay, vừa có thiết kế thu hút và đặc biệt những tính năng của chiếc đồng hồ này thật sự gây nhiều bất ngờ, trải nghiệm thú vị cho người sở hữu.')
INSERT [dbo].[HANG] ([MaHang], [TenHang], [Detail]) VALUES (N'HSK       ', N'Seiko', N'SEIKO, Hãng đồng hồ Seiko từ khi du nhập vào Việt Nam đã tạo nên một cơn sốt rất mạnh mẽ trong giới trẻ hiện đại. Những người trẻ tuổi lựa chọn dòng đồng hồ Seiko chính hãng này vì thiết kế tối giản nhất mà lại mang đến vẻ đẹp thời thượng nhất. Hơn cả, việc phối hợp đồ cùng những chiếc Seiko còn không thể đơn giản dễ dàng hơn. Thương hiệu đến từ xứ sở mặt trời mọc này luôn đều đặn tung ra những mẫu sản phẩm hút hồn khách hàng với chất lượng tốt, hợp thời trang và giá thành vô cùng rẻ.')
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [DiaChi], [SoDT], [Email], [TenDN], [MatKhau]) VALUES (1, N'Võ Van A', N'18 Ð? Nhu?n', N'0926252666', N'vovana@gmail.com    ', N'vovana              ', N'123456          ')
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
ALTER TABLE [dbo].[CHITIETDONDATHANG]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETDONDATHANG_DONDATHANG] FOREIGN KEY([MaDatHang])
REFERENCES [dbo].[DONDATHANG] ([MaDatHang])
GO
ALTER TABLE [dbo].[CHITIETDONDATHANG] CHECK CONSTRAINT [FK_CHITIETDONDATHANG_DONDATHANG]
GO
ALTER TABLE [dbo].[CHITIETDONDATHANG]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETDONDATHANG_DONGHO] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[DONGHO] ([MaDH])
GO
ALTER TABLE [dbo].[CHITIETDONDATHANG] CHECK CONSTRAINT [FK_CHITIETDONDATHANG_DONGHO]
GO
ALTER TABLE [dbo].[DONDATHANG]  WITH CHECK ADD  CONSTRAINT [FK_DONDATHANG_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[DONDATHANG] CHECK CONSTRAINT [FK_DONDATHANG_KHACHHANG]
GO
ALTER TABLE [dbo].[DONGHO]  WITH CHECK ADD  CONSTRAINT [FK_DONGHO_HANG] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HANG] ([MaHang])
GO
ALTER TABLE [dbo].[DONGHO] CHECK CONSTRAINT [FK_DONGHO_HANG]
GO
