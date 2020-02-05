using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLog.ApplicationLogic.DTOs;
using MyLog.ApplicationLogic.Enum;

namespace MyLog.ApplicationLogic.ServiceFolder.TracciamentiService.Interface
{
    public interface ITracciamentiService : IBaseService
    {
        bool isAbilitato(int id, LivelloTracciamento livello);
    }
}
