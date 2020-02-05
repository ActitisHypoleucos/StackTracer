USE [TraceEvent]
GO

/****** Object:  Table [dbo].[T2_Profondita]    Script Date: 25/01/2020 12:30:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[T2_Profondita](
	[ID_Profondita_PK] [int] IDENTITY(1,1) NOT NULL,
	[Livello_Tracciamento] [varchar](20) NOT NULL,
 CONSTRAINT [PK_T2_Profondita] PRIMARY KEY CLUSTERED 
(
	[ID_Profondita_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

