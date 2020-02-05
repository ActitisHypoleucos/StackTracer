USE [TraceEvent]
GO

/****** Object:  Table [dbo].[T3_Eventi]    Script Date: 25/01/2020 12:30:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[T3_Eventi](
	[ID_Evento_PK] [int] IDENTITY(1,1) NOT NULL,
	[ID_Componente_FK] [int] NOT NULL,
	[ID_Profondita_FK] [int] NOT NULL,
	[Messaggio] [varchar](50) NOT NULL,
	[StackTrace] [varchar](max) NULL,
	[MetodoEvocatore] [varchar](50) NOT NULL,
	[DataEvento] [datetime] NOT NULL,
 CONSTRAINT [PK_T3_Eventi] PRIMARY KEY CLUSTERED 
(
	[ID_Evento_PK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[T3_Eventi] ADD  CONSTRAINT [DF_T3_Eventi_DataEvento]  DEFAULT (getdate()) FOR [DataEvento]
GO

ALTER TABLE [dbo].[T3_Eventi]  WITH CHECK ADD  CONSTRAINT [FK_T3_ID_COMPONENTE] FOREIGN KEY([ID_Componente_FK])
REFERENCES [dbo].[T1_Componenti] ([ID_Componente_PK])
GO

ALTER TABLE [dbo].[T3_Eventi] CHECK CONSTRAINT [FK_T3_ID_COMPONENTE]
GO

ALTER TABLE [dbo].[T3_Eventi]  WITH CHECK ADD  CONSTRAINT [FK_T3_ID_PROFONDITA] FOREIGN KEY([ID_Profondita_FK])
REFERENCES [dbo].[T2_Profondita] ([ID_Profondita_PK])
GO

ALTER TABLE [dbo].[T3_Eventi] CHECK CONSTRAINT [FK_T3_ID_PROFONDITA]
GO

