using MyLog.ApplicationLogic.DTOs;
using MyLog.DomainLogic.DomainLogics.TracciamentiLogic;
using MyLog.DomainLogic.DomainLogics.TracciamentiLogic.Interface;

namespace MyLog.ApplicationLogic.Extension
{
    public static class TracciamentoExtension
    {
        public static bool CheckTracciamentoExists(this TracciamentoDTO tracciamentoOggetto, string connectString)
        {
            ITracciamentiQuery tracciamentoQuery = new TracciamentiQuery();
            var tracciamento = tracciamentoQuery.GetTracciamentoByComponentAndDepth(tracciamentoOggetto.id_Componente_FK, tracciamentoOggetto.id_Profondita_FK, connectString);
            return tracciamento != null ? true : false; //Operatore ternario 
        }
    }
}

//COMPLETED