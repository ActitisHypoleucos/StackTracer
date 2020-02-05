using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLog.DomainLogic.Models
{
    public class Tracciamenti 
    {
        public int id_Componente_FK { get; set; }
        public int id_Profondita_FK { get; set; }
        public DateTime DataUltimaModifica { get; set; }
    }
}

//COMPLETED