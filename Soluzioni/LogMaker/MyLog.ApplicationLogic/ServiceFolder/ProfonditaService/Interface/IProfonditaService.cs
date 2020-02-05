using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLog.ApplicationLogic.DTOs;

namespace MyLog.ApplicationLogic.ServiceFolder.ProfonditaService.Interface
{
    public interface IProfonditaService : IBaseService
    {
        ProfonditaDTO getProfonditaByLevel(string livello);
    }
}
