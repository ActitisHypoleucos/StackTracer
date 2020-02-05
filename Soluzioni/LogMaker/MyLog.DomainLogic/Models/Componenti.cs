using System;

namespace MyLog.DomainLogic.Models
{
    public class Componenti : BaseModel
    {
        public string NomeApplicazione { get; set; }
        public string Descrizione { get; set; }
        public DateTime DataInserimento { get; set; }
    }
}

//COMPLETED