using MyLog.DomainLogic.Models;

namespace MyLog.DomainLogic.DomainLogics.EventiLogic.Interface
{
    public interface IEventiCMD
    {
        bool insert(Eventi evento, string connectString);
        bool update(Eventi evento, string connectString);
    }
}
