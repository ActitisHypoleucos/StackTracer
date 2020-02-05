using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLog.ApplicationLogic.DTOs
{
    public class EventoDTO
    {
        public int id_Componente_FK { get; set; }
        public int id_Profondita_FK { get; set; }
        public DateTime DataEvento { get; set; }
        public string Messaggio { get; set; }
        public string StackTrace { get; set; }
        public string MetodoEvocatore { get; set; }
    }
}

//COMPLETED