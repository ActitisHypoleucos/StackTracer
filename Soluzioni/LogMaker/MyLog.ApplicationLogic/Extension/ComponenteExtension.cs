using MyLog.ApplicationLogic.DTOs;
using MyLog.DomainLogic.DomainLogics.ComponenteLogic.Interface;
using MyLog.DomainLogic.DomainLogics.ComponentiLogic;

namespace MyLog.ApplicationLogic.Extension
{
    public static class ComponenteExtension
    {
        public static bool checkComponenteExists(this ComponenteDTO componenteOggetto, string connectString)
        {
            IComponentiQuery componenteQuery = new ComponentiQuery();
            var componente = componenteQuery.GetComponenteByAppName(componenteOggetto.NomeApplicazione, connectString);
            return componente != null ? true : false; //Operatore ternario 
        }
    }
}

//COMPLETED