using System;
using MyLog.DomainLogic.Models;

namespace MyLog.DomainLogic.DomainLogics.EventiLogic.Interface
{
    public interface IEventiQuery
    {
        Eventi GetEventoById(int id, string connectString);
        Eventi GetEventoByCaller(string nome, string connectString);
        Eventi GetEventoByDateEvent(DateTime dataEvento, string connectString);

    }
}
