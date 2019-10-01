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
                            if (values[2].Contains("\""))
                            {
                                var company = values[2] + values[3];
                                company = company.Replace("\"", "");
                                customers.Add(new CustomerEntity()
                                {
                                    FirstName = values[0],
                                    LastName = values[1],
                                    CompanyName = company,
                                    Address = values[4],
                                    City = values[5],
                                    State = values[6],
                                    Post = values[7],
                                    Phone1 = values[8],
                                    Phone2 = values[9],
                                    Email = values[10],
                                    Web = values[11]
                                });
                            }
                            else
                            {
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