using System;
using Xunit.Abstractions;

namespace NeutroLab.XUnit
{
    public class UnitTest
    {
        protected ITestOutputHelper Output { get; private set; }

        public UnitTest(ITestOutputHelper output)
        {
            if (null == output)
                throw new ArgumentNullException("output");

            this.Output = output;
        }
    }
}
