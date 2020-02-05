using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLog.ApplicationLogic.Exception
{
    public class ComponenteEsistenteException : System.Exception
    {
        public ComponenteEsistenteException()
        {

        }

        public ComponenteEsistenteException(string nomeComponente) : base(nomeComponente)
        {

        }

    }//COMPLETED

}

