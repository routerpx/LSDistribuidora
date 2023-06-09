USE [LS]
GO
/****** Object:  Table [dbo].[Produtos]    Script Date: 28/05/2023 01:59:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produtos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NULL,
	[Categoria] [varchar](100) NULL,
	[Quantidade] [int] NULL,
	[Valor] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 28/05/2023 01:59:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](100) NULL,
	[Senha] [varchar](100) NULL,
	[Nome] [varchar](100) NULL,
	[Nivel] [int] NOT NULL,
	[Ativo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Produtos] ON 

INSERT [dbo].[Produtos] ([ID], [Nome], [Categoria], [Quantidade], [Valor]) VALUES (1, N'Pessego', N'Fruta', 2, 8)
INSERT [dbo].[Produtos] ([ID], [Nome], [Categoria], [Quantidade], [Valor]) VALUES (2, N'Própolis', N'Remedio', 3, 70)
INSERT [dbo].[Produtos] ([ID], [Nome], [Categoria], [Quantidade], [Valor]) VALUES (4, N'Mel', N'Abelha', 10, 1000)
SET IDENTITY_INSERT [dbo].[Produtos] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([ID], [Login], [Senha], [Nome], [Nivel], [Ativo]) VALUES (1, N'router', N'12345', N'Joao Pedro', 1, 1)
INSERT [dbo].[Usuarios] ([ID], [Login], [Senha], [Nome], [Nivel], [Ativo]) VALUES (2, N'jone', N'12345', N'Jone', 1, 1)
INSERT [dbo].[Usuarios] ([ID], [Login], [Senha], [Nome], [Nivel], [Ativo]) VALUES (3, N'zico', N'12345', N'Leo', 1, 1)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT ((1)) FOR [Nivel]
GO
ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT ((1)) FOR [Ativo]
GO
