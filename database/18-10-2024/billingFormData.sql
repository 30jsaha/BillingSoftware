USE [master]
GO
/****** Object:  Database [billingFormData]    Script Date: 18-10-2024 5.53.58 PM ******/
CREATE DATABASE [billingFormData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'billingFormData', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\billingFormData.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'billingFormData_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\billingFormData_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [billingFormData] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [billingFormData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [billingFormData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [billingFormData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [billingFormData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [billingFormData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [billingFormData] SET ARITHABORT OFF 
GO
ALTER DATABASE [billingFormData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [billingFormData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [billingFormData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [billingFormData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [billingFormData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [billingFormData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [billingFormData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [billingFormData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [billingFormData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [billingFormData] SET  DISABLE_BROKER 
GO
ALTER DATABASE [billingFormData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [billingFormData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [billingFormData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [billingFormData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [billingFormData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [billingFormData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [billingFormData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [billingFormData] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [billingFormData] SET  MULTI_USER 
GO
ALTER DATABASE [billingFormData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [billingFormData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [billingFormData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [billingFormData] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [billingFormData] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [billingFormData] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [billingFormData] SET QUERY_STORE = ON
GO
ALTER DATABASE [billingFormData] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [billingFormData]
GO
/****** Object:  Table [dbo].[account_master]    Script Date: 18-10-2024 5.53.58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account_master](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[account_name] [varchar](100) NULL,
	[status] [varchar](1) NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_account_master] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[company_master]    Script Date: 18-10-2024 5.53.58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[company_master](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[company_id] [int] NOT NULL,
	[company_name] [varchar](100) NULL,
	[company_country] [varchar](100) NULL,
	[company_state] [varchar](100) NULL,
	[currency_id] [int] NOT NULL,
	[fiscal_year_start_date] [date] NULL,
	[fiscal_year_end_date] [date] NULL,
	[company_industry_type] [varchar](150) NULL,
	[status] [varchar](1) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_company_master] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[currency_master]    Script Date: 18-10-2024 5.53.58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[currency_master](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[currency_name] [varchar](50) NULL,
	[currency_details] [varchar](100) NULL,
	[status] [varchar](1) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_currency_master] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer_master]    Script Date: 18-10-2024 5.53.58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer_master](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customer_name] [varchar](100) NULL,
	[customer_email] [varchar](100) NULL,
	[customer_phone] [varchar](100) NULL,
	[customer_type] [int] NOT NULL,
	[company_name] [varchar](100) NULL,
	[currency_id] [int] NOT NULL,
	[customer_city] [varchar](100) NULL,
	[customer_state] [varchar](100) NULL,
	[customer_pincode] [varchar](10) NULL,
	[customer_address] [varchar](400) NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NULL,
	[status] [varchar](1) NOT NULL,
 CONSTRAINT [PK_customer_master] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[item_master]    Script Date: 18-10-2024 5.53.58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item_master](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[item_type] [varchar](50) NULL,
	[item_name] [varchar](100) NULL,
	[item_unit] [varchar](100) NULL,
	[item_selling_price] [float] NULL,
	[item_account] [int] NOT NULL,
	[item_description] [varchar](max) NULL,
	[status] [varchar](1) NOT NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_item_master] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_data]    Script Date: 18-10-2024 5.53.58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_data](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](100) NULL,
	[user_email] [varchar](100) NULL,
	[user_phone] [varchar](100) NULL,
	[user_type] [int] NOT NULL,
	[user_id] [varchar](50) NULL,
	[password] [varchar](20) NULL,
	[active] [int] NOT NULL,
	[status] [varchar](1) NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_userData] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vendor_master]    Script Date: 18-10-2024 5.53.58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vendor_master](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[vendor_name] [varchar](100) NULL,
	[vendor_phone] [varchar](20) NULL,
	[vendor_email] [varchar](100) NULL,
	[vendor_currency_id] [int] NOT NULL,
	[vendor_city] [varchar](100) NULL,
	[vendor_state] [varchar](100) NULL,
	[vendor_pincode] [varchar](10) NULL,
	[vendor_address] [varchar](350) NULL,
	[status] [varchar](1) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_vendor_master] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[account_master] ADD  CONSTRAINT [DF_account_master_account_status]  DEFAULT ('A') FOR [status]
GO
ALTER TABLE [dbo].[account_master] ADD  CONSTRAINT [DF_account_master_created_at]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[company_master] ADD  CONSTRAINT [DF_company_master_company_id]  DEFAULT ((0)) FOR [company_id]
GO
ALTER TABLE [dbo].[company_master] ADD  CONSTRAINT [DF_company_master_currency_id]  DEFAULT ((0)) FOR [currency_id]
GO
ALTER TABLE [dbo].[company_master] ADD  CONSTRAINT [DF_company_master_status]  DEFAULT ('A') FOR [status]
GO
ALTER TABLE [dbo].[company_master] ADD  CONSTRAINT [DF_company_master_created_at]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[currency_master] ADD  CONSTRAINT [DF_currency_master_status]  DEFAULT ('A') FOR [status]
GO
ALTER TABLE [dbo].[currency_master] ADD  CONSTRAINT [DF_currency_master_created_at]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[customer_master] ADD  CONSTRAINT [DF_customer_master_customer_type]  DEFAULT ((0)) FOR [customer_type]
GO
ALTER TABLE [dbo].[customer_master] ADD  CONSTRAINT [DF_customer_master_currency]  DEFAULT ((0)) FOR [currency_id]
GO
ALTER TABLE [dbo].[customer_master] ADD  CONSTRAINT [DF_customer_master_created_at]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[customer_master] ADD  CONSTRAINT [DF_customer_master_status]  DEFAULT ('A') FOR [status]
GO
ALTER TABLE [dbo].[item_master] ADD  CONSTRAINT [DF_item_master_item_account]  DEFAULT ((0)) FOR [item_account]
GO
ALTER TABLE [dbo].[item_master] ADD  CONSTRAINT [DF_item_master_status]  DEFAULT ('A') FOR [status]
GO
ALTER TABLE [dbo].[item_master] ADD  CONSTRAINT [DF_item_master_created_at]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[item_master] ADD  CONSTRAINT [DF_item_master_updated_at]  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[user_data] ADD  CONSTRAINT [DF_userData_user_type]  DEFAULT ((0)) FOR [user_type]
GO
ALTER TABLE [dbo].[user_data] ADD  CONSTRAINT [DF_userData_active]  DEFAULT ((1)) FOR [active]
GO
ALTER TABLE [dbo].[user_data] ADD  CONSTRAINT [DF_userData_status]  DEFAULT ('A') FOR [status]
GO
ALTER TABLE [dbo].[user_data] ADD  CONSTRAINT [DF_userData_created_at]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[vendor_master] ADD  CONSTRAINT [DF_vendor_master_status]  DEFAULT ('A') FOR [status]
GO
ALTER TABLE [dbo].[vendor_master] ADD  CONSTRAINT [DF_vendor_master_created_at]  DEFAULT (getdate()) FOR [created_at]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A = Active, D = Inactive / Deleted' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'account_master', @level2type=N'COLUMN',@level2name=N'status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'General table''s company ID (starts from: 1001)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'company_master', @level2type=N'COLUMN',@level2name=N'company_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A = Active, D = Inactive / Deleted' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'currency_master', @level2type=N'COLUMN',@level2name=N'status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = Default Input, 1 = Business, 2 = Individual' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'customer_master', @level2type=N'COLUMN',@level2name=N'customer_type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'will store currency_master table''s id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'customer_master', @level2type=N'COLUMN',@level2name=N'currency_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A = Active, D = Deactive / Deleted' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'customer_master', @level2type=N'COLUMN',@level2name=N'status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'This is the master table for holding customer''s all details' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'customer_master'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A = Active, D = Deleted / Deactive' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'item_master', @level2type=N'COLUMN',@level2name=N'status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'7=admin, 6=staff' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user_data', @level2type=N'COLUMN',@level2name=N'user_type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A = Active, D = Deactive / Deleted' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'vendor_master', @level2type=N'COLUMN',@level2name=N'status'
GO
USE [master]
GO
ALTER DATABASE [billingFormData] SET  READ_WRITE 
GO
