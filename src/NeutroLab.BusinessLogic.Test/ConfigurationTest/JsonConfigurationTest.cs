using System;
using Xunit;
using Xunit.Abstractions;
using FluentAssertions;
using NeutroLab.XUnit;

namespace NeutroLab.BusinessLogic.Test.ConfigurationTest
{
    public class JsonConfigurationTest : UnitTest
    {
        public JsonConfigurationTest(ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        public void Get_DbConnection_Test()
        {
            DbConfigurationReader configReader = new DbConfigurationReader();
            var configuration = configReader.GetDbConfiguration(AppContext.BaseDirectory);

            configuration
                .Should().NotBeNull("Configuration object cannot be null");

            configuration.ConnectionString
                .Should().NotBeNull("Connection string cannot be null.")
                .And.Should().NotBeSameAs(String.Empty, "Connection cannot be an empty string");

            Output.WriteLine($"Connection string is: {configuration.ConnectionString}");
        }

    }
}
