USE [master]
GO
/****** Object:  Database [BRCTransportDB]    Script Date: 04/01/2015 19:02:43 ******/
CREATE DATABASE [BRCTransportDB] ON  PRIMARY 
( NAME = N'BRCTransportDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\BRCTransportDB.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BRCTransportDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\BRCTransportDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BRCTransportDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BRCTransportDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BRCTransportDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [BRCTransportDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [BRCTransportDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [BRCTransportDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [BRCTransportDB] SET ARITHABORT OFF
GO
ALTER DATABASE [BRCTransportDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [BRCTransportDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [BRCTransportDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [BRCTransportDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [BRCTransportDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [BRCTransportDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [BRCTransportDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [BRCTransportDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [BRCTransportDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [BRCTransportDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [BRCTransportDB] SET  DISABLE_BROKER
GO
ALTER DATABASE [BRCTransportDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [BRCTransportDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [BRCTransportDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [BRCTransportDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [BRCTransportDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [BRCTransportDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [BRCTransportDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [BRCTransportDB] SET  READ_WRITE
GO
ALTER DATABASE [BRCTransportDB] SET RECOVERY FULL
GO
ALTER DATABASE [BRCTransportDB] SET  MULTI_USER
GO
ALTER DATABASE [BRCTransportDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [BRCTransportDB] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'BRCTransportDB', N'ON'
GO
USE [BRCTransportDB]
GO
/****** Object:  Table [dbo].[tblChallan]    Script Date: 04/01/2015 19:02:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblChallan](
	[ChallanId] [int] IDENTITY(1,1) NOT NULL,
	[ChallanNo] [int] NULL,
	[ChallanDateTime] [date] NULL,
	[VehicleNo] [varchar](50) NULL,
	[VehicleType] [varchar](50) NULL,
	[VechicleMake] [varchar](50) NULL,
	[VehicleModel] [varchar](50) NULL,
	[VehicleNoOfPointLoading] [varchar](50) NULL,
	[Vehicle4NoOfPointUnLoading] [varchar](50) NULL,
	[VehicleFleetCode] [varchar](50) NULL,
	[FromBrCode] [varchar](50) NULL,
	[LoadedForm] [varchar](50) NULL,
	[ToBrCode] [varchar](50) NULL,
	[Destination] [varchar](50) NULL,
	[DistanceKM] [varchar](50) NULL,
	[ScheduleDateofActual] [varchar](50) NULL,
	[VechicleEngineNo] [varchar](50) NULL,
	[VechicleChassisNo] [varchar](50) NULL,
	[DriverName] [varchar](50) NULL,
	[DriverMobileNo] [varchar](500) NULL,
	[DriverAddress] [varchar](500) NULL,
	[TaxTokenNo] [varchar](50) NULL,
	[TaxTokenNoValidUpto] [varchar](50) NULL,
	[TaxTokenNoIssuedFrom] [varchar](50) NULL,
	[DriverLicenseNo] [varchar](50) NULL,
	[LicenseIssuedFrom] [varchar](50) NULL,
	[LicenseValidUpto] [varchar](50) NULL,
	[RoadPermitNo] [varchar](50) NULL,
	[RoadPermitValidUpto] [varchar](50) NULL,
	[VechicleOwnerName] [varchar](50) NULL,
	[VechicleOwnerMobileNo] [varchar](50) NULL,
	[VechicleOwnerPanNo] [varchar](10) NULL,
	[VechicleOwnerAddress] [varchar](300) NULL,
	[InsPolicyNo] [varchar](200) NULL,
	[InsCoWithStn] [varchar](50) NULL,
	[VechicleEngagedByNameWithEmpCode1] [varchar](300) NULL,
	[VechicleEngagedByNameWithEmpCode2] [varchar](300) NULL,
	[VechicleAgentName] [varchar](100) NULL,
	[VechicleMobileNo] [varchar](50) NULL,
	[VechicleAgentAddress] [varchar](500) NULL,
	[VechicleFinancierDetails] [varchar](200) NULL,
	[BrokerLoadingAdviceNoDate] [varchar](200) NULL,
	[GrandTotalPKG] [float] NULL,
	[GrandTotalKGS] [float] NULL,
	[MaterialUnLoadingBy] [varchar](50) NULL,
	[PayableTotalPackages] [float] NULL,
	[PayableChargedWeight] [float] NULL,
	[PayableRatePerTon] [float] NULL,
	[TotalLorryHire] [float] NULL,
	[ITDSDeduction] [float] NULL,
	[PartyLorryHire] [float] NULL,
	[BalanceLorryHire] [float] NULL,
 CONSTRAINT [PK_tblChallenNo] PRIMARY KEY CLUSTERED 
(
	[ChallanId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblChallan] ON
INSERT [dbo].[tblChallan] ([ChallanId], [ChallanNo], [ChallanDateTime], [VehicleNo], [VehicleType], [VechicleMake], [VehicleModel], [VehicleNoOfPointLoading], [Vehicle4NoOfPointUnLoading], [VehicleFleetCode], [FromBrCode], [LoadedForm], [ToBrCode], [Destination], [DistanceKM], [ScheduleDateofActual], [VechicleEngineNo], [VechicleChassisNo], [DriverName], [DriverMobileNo], [DriverAddress], [TaxTokenNo], [TaxTokenNoValidUpto], [TaxTokenNoIssuedFrom], [DriverLicenseNo], [LicenseIssuedFrom], [LicenseValidUpto], [RoadPermitNo], [RoadPermitValidUpto], [VechicleOwnerName], [VechicleOwnerMobileNo], [VechicleOwnerPanNo], [VechicleOwnerAddress], [InsPolicyNo], [InsCoWithStn], [VechicleEngagedByNameWithEmpCode1], [VechicleEngagedByNameWithEmpCode2], [VechicleAgentName], [VechicleMobileNo], [VechicleAgentAddress], [VechicleFinancierDetails], [BrokerLoadingAdviceNoDate], [GrandTotalPKG], [GrandTotalKGS], [MaterialUnLoadingBy], [PayableTotalPackages], [PayableChargedWeight], [PayableRatePerTon], [TotalLorryHire], [ITDSDeduction], [PartyLorryHire], [BalanceLorryHire]) VALUES (2, 1, CAST(0x80360B00 AS Date), N'dsfs', N'vhvhv', N'vkhvkhv', NULL, NULL, NULL, NULL, N'khvkhv', N'vkhvkhvkv', N'khvkhvkh', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0, NULL, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tblChallan] ([ChallanId], [ChallanNo], [ChallanDateTime], [VehicleNo], [VehicleType], [VechicleMake], [VehicleModel], [VehicleNoOfPointLoading], [Vehicle4NoOfPointUnLoading], [VehicleFleetCode], [FromBrCode], [LoadedForm], [ToBrCode], [Destination], [DistanceKM], [ScheduleDateofActual], [VechicleEngineNo], [VechicleChassisNo], [DriverName], [DriverMobileNo], [DriverAddress], [TaxTokenNo], [TaxTokenNoValidUpto], [TaxTokenNoIssuedFrom], [DriverLicenseNo], [LicenseIssuedFrom], [LicenseValidUpto], [RoadPermitNo], [RoadPermitValidUpto], [VechicleOwnerName], [VechicleOwnerMobileNo], [VechicleOwnerPanNo], [VechicleOwnerAddress], [InsPolicyNo], [InsCoWithStn], [VechicleEngagedByNameWithEmpCode1], [VechicleEngagedByNameWithEmpCode2], [VechicleAgentName], [VechicleMobileNo], [VechicleAgentAddress], [VechicleFinancierDetails], [BrokerLoadingAdviceNoDate], [GrandTotalPKG], [GrandTotalKGS], [MaterialUnLoadingBy], [PayableTotalPackages], [PayableChargedWeight], [PayableRatePerTon], [TotalLorryHire], [ITDSDeduction], [PartyLorryHire], [BalanceLorryHire]) VALUES (3, 2, CAST(0x80360B00 AS Date), N'dsfs', N'vhvhv', N'vkhvkhv', NULL, NULL, NULL, NULL, N'khvkhv', N'vkhvkhvkv', N'khvkhvkh', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0, NULL, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[tblChallan] ([ChallanId], [ChallanNo], [ChallanDateTime], [VehicleNo], [VehicleType], [VechicleMake], [VehicleModel], [VehicleNoOfPointLoading], [Vehicle4NoOfPointUnLoading], [VehicleFleetCode], [FromBrCode], [LoadedForm], [ToBrCode], [Destination], [DistanceKM], [ScheduleDateofActual], [VechicleEngineNo], [VechicleChassisNo], [DriverName], [DriverMobileNo], [DriverAddress], [TaxTokenNo], [TaxTokenNoValidUpto], [TaxTokenNoIssuedFrom], [DriverLicenseNo], [LicenseIssuedFrom], [LicenseValidUpto], [RoadPermitNo], [RoadPermitValidUpto], [VechicleOwnerName], [VechicleOwnerMobileNo], [VechicleOwnerPanNo], [VechicleOwnerAddress], [InsPolicyNo], [InsCoWithStn], [VechicleEngagedByNameWithEmpCode1], [VechicleEngagedByNameWithEmpCode2], [VechicleAgentName], [VechicleMobileNo], [VechicleAgentAddress], [VechicleFinancierDetails], [BrokerLoadingAdviceNoDate], [GrandTotalPKG], [GrandTotalKGS], [MaterialUnLoadingBy], [PayableTotalPackages], [PayableChargedWeight], [PayableRatePerTon], [TotalLorryHire], [ITDSDeduction], [PartyLorryHire], [BalanceLorryHire]) VALUES (4, 3, CAST(0x80360B00 AS Date), N'dsfs', N'vhvhv', N'vkhvkhv', NULL, NULL, NULL, NULL, N'khvkhv', N'vkhvkhvkv', N'khvkhvkh', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0, 0, NULL, 0, 0, 0, 0, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[tblChallan] OFF
/****** Object:  Table [dbo].[tblBankMaster]    Script Date: 04/01/2015 19:02:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBankMaster](
	[BankId] [int] IDENTITY(1,1) NOT NULL,
	[BankName] [varchar](100) NULL,
	[AccountNo] [varchar](50) NULL,
	[AccountType] [varchar](50) NULL,
	[Addrees] [varchar](500) NULL,
	[PhoneNo] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
	[OpeningBalance] [float] NULL,
	[OpeningDate] [date] NULL,
 CONSTRAINT [PK_BankMaster] PRIMARY KEY CLUSTERED 
(
	[BankId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblAccountsMaster]    Script Date: 04/01/2015 19:02:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblAccountsMaster](
	[AccountId] [int] IDENTITY(1,1) NOT NULL,
	[AccountName] [varchar](100) NULL,
	[AccountType] [varchar](50) NOT NULL,
	[AccountNo] [varchar](50) NULL,
	[Addrees] [varchar](500) NULL,
	[PhoneNo] [varchar](50) NULL,
	[OpeningBalance] [float] NULL,
	[OpeningDate] [date] NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_TransactionAccounts] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblAccountsMaster] ON
INSERT [dbo].[tblAccountsMaster] ([AccountId], [AccountName], [AccountType], [AccountNo], [Addrees], [PhoneNo], [OpeningBalance], [OpeningDate], [Description]) VALUES (1, N'ICICi Bank ', N'1', N'1234665', N'sdbfsdb', N'bjkjb', 1000, CAST(0x5A390B00 AS Date), NULL)
INSERT [dbo].[tblAccountsMaster] ([AccountId], [AccountName], [AccountType], [AccountNo], [Addrees], [PhoneNo], [OpeningBalance], [OpeningDate], [Description]) VALUES (2, N'asdsda', N'1', N'1222', N'fgsds', N'12122', 15116, CAST(0x5A390B00 AS Date), NULL)
INSERT [dbo].[tblAccountsMaster] ([AccountId], [AccountName], [AccountType], [AccountNo], [Addrees], [PhoneNo], [OpeningBalance], [OpeningDate], [Description]) VALUES (3, N'mayur', N'2', N'1223122322', N'21sdfsfs
', N'212', 121, CAST(0xC2390B00 AS Date), NULL)
INSERT [dbo].[tblAccountsMaster] ([AccountId], [AccountName], [AccountType], [AccountNo], [Addrees], [PhoneNo], [OpeningBalance], [OpeningDate], [Description]) VALUES (4, N'mayur', N'2', N'1223122322', N'', N'212', 100, CAST(0xC2390B00 AS Date), NULL)
INSERT [dbo].[tblAccountsMaster] ([AccountId], [AccountName], [AccountType], [AccountNo], [Addrees], [PhoneNo], [OpeningBalance], [OpeningDate], [Description]) VALUES (5, N's', N'1', N'3223', N'dssdsd', N'22', 22, CAST(0xC2390B00 AS Date), N'')
INSERT [dbo].[tblAccountsMaster] ([AccountId], [AccountName], [AccountType], [AccountNo], [Addrees], [PhoneNo], [OpeningBalance], [OpeningDate], [Description]) VALUES (6, N'12', N'2', N'22', N'222', N'22', 22, CAST(0xC2390B00 AS Date), N'2212')
SET IDENTITY_INSERT [dbo].[tblAccountsMaster] OFF
/****** Object:  Table [dbo].[tblConsignee]    Script Date: 04/01/2015 19:02:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblConsignee](
	[ConsigneeId] [int] IDENTITY(1,1) NOT NULL,
	[ConsigneeName] [varchar](100) NULL,
	[Address] [varchar](300) NULL,
	[PhoneNo] [varchar](100) NULL,
	[STNOCSTNO] [varchar](50) NULL,
	[TINNOVATNO] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
	[CreationDate] [date] NULL,
 CONSTRAINT [PK_tblConsignee] PRIMARY KEY CLUSTERED 
(
	[ConsigneeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblConsignee] ON
INSERT [dbo].[tblConsignee] ([ConsigneeId], [ConsigneeName], [Address], [PhoneNo], [STNOCSTNO], [TINNOVATNO], [Description], [CreationDate]) VALUES (1, N'a1', N'a2', N'a3', N'a4', N'a5', N'a6', CAST(0x0F390B00 AS Date))
INSERT [dbo].[tblConsignee] ([ConsigneeId], [ConsigneeName], [Address], [PhoneNo], [STNOCSTNO], [TINNOVATNO], [Description], [CreationDate]) VALUES (4, N'1', N'2', N'3', N'4', N'5', N'6', CAST(0x0F390B00 AS Date))
INSERT [dbo].[tblConsignee] ([ConsigneeId], [ConsigneeName], [Address], [PhoneNo], [STNOCSTNO], [TINNOVATNO], [Description], [CreationDate]) VALUES (5, N'dasfdsblj', N'bljbljb', N'bjllblb', N'jlbljbljb', N'jbljbljb', N'jlblb', CAST(0x14390B00 AS Date))
INSERT [dbo].[tblConsignee] ([ConsigneeId], [ConsigneeName], [Address], [PhoneNo], [STNOCSTNO], [TINNOVATNO], [Description], [CreationDate]) VALUES (6, N'adsdas', N'bjb', N'bljb', N'lbjljb', N'ljb', N'blj', CAST(0x15390B00 AS Date))
INSERT [dbo].[tblConsignee] ([ConsigneeId], [ConsigneeName], [Address], [PhoneNo], [STNOCSTNO], [TINNOVATNO], [Description], [CreationDate]) VALUES (7, N'sdfdsfsdfs', N'df', N'lbljbj', N'ljb', N'ljb', N'jlblj', CAST(0x15390B00 AS Date))
INSERT [dbo].[tblConsignee] ([ConsigneeId], [ConsigneeName], [Address], [PhoneNo], [STNOCSTNO], [TINNOVATNO], [Description], [CreationDate]) VALUES (8, N'asda', N'dasd', N'sdas', N'dasd', N'asdasd', N'asda', CAST(0x15390B00 AS Date))
INSERT [dbo].[tblConsignee] ([ConsigneeId], [ConsigneeName], [Address], [PhoneNo], [STNOCSTNO], [TINNOVATNO], [Description], [CreationDate]) VALUES (9, N'asdasdasd', N'asdasdas', N'sada', N'sdasd', N'asdasas', N'asdasd', CAST(0x15390B00 AS Date))
INSERT [dbo].[tblConsignee] ([ConsigneeId], [ConsigneeName], [Address], [PhoneNo], [STNOCSTNO], [TINNOVATNO], [Description], [CreationDate]) VALUES (10, N'asdasd', N'vkhv', N'vkhv', N'khvkv', N'khvkh', N'vkh', CAST(0x15390B00 AS Date))
INSERT [dbo].[tblConsignee] ([ConsigneeId], [ConsigneeName], [Address], [PhoneNo], [STNOCSTNO], [TINNOVATNO], [Description], [CreationDate]) VALUES (11, N'sdfsdfsd', N'dfsdf', N'sdfsdfsd', N'fsdfsdfsd', N'fsdf', N'dsfdsf', CAST(0x15390B00 AS Date))
INSERT [dbo].[tblConsignee] ([ConsigneeId], [ConsigneeName], [Address], [PhoneNo], [STNOCSTNO], [TINNOVATNO], [Description], [CreationDate]) VALUES (12, N'sdfsdfsd', N'fsdfdf', N'sdfsdfsdf', N'sdasd', N'dsfdsf', N'sdfsdf', CAST(0x15390B00 AS Date))
SET IDENTITY_INSERT [dbo].[tblConsignee] OFF
/****** Object:  Table [dbo].[tblCompany]    Script Date: 04/01/2015 19:02:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCompany](
	[CompanyId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](50) NULL,
	[Address] [varchar](500) NULL,
	[PhoneNo] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
	[ServiceTaxRegdNo] [varchar](50) NULL,
	[PolicyNo] [varchar](50) NULL,
 CONSTRAINT [PK_tblCompany] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblCompany] ON
INSERT [dbo].[tblCompany] ([CompanyId], [CompanyName], [Address], [PhoneNo], [Description], [ServiceTaxRegdNo], [PolicyNo]) VALUES (1, N'Company1', N'afa', N'bljb', N'bljbl', N'bjb', N'lblb')
INSERT [dbo].[tblCompany] ([CompanyId], [CompanyName], [Address], [PhoneNo], [Description], [ServiceTaxRegdNo], [PolicyNo]) VALUES (3, N'Company2', N'8', N'7', N'6', N'5', N'4')
INSERT [dbo].[tblCompany] ([CompanyId], [CompanyName], [Address], [PhoneNo], [Description], [ServiceTaxRegdNo], [PolicyNo]) VALUES (4, N'Company3', N'H', N'v', N'jv', N'v', N'vkv')
SET IDENTITY_INSERT [dbo].[tblCompany] OFF
/****** Object:  Table [dbo].[tblLogin]    Script Date: 04/01/2015 19:02:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblLogin](
	[LoginId] [int] IDENTITY(1,1) NOT NULL,
	[LoginName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_tblLogin] PRIMARY KEY CLUSTERED 
(
	[LoginId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblLogin] ON
INSERT [dbo].[tblLogin] ([LoginId], [LoginName], [Password]) VALUES (1, N'ajitsharma', N'ajitbrc')
INSERT [dbo].[tblLogin] ([LoginId], [LoginName], [Password]) VALUES (2, N'aksharma', N'akbrc')
SET IDENTITY_INSERT [dbo].[tblLogin] OFF
/****** Object:  Table [dbo].[tblConsignor]    Script Date: 04/01/2015 19:02:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblConsignor](
	[ConsignorId] [int] IDENTITY(1,1) NOT NULL,
	[ConsignorName] [varchar](100) NULL,
	[Address] [varchar](300) NULL,
	[PhoneNo] [varchar](100) NULL,
	[STNOCSTNO] [varchar](50) NULL,
	[TINNOVATNO] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
	[CreationDate] [date] NULL,
	[Type] [int] NULL,
	[Code] [varchar](50) NULL,
 CONSTRAINT [PK_tblConsignor] PRIMARY KEY CLUSTERED 
(
	[ConsignorId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblConsignor] ON
INSERT [dbo].[tblConsignor] ([ConsignorId], [ConsignorName], [Address], [PhoneNo], [STNOCSTNO], [TINNOVATNO], [Description], [CreationDate], [Type], [Code]) VALUES (6, N'dfsfs', N'sdfsd', N'fsdfsdf', N'sdfsd', N'fsdf', N'sdfsdf', CAST(0x23390B00 AS Date), 2, N'fdsfsd')
INSERT [dbo].[tblConsignor] ([ConsignorId], [ConsignorName], [Address], [PhoneNo], [STNOCSTNO], [TINNOVATNO], [Description], [CreationDate], [Type], [Code]) VALUES (7, N'ffdsf', N'sdfdsffsddfafa', N'fdsf', N'dsfds', N'fsdfsd', N'sdfsdffsdffsf', CAST(0x23390B00 AS Date), 1, N'fdsfsd1')
INSERT [dbo].[tblConsignor] ([ConsignorId], [ConsignorName], [Address], [PhoneNo], [STNOCSTNO], [TINNOVATNO], [Description], [CreationDate], [Type], [Code]) VALUES (8, N'aa', N'
12
', N'232', N'sdsd', N'sdsd', N'sdfsdfs

', CAST(0xC8390B00 AS Date), 1, N'122')
SET IDENTITY_INSERT [dbo].[tblConsignor] OFF
/****** Object:  Table [dbo].[tblConsignmentNote]    Script Date: 04/01/2015 19:02:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblConsignmentNote](
	[ConsignmentId] [int] IDENTITY(1,1) NOT NULL,
	[ConsignmentNoteNo] [int] NULL,
	[CompanyName] [varchar](500) NULL,
	[PolicyNo] [varchar](50) NULL,
	[CompanyDate] [date] NULL,
	[CompanyAmount] [float] NULL,
	[ConsigneeId] [int] NULL,
	[ConsignorId] [int] NULL,
	[ConsigneeInvoiceNo] [varchar](50) NULL,
	[ConsigneeServiceTaxRegNo] [varchar](50) NULL,
	[ConsignorPurchaseOrderNo] [varchar](50) NULL,
	[ConsignorServiceTaxRegNo] [varchar](50) NULL,
	[FromCode] [varchar](500) NULL,
	[ToCode] [varchar](500) NULL,
	[NoofPackages] [varchar](50) NULL,
	[MethodOfPacking] [varchar](50) NULL,
	[ActualWtInKGS] [varchar](50) NULL,
	[CategoryOfLoad] [varchar](50) NULL,
	[Rate] [varchar](50) NULL,
	[LoadType] [varchar](50) NULL,
	[Distance] [varchar](50) NULL,
	[KMS] [varchar](50) NULL,
	[DescriptionSaidToContain] [varchar](50) NULL,
	[PrivateMarketOtherIdentificaion] [varchar](50) NULL,
	[BusinessType] [varchar](50) NULL,
	[AdvancedPaymentMRNo] [varchar](50) NULL,
	[AdvancedPaymentDate] [date] NULL,
	[AdvancedPaymentAmount] [varchar](50) NULL,
	[DimensionLength] [varchar](50) NULL,
	[DimensionWidth] [varchar](50) NULL,
	[DimensionHeight] [varchar](50) NULL,
	[DimensionNoOfPKGS] [varchar](50) NULL,
	[DimensionTotalCFTCMT] [varchar](50) NULL,
	[DimensionSinglePieceWeight] [varchar](50) NULL,
	[DeclarationNo] [varchar](50) NULL,
	[ValidUpto] [varchar](50) NULL,
	[DeclaredValueOfGoods] [varchar](50) NULL,
	[BasicOfBooking] [varchar](50) NULL,
	[BilledWithMs] [varchar](50) NULL,
	[BranchCode] [varchar](50) NULL,
	[ToPay] [varchar](50) NULL,
	[Rebooking] [varchar](50) NULL,
	[MainConsignmentNo] [varchar](50) NULL,
	[GoodRecievedDetails] [varchar](500) NULL,
	[PanNo] [varchar](50) NULL,
	[PartyCode] [varchar](50) NULL,
	[ServicetaxThrough] [varchar](50) NULL,
	[ValidType] [varchar](50) NULL,
	[PhoneNo] [varchar](50) NULL,
	[AddressofIssuing] [varchar](500) NULL,
	[ConsignmentDate] [date] NULL,
	[CentralisedServiceTaxRegnNo] [varchar](50) NULL,
	[CompanyPhone] [varchar](200) NULL,
	[Charges1] [varchar](50) NULL,
	[Amount1] [float] NULL,
	[Charges2] [varchar](50) NULL,
	[Amount2] [float] NULL,
	[Charges3] [varchar](50) NULL,
	[Amount3] [float] NULL,
	[Charges4] [varchar](50) NULL,
	[Amount4] [float] NULL,
	[Charges5] [varchar](50) NULL,
	[Amount5] [float] NULL,
	[FinalAmount] [float] NULL,
	[ServiceTaxisPayableBy] [varchar](50) NULL,
 CONSTRAINT [PK_tblConsignmentNote] PRIMARY KEY CLUSTERED 
(
	[ConsignmentId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblConsignmentNote] ON
INSERT [dbo].[tblConsignmentNote] ([ConsignmentId], [ConsignmentNoteNo], [CompanyName], [PolicyNo], [CompanyDate], [CompanyAmount], [ConsigneeId], [ConsignorId], [ConsigneeInvoiceNo], [ConsigneeServiceTaxRegNo], [ConsignorPurchaseOrderNo], [ConsignorServiceTaxRegNo], [FromCode], [ToCode], [NoofPackages], [MethodOfPacking], [ActualWtInKGS], [CategoryOfLoad], [Rate], [LoadType], [Distance], [KMS], [DescriptionSaidToContain], [PrivateMarketOtherIdentificaion], [BusinessType], [AdvancedPaymentMRNo], [AdvancedPaymentDate], [AdvancedPaymentAmount], [DimensionLength], [DimensionWidth], [DimensionHeight], [DimensionNoOfPKGS], [DimensionTotalCFTCMT], [DimensionSinglePieceWeight], [DeclarationNo], [ValidUpto], [DeclaredValueOfGoods], [BasicOfBooking], [BilledWithMs], [BranchCode], [ToPay], [Rebooking], [MainConsignmentNo], [GoodRecievedDetails], [PanNo], [PartyCode], [ServicetaxThrough], [ValidType], [PhoneNo], [AddressofIssuing], [ConsignmentDate], [CentralisedServiceTaxRegnNo], [CompanyPhone], [Charges1], [Amount1], [Charges2], [Amount2], [Charges3], [Amount3], [Charges4], [Amount4], [Charges5], [Amount5], [FinalAmount], [ServiceTaxisPayableBy]) VALUES (1, 2, N'adsdsa', NULL, CAST(0xD1260B00 AS Date), NULL, 7, 6, NULL, NULL, NULL, NULL, N'dadasd', N'asdas', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'dfd', 2343, NULL, 23, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'CONSIGNOR')
INSERT [dbo].[tblConsignmentNote] ([ConsignmentId], [ConsignmentNoteNo], [CompanyName], [PolicyNo], [CompanyDate], [CompanyAmount], [ConsigneeId], [ConsignorId], [ConsigneeInvoiceNo], [ConsigneeServiceTaxRegNo], [ConsignorPurchaseOrderNo], [ConsignorServiceTaxRegNo], [FromCode], [ToCode], [NoofPackages], [MethodOfPacking], [ActualWtInKGS], [CategoryOfLoad], [Rate], [LoadType], [Distance], [KMS], [DescriptionSaidToContain], [PrivateMarketOtherIdentificaion], [BusinessType], [AdvancedPaymentMRNo], [AdvancedPaymentDate], [AdvancedPaymentAmount], [DimensionLength], [DimensionWidth], [DimensionHeight], [DimensionNoOfPKGS], [DimensionTotalCFTCMT], [DimensionSinglePieceWeight], [DeclarationNo], [ValidUpto], [DeclaredValueOfGoods], [BasicOfBooking], [BilledWithMs], [BranchCode], [ToPay], [Rebooking], [MainConsignmentNo], [GoodRecievedDetails], [PanNo], [PartyCode], [ServicetaxThrough], [ValidType], [PhoneNo], [AddressofIssuing], [ConsignmentDate], [CentralisedServiceTaxRegnNo], [CompanyPhone], [Charges1], [Amount1], [Charges2], [Amount2], [Charges3], [Amount3], [Charges4], [Amount4], [Charges5], [Amount5], [FinalAmount], [ServiceTaxisPayableBy]) VALUES (3, 23, N'sadasd', NULL, CAST(0xB4960A00 AS Date), NULL, 7, 6, NULL, NULL, NULL, NULL, N'asd', N'asdasd', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(0x1E170B00 AS Date), NULL, NULL, N'asdasda', 223123123, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'CONSIGNOR')
INSERT [dbo].[tblConsignmentNote] ([ConsignmentId], [ConsignmentNoteNo], [CompanyName], [PolicyNo], [CompanyDate], [CompanyAmount], [ConsigneeId], [ConsignorId], [ConsigneeInvoiceNo], [ConsigneeServiceTaxRegNo], [ConsignorPurchaseOrderNo], [ConsignorServiceTaxRegNo], [FromCode], [ToCode], [NoofPackages], [MethodOfPacking], [ActualWtInKGS], [CategoryOfLoad], [Rate], [LoadType], [Distance], [KMS], [DescriptionSaidToContain], [PrivateMarketOtherIdentificaion], [BusinessType], [AdvancedPaymentMRNo], [AdvancedPaymentDate], [AdvancedPaymentAmount], [DimensionLength], [DimensionWidth], [DimensionHeight], [DimensionNoOfPKGS], [DimensionTotalCFTCMT], [DimensionSinglePieceWeight], [DeclarationNo], [ValidUpto], [DeclaredValueOfGoods], [BasicOfBooking], [BilledWithMs], [BranchCode], [ToPay], [Rebooking], [MainConsignmentNo], [GoodRecievedDetails], [PanNo], [PartyCode], [ServicetaxThrough], [ValidType], [PhoneNo], [AddressofIssuing], [ConsignmentDate], [CentralisedServiceTaxRegnNo], [CompanyPhone], [Charges1], [Amount1], [Charges2], [Amount2], [Charges3], [Amount3], [Charges4], [Amount4], [Charges5], [Amount5], [FinalAmount], [ServiceTaxisPayableBy]) VALUES (4, 231, N'sadasd', NULL, CAST(0xB4960A00 AS Date), NULL, 7, 6, NULL, NULL, NULL, NULL, N'asd', N'asdasd', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(0x1E170B00 AS Date), NULL, NULL, N'asdasda', 223123123, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'CONSIGNOR')
INSERT [dbo].[tblConsignmentNote] ([ConsignmentId], [ConsignmentNoteNo], [CompanyName], [PolicyNo], [CompanyDate], [CompanyAmount], [ConsigneeId], [ConsignorId], [ConsigneeInvoiceNo], [ConsigneeServiceTaxRegNo], [ConsignorPurchaseOrderNo], [ConsignorServiceTaxRegNo], [FromCode], [ToCode], [NoofPackages], [MethodOfPacking], [ActualWtInKGS], [CategoryOfLoad], [Rate], [LoadType], [Distance], [KMS], [DescriptionSaidToContain], [PrivateMarketOtherIdentificaion], [BusinessType], [AdvancedPaymentMRNo], [AdvancedPaymentDate], [AdvancedPaymentAmount], [DimensionLength], [DimensionWidth], [DimensionHeight], [DimensionNoOfPKGS], [DimensionTotalCFTCMT], [DimensionSinglePieceWeight], [DeclarationNo], [ValidUpto], [DeclaredValueOfGoods], [BasicOfBooking], [BilledWithMs], [BranchCode], [ToPay], [Rebooking], [MainConsignmentNo], [GoodRecievedDetails], [PanNo], [PartyCode], [ServicetaxThrough], [ValidType], [PhoneNo], [AddressofIssuing], [ConsignmentDate], [CentralisedServiceTaxRegnNo], [CompanyPhone], [Charges1], [Amount1], [Charges2], [Amount2], [Charges3], [Amount3], [Charges4], [Amount4], [Charges5], [Amount5], [FinalAmount], [ServiceTaxisPayableBy]) VALUES (5, 123, N'asd', NULL, CAST(0x61390B00 AS Date), NULL, 7, 6, NULL, NULL, NULL, NULL, N'sdsd', N'asda', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(0x60390B00 AS Date), NULL, NULL, N'sdasd', 31, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'CONSIGNOR')
SET IDENTITY_INSERT [dbo].[tblConsignmentNote] OFF
/****** Object:  Table [dbo].[tblChallanEntry]    Script Date: 04/01/2015 19:02:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblChallanEntry](
	[ChallanEntryNo] [int] IDENTITY(1,1) NOT NULL,
	[ChallanId] [int] NULL,
	[BkgStnCode] [varchar](50) NULL,
	[CNNoWithAlphaCode] [varchar](50) NULL,
	[PackagesNos] [varchar](50) NULL,
	[PackagesMethod] [varchar](50) NULL,
	[SaidToContain] [varchar](50) NULL,
	[ActualWeightKgs] [varchar](50) NULL,
	[DestinationName] [varchar](50) NULL,
 CONSTRAINT [PK_tblChallanEntry] PRIMARY KEY CLUSTERED 
(
	[ChallanEntryNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBill]    Script Date: 04/01/2015 19:02:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBill](
	[BillId] [int] IDENTITY(1,1) NOT NULL,
	[BillNo] [int] NOT NULL,
	[BillDate] [date] NULL,
	[PartyId] [int] NULL,
	[BranchCode] [varchar](50) NULL,
	[PaymentDueDate] [date] NULL,
	[BillType] [varchar](50) NULL,
	[BasicOfChargesGC] [varchar](50) NULL,
	[Enclosure] [varchar](50) NULL,
	[ServiceTaxThrough] [varchar](50) NULL,
	[CheckedBy] [varchar](50) NULL,
	[GrandTotal] [int] NULL,
	[ServiceTaxRegdNo] [varchar](50) NULL,
 CONSTRAINT [PK_tblBill] PRIMARY KEY CLUSTERED 
(
	[BillId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblBill] ON
INSERT [dbo].[tblBill] ([BillId], [BillNo], [BillDate], [PartyId], [BranchCode], [PaymentDueDate], [BillType], [BasicOfChargesGC], [Enclosure], [ServiceTaxThrough], [CheckedBy], [GrandTotal], [ServiceTaxRegdNo]) VALUES (1, 1, CAST(0x67390B00 AS Date), 7, N'edasd', CAST(0x5A390B00 AS Date), N'OCTROI', NULL, NULL, N'CONSIGNOR', NULL, 1477, NULL)
INSERT [dbo].[tblBill] ([BillId], [BillNo], [BillDate], [PartyId], [BranchCode], [PaymentDueDate], [BillType], [BasicOfChargesGC], [Enclosure], [ServiceTaxThrough], [CheckedBy], [GrandTotal], [ServiceTaxRegdNo]) VALUES (2, 2, CAST(0x5F390B00 AS Date), 6, N'sddf', CAST(0x5A390B00 AS Date), N'OCTROI', NULL, NULL, N'CONSIGNOR', NULL, 0, NULL)
INSERT [dbo].[tblBill] ([BillId], [BillNo], [BillDate], [PartyId], [BranchCode], [PaymentDueDate], [BillType], [BasicOfChargesGC], [Enclosure], [ServiceTaxThrough], [CheckedBy], [GrandTotal], [ServiceTaxRegdNo]) VALUES (3, 3, CAST(0xBA380B00 AS Date), 7, N'sdas', CAST(0x82380B00 AS Date), N'FREIGHT', NULL, NULL, N'CONSIGNOR', NULL, 1150, NULL)
INSERT [dbo].[tblBill] ([BillId], [BillNo], [BillDate], [PartyId], [BranchCode], [PaymentDueDate], [BillType], [BasicOfChargesGC], [Enclosure], [ServiceTaxThrough], [CheckedBy], [GrandTotal], [ServiceTaxRegdNo]) VALUES (4, 4, CAST(0x5B390B00 AS Date), 6, N'dsfdsf', CAST(0x5B390B00 AS Date), N'OCTROI', NULL, NULL, N'CONSIGNOR', NULL, 1655, NULL)
INSERT [dbo].[tblBill] ([BillId], [BillNo], [BillDate], [PartyId], [BranchCode], [PaymentDueDate], [BillType], [BasicOfChargesGC], [Enclosure], [ServiceTaxThrough], [CheckedBy], [GrandTotal], [ServiceTaxRegdNo]) VALUES (5, 5, CAST(0x4F390B00 AS Date), 6, N'23213', CAST(0x5E390B00 AS Date), N'OCTROI', NULL, NULL, N'CONSIGNOR', NULL, 231, NULL)
SET IDENTITY_INSERT [dbo].[tblBill] OFF
/****** Object:  Table [dbo].[tblBankTransaction]    Script Date: 04/01/2015 19:02:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBankTransaction](
	[TransactionId] [int] IDENTITY(1,1) NOT NULL,
	[BankId] [int] NOT NULL,
	[TDate] [date] NOT NULL,
	[TType] [varchar](50) NOT NULL,
	[DrAmount] [float] NOT NULL,
	[CrAmount] [float] NOT NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_BankTransaction] PRIMARY KEY CLUSTERED 
(
	[TransactionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTransaction]    Script Date: 04/01/2015 19:02:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTransaction](
	[TransactionId] [int] IDENTITY(1,1) NOT NULL,
	[AccountId] [int] NOT NULL,
	[TDate] [date] NOT NULL,
	[DrAmount] [float] NOT NULL,
	[CrAmount] [float] NOT NULL,
	[Recievedby] [varchar](50) NULL,
	[PaidBy] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
	[ChequeNo] [varchar](50) NULL,
	[ChequeDate] [date] NULL,
 CONSTRAINT [PK_CashTransaction] PRIMARY KEY CLUSTERED 
(
	[TransactionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblTransaction] ON
INSERT [dbo].[tblTransaction] ([TransactionId], [AccountId], [TDate], [DrAmount], [CrAmount], [Recievedby], [PaidBy], [Description], [ChequeNo], [ChequeDate]) VALUES (1, 1, CAST(0x5A390B00 AS Date), 0, 100, NULL, NULL, NULL, N'asdsad', CAST(0x5A390B00 AS Date))
INSERT [dbo].[tblTransaction] ([TransactionId], [AccountId], [TDate], [DrAmount], [CrAmount], [Recievedby], [PaidBy], [Description], [ChequeNo], [ChequeDate]) VALUES (2, 1, CAST(0x51390B00 AS Date), 0, 232, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tblTransaction] ([TransactionId], [AccountId], [TDate], [DrAmount], [CrAmount], [Recievedby], [PaidBy], [Description], [ChequeNo], [ChequeDate]) VALUES (3, 1, CAST(0xC8390B00 AS Date), 202, 0, N'3', N'23', N'2222
', N'2', CAST(0xC8390B00 AS Date))
INSERT [dbo].[tblTransaction] ([TransactionId], [AccountId], [TDate], [DrAmount], [CrAmount], [Recievedby], [PaidBy], [Description], [ChequeNo], [ChequeDate]) VALUES (4, 1, CAST(0xC8390B00 AS Date), 202, 0, N'3', N'23', N'2222
333', N'2', CAST(0xC8390B00 AS Date))
INSERT [dbo].[tblTransaction] ([TransactionId], [AccountId], [TDate], [DrAmount], [CrAmount], [Recievedby], [PaidBy], [Description], [ChequeNo], [ChequeDate]) VALUES (5, 1, CAST(0x5A390B00 AS Date), 0, 100, N'sfd', N'sdfsf', N'dfsfsf', N'asdsad', CAST(0x5A390B00 AS Date))
SET IDENTITY_INSERT [dbo].[tblTransaction] OFF
/****** Object:  Table [dbo].[tblMRNote]    Script Date: 04/01/2015 19:02:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMRNote](
	[MRId] [int] IDENTITY(1,1) NOT NULL,
	[MrNo] [int] NULL,
	[BillId] [int] NULL,
	[MRDate] [date] NULL,
	[RecievedFrom] [varchar](50) NULL,
	[LocationFrom] [varchar](50) NULL,
	[LocationTo] [varchar](50) NULL,
	[NoofPackages] [varchar](50) NULL,
	[Weight] [varchar](50) NULL,
	[AmountRecieved] [float] NULL,
	[WayOfRecieve] [varchar](50) NULL,
	[Fright] [float] NULL,
	[StCharges] [float] NULL,
	[Hamali] [float] NULL,
	[Other1] [float] NULL,
	[Other2] [float] NULL,
	[Other3] [float] NULL,
	[Other4] [float] NULL,
	[TotalAmount] [float] NULL,
	[CreationDate] [datetime] NULL,
 CONSTRAINT [PK_tblMRNote] PRIMARY KEY CLUSTERED 
(
	[MRId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblMRNote] ON
INSERT [dbo].[tblMRNote] ([MRId], [MrNo], [BillId], [MRDate], [RecievedFrom], [LocationFrom], [LocationTo], [NoofPackages], [Weight], [AmountRecieved], [WayOfRecieve], [Fright], [StCharges], [Hamali], [Other1], [Other2], [Other3], [Other4], [TotalAmount], [CreationDate]) VALUES (5, 31, 2, CAST(0x6F390B00 AS Date), N'sadas', N'asd', N'asdas', N'23', NULL, 1200, N'Cash', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 12213, NULL)
INSERT [dbo].[tblMRNote] ([MRId], [MrNo], [BillId], [MRDate], [RecievedFrom], [LocationFrom], [LocationTo], [NoofPackages], [Weight], [AmountRecieved], [WayOfRecieve], [Fright], [StCharges], [Hamali], [Other1], [Other2], [Other3], [Other4], [TotalAmount], [CreationDate]) VALUES (7, 34, 2, CAST(0xD5390B00 AS Date), N'sdd', N'1', N'2', N'20', N'520', 1000, N'Cash', 12, 12, 1, 1, 2, 12, 12, 1, NULL)
INSERT [dbo].[tblMRNote] ([MRId], [MrNo], [BillId], [MRDate], [RecievedFrom], [LocationFrom], [LocationTo], [NoofPackages], [Weight], [AmountRecieved], [WayOfRecieve], [Fright], [StCharges], [Hamali], [Other1], [Other2], [Other3], [Other4], [TotalAmount], [CreationDate]) VALUES (8, 35, 3, CAST(0xC8390B00 AS Date), N'mayur', N'surat', N'bharuch', N'2', N'3', 3, N'', 0, 0, 0, 0, 0, 0, 0, 0, CAST(0x0000A46D012FE6AB AS DateTime))
INSERT [dbo].[tblMRNote] ([MRId], [MrNo], [BillId], [MRDate], [RecievedFrom], [LocationFrom], [LocationTo], [NoofPackages], [Weight], [AmountRecieved], [WayOfRecieve], [Fright], [StCharges], [Hamali], [Other1], [Other2], [Other3], [Other4], [TotalAmount], [CreationDate]) VALUES (9, 36, 1, CAST(0xC8390B00 AS Date), N'mayur', N'surat', N'bharuch', N'5', N'3', 3, N'', 21, 0, 0, 0, 0, 0, 0, 0, CAST(0x0000A46D01307172 AS DateTime))
INSERT [dbo].[tblMRNote] ([MRId], [MrNo], [BillId], [MRDate], [RecievedFrom], [LocationFrom], [LocationTo], [NoofPackages], [Weight], [AmountRecieved], [WayOfRecieve], [Fright], [StCharges], [Hamali], [Other1], [Other2], [Other3], [Other4], [TotalAmount], [CreationDate]) VALUES (10, 37, 1, CAST(0xC8390B00 AS Date), N'mayur', N'surat', N'bharuch', N'5', N'5', 1474, N'', 5, 2, 32, 0, 0, 0, 0, 0, CAST(0x0000A46D0131CC30 AS DateTime))
SET IDENTITY_INSERT [dbo].[tblMRNote] OFF
/****** Object:  Table [dbo].[tblBillEntry]    Script Date: 04/01/2015 19:02:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBillEntry](
	[BillOrderId] [int] IDENTITY(1,1) NOT NULL,
	[BillId] [int] NULL,
	[BookingOldBrCode] [varchar](50) NULL,
	[OldBillNo] [varchar](50) NULL,
	[OldBillDate] [date] NULL,
	[DestnCode] [varchar](50) NULL,
	[Particulars] [varchar](500) NULL,
	[ChargedWeight] [varchar](50) NULL,
	[Rate] [varchar](50) NULL,
	[Amount] [float] NULL,
 CONSTRAINT [PK_tblBillOrder] PRIMARY KEY CLUSTERED 
(
	[BillOrderId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblBillEntry] ON
INSERT [dbo].[tblBillEntry] ([BillOrderId], [BillId], [BookingOldBrCode], [OldBillNo], [OldBillDate], [DestnCode], [Particulars], [ChargedWeight], [Rate], [Amount]) VALUES (1, 1, N'sadasda', N'sdas', NULL, N'asd', N'asdasd', N'asdas', N'asdas', 1234)
INSERT [dbo].[tblBillEntry] ([BillOrderId], [BillId], [BookingOldBrCode], [OldBillNo], [OldBillDate], [DestnCode], [Particulars], [ChargedWeight], [Rate], [Amount]) VALUES (2, 1, N'adf', N'dfdf', NULL, N'fsdf', N'dsfsdf', N'sdfsdfs', N'sdfs', 243)
INSERT [dbo].[tblBillEntry] ([BillOrderId], [BillId], [BookingOldBrCode], [OldBillNo], [OldBillDate], [DestnCode], [Particulars], [ChargedWeight], [Rate], [Amount]) VALUES (3, 5, N'asd', NULL, NULL, NULL, NULL, NULL, NULL, 231)
SET IDENTITY_INSERT [dbo].[tblBillEntry] OFF
/****** Object:  ForeignKey [FK_tblConsignmentNote_tblConsignee]    Script Date: 04/01/2015 19:02:46 ******/
ALTER TABLE [dbo].[tblConsignmentNote]  WITH CHECK ADD  CONSTRAINT [FK_tblConsignmentNote_tblConsignee] FOREIGN KEY([ConsigneeId])
REFERENCES [dbo].[tblConsignee] ([ConsigneeId])
GO
ALTER TABLE [dbo].[tblConsignmentNote] CHECK CONSTRAINT [FK_tblConsignmentNote_tblConsignee]
GO
/****** Object:  ForeignKey [FK_tblConsignmentNote_tblConsignor]    Script Date: 04/01/2015 19:02:46 ******/
ALTER TABLE [dbo].[tblConsignmentNote]  WITH CHECK ADD  CONSTRAINT [FK_tblConsignmentNote_tblConsignor] FOREIGN KEY([ConsignorId])
REFERENCES [dbo].[tblConsignor] ([ConsignorId])
GO
ALTER TABLE [dbo].[tblConsignmentNote] CHECK CONSTRAINT [FK_tblConsignmentNote_tblConsignor]
GO
/****** Object:  ForeignKey [FK_tblChallanEntry_tblChallan]    Script Date: 04/01/2015 19:02:46 ******/
ALTER TABLE [dbo].[tblChallanEntry]  WITH CHECK ADD  CONSTRAINT [FK_tblChallanEntry_tblChallan] FOREIGN KEY([ChallanId])
REFERENCES [dbo].[tblChallan] ([ChallanId])
GO
ALTER TABLE [dbo].[tblChallanEntry] CHECK CONSTRAINT [FK_tblChallanEntry_tblChallan]
GO
/****** Object:  ForeignKey [FK_tblBill_tblConsignor]    Script Date: 04/01/2015 19:02:46 ******/
ALTER TABLE [dbo].[tblBill]  WITH CHECK ADD  CONSTRAINT [FK_tblBill_tblConsignor] FOREIGN KEY([PartyId])
REFERENCES [dbo].[tblConsignor] ([ConsignorId])
GO
ALTER TABLE [dbo].[tblBill] CHECK CONSTRAINT [FK_tblBill_tblConsignor]
GO
/****** Object:  ForeignKey [FK_BankTransaction_BankTransaction]    Script Date: 04/01/2015 19:02:46 ******/
ALTER TABLE [dbo].[tblBankTransaction]  WITH CHECK ADD  CONSTRAINT [FK_BankTransaction_BankTransaction] FOREIGN KEY([BankId])
REFERENCES [dbo].[tblBankMaster] ([BankId])
GO
ALTER TABLE [dbo].[tblBankTransaction] CHECK CONSTRAINT [FK_BankTransaction_BankTransaction]
GO
/****** Object:  ForeignKey [FK_tblTransaction_tblAccountsMaster]    Script Date: 04/01/2015 19:02:46 ******/
ALTER TABLE [dbo].[tblTransaction]  WITH CHECK ADD  CONSTRAINT [FK_tblTransaction_tblAccountsMaster] FOREIGN KEY([AccountId])
REFERENCES [dbo].[tblAccountsMaster] ([AccountId])
GO
ALTER TABLE [dbo].[tblTransaction] CHECK CONSTRAINT [FK_tblTransaction_tblAccountsMaster]
GO
/****** Object:  ForeignKey [FK_tblMRNote_tblBill]    Script Date: 04/01/2015 19:02:46 ******/
ALTER TABLE [dbo].[tblMRNote]  WITH CHECK ADD  CONSTRAINT [FK_tblMRNote_tblBill] FOREIGN KEY([BillId])
REFERENCES [dbo].[tblBill] ([BillId])
GO
ALTER TABLE [dbo].[tblMRNote] CHECK CONSTRAINT [FK_tblMRNote_tblBill]
GO
/****** Object:  ForeignKey [FK_tblBillEntry_tblBill]    Script Date: 04/01/2015 19:02:46 ******/
ALTER TABLE [dbo].[tblBillEntry]  WITH CHECK ADD  CONSTRAINT [FK_tblBillEntry_tblBill] FOREIGN KEY([BillId])
REFERENCES [dbo].[tblBill] ([BillId])
GO
ALTER TABLE [dbo].[tblBillEntry] CHECK CONSTRAINT [FK_tblBillEntry_tblBill]
GO
