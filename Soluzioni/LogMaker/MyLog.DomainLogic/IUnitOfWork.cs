using MyLog.DomainLogic.DomainLogics.ComponenteLogic.Interface;
using MyLog.DomainLogic.DomainLogics.EventiLogic.Interface;
using MyLog.DomainLogic.DomainLogics.ProfonditaLogic.Interface;
using MyLog.DomainLogic.DomainLogics.TracciamentiLogic;
using MyLog.DomainLogic.DomainLogics.TracciamentiLogic.Interface;

namespace MyLog.DomainLogic
{
    public interface IUnitOfWork
    {
        //Componenti\\
        IComponentiQuery componenteQuery { get; }
        IComponentiCMD componenteCMD { get; }
        
        //Profondita\\
        IProfonditaQuery profonditaQuery { get; }
        IProfonditaCMD profonditaCMD { get; }

        //Eventi\\
        IEventiQuery eventiQuery { get; }
        IEventiCMD eventiCMD { get; }
        
        //Tracciamenti\\
        ITracciamentiQuery tracciamentiQuery { get; }
        ITracciamentiCMD tracciamentiCMD { get; }
    }
}
