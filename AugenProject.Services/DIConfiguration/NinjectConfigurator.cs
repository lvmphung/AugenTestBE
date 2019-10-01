using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AugenProject.Services.DIConfiguration
{
    public class NinjectConfigurator
    {
        public void Configure(IKernel container)
        {
            AddBindings(container);
        }

        private void AddBindings(IKernel container)
        {
            ProcessorConfigurator.Configure(container);
        }
    }
}