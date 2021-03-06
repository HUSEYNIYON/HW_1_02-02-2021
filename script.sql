USE [DushanbeStores]
GO
/****** Object:  Table [dbo].[Stores]    Script Date: 03.02.2021 18:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stores](
	[stores_id] [int] IDENTITY(1,1) NOT NULL,
	[stores_name] [nvarchar](60) NOT NULL,
	[stores_address] [nvarchar](60) NOT NULL,
	[stores_city] [nvarchar](50) NOT NULL,
	[stores_tel] [nvarchar](13) NOT NULL,
	[stores_email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Stores] PRIMARY KEY CLUSTERED 
(
	[stores_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
