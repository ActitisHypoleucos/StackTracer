using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLog.DomainLogic.Models;

namespace MyLog.DomainLogic.DomainLogics.TracciamentiLogic.Interface
{
    public interface ITracciamentiCMD
    {
        bool insert(Tracciamenti tracciamento, string connectString);
        //bool update(Tracciamenti tracciamento, string connectString);
    }
}
