using System;
using Xunit;
using Xunit.Abstractions;

namespace NeutroLab.BusinessLogic.Test.ShareFixtureAcrossTestClasses
{
    [Collection("Customer")]
    public class CustomerAgeTest
	{
        private readonly ITestOutputHelper testOutputHelper;
        private readonly CustomerFixture customerFixture;

        public CustomerAgeTest(ITestOutputHelper testOutputHelper, CustomerFixture customerFixture)
		{
            this.testOutputHelper = testOutputHelper;
			this.customerFixture = customerFixture;
		}

        [Fact]
        public void Age_Should_Be_GreatherThanEqual_30()
        {
            Assert.True(customerFixture.Cust.Age >= 30);

            int localRandom = new Random((int)DateTime.Now.Ticks).Next();
            this.testOutputHelper.WriteLine($"customerFixture random ={customerFixture.Random}");
            this.testOutputHelper.WriteLine($"Local random ={localRandom}");
        }
    }
}

