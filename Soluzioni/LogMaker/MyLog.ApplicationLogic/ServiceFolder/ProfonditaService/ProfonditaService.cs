using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLog.ApplicationLogic.DTOs;
using MyLog.ApplicationLogic.ServiceFolder.ProfonditaService.Interface;

namespace MyLog.ApplicationLogic.ServiceFolder.ProfonditaService
{
    public class ProfonditaService : BaseService, IProfonditaService
    {
        public ProfonditaDTO getProfonditaByLevel(string livello)
        {
            ProfonditaDTO profonditaDTO = new ProfonditaDTO();
            var item = Iunitofwork.profonditaQuery.GetProfonditaByLevel(livello, parametriDTO.connectString);
            profonditaDTO.Livello_Tracciamento = item.Livello_Tracciamento;
            return profonditaDTO;
        }
    }
}
