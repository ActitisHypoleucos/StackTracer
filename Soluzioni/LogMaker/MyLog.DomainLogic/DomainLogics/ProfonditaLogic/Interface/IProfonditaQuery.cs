using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLog.DomainLogic.Models;

namespace MyLog.DomainLogic.DomainLogics.ProfonditaLogic.Interface
{
    public interface IProfonditaQuery
    {
        Profondita GetProfonditaById(int id, string connectString);
        Profondita GetProfonditaByLevel(string level, string connectString);
    }
}
