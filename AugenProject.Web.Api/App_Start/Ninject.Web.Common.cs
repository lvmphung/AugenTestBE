[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(AugenProject.Web.Api.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(AugenProject.Web.Api.App_Start.NinjectWebCommon), "Stop")]

namespace AugenProject.Web.Api.App_Start
{
    using System;
    using System.Web;
    using AugenProject.Services.DIConfiguration;
    using AugenProject.Services.Interfaces;
    using AugenProject.Services.Processors;
    using AugenProject.Web.Api.Controllers.v1;
    using AugenProject.Web.Api.Controllers.v1.DependencyBlocks;
    using AugenProject.Web.Api.Controllers.v1.Interfaces;
    using AugenProject.Web.Common.ActionHelper;
    using AugenProject.Web.Common.DependencyResolvers;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Ninject.Web.Common.WebHost;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            IKernel containerBuilder = null;
            bootstrapper.Initialize(() =>
            {
                containerBuilder = CreateKernel();
                return containerBuilder;
            });

            var resolver = new NinjectDependencyResolver(containerBuilder);
            System.Web.Http.GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            var containerConfigurator = new NinjectConfigurator();
            containerConfigurator.Configure(kernel);

            ConfigureControllerDependencyBlock(kernel);
        }
        private static void ConfigureControllerDependencyBlock(IKernel kernel)
        {
            kernel.Bind<ICustomersControllerDependencyBlock>().To<CustomersControllerDependencyBlock>();
            kernel.Bind<ICustomersProcessor>().To<CustomersProcessor>();
            kernel.Bind<IActionResultHelper>().To<ActionResultHelper>();
        }
    }
}