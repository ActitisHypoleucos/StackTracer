using System;
using System.Diagnostics;
using MyLog.ApplicationLogic.DTOs;
using MyLog.ApplicationLogic.ServiceFolder.ComponentiService.Interface;
using MyLog.ApplicationLogic.ServiceFolder.EventiService.Interface;
using MyLog.ApplicationLogic.ServiceFolder.ProfonditaService.Interface;
using MyLog.ApplicationLogic.ServiceFolder.TracciamentiService.Interface;

namespace MyLog.ApplicationLogic
{
    public class LogWrite : ILogWrite
    {
        #region Attributi
        private readonly IEventiService _eventiService;
        private readonly IComponentiService _componentiService;
        private readonly IProfonditaService _profonditaService;
        private readonly ITracciamentiService _tracciamentiService;
        #endregion

        #region Costruttore
        public LogWrite(IEventiService eventiService, IComponentiService componentiService, IProfonditaService profonditaService, ITracciamentiService tracciamentiService)
        {
            _eventiService = eventiService;
            _componentiService = componentiService;
            _profonditaService = profonditaService;
            _tracciamentiService = tracciamentiService;
        }
        #endregion

        #region TRACE - 1
        public bool TRACE(string messaggio)
        {
            var componente = _componentiService.getComponentByName();
            if (_tracciamentiService.isAbilitato(componente.id, Enum.LivelloTracciamento.TRACE))
            {
                TraceDTO TRACEDTO = getStackTrace();
                return commonTrace(componente.id, (int)Enum.LivelloTracciamento.TRACE, messaggio, TRACEDTO);
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region DEBUG - 2
        public bool TRACEDEBUG(string messaggio)
        {
            var componente = _componentiService.getComponentByName();
            if (_tracciamentiService.isAbilitato(componente.id, Enum.LivelloTracciamento.DEBUG))
            {
                TraceDTO TRACEDTO = getStackTrace();
                return commonTrace(componente.id, (int)Enum.LivelloTracciamento.DEBUG, messaggio, TRACEDTO);
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region INFORMATION - 3
        public bool TRACEINFORMATION(string messaggio)
        {
            var componente = _componentiService.getComponentByName();
            if (_tracciamentiService.isAbilitato(componente.id, Enum.LivelloTracciamento.INFORMATION))
            {
                TraceDTO TRACEDTO = getStackTrace();
                return commonTrace(componente.id, (int)Enum.LivelloTracciamento.INFORMATION, messaggio, TRACEDTO);
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region WARNING - 4 
        public bool TRACEWARNING(string messaggio)
        {
            var componente = _componentiService.getComponentByName();
            if (_tracciamentiService.isAbilitato(componente.id, Enum.LivelloTracciamento.WARNING))
            {
                TraceDTO TRACEDTO = getStackTrace();
                return commonTrace(componente.id, (int)Enum.LivelloTracciamento.WARNING, messaggio, TRACEDTO);
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region ERROR - 5
        public bool TRACEERROR(System.Exception exception)
        {
            var componente = _componentiService.getComponentByName();
            if (_tracciamentiService.isAbilitato(componente.id, Enum.LivelloTracciamento.ERROR))
            {
                TraceDTO TRACEDTO = getStackTrace(exception);
                return commonTrace(componente.id, (int)Enum.LivelloTracciamento.ERROR, exception, TRACEDTO);
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region CRITICAL - 6
        public bool TRACECRITICAL(string messaggio)
        {
            var componente = _componentiService.getComponentByName();
            if (_tracciamentiService.isAbilitato(componente.id, Enum.LivelloTracciamento.CRITICAL))
            {
                TraceDTO TRACEDTO = getStackTrace();
                return commonTrace(componente.id, (int)Enum.LivelloTracciamento.CRITICAL, messaggio, TRACEDTO);
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region commonTrace
        private bool commonTrace(int id_C, int id_P, string messaggio, TraceDTO traceDTO)
        {
            EventoDTO evento = new EventoDTO();
            evento.id_Componente_FK = id_C;
            evento.id_Profondita_FK = id_P;
            evento.Messaggio = messaggio;
            evento.MetodoEvocatore = traceDTO.metodoChiamante;      //vedi classe StackTrace
            //evento.MetodoEvocatore = "metodo placeholder";
            evento.StackTrace = traceDTO.stackTrace;                //vedi classe StackTrace
            //evento.StackTrace = "stacktrace placeholder";

            return (int)_eventiService.insert(evento).esito == 1;
        }
        #endregion

        #region commonTrace Exception
        private bool commonTrace(int id_C, int id_P, System.Exception exception, TraceDTO traceDTO)
        {
            EventoDTO evento = new EventoDTO();
            evento.id_Componente_FK = id_C;
            evento.id_Profondita_FK = id_P;
            evento.Messaggio = exception.Message;
            evento.MetodoEvocatore = traceDTO.metodoChiamante;      //vedi classe StackTrace
            //evento.MetodoEvocatore = "metodo placeholder";
            evento.StackTrace = traceDTO.stackTrace;                //vedi classe StackTrace
            //evento.StackTrace = "stacktrace placeholder";

            return (int)_eventiService.insert(evento).esito == 1;
        }
        #endregion

        #region StackTrace
        public TraceDTO getStackTrace() //quale frame devo inserire nella tabella?
        {
            StackTrace stack = new StackTrace();
            TraceDTO traceDTO = new TraceDTO();
            int countFrame = stack.FrameCount;
            //<Stack è un oggetto array[]>
            //for (int i = 0; i < countFrame; i++ )
            //{
            //StackFrame frame = stack.GetFrame(i);
            StackFrame frame = stack.GetFrame(2); //ottiene il frame corrispondente all'intero. 0 è l'ultimo, countFrame-1 è il primo in assoluto, in '2' è presento lo stack di "UnitTest1.cs"
            traceDTO.metodoChiamante = frame.GetMethod().ToString();
            traceDTO.stackTrace = stack.ToString();
            //}
            return traceDTO;
        }
        #endregion

        #region StackTrace Exception
        public TraceDTO getStackTrace(System.Exception exception) //quale frame devo inserire nella tabella?
        {
            StackTrace stack = new StackTrace();
            TraceDTO traceDTO = new TraceDTO();
            int countFrame = stack.FrameCount;
            //<Stack è un oggetto array[]>
            //for (int i = 0; i < countFrame; i++ )
            //{
            //StackFrame frame = stack.GetFrame(i);
            StackFrame frame = stack.GetFrame(2); //ottiene il frame corrispondente all'intero. 0 è l'ultimo, countFrame-1 è il primo in assoluto, in '2' è presento lo stack di "UnitTest1.cs"
            traceDTO.metodoChiamante = frame.GetMethod().ToString();
            traceDTO.stackTrace = exception.StackTrace;
            //}
            return traceDTO;
        }
        #endregion
    }
}
