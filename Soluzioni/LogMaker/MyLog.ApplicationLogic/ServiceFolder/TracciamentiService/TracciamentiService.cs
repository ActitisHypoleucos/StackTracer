using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLog.ApplicationLogic.DTOs;
using MyLog.ApplicationLogic.Enum;
using MyLog.ApplicationLogic.ServiceFolder.TracciamentiService.Interface;
using MyLog.DomainLogic.Models;
using MyLog.ApplicationLogic.Extension;

namespace MyLog.ApplicationLogic.ServiceFolder.TracciamentiService
{
    public class TracciamentiService : BaseService , ITracciamentiService
    {
        public bool isAbilitato(int id, LivelloTracciamento livello)
        {
            var item = Iunitofwork.tracciamentiQuery.GetTracciamentoByComponent(id, parametriDTO.connectString);
            return item.id_Profondita_FK >= (int)livello;
        }
    }
}

//COMPLETED