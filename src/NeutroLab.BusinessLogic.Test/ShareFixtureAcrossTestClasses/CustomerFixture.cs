using System;
namespace NeutroLab.BusinessLogic.Test.ShareFixtureAcrossTestClasses
{
	public class CustomerFixture
	{
		public Customer Cust => new Customer();
        public int Random = new Random((int)DateTime.Now.Ticks).Next();

    }
}

