using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLog.ApplicationLogic.DTOs;

namespace MyLog.ApplicationLogic.ServiceFolder.EventiService.Interface
{
    public interface IEventiService : IBaseService
    {
        ResultDTO insert(EventoDTO evento);
        ResultDTO update(EventoDTO evento);
        EventoDTO getEventById(int id);
        EventoDTO getEventByCaller(string nome);
        EventoDTO getEventByDateEvent(DateTime dataEvento);
    }
}
