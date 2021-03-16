using System;
using NeutroLab.XUnit.Order;
using Xunit;
using Xunit.Abstractions;

namespace NeutroLab.XUnit
{
    [TestCaseOrderer("NeutroLab.XUnit.Order.NumericOrderer", "NeutroLab.XUnit")]
    public class UnitTestWithFixtureNumericOrder<TFixture> : UnitTestWithFixture<TFixture>
         where TFixture : TestFixture
    {
        public UnitTestWithFixtureNumericOrder(ITestOutputHelper output, TFixture fixture)
            : base(output, fixture)
        {
        }
    }
}
