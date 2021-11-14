using DIdemoLibrary;
using System;

namespace DIdemoConsole
{
    class Program
    {
        private static ILogger _logger;
        private static IApiService _apiService;

        static void Main(string[] args)
        {
            Dependency.Configure();
            _logger = Dependency.Container.GetInstance<ILogger>();
            _apiService = Dependency.Container.GetInstance<IApiService>();

            var idCustomer = 1;

            while (idCustomer > 0)
            {
                Console.WriteLine("Enter the customer ID to read his data: ");

                try
                {
                    idCustomer = Convert.ToInt32(Console.ReadLine());
                    var customer = _apiService.GetCustomer(idCustomer);

                    if (customer is not null)
                    {
                        _logger.LogInfo($"Found customer: {customer.Id} - {customer.Name} - {customer.Surname}.");
                    }
                    else
                    {
                        _logger.LogError($"Customer not found.");
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
