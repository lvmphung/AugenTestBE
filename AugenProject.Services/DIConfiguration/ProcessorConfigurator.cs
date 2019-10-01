using AugenProject.Data.QueryProcessors;
using Ninject;
using Ninject.Web.Common;

namespace AugenProject.Services.DIConfiguration
{
    public static class ProcessorConfigurator
    {
        public static void Configure(IKernel containerBuilder)
        {
            containerBuilder.Bind<ICSVProcessor>().To<CSVProcessor>().InRequestScope();
        }
    }
}