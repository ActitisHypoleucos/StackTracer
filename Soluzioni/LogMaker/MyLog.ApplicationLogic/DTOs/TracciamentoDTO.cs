using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLog.ApplicationLogic.DTOs
{
    public class TracciamentoDTO
    {
        public int id_Componente_FK { get; set; }
        public int id_Profondita_FK { get; set; }
        public DateTime DataUltimaModifica { get; set; }
    }
}

//COMPLETED