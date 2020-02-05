using System;
using MyLog.ApplicationLogic.DTOs;
using MyLog.ApplicationLogic.Exception;
using MyLog.ApplicationLogic.Extension;
using MyLog.ApplicationLogic.ServiceFolder.EventiService.Interface;

namespace MyLog.ApplicationLogic.ServiceFolder.EventiService
{
    public class EventiService : BaseService , IEventiService
    {
        //INSERT EVENTI
        public ResultDTO insert(EventoDTO evento)
        {
            ResultDTO risultato = new ResultDTO();
            //bool checkExists = evento.checkEventoExists(parametriDTO.connectString); // il metodo ritorna un valore booleano, vedi la cartella extension
            //if (!checkExists)
            //{
                if (Iunitofwork.eventiCMD.insert(new DomainLogic.Models.Eventi()
                {
                    id_Componente_FK = evento.id_Componente_FK,
                    id_Profondita_FK = evento.id_Profondita_FK,
                    Messaggio = evento.Messaggio,
                    MetodoEvocatore = evento.MetodoEvocatore,
                    StackTrace = evento.StackTrace,
                }, parametriDTO.connectString))
                {
                    risultato.descrizione = "L'inserimento è avvenuto con successo";
                    risultato.esito = Enum.EsitoEsecuzione.OK;
                }
                else
                {
                    risultato.descrizione = "L'inserimento non è andato a buon fine ";
                    risultato.esito = Enum.EsitoEsecuzione.KO;
                }
            /*}
            else
            {
                throw new EventoEsistenteException();
            }*/
            return risultato;
        }

        //UPDATE EVENTI
        public ResultDTO update(EventoDTO evento)
        {
            //todo
            ResultDTO risultato = new ResultDTO();
            bool checkExists = evento.checkEventoExists(parametriDTO.connectString);
            if (!checkExists)
            {
                if (Iunitofwork.eventiCMD.update(new DomainLogic.Models.Eventi()
                {
                    Messaggio = evento.Messaggio,
                    MetodoEvocatore = evento.MetodoEvocatore,
                    StackTrace = evento.StackTrace,
                }, parametriDTO.connectString)) //<parametri if>\\
                //corpo if
                {
                    risultato.descrizione = "L'aggiornamento è avvenuto con successo";
                    risultato.esito = Enum.EsitoEsecuzione.OK;
                }
                else
                {
                    risultato.descrizione = "L'aggiornamento non è andato a buon fine ";
                    risultato.esito = Enum.EsitoEsecuzione.KO;
                }
            }
            else
            {
                throw new ComponenteEsistenteException();
            }
            return risultato;
        }

        //GET EVENTI ID
        public EventoDTO getEventById(int id)
        {
            EventoDTO eventoDTO = new EventoDTO();
            var item = Iunitofwork.eventiQuery.GetEventoById(id, parametriDTO.connectString);
            eventoDTO.Messaggio = item.Messaggio;
            eventoDTO.StackTrace = item.StackTrace;
            eventoDTO.MetodoEvocatore = item.MetodoEvocatore;
            eventoDTO.DataEvento = item.DataEvento;
            return eventoDTO;
        }

        //GET EVENTI CALLER
        public EventoDTO getEventByCaller(string caller)
        {
            EventoDTO eventoDTO = new EventoDTO();
            var item = Iunitofwork.eventiQuery.GetEventoByCaller(caller, parametriDTO.connectString);
            eventoDTO.Messaggio = item.Messaggio;
            eventoDTO.StackTrace = item.StackTrace;
            eventoDTO.MetodoEvocatore = item.MetodoEvocatore;
            eventoDTO.DataEvento = item.DataEvento;
            return eventoDTO;
        }

        //GET EVENTI DATA
        public EventoDTO getEventByDateEvent(DateTime dataEvento)
        {
            EventoDTO eventoDTO = new EventoDTO();
            var item = Iunitofwork.eventiQuery.GetEventoByDateEvent(dataEvento, parametriDTO.connectString);
            eventoDTO.Messaggio = item.Messaggio;
            eventoDTO.StackTrace = item.StackTrace;
            eventoDTO.MetodoEvocatore = item.MetodoEvocatore;
            eventoDTO.DataEvento = item.DataEvento;
            return eventoDTO;
        }
    }
}

//COMPLETED