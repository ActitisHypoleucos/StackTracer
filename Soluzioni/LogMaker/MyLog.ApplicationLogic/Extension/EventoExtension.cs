using MyLog.ApplicationLogic.DTOs;
using MyLog.DomainLogic.DomainLogics.EventiLogic;
using MyLog.DomainLogic.DomainLogics.EventiLogic.Interface;

namespace MyLog.ApplicationLogic.Extension
{
    public static class EventoExtension
    {
        //l'estensione è un metodo che può essere chiamato da qualsiasi oggetto di tipo EventoDTO
        public static bool checkEventoExists(this EventoDTO eventoOggetto, string connectString)
        {
            IEventiQuery eventoQuery = new EventiQuery();
            var evento = eventoQuery.GetEventoByCaller(eventoOggetto.MetodoEvocatore, connectString);
            return evento != null ? true : false; //Operatore ternario 
        }
    }
}

//COMPLETED