namespace MyLog.DomainLogic.Enums
{
    public struct Query
    {
        //CMD COMPONENTI
        public const string insertComponente = @"INSERT INTO [TraceEvent].[dbo].[T1_Componenti] (NomeApplicazione, Descrizione, DataInserimento) VALUES ('{0}','{1}',{2})";
        public const string updateComponente = @"UPDATE [TraceEvent].[dbo].[T1_Componenti] SET NomeApplicazione = ('{0}'), Descrizione = ('{1}'), DataInserimento = ({2}) WHERE ID_Componente_PK = ({3})";

        //QUERY COMPONENTI
        public const string GetComponenteById = @"SELECT * FROM [TraceEvent].[dbo].[T1_Componenti] WHERE ID_Componente_PK = {0}";
        public const string GetComponenteByAppName = @"SELECT * FROM [TraceEvent].[dbo].[T1_Componenti] WHERE NomeApplicazione = '{0}'";

        //CMD PROFONDITA
        public const string insertProfondita = @"INSERT INTO [TraceEvent].[dbo].[T2_Profondita] (Livello_Tracciamento) VALUES ('{0}')";
        public const string updateProfondita = @"UPDATE [TraceEvent].[dbo].[T2_Profondita] SET Livello_Tracciamento = ('{0}') WHERE ID_Profondita_PK = ({1})";

        //QUERY PROFONDITA
        public const string GetProfonditaById = @"SELECT * FROM [TraceEvent].[dbo].[T2_Profondita] WHERE ID_Profondita_PK = ({0})";
        public const string GetProfonditaByLivello = @"SELECT * FROM [TraceEvent].[dbo].[T2_Profondita] WHERE Livello_Tracciamento = ('{0}')";

        //CMD EVENTI
        public const string insertEvento = @"INSERT INTO [TraceEvent].[dbo].[T3_Eventi] (ID_Componente_FK, ID_Profondita_FK, Messaggio, StackTrace, MetodoEvocatore) VALUES ({0},{1},'{2}','{3}','{4}')";
        public const string updateEvento = @"UPDATE [TraceEvent].[dbo].[T3_Eventi] SET ID_Componente_FK = ({0}), ID_Profondita_FK = ({1}), DataEvento = ({2}), Messaggio = ('{3}'), StackTrace = ('{4}'), MetodoEvocatore = ('{5}') WHERE ID_Evento_PK = ({6})";

        //QUERY EVENTI
        public const string GetEventoById = @"SELECT * FROM [TraceEvent].[dbo].[T3_Eventi] WHERE ID_Evento_PK = ({0})";
        public const string GetEventoByCaller = @"SELECT * FROM [TraceEvent].[dbo].[T3_Eventi] WHERE MetodoEvocatore = ('{0}')";
        public const string GetEventoByDateEvent = @"SELECT * FROM [TraceEvent].[dbo].[T3_Eventi] WHERE DataEvento = ({0})";

        //CMD TRACCIAMENTI
        public const string insertTracciamenti = @"INSERT INTO [TraceEvent].[dbo].[T4_ProfonditaTracciamentiComponenti] (ID_Componente_FK,ID_Profondita_FK,DataUltimaModifica) VALUES ({0},{1},{2})";
        //public const string updateTracciamenti = @"UPDATE T4_ProfonditaTracciamentiComponenti SET ID_Componente_FK = ({0}), ID_Profondita_FK = ({1}), DataUltimaModifica = ({1}) WHERE ID_Componente_FK = ({3}) AND ID_Profondita_FK = ({4})";

        //QUERY TRACCIAMENTI
        public const string GetTracciamentoByComponent = @"SELECT * FROM [TraceEvent].[dbo].[T4_ProfonditaTracciamentiComponenti] WHERE ID_Componente_FK = ({0})";
        public const string GetTracciamentoByDepth = @"SELECT * FROM [TraceEvent].[dbo].[T4_ProfonditaTracciamentiComponenti] WHERE ID_Profondita_FK = ({0})";
        public const string GetTracciamentoByDate = @"SELECT * FROM [TraceEvent].[dbo].[T4_ProfonditaTracciamentiComponenti] WHERE DataUltimaModifica = ({0})";
        public const string GetTracciamentoByComponentAndDepth = @"SELECT * FROM [TraceEvent].[dbo].[T4_ProfonditaTracciamentiComponenti] WHERE ID_Profondita_FK = ({0}) AND ID_Componente_FK = ({1})";
    }
}

//COMPLETED
