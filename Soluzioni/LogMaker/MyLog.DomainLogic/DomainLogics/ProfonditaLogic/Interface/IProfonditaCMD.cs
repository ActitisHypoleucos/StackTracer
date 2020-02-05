using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLog.DomainLogic.Models;

namespace MyLog.DomainLogic.DomainLogics.ProfonditaLogic.Interface
{
    public interface IProfonditaCMD
    {
        bool insert(Profondita profondita, string connectString);
        bool update(Profondita profondita, string connectString);
    }
}
