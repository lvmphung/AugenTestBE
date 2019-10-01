using AugenProject.Common;
using AugenProject.Data.Entity;
using AugenProject.Data.PagedDataRequest;
using AugenProject.Data.QueryProcessors;
using AugenProject.Services.AutoMappingConfiguration.Customers;
using AugenProject.Services.Interfaces;
using AugenProject.Services.Models.Common;
using AugenProject.Services.Models.Customers;
using System.Collections.Generic;
using System.Linq;

namespace AugenProject.Services.Processors
{
    public class CustomersProcessor : BaseProcessor, ICustomersProcessor
    {
        public ICSVProcessor CsvProcessor { get; }
        public CustomersProcessor(ICSVProcessor cSVProcessor)
        {
            this.CsvProcessor = cSVProcessor;
        }
        public List<CustomerInfoModel> GetCustomers()
        {
            var result = LoadCustomerData();
            // AutoMapper
            return result.Select(x=> CustomerEntityToCustomerInfoModelAutoMapperConfigurator.Mapper(x)).ToList();
        }

        private List<CustomerEntity> LoadCustomerData()
        {
            return CsvProcessor.LoadCustomerData();
        }
    }
}