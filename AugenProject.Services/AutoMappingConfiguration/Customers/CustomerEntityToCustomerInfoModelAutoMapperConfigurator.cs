using AugenProject.Data.Entity;
using AugenProject.Services.Models.Customers;
using AutoMapper;

namespace AugenProject.Services.AutoMappingConfiguration.Customers
{
    public static class CustomerEntityToCustomerInfoModelAutoMapperConfigurator
    {
        public static CustomerInfoModel Mapper(CustomerEntity customerEntity)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CustomerEntity, CustomerInfoModel>());
            var mapper = new Mapper(config);
            return mapper.Map<CustomerInfoModel>(customerEntity);
        }
    }
}