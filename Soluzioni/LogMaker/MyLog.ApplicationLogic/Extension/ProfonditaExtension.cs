
using MyLog.ApplicationLogic.DTOs;
using MyLog.DomainLogic.DomainLogics.ProfonditaLogic;
using MyLog.DomainLogic.DomainLogics.ProfonditaLogic.Interface;

namespace MyLog.ApplicationLogic.Extension
{
    public static class ProfonditaExtension
    {
        public static bool checkProfonditaExists(this ProfonditaDTO profonditaOggetto, string connectString)
        {
            IProfonditaQuery profonditaQuery = new ProfonditaQuery();
            var profondita = profonditaQuery.GetProfonditaByLevel(profonditaOggetto.Livello_Tracciamento, connectString);
            return profondita != null ? true : false; //Operatore ternario
        }
    }
}

//COMPLETED
