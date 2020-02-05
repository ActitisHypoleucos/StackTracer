using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLog.ApplicationLogic.DTOs
{
    public class ComponenteDTO
    {
        public int id { get; set; }
        public string NomeApplicazione { get; set; }
        public string Descrizione { get; set; }
        public DateTime DataInserimento { get; set; }
    }
}

//COMPLETED