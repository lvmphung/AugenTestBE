using AugenProject.Web.Api.Controllers.v1.Interfaces;
using AugenProject.Web.Common.ActionHelper;

namespace AugenProject.Web.Api.Controllers.v1.DependencyBlocks
{
    public abstract class ControllerDependencyBlockBase : IControllerDependencyBlock
    {
        public IActionResultHelper ActionResultHelper { get; protected set; }

        protected ControllerDependencyBlockBase()
        {
        }

        protected ControllerDependencyBlockBase(IActionResultHelper actionResultHelper)
        {
            this.ActionResultHelper = actionResultHelper;
        }
    }
}