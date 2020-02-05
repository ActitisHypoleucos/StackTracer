USE [TraceEvent]
GO

/****** Object:  Table [dbo].[T4_ProfonditaTracciamentiComponenti]    Script Date: 25/01/2020 12:30:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[T4_ProfonditaTracciamentiComponenti](
	[ID_Componente_FK] [int] NOT NULL,
	[ID_Profondita_FK] [int] NOT NULL,
	[DataUltimaModifica] [datetime] NOT NULL,
 CONSTRAINT [PK_T4_ProfonditaTracciamentiComponenti] PRIMARY KEY CLUSTERED 
(
	[ID_Componente_FK] ASC,
	[ID_Profondita_FK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[T4_ProfonditaTracciamentiComponenti] ADD  CONSTRAINT [DF_T4_ProfonditaTracciamentiComponenti_DataUltimaModifica]  DEFAULT (getdate()) FOR [DataUltimaModifica]
GO

ALTER TABLE [dbo].[T4_ProfonditaTracciamentiComponenti]  WITH CHECK ADD  CONSTRAINT [FK_T4_ID_COMPONENTE] FOREIGN KEY([ID_Componente_FK])
REFERENCES [dbo].[T1_Componenti] ([ID_Componente_PK])
GO

ALTER TABLE [dbo].[T4_ProfonditaTracciamentiComponenti] CHECK CONSTRAINT [FK_T4_ID_COMPONENTE]
GO

ALTER TABLE [dbo].[T4_ProfonditaTracciamentiComponenti]  WITH CHECK ADD  CONSTRAINT [FK_T4_ID_PROFONDITA] FOREIGN KEY([ID_Profondita_FK])
REFERENCES [dbo].[T2_Profondita] ([ID_Profondita_PK])
GO

ALTER TABLE [dbo].[T4_ProfonditaTracciamentiComponenti] CHECK CONSTRAINT [FK_T4_ID_PROFONDITA]
GO

