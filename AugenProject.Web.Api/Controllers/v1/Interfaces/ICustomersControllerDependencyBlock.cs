using AugenProject.Services.Interfaces;

namespace AugenProject.Web.Api.Controllers.v1.Interfaces
{
    public interface ICustomersControllerDependencyBlock : IControllerDependencyBlock
    {
        ICustomersProcessor CustomersProcessor { get; }
    }
}
