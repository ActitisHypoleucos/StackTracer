using System;
using MyLog.ApplicationLogic.DTOs;
using MyLog.ApplicationLogic.Extension;
using MyLog.ApplicationLogic.Exception;
using MyLog.ApplicationLogic.ServiceFolder.ComponentiService.Interface;

namespace MyLog.ApplicationLogic.ServiceFolder.ComponentiService
{
    public class ComponentiService : BaseService , IComponentiService
    {
        //INSERT COMPONENTI
        public ResultDTO insert(ComponenteDTO componente)
        {
            ResultDTO risultato = new ResultDTO();
            bool checkExists = componente.checkComponenteExists(parametriDTO.connectString);
            if (!checkExists)
            {
                if (Iunitofwork.componenteCMD.insert(new DomainLogic.Models.Componenti()
                    {
                        NomeApplicazione = componente.NomeApplicazione,
                        Descrizione = componente.Descrizione,
                    }, parametriDTO.connectString)) //<parametri if>\\
                //corpo if
                {
                    risultato.descrizione = "L'inserimento è avvenuto con successo";
                    risultato.esito = Enum.EsitoEsecuzione.OK;
                }
                else
                {
                    risultato.descrizione = "L'inserimento non è andato a buon fine ";
                    risultato.esito = Enum.EsitoEsecuzione.KO;
                }
            }
            else
            {
                throw new ComponenteEsistenteException();
            }
            return risultato;
        }

        //UPDATE COMPONENTI
        public ResultDTO update(ComponenteDTO componente)
        {
            //todo
            ResultDTO risultato = new ResultDTO();
            bool checkExists = componente.checkComponenteExists(parametriDTO.connectString);
            if (!checkExists)
            {
                if (Iunitofwork.componenteCMD.update(new DomainLogic.Models.Componenti()
                {
                    NomeApplicazione = componente.NomeApplicazione,
                    Descrizione = componente.Descrizione,
                    DataInserimento = DateTime.Now
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

        //GET COMPONENTI ID
        public ComponenteDTO getComponentById(int id)
        {
            ComponenteDTO componenteDTO = new ComponenteDTO();
            var item = Iunitofwork.componenteQuery.GetComponenteById(id, parametriDTO.connectString);
            componenteDTO.NomeApplicazione = item.NomeApplicazione;
            componenteDTO.Descrizione = item.Descrizione;
            componenteDTO.DataInserimento = item.DataInserimento;
            return componenteDTO;
        }

        #region GetComponenti

        
        //GET COMPONENTI NOME
        public ComponenteDTO getComponentByName(string nameApp)
        {
            ComponenteDTO componenteDTO = new ComponenteDTO();
            var item = Iunitofwork.componenteQuery.GetComponenteByAppName(nameApp, parametriDTO.connectString);
            componenteDTO.NomeApplicazione = item.NomeApplicazione;
            componenteDTO.Descrizione = item.Descrizione;
            componenteDTO.DataInserimento = item.DataInserimento;
            componenteDTO.id = item.id;
            return componenteDTO;
        }

        public ComponenteDTO getComponentByName()
        {
            return getComponentByName(parametriDTO.nomeComponente);
            
        }
        #endregion
    }
}

//COMPLETED