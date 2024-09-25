USE [billingFormData]
GO
/****** Object:  Table [dbo].[item_master]    Script Date: 25-09-2024 5.58.03 PM ******/
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
	[item_account] [varchar](100) NULL,
	[item_description] [varchar](max) NULL,
 CONSTRAINT [PK_item_master] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
