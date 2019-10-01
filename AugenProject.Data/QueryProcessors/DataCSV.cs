using AugenProject.Data.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace AugenProject.Data.QueryProcessors
{
    public static class DataCSV
    {
        private static List<CustomerEntity> customerEntities;

        private static List<CustomerEntity> ReadFileCustomers()
        {
            List<CustomerEntity> customers = new List<CustomerEntity>();
            try
            {
                var fileNameCSV = ConfigurationManager.AppSettings["FileCSV"];
                using (var reader = new StreamReader(File.OpenRead(fileNameCSV)))
                {
                    string headerLine = reader.ReadLine();
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (!string.Equals(headerLine, line))
                        {
                            var values = line.Split(',');
                            customers.Add(new CustomerEntity()
                            {
                                FirstName = values[0],
                                LastName = values[1],
                                CompanyName = values[2],
                                Address = values[3],
                                City = values[4],
                                State = values[5],
                                Post = values[6],
                                Phone1 = values[7],
                                Phone2 = values[8],
                                Email = values[9],
                                Web = values[10]
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return customers;
        }

        public static List<CustomerEntity> LoadData()
        {
            if (customerEntities == null)
                customerEntities = ReadFileCustomers();

            return customerEntities;
        }
    }
}