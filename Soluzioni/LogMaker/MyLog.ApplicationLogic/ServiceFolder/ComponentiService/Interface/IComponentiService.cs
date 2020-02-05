using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLog.ApplicationLogic.DTOs;

namespace MyLog.ApplicationLogic.ServiceFolder.ComponentiService.Interface
{
    public interface IComponentiService : IBaseService
    {
        ResultDTO insert(ComponenteDTO componente);
        ResultDTO update(ComponenteDTO componente);
        ComponenteDTO getComponentById(int id);
        ComponenteDTO getComponentByName(string nameApp);
        ComponenteDTO getComponentByName();
    }
}

//COMPLETED