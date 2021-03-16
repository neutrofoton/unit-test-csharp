using System;
using Xunit;
using Xunit.Abstractions;

namespace NeutroLab.XUnit
{
    public abstract class UnitTestWithFixture<TFixture> : UnitTest, IClassFixture<TFixture>
        where TFixture : TestFixture
    {
        protected TFixture fixture;

        public UnitTestWithFixture(ITestOutputHelper output, TFixture fixture)
            : base(output)
        {
            if (null == fixture)
                throw new ArgumentNullException("fixture");

            this.fixture = fixture;

        }
    }
}
