/****** Object:  Table [dbo].[SiteUsers]    Script Date: 5/5/2014 1:40:40 PM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[SiteUsers](
	[UserId] [int] NOT NULL,
	[SiteId] [int] NOT NULL,
	[Added] [datetime] NOT NULL,
	[Roles] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
 CONSTRAINT [PK_SiteUsers] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[SiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Index [SiteUsers_Site]    Script Date: 5/5/2014 1:40:40 PM ******/
CREATE NONCLUSTERED INDEX [SiteUsers_Site] ON [dbo].[SiteUsers]
(
	[SiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
/****** Object:  Index [SiteUsers_User]    Script Date: 5/5/2014 1:40:40 PM ******/
CREATE NONCLUSTERED INDEX [SiteUsers_User] ON [dbo].[SiteUsers]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
