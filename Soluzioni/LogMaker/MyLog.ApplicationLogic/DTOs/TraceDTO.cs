using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLog.ApplicationLogic.DTOs
{
    public class TraceDTO
    {
        public string metodoChiamante { get; set; } //il metodo chiamante contenuto dentro ad un frame
        public string stackTrace { get; set; } //non ho idea di cosa ci debba mettere
    }
}
