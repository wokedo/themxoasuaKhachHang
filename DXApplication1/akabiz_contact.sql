USE [akabiz_contact]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 7/3/2021 1:30:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[Pass] [nvarchar](50) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Campaign]    Script Date: 7/3/2021 1:30:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campaign](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[Describe] [nvarchar](1000) NULL,
	[CampaignType] [tinyint] NULL,
	[SendingFirstId] [int] NULL,
	[AccountId] [int] NULL,
	[DateModify] [datetime] NULL,
	[StaffCreateId] [int] NULL,
	[StaffModifyId] [int] NULL,
	[DateCreate] [datetime] NULL,
	[IsActive] [bit] NULL,
	[IsSystem] [bit] NULL,
	[CountSended] [int] NULL,
	[CountRecieved] [int] NULL,
	[CountOpened] [int] NULL,
	[CountClicked] [int] NULL,
	[ShopId] [int] NULL,
	[IsActiveShopee] [bit] NULL,
	[MessageZalo] [nvarchar](2000) NULL,
	[IsActiveZalo] [bit] NULL,
	[MessageSms] [nvarchar](2000) NULL,
	[IsActiveSms] [bit] NULL,
	[ShopIdZalo] [int] NULL,
	[InviteZalo] [bit] NULL,
	[ShopIdSms] [int] NULL,
	[ShopIdFacebook] [int] NULL,
	[InviteFacebook] [bit] NULL,
	[MessageFacebook] [nvarchar](2000) NULL,
	[IsActiveFacebook] [bit] NULL,
	[LinkMedia] [nvarchar](500) NULL,
	[DeleyTime] [int] NULL,
	[DeleyType] [nvarchar](50) NULL,
	[TagIdContain] [int] NULL,
	[TagIdNotContain] [int] NULL,
	[PipelineId] [smallint] NULL,
 CONSTRAINT [PK_Campaign] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CampaignType]    Script Date: 7/3/2021 1:30:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CampaignType](
	[Id] [smallint] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_CampaignType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contact]    Script Date: 7/3/2021 1:30:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Uid] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[AccountId] [int] NULL,
	[PipelineId] [smallint] NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Pipeline]    Script Date: 7/3/2021 1:30:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pipeline](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[IndexStage] [tinyint] NULL,
	[ColorStage] [nvarchar](50) NULL,
	[IsStageClose] [bit] NULL,
	[AccountId] [int] NULL,
	[StatusId] [tinyint] NULL,
 CONSTRAINT [PK_Pipeline] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Shop]    Script Date: 7/3/2021 1:30:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shop](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ShopName] [nvarchar](50) NULL,
	[ShopType] [nvarchar](50) NULL,
	[AccountId] [int] NULL,
	[AppId] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Shop] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tag]    Script Date: 7/3/2021 1:30:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tag](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[AccountId] [int] NULL,
 CONSTRAINT [PK_Tag] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TagTable]    Script Date: 7/3/2021 1:30:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TagTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TagId] [int] NULL,
	[ContactId] [int] NULL,
 CONSTRAINT [PK_TagTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([Id], [Name], [Username], [Pass]) VALUES (1, N'Cuong', N'test01', N'1')
INSERT [dbo].[Account] ([Id], [Name], [Username], [Pass]) VALUES (2, N'Hien', N'Hienm4', N'123456')
SET IDENTITY_INSERT [dbo].[Account] OFF
SET IDENTITY_INSERT [dbo].[Campaign] ON 

INSERT [dbo].[Campaign] ([Id], [Name], [Describe], [CampaignType], [SendingFirstId], [AccountId], [DateModify], [StaffCreateId], [StaffModifyId], [DateCreate], [IsActive], [IsSystem], [CountSended], [CountRecieved], [CountOpened], [CountClicked], [ShopId], [IsActiveShopee], [MessageZalo], [IsActiveZalo], [MessageSms], [IsActiveSms], [ShopIdZalo], [InviteZalo], [ShopIdSms], [ShopIdFacebook], [InviteFacebook], [MessageFacebook], [IsActiveFacebook], [LinkMedia], [DeleyTime], [DeleyType], [TagIdContain], [TagIdNotContain], [PipelineId]) VALUES (5, N'obama', NULL, 3, NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 5, 0, N'sento to zalo2', 1, N'sent to Sms', 1, 10, 1, 13, 7, 1, N'sent to facebook', 1, N'C:\Users\aa\Desktop\download.jpg', 2, N'Giờ', NULL, NULL, NULL)
INSERT [dbo].[Campaign] ([Id], [Name], [Describe], [CampaignType], [SendingFirstId], [AccountId], [DateModify], [StaffCreateId], [StaffModifyId], [DateCreate], [IsActive], [IsSystem], [CountSended], [CountRecieved], [CountOpened], [CountClicked], [ShopId], [IsActiveShopee], [MessageZalo], [IsActiveZalo], [MessageSms], [IsActiveSms], [ShopIdZalo], [InviteZalo], [ShopIdSms], [ShopIdFacebook], [InviteFacebook], [MessageFacebook], [IsActiveFacebook], [LinkMedia], [DeleyTime], [DeleyType], [TagIdContain], [TagIdNotContain], [PipelineId]) VALUES (6, N'test', NULL, 92, NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL, NULL, NULL, NULL, 9, 1, N'', 1, N'', 0, 11, 0, NULL, NULL, 0, N'', 0, N'', 10, N'Phút', NULL, NULL, NULL)
INSERT [dbo].[Campaign] ([Id], [Name], [Describe], [CampaignType], [SendingFirstId], [AccountId], [DateModify], [StaffCreateId], [StaffModifyId], [DateCreate], [IsActive], [IsSystem], [CountSended], [CountRecieved], [CountOpened], [CountClicked], [ShopId], [IsActiveShopee], [MessageZalo], [IsActiveZalo], [MessageSms], [IsActiveSms], [ShopIdZalo], [InviteZalo], [ShopIdSms], [ShopIdFacebook], [InviteFacebook], [MessageFacebook], [IsActiveFacebook], [LinkMedia], [DeleyTime], [DeleyType], [TagIdContain], [TagIdNotContain], [PipelineId]) VALUES (10, N'Test Add', NULL, 8, NULL, NULL, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 0, 0, N'', 0, N'', 0, NULL, 0, NULL, NULL, 0, N'', 0, N'', 100, N'Phút', 2, NULL, NULL)
INSERT [dbo].[Campaign] ([Id], [Name], [Describe], [CampaignType], [SendingFirstId], [AccountId], [DateModify], [StaffCreateId], [StaffModifyId], [DateCreate], [IsActive], [IsSystem], [CountSended], [CountRecieved], [CountOpened], [CountClicked], [ShopId], [IsActiveShopee], [MessageZalo], [IsActiveZalo], [MessageSms], [IsActiveSms], [ShopIdZalo], [InviteZalo], [ShopIdSms], [ShopIdFacebook], [InviteFacebook], [MessageFacebook], [IsActiveFacebook], [LinkMedia], [DeleyTime], [DeleyType], [TagIdContain], [TagIdNotContain], [PipelineId]) VALUES (14, N'df', NULL, 3, NULL, 2, NULL, NULL, NULL, NULL, 0, NULL, NULL, NULL, NULL, NULL, 5, 0, N'', 1, N'', 1, 10, 0, NULL, 6, 0, N'', 1, N'', 2, N'Giờ', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Campaign] OFF
INSERT [dbo].[CampaignType] ([Id], [Name]) VALUES (1, N'Khách hàng mới')
INSERT [dbo].[CampaignType] ([Id], [Name]) VALUES (3, N'Tạo mới khách hàng')
INSERT [dbo].[CampaignType] ([Id], [Name]) VALUES (4, N'Tạo mới đơn hàng')
INSERT [dbo].[CampaignType] ([Id], [Name]) VALUES (8, N'Thay đổi trạng thái bán hàng')
INSERT [dbo].[CampaignType] ([Id], [Name]) VALUES (51, N'Giao hàng cho đơn vị vận chuyển')
INSERT [dbo].[CampaignType] ([Id], [Name]) VALUES (52, N'Giao hàng thành công')
INSERT [dbo].[CampaignType] ([Id], [Name]) VALUES (53, N'Khách trả lại hàng')
INSERT [dbo].[CampaignType] ([Id], [Name]) VALUES (91, N'Khi khách hàng feedback 1*')
INSERT [dbo].[CampaignType] ([Id], [Name]) VALUES (92, N'Khi khách hàng feedback 2*')
INSERT [dbo].[CampaignType] ([Id], [Name]) VALUES (93, N'Khi khách hàng feedback 3*')
INSERT [dbo].[CampaignType] ([Id], [Name]) VALUES (94, N'Khi khách hàng feedback 4*')
INSERT [dbo].[CampaignType] ([Id], [Name]) VALUES (95, N'Khi khách hàng feedback 5*')
SET IDENTITY_INSERT [dbo].[Contact] ON 

INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (1, N'Nguyễn Huy', N'4343434', N'09434322', N'huy@gmail.com', 1, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (3, N'Cuong', N'23232', N'0215711442', N'cuong@gmail.com', 1, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (7, N'Nguyễn Văn Khải', N'80376650-94B6-41BC-A670-3B73A90B442B', N'0912129090', N'vankhai@gmail.com', 2, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (8, N'Trương Ngọc Minh', N'A7EDBDC5-CB8F-4CF5-9236-EC110B0EAF2E', N'0912129091', N'ngocminh@gmail.com', 2, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (11, N'Nguyen van c', N'231131', N'090909090', N'vanc@gmail.com', 2, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (12, N'nguyen Van d', N'13131313', N'09090909', N'Vand@gmail.com', 2, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (13, N'e', N'90909', N'90090909', N'err@gmail.com', 2, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (14, N'qqq', N'9090', N'090900', N'qqq@fhaa.com', 2, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (15, N'aaa', N'311313', N'909090909', N'aaa@gmail.com', 2, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (16, N'ww', N'ww', N'www', N'ww', 2, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (17, N'eee', N'122', N'090909', N'eee@hhf.com', 2, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (19, N'Nguyễn Văn Minh', N'80376650-94B6-41BC-A670-3B73A90B442B', N'0912129090', N'vankhai@gmail.com', 2, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (20, N'Trương Ngọc Minh', N'A7EDBDC5-CB8F-4CF5-9236-EC110B0EAF2E', N'0912129091', N'ngocminh@gmail.com', 2, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (23, N'Nguyễn Văn Khánh', N'80376650-94B6-41BC-A670-3B73A90B442B', N'0912129992', N'vankhanh@gmail.com', 2, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (24, N'Trương Ngọc Đại', N'A7EDBDC5-CB8F-4CF5-9236-EC110B0EAF2E', N'0912129234', N'ngocdai@gmail.com', 2, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (33, N'Kroosm4', N'90909019', N'0909090909', N'dk@gmail.com', 2, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (34, N'Phan Van Tai Em', N'9090909', N'0808080808', N'pvt@gmail.com', 2, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (35, N'Trương tấn Sang', N'90909', N'0909090901', N'pvt@gmail.com', 2, NULL)
INSERT [dbo].[Contact] ([Id], [Name], [Uid], [Phone], [Email], [AccountId], [PipelineId]) VALUES (36, N'Ronaldo', N'90909', N'0992989786', N'pvt@gmail.com', 2, NULL)
SET IDENTITY_INSERT [dbo].[Contact] OFF
SET IDENTITY_INSERT [dbo].[Pipeline] ON 

INSERT [dbo].[Pipeline] ([Id], [Name], [IndexStage], [ColorStage], [IsStageClose], [AccountId], [StatusId]) VALUES (3, N'cam', 4, N'Cam', 0, 2, 1)
INSERT [dbo].[Pipeline] ([Id], [Name], [IndexStage], [ColorStage], [IsStageClose], [AccountId], [StatusId]) VALUES (7, N'aaf', 3, N'aa', 1, 2, 2)
SET IDENTITY_INSERT [dbo].[Pipeline] OFF
SET IDENTITY_INSERT [dbo].[Shop] ON 

INSERT [dbo].[Shop] ([Id], [ShopName], [ShopType], [AccountId], [AppId], [IsActive]) VALUES (4, N'1', N'dellvn', 1, N'2', 1)
INSERT [dbo].[Shop] ([Id], [ShopName], [ShopType], [AccountId], [AppId], [IsActive]) VALUES (5, N'kroosm4', N'Shopee', 2, N'288863424', 1)
INSERT [dbo].[Shop] ([Id], [ShopName], [ShopType], [AccountId], [AppId], [IsActive]) VALUES (6, N'akaa123', N'Facebook', 2, N'288863424', 1)
INSERT [dbo].[Shop] ([Id], [ShopName], [ShopType], [AccountId], [AppId], [IsActive]) VALUES (7, N'facebook1', N'Facebook', 2, N'288863424', 1)
INSERT [dbo].[Shop] ([Id], [ShopName], [ShopType], [AccountId], [AppId], [IsActive]) VALUES (8, N'facebook2', N'Facebook', 2, N'288863424', 1)
INSERT [dbo].[Shop] ([Id], [ShopName], [ShopType], [AccountId], [AppId], [IsActive]) VALUES (9, N'Shopee1', N'Shopee', 2, N'2', 1)
INSERT [dbo].[Shop] ([Id], [ShopName], [ShopType], [AccountId], [AppId], [IsActive]) VALUES (10, N'Zalo1', N'Zalo', 2, N'288863424', 1)
INSERT [dbo].[Shop] ([Id], [ShopName], [ShopType], [AccountId], [AppId], [IsActive]) VALUES (11, N'Zalo2', N'Zalo', 2, N'288863424', 1)
INSERT [dbo].[Shop] ([Id], [ShopName], [ShopType], [AccountId], [AppId], [IsActive]) VALUES (12, N'Sms1', N'Sms', 2, N'288863424', 1)
INSERT [dbo].[Shop] ([Id], [ShopName], [ShopType], [AccountId], [AppId], [IsActive]) VALUES (13, N'Sms2', N'Sms', 2, N'288863424', 1)
SET IDENTITY_INSERT [dbo].[Shop] OFF
SET IDENTITY_INSERT [dbo].[Tag] ON 

INSERT [dbo].[Tag] ([Id], [Name], [AccountId]) VALUES (1, N'Xanh', 1)
INSERT [dbo].[Tag] ([Id], [Name], [AccountId]) VALUES (2, N'Đỏ', 1)
INSERT [dbo].[Tag] ([Id], [Name], [AccountId]) VALUES (3, N'Tím', 1)
INSERT [dbo].[Tag] ([Id], [Name], [AccountId]) VALUES (4, N'Cam', 1)
INSERT [dbo].[Tag] ([Id], [Name], [AccountId]) VALUES (5, N'Vàng', NULL)
INSERT [dbo].[Tag] ([Id], [Name], [AccountId]) VALUES (13, N'Lam', 2)
INSERT [dbo].[Tag] ([Id], [Name], [AccountId]) VALUES (16, N'Chàm', 2)
INSERT [dbo].[Tag] ([Id], [Name], [AccountId]) VALUES (17, N'Nâu', 2)
INSERT [dbo].[Tag] ([Id], [Name], [AccountId]) VALUES (18, N'Xann lá', 2)
SET IDENTITY_INSERT [dbo].[Tag] OFF
SET IDENTITY_INSERT [dbo].[TagTable] ON 

INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (14, 1, 3)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (15, 2, 3)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (20, 1, 7)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (21, 2, 7)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (22, 1, 8)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (23, 2, 8)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (42, 2, 19)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (43, 3, 19)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (44, 4, 19)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (45, 2, 20)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (46, 3, 20)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (47, 4, 20)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (60, 2, 23)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (61, 4, 23)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (62, 5, 23)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (63, 2, 24)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (64, 4, 24)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (65, 5, 24)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (128, 1, 33)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (129, 2, 33)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (130, 3, 33)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (131, 4, 33)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (132, 5, 33)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (133, 13, 33)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (134, 16, 33)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (135, 17, 33)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (136, 18, 33)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (137, 1, 35)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (138, 2, 35)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (139, 3, 35)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (140, 4, 35)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (141, 5, 35)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (142, 13, 35)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (143, 16, 35)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (144, 17, 35)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (145, 18, 35)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (146, 1, 36)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (147, 2, 36)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (148, 3, 36)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (149, 4, 36)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (150, 5, 36)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (151, 13, 36)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (152, 16, 36)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (153, 17, 36)
INSERT [dbo].[TagTable] ([Id], [TagId], [ContactId]) VALUES (154, 18, 36)
SET IDENTITY_INSERT [dbo].[TagTable] OFF
ALTER TABLE [dbo].[Contact]  WITH CHECK ADD  CONSTRAINT [FK_Contact_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([Id])
GO
ALTER TABLE [dbo].[Contact] CHECK CONSTRAINT [FK_Contact_Account]
GO
ALTER TABLE [dbo].[Tag]  WITH CHECK ADD  CONSTRAINT [FK_Tag_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([Id])
GO
ALTER TABLE [dbo].[Tag] CHECK CONSTRAINT [FK_Tag_Account]
GO
ALTER TABLE [dbo].[TagTable]  WITH CHECK ADD  CONSTRAINT [FK_TagTable_Contact] FOREIGN KEY([ContactId])
REFERENCES [dbo].[Contact] ([Id])
GO
ALTER TABLE [dbo].[TagTable] CHECK CONSTRAINT [FK_TagTable_Contact]
GO
ALTER TABLE [dbo].[TagTable]  WITH CHECK ADD  CONSTRAINT [FK_TagTable_Tag] FOREIGN KEY([TagId])
REFERENCES [dbo].[Tag] ([Id])
GO
ALTER TABLE [dbo].[TagTable] CHECK CONSTRAINT [FK_TagTable_Tag]
GO
