using System.Collections.Generic;
using AugenProject.Data.Entity;

namespace AugenProject.Data.QueryProcessors
{
    public class CSVProcessor : ICSVProcessor
    {
        public List<CustomerEntity> LoadCustomerData()
        {
            return DataCSV.LoadData();
        }
    }
}