using System;
using Xunit;

namespace NeutroLab.BusinessLogic.Test.ShareFixtureAcrossTestClasses
{
	[CollectionDefinition("Customer")]
	public class CustomerFixtureCollection : ICollectionFixture<CustomerFixture>
	{
		
	}
}

