using MyLog.ApplicationLogic;
using MyLog.ApplicationLogic.DTOs;
using MyLog.ApplicationLogic.ServiceFolder.ComponentiService;
using MyLog.ApplicationLogic.ServiceFolder.ComponentiService.Interface;
using MyLog.ApplicationLogic.ServiceFolder.EventiService;
using MyLog.ApplicationLogic.ServiceFolder.EventiService.Interface;
using MyLog.ApplicationLogic.ServiceFolder.ProfonditaService;
using MyLog.ApplicationLogic.ServiceFolder.ProfonditaService.Interface;
using MyLog.ApplicationLogic.ServiceFolder.TracciamentiService;
using MyLog.ApplicationLogic.ServiceFolder.TracciamentiService.Interface;
using StructureMap;
namespace UTLog.IoC
{
    public class InverseofControl : Registry
    {

        public InverseofControl()
        {
            var parametriDTO = new ParametridiConfigurazioneDTO();
            parametriDTO.connectString = @"Data Source=AULA2-PC10\SQLEXPRESS;Initial Catalog=TraceEvent;User ID=sa;Password=Pa$$w0rd1!";
            parametriDTO.nomeComponente = @"Application1";
            For<IComponentiService>().Use<ComponentiService>().Ctor<ParametridiConfigurazioneDTO>().Is(parametriDTO);
            For<IProfonditaService>().Use<ProfonditaService>().Ctor<ParametridiConfigurazioneDTO>().Is(parametriDTO);
            For<IEventiService>().Use<EventiService>().Ctor<ParametridiConfigurazioneDTO>().Is(parametriDTO);
            For<ITracciamentiService>().Use<TracciamentiService>().Ctor<ParametridiConfigurazioneDTO>().Is(parametriDTO);
            For<ILogWrite>().Use<LogWrite>();/*.Ctor<ParametridiConfigurazioneDTO>().Is(parametriDTO);*/
        }
    }
}
