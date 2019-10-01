using AugenProject.Services.Interfaces;
using AugenProject.Web.Api.Controllers.v1.Interfaces;
using AugenProject.Web.Common.ActionHelper;
using System;

namespace AugenProject.Web.Api.Controllers.v1.DependencyBlocks
{
    public class CustomersControllerDependencyBlock : ControllerDependencyBlockBase, ICustomersControllerDependencyBlock
    {
        public CustomersControllerDependencyBlock(IActionResultHelper actionResultHelper,
            ICustomersProcessor customersProcessor) {
            ActionResultHelper = actionResultHelper;
            this.CustomersProcessor = customersProcessor;
        }

        public ICustomersProcessor CustomersProcessor { get; private set; }

    }
}