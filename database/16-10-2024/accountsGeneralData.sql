USE [master]
GO
/****** Object:  Database [accountsGeneralData]    Script Date: 16-10-2024 5.57.25 PM ******/
CREATE DATABASE [accountsGeneralData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'accountsGeneralData', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\accountsGeneralData.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'accountsGeneralData_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\accountsGeneralData_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [accountsGeneralData] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [accountsGeneralData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [accountsGeneralData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [accountsGeneralData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [accountsGeneralData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [accountsGeneralData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [accountsGeneralData] SET ARITHABORT OFF 
GO
ALTER DATABASE [accountsGeneralData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [accountsGeneralData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [accountsGeneralData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [accountsGeneralData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [accountsGeneralData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [accountsGeneralData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [accountsGeneralData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [accountsGeneralData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [accountsGeneralData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [accountsGeneralData] SET  DISABLE_BROKER 
GO
ALTER DATABASE [accountsGeneralData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [accountsGeneralData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [accountsGeneralData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [accountsGeneralData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [accountsGeneralData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [accountsGeneralData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [accountsGeneralData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [accountsGeneralData] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [accountsGeneralData] SET  MULTI_USER 
GO
ALTER DATABASE [accountsGeneralData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [accountsGeneralData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [accountsGeneralData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [accountsGeneralData] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [accountsGeneralData] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [accountsGeneralData] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [accountsGeneralData] SET QUERY_STORE = ON
GO
ALTER DATABASE [accountsGeneralData] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [accountsGeneralData]
GO
/****** Object:  Table [dbo].[client_data]    Script Date: 16-10-2024 5.57.25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client_data](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NULL,
	[email] [varchar](100) NULL,
	[phone] [varchar](20) NULL,
	[full_address] [varchar](350) NULL,
	[registration_date] [datetime] NOT NULL,
 CONSTRAINT [PK_client_data] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[company_data]    Script Date: 16-10-2024 5.57.25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[company_data](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[company_id] [int] NOT NULL,
	[company_name] [varchar](150) NULL,
	[full_database_name] [varchar](150) NULL,
	[active] [int] NOT NULL,
	[status] [varchar](1) NOT NULL,
	[creation_date] [datetime] NOT NULL,
	[removal_date] [datetime] NULL,
 CONSTRAINT [PK_company_data] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_data]    Script Date: 16-10-2024 5.57.25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_data](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[company_id] [int] NOT NULL,
	[user_type] [int] NOT NULL,
	[full_database_name] [varchar](150) NULL,
	[login_user_id] [varchar](50) NULL,
	[login_password] [varchar](50) NULL,
	[active] [int] NOT NULL,
	[status] [varchar](1) NOT NULL,
	[creation_date] [datetime] NOT NULL,
	[is_logged_in] [int] NOT NULL,
	[last_logged_in] [datetime] NULL,
	[last_logged_out] [datetime] NULL,
 CONSTRAINT [PK_user_data] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[client_data] ADD  CONSTRAINT [DF_client_data_registration_date]  DEFAULT (getdate()) FOR [registration_date]
GO
ALTER TABLE [dbo].[company_data] ADD  CONSTRAINT [DF_company_data_active]  DEFAULT ((1)) FOR [active]
GO
ALTER TABLE [dbo].[company_data] ADD  CONSTRAINT [DF_company_data_status]  DEFAULT ('A') FOR [status]
GO
ALTER TABLE [dbo].[company_data] ADD  CONSTRAINT [DF_company_data_creation_date]  DEFAULT (getdate()) FOR [creation_date]
GO
ALTER TABLE [dbo].[user_data] ADD  CONSTRAINT [DF_user_data_active]  DEFAULT ((1)) FOR [active]
GO
ALTER TABLE [dbo].[user_data] ADD  CONSTRAINT [DF_user_data_status]  DEFAULT ('A') FOR [status]
GO
ALTER TABLE [dbo].[user_data] ADD  CONSTRAINT [DF_user_data_creation_date]  DEFAULT (getdate()) FOR [creation_date]
GO
ALTER TABLE [dbo].[user_data] ADD  CONSTRAINT [DF_user_data_is_logged_in]  DEFAULT ((0)) FOR [is_logged_in]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'starts from: 1001, should be maintained in the respective databases also' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'company_data', @level2type=N'COLUMN',@level2name=N'company_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1 = Active, 0 = Inactive' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'company_data', @level2type=N'COLUMN',@level2name=N'active'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'A = Active, D = Deactive / Deleted' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'company_data', @level2type=N'COLUMN',@level2name=N'status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'user table id of the respective company database' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user_data', @level2type=N'COLUMN',@level2name=N'user_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Company ID from general database' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user_data', @level2type=N'COLUMN',@level2name=N'company_id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'7 = Admin, 6 = Staff' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user_data', @level2type=N'COLUMN',@level2name=N'user_type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1 = Active, 0 = Inactive' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user_data', @level2type=N'COLUMN',@level2name=N'active'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 = Not Logged In, 1 = Currently Logged In' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'user_data', @level2type=N'COLUMN',@level2name=N'is_logged_in'
GO
USE [master]
GO
ALTER DATABASE [accountsGeneralData] SET  READ_WRITE 
GO
