USE [master]
GO
/****** Object:  Database [Karaoke]    Script Date: 11/16/2016 3:57:28 PM ******/
CREATE DATABASE [Karaoke]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Karaoke', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Karaoke.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Karaoke_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Karaoke_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Karaoke] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Karaoke].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Karaoke] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Karaoke] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Karaoke] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Karaoke] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Karaoke] SET ARITHABORT OFF 
GO
ALTER DATABASE [Karaoke] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Karaoke] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Karaoke] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Karaoke] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Karaoke] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Karaoke] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Karaoke] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Karaoke] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Karaoke] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Karaoke] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Karaoke] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Karaoke] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Karaoke] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Karaoke] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Karaoke] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Karaoke] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Karaoke] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Karaoke] SET RECOVERY FULL 
GO
ALTER DATABASE [Karaoke] SET  MULTI_USER 
GO
ALTER DATABASE [Karaoke] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Karaoke] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Karaoke] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Karaoke] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Karaoke] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Karaoke', N'ON'
GO
USE [Karaoke]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[index] [int] IDENTITY(1,1) NOT NULL,
	[account_name] [varchar](70) NULL,
	[account_pass] [varchar](70) NULL,
	[index_position] [int] NULL,
	[index_user] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[index] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bill](
	[index] [int] IDENTITY(1,1) NOT NULL,
	[id] [varchar](10) NOT NULL,
	[ngayxuat] [datetime] NOT NULL,
	[id_room] [varchar](15) NOT NULL,
	[id_user] [int] NULL,
	[giovao] [datetime] NOT NULL,
	[tiendatcoc] [int] NULL CONSTRAINT [DF_Bill_tiendatcoc]  DEFAULT ((0)),
	[tienhat] [int] NULL CONSTRAINT [DF_Bill_tienhat]  DEFAULT ((0)),
	[tiendichvu] [int] NULL CONSTRAINT [DF_Bill_tiendichvu]  DEFAULT ((0)),
	[giamgia] [int] NULL CONSTRAINT [DF_Bill_giamgia]  DEFAULT ((0)),
	[phuthu] [varchar](50) NULL CONSTRAINT [DF_Bill_phuthu]  DEFAULT ((0)),
	[tongtien] [int] NULL CONSTRAINT [DF_Bill_tongtien]  DEFAULT ((0)),
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BillDeTail]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BillDeTail](
	[index] [int] IDENTITY(1,1) NOT NULL,
	[id] [varchar](10) NOT NULL,
	[name_menu] [nvarchar](50) NOT NULL,
	[dongia] [int] NOT NULL,
	[soluong] [int] NOT NULL,
 CONSTRAINT [PK_BillDeTail] PRIMARY KEY CLUSTERED 
(
	[index] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Contract]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contract](
	[index] [int] IDENTITY(1,1) NOT NULL,
	[id] [varchar](50) NULL,
	[name] [nvarchar](100) NULL,
	[species] [nvarchar](50) NULL,
	[start] [datetime] NULL,
	[end] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[index] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Insurrance]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Insurrance](
	[index_user] [int] NULL,
	[id] [nvarchar](15) NULL,
	[day_offer] [date] NULL,
	[place_of_issue] [nvarchar](100) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KindRoom]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KindRoom](
	[index] [int] IDENTITY(1,1) NOT NULL,
	[type_room] [int] NOT NULL,
	[start_time] [int] NULL,
	[0] [int] NOT NULL CONSTRAINT [DF_KindRoom_0]  DEFAULT ((0)),
	[1] [int] NOT NULL CONSTRAINT [DF_KindRoom_1]  DEFAULT ((0)),
	[2] [int] NOT NULL CONSTRAINT [DF_KindRoom_2]  DEFAULT ((0)),
	[3] [int] NOT NULL CONSTRAINT [DF_KindRoom_3]  DEFAULT ((0)),
	[4] [int] NOT NULL CONSTRAINT [DF_KindRoom_4]  DEFAULT ((0)),
	[5] [int] NOT NULL CONSTRAINT [DF_KindRoom_5]  DEFAULT ((0)),
	[6] [int] NOT NULL CONSTRAINT [DF_KindRoom_6]  DEFAULT ((0)),
	[7] [int] NOT NULL CONSTRAINT [DF_KindRoom_7]  DEFAULT ((0)),
	[8] [int] NOT NULL CONSTRAINT [DF_KindRoom_8]  DEFAULT ((0)),
	[9] [int] NOT NULL CONSTRAINT [DF_KindRoom_9]  DEFAULT ((0)),
	[10] [int] NOT NULL CONSTRAINT [DF_KindRoom_10]  DEFAULT ((0)),
	[11] [int] NOT NULL CONSTRAINT [DF_KindRoom_11]  DEFAULT ((0)),
	[12] [int] NOT NULL CONSTRAINT [DF_KindRoom_12]  DEFAULT ((0)),
	[13] [int] NOT NULL CONSTRAINT [DF_KindRoom_13]  DEFAULT ((0)),
	[14] [int] NOT NULL CONSTRAINT [DF_KindRoom_14]  DEFAULT ((0)),
	[15] [int] NOT NULL CONSTRAINT [DF_KindRoom_15]  DEFAULT ((0)),
	[16] [int] NOT NULL CONSTRAINT [DF_KindRoom_16]  DEFAULT ((0)),
	[17] [int] NOT NULL CONSTRAINT [DF_KindRoom_17]  DEFAULT ((0)),
	[18] [int] NOT NULL CONSTRAINT [DF_KindRoom_18]  DEFAULT ((0)),
	[19] [int] NOT NULL CONSTRAINT [DF_KindRoom_19]  DEFAULT ((0)),
	[20] [int] NOT NULL CONSTRAINT [DF_KindRoom_20]  DEFAULT ((0)),
	[21] [int] NOT NULL CONSTRAINT [DF_KindRoom_21]  DEFAULT ((0)),
	[22] [int] NOT NULL CONSTRAINT [DF_KindRoom_22]  DEFAULT ((0)),
	[23] [int] NOT NULL CONSTRAINT [DF_KindRoom_23]  DEFAULT ((0)),
 CONSTRAINT [PK_KindRoom] PRIMARY KEY CLUSTERED 
(
	[type_room] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Maternity]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Maternity](
	[index_user] [int] NULL,
	[day_off] [date] NULL,
	[day_on] [date] NULL,
	[subsidize] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Menu]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[index] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[unit] [nvarchar](10) NOT NULL,
	[price] [int] NOT NULL,
	[description] [nvarchar](100) NULL CONSTRAINT [DF_Menu_description]  DEFAULT (N'-'),
	[status] [bit] NULL CONSTRAINT [DF_Menu_status]  DEFAULT ((1)),
 CONSTRAINT [PK_Menu_1] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[index] [int] IDENTITY(1,1) NOT NULL,
	[id] [varchar](10) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[phone] [varchar](15) NULL CONSTRAINT [DF_NhaCungCap_phone]  DEFAULT ('-'),
	[address] [nvarchar](100) NULL CONSTRAINT [DF_NhaCungCap_address]  DEFAULT (N'-'),
	[status] [bit] NULL CONSTRAINT [DF_NhaCungCap_status]  DEFAULT ((1)),
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhapKho]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhapKho](
	[index] [int] IDENTITY(1,1) NOT NULL,
	[id] [varchar](10) NOT NULL,
	[id_product] [varchar](15) NOT NULL,
	[ngaynhap] [datetime] NOT NULL,
	[unit] [nvarchar](10) NOT NULL,
	[soluong] [float] NOT NULL,
	[id_nhacungcap] [varchar](10) NOT NULL,
	[dongia] [varchar](20) NULL CONSTRAINT [DF_NhapKho_dongia]  DEFAULT ('-'),
 CONSTRAINT [PK_NhapKho_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[id_product] ASC,
	[id_nhacungcap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Personal_Info]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Personal_Info](
	[index_user] [int] NULL,
	[birthplace] [nvarchar](50) NULL,
	[domicile] [nvarchar](50) NULL,
	[resident] [nvarchar](100) NULL,
	[staying] [nvarchar](100) NULL,
	[phone_number] [varchar](50) NULL,
	[nation] [nvarchar](50) NULL,
	[religion] [nvarchar](50) NULL,
	[citizenship] [nvarchar](50) NULL,
	[education] [nvarchar](50) NULL,
	[note] [nvarchar](50) NULL,
	[date_start_work] [date] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhuThu]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhuThu](
	[index] [int] IDENTITY(1,1) NOT NULL,
	[ngay] [datetime] NOT NULL,
	[phantramphuthu] [int] NOT NULL,
	[description] [ntext] NOT NULL,
 CONSTRAINT [PK_PhuThu] PRIMARY KEY CLUSTERED 
(
	[ngay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Position]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[index] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[basic_salary] [int] NULL,
	[allowance] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[index] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[index] [int] IDENTITY(1,1) NOT NULL,
	[id] [varchar](15) NOT NULL,
	[name_product] [nvarchar](50) NOT NULL,
	[unit] [nvarchar](10) NOT NULL,
	[soluong] [varchar](20) NULL CONSTRAINT [DF_Product_soluong]  DEFAULT ('-'),
	[status] [bit] NULL CONSTRAINT [DF_Product_status]  DEFAULT ((1)),
	[id_ncc] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[index] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Reservation_room]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Reservation_room](
	[index] [int] IDENTITY(1,1) NOT NULL,
	[name_customer] [nvarchar](50) NOT NULL,
	[phone] [varchar](15) NOT NULL,
	[id_room] [varchar](15) NOT NULL,
	[time_checkin] [datetime] NOT NULL,
	[deposits] [int] NOT NULL,
 CONSTRAINT [PK_Reservation_room] PRIMARY KEY CLUSTERED 
(
	[index] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Room]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Room](
	[index] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](15) NOT NULL,
	[type_room] [int] NOT NULL,
	[status] [int] NOT NULL,
	[amount] [int] NOT NULL,
	[start_time] [datetime] NOT NULL CONSTRAINT [DF_Room_start_time]  DEFAULT (((1975)/(1))/(1)),
	[TienDatPhong] [int] NOT NULL CONSTRAINT [DF_Room_TienDatPhong]  DEFAULT ((0)),
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Room_color]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room_color](
	[status] [int] NOT NULL,
	[code_color] [int] NOT NULL,
 CONSTRAINT [PK_Room_color] PRIMARY KEY CLUSTERED 
(
	[status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Room_status]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room_status](
	[status] [int] NOT NULL,
	[description] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Room_status] PRIMARY KEY CLUSTERED 
(
	[status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Room_type]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room_type](
	[type_room] [int] NOT NULL,
	[decription] [ntext] NULL,
 CONSTRAINT [PK_Room_type] PRIMARY KEY CLUSTERED 
(
	[type_room] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Salary_increase]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary_increase](
	[index_user] [int] NULL,
	[index_position] [int] NULL,
	[salary_bonus] [int] NULL,
	[salary_advance] [int] NULL,
	[reason] [nvarchar](300) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Time_slot]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Time_slot](
	[index] [int] IDENTITY(1,1) NOT NULL,
	[id] [varchar](50) NULL,
	[time_start] [time](7) NULL,
	[time_end] [time](7) NULL,
	[price] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[index] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Time_slot_user]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Time_slot_user](
	[index_time_slot] [int] NULL,
	[index_user] [int] NULL,
	[date_work] [int] NULL,
	[time_start] [datetime] NULL,
	[time_end] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[index] [int] IDENTITY(1,1) NOT NULL,
	[id] [varchar](50) NULL,
	[index_account] [int] NULL,
	[index_contract] [int] NULL,
	[index_position] [int] NULL,
	[full_name] [nvarchar](100) NULL,
	[nick_name] [nvarchar](50) NULL,
	[birthday] [date] NULL,
	[sex] [nchar](3) NULL,
	[marital_status] [nchar](4) NULL,
	[cmnd] [char](12) NULL,
	[day_offer] [datetime] NULL,
	[provider] [nvarchar](50) NULL,
	[photo] [varchar](100) NULL,
	[status] [nvarchar](50) NULL,
 CONSTRAINT [PK__User__1D0A33484B89581E] PRIMARY KEY CLUSTERED 
(
	[index] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[XuatKho]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[XuatKho](
	[index] [int] IDENTITY(1,1) NOT NULL,
	[id] [varchar](10) NOT NULL,
	[id_product] [varchar](15) NOT NULL,
	[ngayxuat] [datetime] NOT NULL,
	[soluong] [float] NOT NULL,
	[id_ncc] [varchar](10) NULL,
	[unit] [nvarchar](10) NULL,
 CONSTRAINT [PK_XuatKho] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[id_product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([index], [account_name], [account_pass], [index_position], [index_user]) VALUES (1, N'admin', N'admin', 1, NULL)
INSERT [dbo].[Account] ([index], [account_name], [account_pass], [index_position], [index_user]) VALUES (2, N'quanly', N'quanly', 2, 1)
INSERT [dbo].[Account] ([index], [account_name], [account_pass], [index_position], [index_user]) VALUES (3, N'thungan', N'thungan', 3, 2)
INSERT [dbo].[Account] ([index], [account_name], [account_pass], [index_position], [index_user]) VALUES (4, N'thukho', N'thukho', 4, 3)
SET IDENTITY_INSERT [dbo].[Account] OFF
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([index], [id], [ngayxuat], [id_room], [id_user], [giovao], [tiendatcoc], [tienhat], [tiendichvu], [giamgia], [phuthu], [tongtien]) VALUES (18, N'HD1', CAST(N'2016-10-29 16:16:46.757' AS DateTime), N'P0001', 0, CAST(N'2016-10-22 11:41:47.000' AS DateTime), 0, 19759000, 55000, 0, N'10%   12%   10%   ', 19814000)
INSERT [dbo].[Bill] ([index], [id], [ngayxuat], [id_room], [id_user], [giovao], [tiendatcoc], [tienhat], [tiendichvu], [giamgia], [phuthu], [tongtien]) VALUES (1023, N'HD10', CAST(N'2016-10-31 14:07:18.777' AS DateTime), N'P0008', 0, CAST(N'2016-10-31 13:55:29.000' AS DateTime), 0, 12000, 0, 0, N'', 12000)
INSERT [dbo].[Bill] ([index], [id], [ngayxuat], [id_room], [id_user], [giovao], [tiendatcoc], [tienhat], [tiendichvu], [giamgia], [phuthu], [tongtien]) VALUES (1024, N'HD11', CAST(N'2016-10-31 14:07:56.487' AS DateTime), N'P0008', 0, CAST(N'2016-10-31 14:07:26.000' AS DateTime), 0, 0, 0, 0, N'', 0)
INSERT [dbo].[Bill] ([index], [id], [ngayxuat], [id_room], [id_user], [giovao], [tiendatcoc], [tienhat], [tiendichvu], [giamgia], [phuthu], [tongtien]) VALUES (1025, N'HD12', CAST(N'2016-10-31 18:04:23.280' AS DateTime), N'P0002', 0, CAST(N'2016-10-31 14:10:52.000' AS DateTime), 0, 234500, 130000, 0, N'', 364500)
INSERT [dbo].[Bill] ([index], [id], [ngayxuat], [id_room], [id_user], [giovao], [tiendatcoc], [tienhat], [tiendichvu], [giamgia], [phuthu], [tongtien]) VALUES (1026, N'HD13', CAST(N'2016-11-01 11:01:41.153' AS DateTime), N'P1008', 0, CAST(N'2016-10-20 15:51:24.000' AS DateTime), 0, 32789500, 0, 0, N'10%   12%   10%   ', 32789500)
INSERT [dbo].[Bill] ([index], [id], [ngayxuat], [id_room], [id_user], [giovao], [tiendatcoc], [tienhat], [tiendichvu], [giamgia], [phuthu], [tongtien]) VALUES (1027, N'HD14', CAST(N'2016-11-03 23:11:48.727' AS DateTime), N'P0009', 0, CAST(N'2016-03-11 14:22:29.000' AS DateTime), 0, 720000, 0, 0, N'', 720000)
INSERT [dbo].[Bill] ([index], [id], [ngayxuat], [id_room], [id_user], [giovao], [tiendatcoc], [tienhat], [tiendichvu], [giamgia], [phuthu], [tongtien]) VALUES (1028, N'HD15', CAST(N'2016-11-04 15:05:48.750' AS DateTime), N'P0001', 0, CAST(N'2016-03-11 18:20:04.000' AS DateTime), 0, 88890000, 0, 0, N'', 556565)
INSERT [dbo].[Bill] ([index], [id], [ngayxuat], [id_room], [id_user], [giovao], [tiendatcoc], [tienhat], [tiendichvu], [giamgia], [phuthu], [tongtien]) VALUES (19, N'HD2', CAST(N'2016-10-29 16:18:28.563' AS DateTime), N'P0001', 0, CAST(N'2016-10-22 11:41:47.000' AS DateTime), 0, 19761000, 55000, 0, N'10%   12%   10%   ', 19816000)
INSERT [dbo].[Bill] ([index], [id], [ngayxuat], [id_room], [id_user], [giovao], [tiendatcoc], [tienhat], [tiendichvu], [giamgia], [phuthu], [tongtien]) VALUES (1016, N'HD3', CAST(N'2016-10-30 09:27:40.243' AS DateTime), N'P0001', 0, CAST(N'2016-10-22 11:41:47.000' AS DateTime), 0, 22021000, 55000, 0, N'10%   12%   10%   ', 22076000)
INSERT [dbo].[Bill] ([index], [id], [ngayxuat], [id_room], [id_user], [giovao], [tiendatcoc], [tienhat], [tiendichvu], [giamgia], [phuthu], [tongtien]) VALUES (1017, N'HD4', CAST(N'2016-10-30 22:27:46.663' AS DateTime), N'P0003', 0, CAST(N'2016-10-20 15:51:24.000' AS DateTime), 0, 28304000, 0, 0, N'10%   12%   10%   ', 28304000)
INSERT [dbo].[Bill] ([index], [id], [ngayxuat], [id_room], [id_user], [giovao], [tiendatcoc], [tienhat], [tiendichvu], [giamgia], [phuthu], [tongtien]) VALUES (1018, N'HD5', CAST(N'2016-10-30 22:28:51.453' AS DateTime), N'P0003', 0, CAST(N'2016-10-20 15:51:24.000' AS DateTime), 0, 28304000, 94000, 0, N'10%   12%   10%   ', 28351000)
INSERT [dbo].[Bill] ([index], [id], [ngayxuat], [id_room], [id_user], [giovao], [tiendatcoc], [tienhat], [tiendichvu], [giamgia], [phuthu], [tongtien]) VALUES (1019, N'HD6', CAST(N'2016-10-31 13:51:36.027' AS DateTime), N'P0001', 0, CAST(N'2016-10-22 11:41:47.000' AS DateTime), 0, 20696500, 70000, 0, N'10%   12%   10%   ', 20766500)
INSERT [dbo].[Bill] ([index], [id], [ngayxuat], [id_room], [id_user], [giovao], [tiendatcoc], [tienhat], [tiendichvu], [giamgia], [phuthu], [tongtien]) VALUES (1020, N'HD7', CAST(N'2016-10-31 13:54:58.990' AS DateTime), N'P0002', 0, CAST(N'2016-10-20 15:29:15.000' AS DateTime), 0, 30299500, 0, 0, N'10%   12%   10%   ', 30299500)
INSERT [dbo].[Bill] ([index], [id], [ngayxuat], [id_room], [id_user], [giovao], [tiendatcoc], [tienhat], [tiendichvu], [giamgia], [phuthu], [tongtien]) VALUES (1021, N'HD8', CAST(N'2016-10-31 13:55:16.507' AS DateTime), N'P0008', 0, CAST(N'2016-10-24 23:13:23.000' AS DateTime), 0, 18635000, 0, 0, N'12%   10%   ', 18635000)
INSERT [dbo].[Bill] ([index], [id], [ngayxuat], [id_room], [id_user], [giovao], [tiendatcoc], [tienhat], [tiendichvu], [giamgia], [phuthu], [tongtien]) VALUES (1022, N'HD9', CAST(N'2016-10-31 14:06:40.447' AS DateTime), N'P0004', 0, CAST(N'2016-10-20 16:10:20.000' AS DateTime), 0, 30270500, 0, 0, N'10%   12%   10%   ', 30270500)
SET IDENTITY_INSERT [dbo].[Bill] OFF
SET IDENTITY_INSERT [dbo].[BillDeTail] ON 

INSERT [dbo].[BillDeTail] ([index], [id], [name_menu], [dongia], [soluong]) VALUES (1, N'HD2', N'Sting', 10000, 2)
INSERT [dbo].[BillDeTail] ([index], [id], [name_menu], [dongia], [soluong]) VALUES (2, N'HD2', N'Trái cây', 35000, 1)
INSERT [dbo].[BillDeTail] ([index], [id], [name_menu], [dongia], [soluong]) VALUES (1002, N'HD3', N'Sting', 10000, 2)
INSERT [dbo].[BillDeTail] ([index], [id], [name_menu], [dongia], [soluong]) VALUES (1003, N'HD3', N'Trái cây', 35000, 1)
INSERT [dbo].[BillDeTail] ([index], [id], [name_menu], [dongia], [soluong]) VALUES (1004, N'HD5', N'Bia 333', 12000, 1)
INSERT [dbo].[BillDeTail] ([index], [id], [name_menu], [dongia], [soluong]) VALUES (1005, N'HD5', N'Trái cây', 35000, 1)
INSERT [dbo].[BillDeTail] ([index], [id], [name_menu], [dongia], [soluong]) VALUES (1006, N'HD6', N'Trái cây', 35000, 2)
INSERT [dbo].[BillDeTail] ([index], [id], [name_menu], [dongia], [soluong]) VALUES (1007, N'HD9', N'Bia 333', 12000, 5)
INSERT [dbo].[BillDeTail] ([index], [id], [name_menu], [dongia], [soluong]) VALUES (1008, N'HD12', N'Bia 333', 12000, 5)
INSERT [dbo].[BillDeTail] ([index], [id], [name_menu], [dongia], [soluong]) VALUES (1009, N'HD12', N'Trái cây', 35000, 2)
SET IDENTITY_INSERT [dbo].[BillDeTail] OFF
SET IDENTITY_INSERT [dbo].[KindRoom] ON 

INSERT [dbo].[KindRoom] ([index], [type_room], [start_time], [0], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23]) VALUES (14, 0, 0, 0, 1, 2, 3, 4, 5, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[KindRoom] ([index], [type_room], [start_time], [0], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23]) VALUES (15, 1, 9, 200000, 200000, 200000, 200000, 200000, 200000, 0, 0, 0, 0, 100000, 100000, 100000, 100000, 100000, 100000, 150000, 150000, 150000, 150000, 150000, 150000, 150000, 150000)
INSERT [dbo].[KindRoom] ([index], [type_room], [start_time], [0], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23]) VALUES (16, 2, 0, 200000, 200000, 200000, 200000, 200000, 200000, 200000, 200000, 200000, 200000, 200000, 200000, 200000, 200000, 200000, 200000, 200000, 200000, 200000, 200000, 200000, 200000, 200000, 200000)
INSERT [dbo].[KindRoom] ([index], [type_room], [start_time], [0], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10], [11], [12], [13], [14], [15], [16], [17], [18], [19], [20], [21], [22], [23]) VALUES (17, 3, 13, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 1, 0, 0, 0, 0, 0, 0, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000, 100000)
SET IDENTITY_INSERT [dbo].[KindRoom] OFF
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([index], [name], [unit], [price], [description], [status]) VALUES (23, N'123', N'123', 12322, N'123', 0)
INSERT [dbo].[Menu] ([index], [name], [unit], [price], [description], [status]) VALUES (25, N'213', N'213', 213, N'213', 0)
INSERT [dbo].[Menu] ([index], [name], [unit], [price], [description], [status]) VALUES (22, N'435', N'345', 345, N'345', 0)
INSERT [dbo].[Menu] ([index], [name], [unit], [price], [description], [status]) VALUES (27, N'Bia 333', N'Lon', 12000, N'-', 1)
INSERT [dbo].[Menu] ([index], [name], [unit], [price], [description], [status]) VALUES (28, N'Sting', N'Chai', 10000, N'-', 1)
INSERT [dbo].[Menu] ([index], [name], [unit], [price], [description], [status]) VALUES (26, N'Trái cây', N'Dĩa', 35000, N'-', 1)
SET IDENTITY_INSERT [dbo].[Menu] OFF
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON 

INSERT [dbo].[NhaCungCap] ([index], [id], [name], [phone], [address], [status]) VALUES (13, N'NCC1', N'Sài Gòn Corperation', N'+84123123123', N'Vĩnh Long', 1)
INSERT [dbo].[NhaCungCap] ([index], [id], [name], [phone], [address], [status]) VALUES (14, N'NCC2', N'Chợ đầu mối', N'-', N'-', 1)
INSERT [dbo].[NhaCungCap] ([index], [id], [name], [phone], [address], [status]) VALUES (15, N'NCC3', N'Chợ An Khánh', N'-', N'-', 1)
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
SET IDENTITY_INSERT [dbo].[NhapKho] ON 

INSERT [dbo].[NhapKho] ([index], [id], [id_product], [ngaynhap], [unit], [soluong], [id_nhacungcap], [dongia]) VALUES (24, N'34234', N'SP001', CAST(N'2016-10-25 15:26:57.283' AS DateTime), N'Thùng', 2353, N'NCC1', N'324')
INSERT [dbo].[NhapKho] ([index], [id], [id_product], [ngaynhap], [unit], [soluong], [id_nhacungcap], [dongia]) VALUES (22, N'NK001', N'SP002', CAST(N'2016-10-24 22:20:45.303' AS DateTime), N'Thùng', 20, N'NCC1', N'200000')
INSERT [dbo].[NhapKho] ([index], [id], [id_product], [ngaynhap], [unit], [soluong], [id_nhacungcap], [dongia]) VALUES (21, N'NK002', N'SP001', CAST(N'2016-10-24 00:00:00.000' AS DateTime), N'Thùng', 20, N'NCC1', N'150000')
INSERT [dbo].[NhapKho] ([index], [id], [id_product], [ngaynhap], [unit], [soluong], [id_nhacungcap], [dongia]) VALUES (23, N'NK003', N'SP003', CAST(N'2016-10-24 22:46:58.313' AS DateTime), N'Dĩa', 5, N'NCC2', N'60000')
SET IDENTITY_INSERT [dbo].[NhapKho] OFF
SET IDENTITY_INSERT [dbo].[PhuThu] ON 

INSERT [dbo].[PhuThu] ([index], [ngay], [phantramphuthu], [description]) VALUES (1, CAST(N'2016-04-30 00:00:00.000' AS DateTime), 15, N'lễ 30/4')
INSERT [dbo].[PhuThu] ([index], [ngay], [phantramphuthu], [description]) VALUES (3, CAST(N'2016-05-01 00:00:00.000' AS DateTime), 10, N'ahihi')
INSERT [dbo].[PhuThu] ([index], [ngay], [phantramphuthu], [description]) VALUES (2, CAST(N'2016-05-02 00:00:00.000' AS DateTime), 12, N'thích thì thu')
INSERT [dbo].[PhuThu] ([index], [ngay], [phantramphuthu], [description]) VALUES (4, CAST(N'2016-10-22 00:00:00.000' AS DateTime), 10, N'thích')
INSERT [dbo].[PhuThu] ([index], [ngay], [phantramphuthu], [description]) VALUES (6, CAST(N'2016-10-25 00:00:00.000' AS DateTime), 12, N'điên')
INSERT [dbo].[PhuThu] ([index], [ngay], [phantramphuthu], [description]) VALUES (5, CAST(N'2016-10-26 00:00:00.000' AS DateTime), 10, N'tại vì muốn thu')
SET IDENTITY_INSERT [dbo].[PhuThu] OFF
SET IDENTITY_INSERT [dbo].[Position] ON 

INSERT [dbo].[Position] ([index], [name], [basic_salary], [allowance]) VALUES (1, N'ADMIN', 0, 0)
INSERT [dbo].[Position] ([index], [name], [basic_salary], [allowance]) VALUES (2, N'Quản Lý', 1000000, 500000)
INSERT [dbo].[Position] ([index], [name], [basic_salary], [allowance]) VALUES (3, N'Thu Ngân', 2000000, 500000)
INSERT [dbo].[Position] ([index], [name], [basic_salary], [allowance]) VALUES (4, N'Thủ Kho', 1500000, 500000)
INSERT [dbo].[Position] ([index], [name], [basic_salary], [allowance]) VALUES (5, N'Nhân Viên', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Position] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([index], [id], [name_product], [unit], [soluong], [status], [id_ncc]) VALUES (10, N'SP001', N'Bia 333', N'Thùng', N'1990', 1, N'NCC1')
INSERT [dbo].[Product] ([index], [id], [name_product], [unit], [soluong], [status], [id_ncc]) VALUES (11, N'SP002', N'Heineken', N'Thùng', N'2358', 1, N'NCC1')
INSERT [dbo].[Product] ([index], [id], [name_product], [unit], [soluong], [status], [id_ncc]) VALUES (15, N'SP003', N'Trái Cây', N'Dĩa', N'2358', 1, N'NCC1')
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (1, N'P0001', 0, 2, 20, CAST(N'2016-11-16 15:50:56.030' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (2, N'P0002', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (3, N'P0003', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (4, N'P0004', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (5, N'P0005', 0, 2, 20, CAST(N'2016-11-16 15:56:29.510' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (6, N'P0006', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (7, N'P0007', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (8, N'P0008', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (9, N'P0009', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (10, N'P0010', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (11, N'P0011', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (12, N'P0012', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (13, N'P0013', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (14, N'P0014', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (15, N'P0015', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (16, N'P0016', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (17, N'P0017', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (18, N'P0018', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (19, N'P0019', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (20, N'P0020', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (21, N'P1001', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (22, N'P1002', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (23, N'P1003', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (24, N'P1004', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (25, N'P1005', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (26, N'P1006', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (27, N'P1007', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (28, N'P1008', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (29, N'P1009', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (30, N'P1010', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (31, N'P1011', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (32, N'P1012', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (33, N'P1013', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (34, N'P1014', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (35, N'P1015', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (36, N'P1016', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (37, N'P1017', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (38, N'P1018', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (39, N'P1019', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (40, N'P1020', 1, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (41, N'P2001', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (42, N'P2002', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (43, N'P2003', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (44, N'P2004', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (45, N'P2005', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (46, N'P2006', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (47, N'P2007', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (48, N'P2008', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (49, N'P2009', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (50, N'P2010', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (51, N'P2011', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (52, N'P2012', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (53, N'P2013', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (54, N'P2014', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (55, N'P2015', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (56, N'P2016', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (57, N'P2017', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (58, N'P2018', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (59, N'P2019', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Room] ([index], [name], [type_room], [status], [amount], [start_time], [TienDatPhong]) VALUES (60, N'P2020', 0, 1, 20, CAST(N'1905-05-30 00:00:00.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Room] OFF
INSERT [dbo].[Room_color] ([status], [code_color]) VALUES (1, -12550016)
INSERT [dbo].[Room_color] ([status], [code_color]) VALUES (2, -4144960)
INSERT [dbo].[Room_color] ([status], [code_color]) VALUES (3, -65536)
INSERT [dbo].[Room_color] ([status], [code_color]) VALUES (4, -16744193)
INSERT [dbo].[Room_status] ([status], [description]) VALUES (1, N'Phòng trống')
INSERT [dbo].[Room_status] ([status], [description]) VALUES (2, N'Phòng đang sử dụng')
INSERT [dbo].[Room_status] ([status], [description]) VALUES (3, N'Phòng đã đặt')
INSERT [dbo].[Room_status] ([status], [description]) VALUES (4, N'Phòng đang bảo trì')
INSERT [dbo].[Room_type] ([type_room], [decription]) VALUES (0, N'Thường 1')
INSERT [dbo].[Room_type] ([type_room], [decription]) VALUES (1, N'Thường 2')
INSERT [dbo].[Room_type] ([type_room], [decription]) VALUES (2, N'Thường 3')
INSERT [dbo].[Room_type] ([type_room], [decription]) VALUES (3, N'Thường 4')
INSERT [dbo].[Room_type] ([type_room], [decription]) VALUES (4, N'Thường 5')
INSERT [dbo].[Room_type] ([type_room], [decription]) VALUES (5, N'Thường 6')
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([index], [id], [index_account], [index_contract], [index_position], [full_name], [nick_name], [birthday], [sex], [marital_status], [cmnd], [day_offer], [provider], [photo], [status]) VALUES (1, N'NV1', 2, 1, 2, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'ONLINE')
INSERT [dbo].[User] ([index], [id], [index_account], [index_contract], [index_position], [full_name], [nick_name], [birthday], [sex], [marital_status], [cmnd], [day_offer], [provider], [photo], [status]) VALUES (2, N'NV2', 3, 2, 3, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'OFFLINE')
SET IDENTITY_INSERT [dbo].[User] OFF
SET IDENTITY_INSERT [dbo].[XuatKho] ON 

INSERT [dbo].[XuatKho] ([index], [id], [id_product], [ngayxuat], [soluong], [id_ncc], [unit]) VALUES (5, N'?tybd', N'SP001', CAST(N'2016-11-03 11:57:57.790' AS DateTime), 345, NULL, NULL)
INSERT [dbo].[XuatKho] ([index], [id], [id_product], [ngayxuat], [soluong], [id_ncc], [unit]) VALUES (1, N'13213', N'SP001', CAST(N'2016-10-25 13:17:17.040' AS DateTime), 231, NULL, NULL)
INSERT [dbo].[XuatKho] ([index], [id], [id_product], [ngayxuat], [soluong], [id_ncc], [unit]) VALUES (2, N'234234', N'SP001', CAST(N'2016-10-25 13:20:28.783' AS DateTime), 233424, NULL, NULL)
INSERT [dbo].[XuatKho] ([index], [id], [id_product], [ngayxuat], [soluong], [id_ncc], [unit]) VALUES (3, N'234234', N'SP002', CAST(N'2016-10-25 13:20:28.783' AS DateTime), 233424, NULL, NULL)
INSERT [dbo].[XuatKho] ([index], [id], [id_product], [ngayxuat], [soluong], [id_ncc], [unit]) VALUES (4, N'324234', N'SP001', CAST(N'2016-10-25 15:27:05.713' AS DateTime), 23, NULL, NULL)
SET IDENTITY_INSERT [dbo].[XuatKho] OFF
ALTER TABLE [dbo].[Reservation_room] ADD  CONSTRAINT [DF_Reservation_room_time_checkin]  DEFAULT (((1975)/(1))/(1)) FOR [time_checkin]
GO
ALTER TABLE [dbo].[Reservation_room] ADD  CONSTRAINT [DF_Reservation_room_deposits]  DEFAULT ((0)) FOR [deposits]
GO
ALTER TABLE [dbo].[BillDeTail]  WITH CHECK ADD  CONSTRAINT [FK_BillDeTail_Bill] FOREIGN KEY([id])
REFERENCES [dbo].[Bill] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BillDeTail] CHECK CONSTRAINT [FK_BillDeTail_Bill]
GO
ALTER TABLE [dbo].[NhapKho]  WITH CHECK ADD  CONSTRAINT [FK_NhapKho_NhaCungCap] FOREIGN KEY([id_nhacungcap])
REFERENCES [dbo].[NhaCungCap] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NhapKho] CHECK CONSTRAINT [FK_NhapKho_NhaCungCap]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_NhaCungCap] FOREIGN KEY([id_ncc])
REFERENCES [dbo].[NhaCungCap] ([id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_NhaCungCap]
GO
ALTER TABLE [dbo].[Reservation_room]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_room_Room] FOREIGN KEY([id_room])
REFERENCES [dbo].[Room] ([name])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reservation_room] CHECK CONSTRAINT [FK_Reservation_room_Room]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_KindRoom] FOREIGN KEY([type_room])
REFERENCES [dbo].[KindRoom] ([type_room])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_KindRoom]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Room_status] FOREIGN KEY([status])
REFERENCES [dbo].[Room_status] ([status])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Room_status]
GO
ALTER TABLE [dbo].[Room_color]  WITH CHECK ADD  CONSTRAINT [FK_Room_color_Room_status] FOREIGN KEY([status])
REFERENCES [dbo].[Room_status] ([status])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Room_color] CHECK CONSTRAINT [FK_Room_color_Room_status]
GO
/****** Object:  StoredProcedure [dbo].[Del_BillDetail]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Del_BillDetail]
@id			varchar(10),
@name_menu	nvarchar(50)
AS
	BEGIN
			DELETE FROM dbo.BillDeTail WHERE id = @id AND name_menu  = @name_menu
	END



GO
/****** Object:  StoredProcedure [dbo].[GetDatePhuThu]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GetDatePhuThu]
AS
	BEGIN
			SELECT		ngay, phantramphuthu, dbo.PhuThu.description
			FROM		PhuThu
	END




GO
/****** Object:  StoredProcedure [dbo].[GetInFoNhaCC]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetInFoNhaCC]
AS
	BEGIN
			SELECT		id, name, phone, address
			FROM		NhaCungCap
			WHERE		status = 1
	END





GO
/****** Object:  StoredProcedure [dbo].[GetinfoProduct]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetinfoProduct]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT id, name_product FROM dbo.Product
END





GO
/****** Object:  StoredProcedure [dbo].[GetMaHoaDon]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROC [dbo].[GetMaHoaDon]
	AS
		BEGIN
			SELECT		bill.id
			FROM
			(
				SELECT	MAX(ngayxuat) 'ngày'		FROM dbo.Bill
			)A, dbo.Bill
			WHERE	a.ngày = dbo.Bill.ngayxuat
		END



GO
/****** Object:  StoredProcedure [dbo].[Insert_Bill]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insert_Bill]
@id		varchar(10),
@ngayxuat	datetime,
@id_room	varchar(15),
@id_user	int,
@giovao		datetime,
@tienhat	int,
@tiendichvu		int,
@giamgia		int,
@phuthu			VARCHAR(50),
@tongtien		INT
AS
	BEGIN
			INSERT INTO dbo.Bill
			        ( id ,
			          ngayxuat ,
			          id_room ,
			          id_user ,
			          giovao ,
			          tienhat ,
			          tiendichvu ,
			          giamgia ,
			          phuthu ,
			          tongtien
			        )
			VALUES  ( @id , -- id - varchar(10)
			          @ngayxuat , -- ngayxuat - datetime
			          @id_room, -- id_room - varchar(15)
			          @id_user , -- id_user - int
			          @giovao , -- giovao - datetime
			          @tienhat , -- tienhat - int
			          @tiendichvu, -- tiendichvu - int
			          @giamgia , -- giamgia - int
			          @phuthu , -- phuthu - int
			          @tongtien  -- tongtien - int
			        )

			UPDATE dbo.Room SET status = 1 WHERE name = @id_room
	END




GO
/****** Object:  StoredProcedure [dbo].[Insert_BillDetail]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insert_BillDetail]
@id		varchar(10),
@name_menu	nvarchar(50),
@dongia		int,
@soluong	int
AS
	BEGIN
			INSERT INTO dbo.BillDeTail
			        ( id ,
			          name_menu ,
			          dongia ,
			          soluong 
			        )
			VALUES  ( @id , -- id - varchar(10)
			          @name_menu , -- name_menu - nvarchar(50)
			          @dongia , -- dongia - int
			          @soluong  -- soluong - int

			        )
	END



GO
/****** Object:  StoredProcedure [dbo].[Insert_typeroom]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Insert_typeroom]
@type INT, @decription NTEXT
AS
BEGIN
INSERT dbo.Room_type
        ( type_room, decription )
VALUES  ( @type, -- type_room - int
          @decription  -- decription - ntext
          )
END 



GO
/****** Object:  StoredProcedure [dbo].[LoadTypeRoom]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LoadTypeRoom]
AS 
BEGIN
SELECT * FROM dbo.Room_type
END



GO
/****** Object:  StoredProcedure [dbo].[SoLuongSanPham]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SoLuongSanPham]
@masp varchar(15)
AS
	BEGIN
		Select soluong FROM Product WHERE id = @masp
	END




GO
/****** Object:  StoredProcedure [dbo].[sp_ChinhSuaDichVu]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ChinhSuaDichVu]
@name NVARCHAR(50),
@unit NVARCHAR(10),
@price INT,
@description NVARCHAR(100)
AS
BEGIN
	UPDATE dbo.Menu SET unit = @unit, price = @price, description = @description WHERE name = @name
END





GO
/****** Object:  StoredProcedure [dbo].[sp_EditProduct]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_EditProduct]
@id VARCHAR(15),
@name_product NVARCHAR(50),
@unit NVARCHAR(10)
AS
BEGIN
	UPDATE dbo.Product SET name_product = @name_product, unit = @unit WHERE id = @id
END




GO
/****** Object:  StoredProcedure [dbo].[sp_GetIDNhaCC]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetIDNhaCC]
AS
BEGIN
	SELECT id, name FROM dbo.NhaCungCap
END




GO
/****** Object:  StoredProcedure [dbo].[sp_GetIDProduct]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetIDProduct]
AS
BEGIN
	
SELECT id, name_product FROM dbo.Product 
END




GO
/****** Object:  StoredProcedure [dbo].[sp_GetInfoKho]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetInfoKho]
AS
BEGIN
	SELECT sp.id, sp.name_product, sp.unit, sp.soluong, ncc.name
FROM dbo.Product sp, dbo.NhaCungCap ncc
WHERE sp.id_ncc = ncc.id AND sp.status = 1
END




GO
/****** Object:  StoredProcedure [dbo].[sp_GetMenu]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_GetMenu]
AS
BEGIN
	SELECT name, unit, price, description FROM dbo.Menu WHERE status = 1
END





GO
/****** Object:  StoredProcedure [dbo].[sp_GetUnit_IDProduct]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_GetUnit_IDProduct]
@id_product VARCHAR(15)
AS
BEGIN
	SELECT unit FROM dbo.Product WHERE id = @id_product
END




GO
/****** Object:  StoredProcedure [dbo].[sp_HuyDatPhong_ID]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_HuyDatPhong_ID]
@id_room VARCHAR(15)
AS
BEGIN
	DELETE dbo.Reservation_room WHERE id_room = @id_room
	UPDATE dbo.Room SET status = 1 WHERE name = @id_room
END



GO
/****** Object:  StoredProcedure [dbo].[sp_Insert_RoomTimeSlot]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Insert_RoomTimeSlot]
@type_room INT,
@start_time INT,
@arr_0 INT,
@arr_1 INT,
@arr_2 INT,
@arr_3 INT,
@arr_4 INT,
@arr_5 INT,
@arr_6 INT,
@arr_7 INT,
@arr_8 INT,
@arr_9 INT,
@arr_10 INT,
@arr_11 INT,
@arr_12 INT,
@arr_13 INT,
@arr_14 INT,
@arr_15 INT,
@arr_16 INT,
@arr_17 INT,
@arr_18 INT,
@arr_19 INT,
@arr_20 INT,
@arr_21 INT,
@arr_22 INT,
@arr_23 INT
AS
BEGIN
INSERT dbo.KindRoom
        ( type_room ,
          start_time ,
          [0] ,
          [1] ,
          [2] ,
          [3] ,
          [4] ,
          [5] ,
          [6] ,
          [7] ,
          [8] ,
          [9] ,
          [10] ,
          [11] ,
          [12] ,
          [13] ,
          [14] ,
          [15] ,
          [16] ,
          [17] ,
          [18] ,
          [19] ,
          [20] ,
          [21] ,
          [22] ,
          [23]
        )
VALUES  ( @type_room , -- type_room - int
          @start_time , -- start_time - int
          @arr_0 , -- 0 - int
          @arr_1 , -- 1 - int
          @arr_2 , -- 2 - int
          @arr_3 , -- 3 - int
          @arr_4 , -- 4 - int
          @arr_5 , -- 5 - int
          @arr_6 , -- 6 - int
          @arr_7 , -- 7 - int
          @arr_8 , -- 8 - int
          @arr_9 , -- 9 - int
          @arr_10 , -- 10 - int
          @arr_11, -- 11 - int
          @arr_12, -- 12 - int
          @arr_13, -- 13 - int
          @arr_14, -- 14 - int
          @arr_15, -- 15 - int
          @arr_16, -- 16 - int
          @arr_17, -- 17 - int
          @arr_18, -- 18 - int
          @arr_19, -- 19 - int
          @arr_20, -- 20 - int
          @arr_21, -- 21 - int
          @arr_22, -- 22 - int
          @arr_23 -- 23 - int
        )
END

GO
/****** Object:  StoredProcedure [dbo].[sp_insertProduct]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_insertProduct]
@id VARCHAR(15),
@name_product NVARCHAR(50),
@unit NVARCHAR(10)
AS
BEGIN
	INSERT INTO dbo.Product 
        ( id, name_product, unit )
VALUES  (  @id, -- id - varchar(15)
          @name_product, -- name_product - nvarchar(50)
          @unit -- unit - nvarchar(10)
          )
END




GO
/****** Object:  StoredProcedure [dbo].[sp_LoadRoomTimeSlot]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_LoadRoomTimeSlot]
AS
BEGIN
SELECT * FROM dbo.KindRoom
END

GO
/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Login]
AS
BEGIN
	SET TRANSACTION ISOLATION LEVEL READ COMMITTED
	SELECT acc.account_name, account_pass, acc.index_user, p.name
	FROM dbo.Position p JOIN dbo.Account acc ON p.[index] = acc.index_position
END


GO
/****** Object:  StoredProcedure [dbo].[sp_Menu_GetPrice_Name]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_Menu_GetPrice_Name]
@name NVARCHAR(50)
AS
BEGIN
	SELECT price FROM dbo.Menu WHERE name = @name
END


GO
/****** Object:  StoredProcedure [dbo].[sp_Menu_GetPrice_Unit_Name]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_Menu_GetPrice_Unit_Name]
@name NVARCHAR(50),
@unit NVARCHAR(10)
AS
BEGIN
	SELECT price FROM dbo.Menu WHERE name = @name AND unit = @unit
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Menu_GetUnit_Name]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_Menu_GetUnit_Name]
@name NVARCHAR(50)
AS
BEGIN
	SELECT unit FROM dbo.Menu WHERE name = @name;
END



GO
/****** Object:  StoredProcedure [dbo].[sp_NhapKho]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_NhapKho]
@id VARCHAR(10),
@id_product VARCHAR(15),
@ngaynhap DATETIME,
@unit NVARCHAR(10),
@soluong FLOAT,
@id_nhacungcap VARCHAR(10),
@dongia VARCHAR(20)
AS
BEGIN
	INSERT INTO dbo.NhapKho
	        ( id ,
	          id_product ,
	          ngaynhap ,
	          unit ,
	          soluong ,
	          id_nhacungcap ,
	          dongia
	        )
	VALUES  ( @id , -- id - varchar(10)
	          @id_product , -- id_product - varchar(15)
	          @ngaynhap , -- ngaynhap - datetime
	          @unit , -- unit - nvarchar(10)
	          @soluong , -- soluong - float
	          @id_nhacungcap , -- id_nhacungcap - varchar(10)
	          @dongia  -- gianhap - varchar(20)
	        )

	UPDATE dbo.Product SET soluong += @soluong
END




GO
/****** Object:  StoredProcedure [dbo].[sp_ReservationRoom_Loadinfo]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Load info customer
CREATE PROC [dbo].[sp_ReservationRoom_Loadinfo]
AS
BEGIN
	SELECT name_customer, phone, id_room, time_checkin, deposits FROM dbo.Reservation_Room
END






GO
/****** Object:  StoredProcedure [dbo].[sp_Room_ChuyenPhong]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Chuyen phong
CREATE PROC [dbo].[sp_Room_ChuyenPhong]
@idroomHienTai VARCHAR(15),
@idroomCanChuyen VARCHAR(15),
@thoigianvao DATETIME,
@tiendatphong int
AS
BEGIN
	--update status room
	UPDATE dbo.Room SET status = 1, TienDatPhong = 0 WHERE name = @idroomHienTai;
	--update time checkin
	UPDATE dbo.Room SET status = 2, start_time = @thoigianvao, TienDatPhong = @tiendatphong WHERE name = @idroomCanChuyen
END







GO
/****** Object:  StoredProcedure [dbo].[sp_Room_DatPhong]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_Room_DatPhong]
@idroom VARCHAR(15),
@name_customer NVARCHAR(50),
@phone_number NVARCHAR(15),
@time_checkin DATETIME,
@deposits INT
AS
BEGIN
	--Change status table ROOM 
	SET NOCOUNT ON;
	UPDATE dbo.Room SET status = 3 , TienDatPhong = @deposits WHERE name = @idroom;

	--Insert data to Reservation_Room
	INSERT INTO dbo.Reservation_Room
	        ( name_customer ,
	          phone ,
	          id_room,
	          time_checkin ,
	          deposits
	        )
	VALUES  ( @name_customer , -- name_customer - nvarchar(50)
	          @phone_number , -- phone_number - nvarchar(15)
	          @idroom , -- name - varchar(15)
	          @time_checkin , -- time_checkin - datetime
	          @deposits  -- deposits - int
	        )
END





GO
/****** Object:  StoredProcedure [dbo].[sp_Room_DeleteRoom_ID]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_Room_DeleteRoom_ID]
@idroom VARCHAR(15)
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM dbo.Room WHERE name = @idroom
END






GO
/****** Object:  StoredProcedure [dbo].[sp_Room_GetStatus_ID]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_Room_GetStatus_ID]
@idroom varchar(15)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT status FROM dbo.Room WHERE name = @idroom
END






GO
/****** Object:  StoredProcedure [dbo].[sp_Room_LoadInfoRoom]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_Room_LoadInfoRoom]
AS
BEGIN
	SELECT name, type_room, status, amount, start_time, TienDatPhong FROM dbo.Room
END






GO
/****** Object:  StoredProcedure [dbo].[sp_Room_ThuePhong_ID]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Lê Anh Tuấn
-- Create date: 19/10/2016 21:00
-- Description:	
-- =============================================
CREATE PROCEDURE [dbo].[sp_Room_ThuePhong_ID]
	-- Add the parameters for the stored procedure here
	@idroom VARCHAR(15),
	@tiendatphong int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	

    -- Insert statements for procedure here
	UPDATE dbo.Room SET status = 2, start_time = GETDATE(), TienDatPhong = @tiendatphong WHERE name = @idroom
END





GO
/****** Object:  StoredProcedure [dbo].[sp_Room_UpdateInfo_ID]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_Room_UpdateInfo_ID]
@idroom VARCHAR(15),
@type_room INT,
@amount INT,
@status INT
AS
BEGIN
	UPDATE dbo.Room SET type_room = @type_room, amount = @amount, status = @status WHERE name = @idroom
END











GO
/****** Object:  StoredProcedure [dbo].[sp_RoomColor_DeleteColor]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_RoomColor_DeleteColor]
AS
BEGIN
	DELETE FROM dbo.Room_Color
END






GO
/****** Object:  StoredProcedure [dbo].[sp_RoomColor_LoadColor]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_RoomColor_LoadColor]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT status, code_color FROM dbo.Room_Color
END






GO
/****** Object:  StoredProcedure [dbo].[sp_ThayDoiDatPhong_ID]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ThayDoiDatPhong_ID]
@id_room VARCHAR(15),
@name_customer NVARCHAR(50),
@phone VARCHAR(15),
@time_checkin DATETIME,
@deposits INT
AS
BEGIN
	UPDATE dbo.Reservation_room SET name_customer = @name_customer, phone = @phone, time_checkin = @time_checkin, deposits = @deposits WHERE id_room = @id_room
END



GO
/****** Object:  StoredProcedure [dbo].[sp_ThemDichVu]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ThemDichVu]
@name NVARCHAR(50),
@unit NVARCHAR(10),
@price INT,
@description NVARCHAR(100)
AS
BEGIN
	INSERT INTO dbo.Menu
	        ( name ,
	          unit ,
	          price ,
	          description 
	        )
	VALUES  ( @name , -- name - nvarchar(50)
	          @unit , -- unit - nvarchar(10)
	          @price , -- price - int
			  @description -- description - nvarchar(100)
	        )
END




GO
/****** Object:  StoredProcedure [dbo].[sp_TuHuyDonDatPhong]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_TuHuyDonDatPhong]
@id_room VARCHAR(15)
AS
BEGIN
	UPDATE dbo.Room SET status = 1, TienDatPhong = 0 WHERE name = @id_room
	DELETE dbo.Reservation_room WHERE id_room = @id_room
END



GO
/****** Object:  StoredProcedure [dbo].[sp_Update_RoomTimeSlot]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Update_RoomTimeSlot]
@type_room INT,
@start_time INT,
@arr_0 INT,
@arr_1 INT,
@arr_2 INT,
@arr_3 INT,
@arr_4 INT,
@arr_5 INT,
@arr_6 INT,
@arr_7 INT,
@arr_8 INT,
@arr_9 INT,
@arr_10 INT,
@arr_11 INT,
@arr_12 INT,
@arr_13 INT,
@arr_14 INT,
@arr_15 INT,
@arr_16 INT,
@arr_17 INT,
@arr_18 INT,
@arr_19 INT,
@arr_20 INT,
@arr_21 INT,
@arr_22 INT,
@arr_23 INT
AS
BEGIN
UPDATE dbo.KindRoom SET
start_time = @start_time,
[0] = @arr_0,
[1] = @arr_1,
[2] = @arr_2,
[3] = @arr_3,
[4] = @arr_4,
[5] = @arr_5,
[6] = @arr_6,
[7] = @arr_7,
[8] = @arr_8,
[9] = @arr_9,
[10] = @arr_10,
[11] = @arr_11,
[12] = @arr_12,
[13] = @arr_13,
[14] = @arr_14,
[15] = @arr_15,
[16] = @arr_16,
[17] = @arr_17,
[18] = @arr_18,
[19] = @arr_19,
[20] = @arr_20,
[21] = @arr_21,
[22] = @arr_22,
[23] = @arr_23
WHERE type_room = @type_room
END

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatus]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_UpdateStatus]
@idx_user INT,
@str_status NVARCHAR(50)
AS
BEGIN
	SET XACT_ABORT ON
BEGIN TRAN
BEGIN TRY
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
	UPDATE dbo.[User] SET status = @str_status WHERE [index] = @idx_user
COMMIT
END TRY
BEGIN CATCH
   ROLLBACK
   DECLARE @ErrorMessage VARCHAR(2000)
   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)
END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[sp_XoaDichVu]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_XoaDichVu]
@name NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.Menu SET status = 0 WHERE name = @name
END




GO
/****** Object:  StoredProcedure [dbo].[sp_XoaSanPham_ID]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	[dbo].[sp_XoaSanPham_ID]
@id VARCHAR(15)
AS
BEGIN
	UPDATE dbo.Product SET status = 0 WHERE [index] = @id
END



GO
/****** Object:  StoredProcedure [dbo].[sp_XuatKho]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_XuatKho]
@maxuat varchar(10),
@masp varchar(15),
@soluong float,
@ngayxuat DateTime
AS
	BEGIN
		INSERT INTO XuatKho(id, id_product, soluong, ngayxuat)
		VALUES (@maxuat, @masp, @soluong, @ngayxuat)
		
		UPDATE Product SET soluong -= @soluong WHERE id = @masp
	END




GO
/****** Object:  StoredProcedure [dbo].[SuaNhaCC]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaNhaCC]
@mancc varchar(10),
@tenncc nvarchar(50),
@sdt varchar(15),
@diachi nvarchar(100)
AS
	BEGIN
	
		UPDATE NhaCungCap SET name = @tenncc, phone = @sdt, address = @diachi 
		WHERE	id = @mancc
	END




GO
/****** Object:  StoredProcedure [dbo].[ThemNhaCC]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThemNhaCC]
@mancc varchar(10),
@tenncc nvarchar(50),
@sdt varchar(15),
@diachi nvarchar(100)
AS
	BEGIN
		INSERT INTO NhaCungCap(id, name, phone, address) VALUES(@mancc, @tenncc, @sdt,  @diachi)
	END





GO
/****** Object:  StoredProcedure [dbo].[Update_typeroom]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Update_typeroom]
@type INT, @decription NTEXT
AS 
BEGIN
UPDATE dbo.Room_type SET decription = @decription WHERE type_room = @type
END



GO
/****** Object:  StoredProcedure [dbo].[XoaNhaCC]    Script Date: 11/16/2016 3:57:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	
CREATE PROCEDURE [dbo].[XoaNhaCC]
@id varchar(10)
AS	
	BEGIN
		UPDATE NhaCungCap SET status = 'false' WHERE id = @id
	END





GO
USE [master]
GO
ALTER DATABASE [Karaoke] SET  READ_WRITE 
GO
