/****** Object:  Table [dbo].[SiteUsers]    Script Date: 5/1/2014 1:39:03 PM ******/
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

