using AugenProject.Services.Models.Common;
using AugenProject.Services.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugenProject.Services.Interfaces
{
    public interface ICustomersProcessor
    {
        List<CustomerInfoModel> GetCustomers();
    }
}
