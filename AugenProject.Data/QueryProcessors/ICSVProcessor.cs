using AugenProject.Data.Entity;
using System.Collections.Generic;

namespace AugenProject.Data.QueryProcessors
{
    public interface ICSVProcessor
    {
        List<CustomerEntity> LoadCustomerData();
    }
}
