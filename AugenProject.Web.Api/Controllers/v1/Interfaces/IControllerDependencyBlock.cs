using AugenProject.Web.Common.ActionHelper;

namespace AugenProject.Web.Api.Controllers.v1.Interfaces
{
    public interface IControllerDependencyBlock
    {
        IActionResultHelper ActionResultHelper { get; }
    }
}
