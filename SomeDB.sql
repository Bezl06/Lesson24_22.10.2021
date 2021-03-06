USE [SomeDataBase]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 22.10.2021 21:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Balance] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([Id], [Name], [Balance]) VALUES (4, N'Komil', CAST(400.00 AS Decimal(18, 2)))
INSERT [dbo].[Clients] ([Id], [Name], [Balance]) VALUES (5, N'Umed', CAST(700.00 AS Decimal(18, 2)))
INSERT [dbo].[Clients] ([Id], [Name], [Balance]) VALUES (6, N'Komron', CAST(350.00 AS Decimal(18, 2)))
INSERT [dbo].[Clients] ([Id], [Name], [Balance]) VALUES (7, N'Murod', CAST(350.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
