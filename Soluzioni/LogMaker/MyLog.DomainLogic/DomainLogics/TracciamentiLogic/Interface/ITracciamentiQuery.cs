using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLog.DomainLogic.Models;

namespace MyLog.DomainLogic.DomainLogics.TracciamentiLogic.Interface
{
    public interface ITracciamentiQuery
    {
        Tracciamenti GetTracciamentoByComponent(int id, string connectString);
        Tracciamenti GetTracciamentoByDepth (int id, string connectString);
        Tracciamenti GetTracciamentoByDate (DateTime date, string connectString);
        Tracciamenti GetTracciamentoByComponentAndDepth(int id_C, int id_P, string connectString);
    }
}

//COMPLETED