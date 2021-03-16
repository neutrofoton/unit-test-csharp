using System;
using Xunit;
using Xunit.Abstractions;

namespace NeutroLab.XUnit
{
    [TestCaseOrderer("NeutroLab.XUnit.Order.NumericOrderer", "NeutroLab.XUnit")]
    public class UnitTestWithNumericOrder : UnitTest
    {
        public UnitTestWithNumericOrder(ITestOutputHelper output)
            : base(output)
        {
        }
    }
}
