using System;
using Xunit;
using Xunit.Abstractions;

namespace NeutroLab.XUnit
{
    [TestCaseOrderer("NeutroLab.XUnit.Order.AlphabeticalOrderer", "NeutroLab.XUnit")]
    public class UnitTestWithAlphabeticalOrder : UnitTest
    {
        public UnitTestWithAlphabeticalOrder(ITestOutputHelper output)
            : base(output)
        {
        }
    }
}
