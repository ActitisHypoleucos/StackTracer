using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLog.DomainLogic.DomainLogics.ComponenteLogic.Interface;
using MyLog.DomainLogic.DomainLogics.ComponentiLogic;
using MyLog.DomainLogic.DomainLogics.EventiLogic;
using MyLog.DomainLogic.DomainLogics.EventiLogic.Interface;
using MyLog.DomainLogic.DomainLogics.ProfonditaLogic;
using MyLog.DomainLogic.DomainLogics.ProfonditaLogic.Interface;
using MyLog.DomainLogic.DomainLogics.TracciamentiLogic;
using MyLog.DomainLogic.DomainLogics.TracciamentiLogic.Interface;

namespace MyLog.DomainLogic
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IComponentiCMD _componenteCMD;
        private readonly IComponentiQuery _componenteQuery;
        private readonly IProfonditaCMD _profonditaCMD;
        private readonly IProfonditaQuery _profonditaQuery;
        private readonly IEventiCMD _eventiCMD;
        private readonly IEventiQuery _eventiQuery;
        private readonly ITracciamentiCMD _tracciamentiCMD;
        private readonly ITracciamentiQuery _tracciamentiQuery;

        public UnitOfWork()
        {
            _componenteCMD = new ComponentiCMD();
            _componenteQuery = new ComponentiQuery();
            _profonditaCMD = new ProfonditaCMD();
            _profonditaQuery = new ProfonditaQuery();
            _eventiCMD = new EventiCMD();
            _eventiQuery = new EventiQuery();
            _tracciamentiCMD = new TracciamentiCMD();
            _tracciamentiQuery = new TracciamentiQuery();
        }
        public IComponentiCMD componenteCMD
        { get { return _componenteCMD; } }

        public IComponentiQuery componenteQuery
        { get { return _componenteQuery; } }

        public IProfonditaCMD profonditaCMD
        { get { return _profonditaCMD; } }

        public IProfonditaQuery profonditaQuery
        { get { return _profonditaQuery; } }

        public IEventiCMD eventiCMD
        { get { return _eventiCMD; } }

        public IEventiQuery eventiQuery
        { get { return _eventiQuery; } }

        public ITracciamentiCMD tracciamentiCMD
        { get { return _tracciamentiCMD; } }

        public ITracciamentiQuery tracciamentiQuery
        { get { return _tracciamentiQuery; } }
    }
}