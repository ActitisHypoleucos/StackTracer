using MyLog.DomainLogic.Models;

namespace MyLog.DomainLogic.DomainLogics.ComponenteLogic.Interface
{
    public interface IComponentiCMD
    {
        bool insert(Componenti componente, string connectString);
        bool update(Componenti componente, string connectString);
    }
}

//COMPLETED