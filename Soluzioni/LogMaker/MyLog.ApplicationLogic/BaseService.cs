using MyLog.ApplicationLogic.DTOs;
using MyLog.DomainLogic;

namespace MyLog.ApplicationLogic
{
    //Questa classe definisce il BaseService, che è la base di ogni servizio di connessione al DB
    public class BaseService : IBaseService
    {
        public readonly IUnitOfWork Iunitofwork;
        public ParametridiConfigurazioneDTO parametriDTO { get; set; }

        public BaseService()
        {
            Iunitofwork = new UnitOfWork();
        }
    }
}

//COMPLETED