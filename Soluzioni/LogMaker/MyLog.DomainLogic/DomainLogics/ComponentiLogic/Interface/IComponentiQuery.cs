using MyLog.DomainLogic.Models;

namespace MyLog.DomainLogic.DomainLogics.ComponenteLogic.Interface
{
    public interface IComponentiQuery
    {
        Componenti GetComponenteById(int id, string connectString);
        Componenti GetComponenteByAppName(string nome, string connectString);
    }
}

//COMPLETED