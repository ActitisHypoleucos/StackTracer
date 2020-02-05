USE [TraceEvent]
GO

/****** Object:  Table [dbo].[T1_Componenti]    Script Date: 25/01/2020 12:29:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[T1_Componenti](
	[ID_Componente_PK] [int] IDENTITY(1,1) NOT NULL,
	[NomeApplicazione] [varchar](50) NOT NULL,
	[Descrizione] [varchar](50) NOT NULL,
	[DataInserimento] [datetime] NOT NULL,
 CONSTRAINT [PK_T1_Componenti] PRIMARY KEY CLUSTERED 
(
	[ID_Componente_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[T1_Componenti] ADD  CONSTRAINT [DF_T1_Componenti_DataInserimento]  DEFAULT (getdate()) FOR [DataInserimento]
GO

