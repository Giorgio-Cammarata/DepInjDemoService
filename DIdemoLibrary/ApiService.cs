using DIdemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DIdemoLibrary
{
    public class ApiService : IApiService
    {
        // Configure your xml file path 
        private const string XmlFilePath = "D:/PERSONALE/source/repos/DepInjDemoService/DIdemoLibrary/Data/dataCustomers.xml";
        private readonly ILogger _logger;
        private List<Customer> _customers;

        public ApiService(ILogger logger)
        {
            _logger = logger;
            _customers = new List<Customer>();

            LoadCustomersDataFromXmlFile();
        }

        private void LoadCustomersDataFromXmlFile()
        {
            _logger.LogInfo($"Entered method {typeof(ApiService)}.{nameof(LoadCustomersDataFromXmlFile)}");

            XDocument xDoc = XDocument.Load(XmlFilePath);
            XElement xRoot = xDoc.Root;

            _customers = (from c in xRoot.Descendants("customer")
                          select new Customer
                          {
                              Id = Convert.ToInt32(c.Attribute("id").Value),
                              Name = c.Attribute("name").Value,
                              Surname = c.Attribute("surname").Value
                          }).ToList();
        }

        public Customer GetCustomer(int id)
        {
            _logger.LogInfo($"Entered method {typeof(ApiService)}.{nameof(GetCustomer)}");

            return _customers.FirstOrDefault(c => c.Id == id);
        }
    }
}
