using System;
using Xunit;
using Xunit.Abstractions;

namespace NeutroLab.BusinessLogic.Test.ShareFixtureAcrossTestClasses
{
	[Collection("Customer")]
	public class CustomerNameTest
	{
        private readonly ITestOutputHelper testOutputHelper;
        private readonly CustomerFixture customerFixture;

		public CustomerNameTest(ITestOutputHelper testOutputHelper, CustomerFixture customerFixture)
		{
			this.testOutputHelper = testOutputHelper;
            this.customerFixture = customerFixture;
		}

		[Fact]
		public void Customer_Name_Should_Not_Null()
		{
			Assert.NotNull(customerFixture.Cust.Name);

            int localRandom = new Random((int)DateTime.Now.Ticks).Next();
            this.testOutputHelper.WriteLine($"customerFixture random ={customerFixture.Random}");
            this.testOutputHelper.WriteLine($"Local random ={localRandom}");
        }
	}
}

