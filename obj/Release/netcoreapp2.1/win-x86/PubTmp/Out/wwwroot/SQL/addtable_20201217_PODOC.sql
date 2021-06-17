USE [Scoliosis]
GO

/****** Object:  Table [dbo].[PODOC]    Script Date: 24/12/2020 11:59:40 pm ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PODOC](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[SCN] [char](8) NOT NULL,
	[DOC] [nvarchar](1000) NULL,
	[DOCRemark] [nvarchar](1000) NULL,
	[DOCDate] [datetime] NULL,
	[LastModify] [datetime] NULL,
	[LastModifyUser] [nvarchar](100) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PODOC] ADD  DEFAULT (NULL) FOR [DOC]
GO

ALTER TABLE [dbo].[PODOC] ADD  DEFAULT (NULL) FOR [DOCRemark]
GO

ALTER TABLE [dbo].[PODOC] ADD  DEFAULT (NULL) FOR [DOCDate]
GO


