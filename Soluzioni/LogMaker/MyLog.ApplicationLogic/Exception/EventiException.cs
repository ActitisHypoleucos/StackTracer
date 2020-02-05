using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLog.ApplicationLogic.Exception
{
    public class EventoEsistenteException : System.Exception
    {
        public EventoEsistenteException()
        {

        }

        public EventoEsistenteException(string metodoEvocatore) : base(metodoEvocatore)
        {

        }

    }//COMPLETED
}
