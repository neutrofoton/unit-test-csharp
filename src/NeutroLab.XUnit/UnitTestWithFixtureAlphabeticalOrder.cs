using System;
using Xunit;
using Xunit.Abstractions;

namespace NeutroLab.XUnit
{
    [TestCaseOrderer("NeutroLab.XUnit.Order.AlphabeticalOrderer", "NeutroLab.XUnit")]
    public class UnitTestWithFixtureAlphabeticalOrder<TFixtureT> : UnitTestWithFixture<TFixtureT>
         where TFixtureT : TestFixture
    {
        public UnitTestWithFixtureAlphabeticalOrder(ITestOutputHelper output, TFixtureT fixture)
            : base(output,fixture)
        {
        }
    }
}
