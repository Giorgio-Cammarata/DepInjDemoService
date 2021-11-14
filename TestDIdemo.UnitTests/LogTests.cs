using DIdemoLibrary;
using FluentAssertions;
using System;
using Xunit;

namespace TestDIdemo.UnitTests
{
    public class LogTests : IDisposable
    {
        private readonly ILogger _logger;
        private readonly IApiService _apiService;

        static LogTests()
        {
            Dependency.Configure();
        }

        public LogTests()
        {
            _logger = Dependency.Container.GetInstance<ILogger>();
            _apiService = Dependency.Container.GetInstance<IApiService>();
        }

        public void Dispose() { }           

        [Fact]
        public void ApiServiceWithLogInfo_ReturnsTrue()
        {
            var customer = _apiService.GetCustomer(2);

            if (customer != null)
            {
                _logger.LogInfo($"Found customer: {customer.Id} - {customer.Name} - {customer.Surname}.");
                customer.Should().NotBe(null);
            }
        }

        [Fact]
        public void ApiServiceWithLogError_ReturnsTrue()
        {
            var customer = _apiService.GetCustomer(10);

            if (customer == null)
            {
                _logger.LogError($"Customer not found.");
                customer.Should().Be(null);
            }
        }

        #region SomeTrialTests

        [Fact(Skip = "This test is skipped")]
        public void TestSkipped() { }

        [Theory]
        [InlineData(-100, false)]
        [InlineData(17, false)]
        [InlineData(18, true)]
        [InlineData(65, true)]
        [InlineData(66, false)]
        public void ValidateAge_AgeIsValidFrom18To65(int age, bool expectedResult)
        {
            var result = (age >= 18 && age <= 65);

            result.Should().Be(expectedResult);
        }

        #endregion
    }
}
