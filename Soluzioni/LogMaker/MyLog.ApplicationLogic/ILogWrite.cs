using System;
namespace MyLog.ApplicationLogic
{
    public interface ILogWrite
    {
        bool TRACE(string messaggio);
        bool TRACEDEBUG(string messaggio);
        bool TRACEINFORMATION(string messaggio);
        bool TRACEWARNING(string messaggio);
        bool TRACEERROR(System.Exception exception);
        bool TRACECRITICAL(string messaggio);
    }
}

//COMPLETED