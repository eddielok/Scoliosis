

ALTER TABLE  Visits
ADD QoL  float  DEFAULT NULL;

ALTER TABLE  VisitsLog
ADD QoL  float  DEFAULT NULL;

USE [Scoliosis]
GO

/****** Object:  Table [dbo].[POVisit]    Script Date: 3/9/2020 11:25:27 am ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Physio](
	[SCN] [char](8) NOT NULL,
	[DOC] [date] NOT NULL,
	[SRS22] [int] NULL,
	[SRS22Domains] [int] NULL,
	[SAQ] [int] NULL,
	[SAQDomains] [int] NULL,
	[ExerciseCompliance] [decimal](16, 2) NULL,
	[BrQ] [decimal](16, 2) NULL,
	[Remarks] [nvarchar](500) NULL,
	[LastModify] [datetime] NULL,
	[LastModifyUser] [nvarchar](100) NULL
) ON [PRIMARY]
GO




