﻿using System;
using NeutroLab.BusinessLogic.Test.ShareDataTest;
using Xunit;
using Xunit.Abstractions;

namespace NeutroLab.BusinessLogic.Test
{
	public class CalculatorFixture : IDisposable
	{
      
        public Calculator Calc => new Calculator();
        public int Random = new Random((int)DateTime.Now.Ticks).Next();

       
      
        public void Dispose()
        {
        }
    }

    public class CalculatorTest : IClassFixture<CalculatorFixture>, IDisposable
	{
		private readonly ITestOutputHelper testOutputHelper;
		private readonly CalculatorFixture calculatorFixture;


        public CalculatorTest(ITestOutputHelper testOutputHelper, CalculatorFixture calculatorFixture)
		{
			this.testOutputHelper = testOutputHelper;
			this.calculatorFixture = calculatorFixture;

            this.testOutputHelper.WriteLine("Constructor CalculatorTest is called");
            
        }

        [Fact]
        public void Fibo_Does_Not_Contain_Zero_Test()
        {
			var calc = calculatorFixture.Calc;
            Assert.DoesNotContain(0, calc.FiboNumbers);

            int localRandom = new Random((int)DateTime.Now.Ticks).Next();
            this.testOutputHelper.WriteLine($"CalculatorFixture random ={calculatorFixture.Random}" );
            this.testOutputHelper.WriteLine($"Local random ={localRandom}");
        }

        [Fact]
        public void Fibo_Does_Contain_13_Test()
        {
            var calc = calculatorFixture.Calc;
            Assert.Contains(13, calc.FiboNumbers);

            int localRandom = new Random((int)DateTime.Now.Ticks).Next();
            this.testOutputHelper.WriteLine($"CalculatorFixture random ={calculatorFixture.Random}");
            this.testOutputHelper.WriteLine($"Local random ={localRandom}");
        }

        [Theory]
        [InlineData(9, true)]
        [InlineData(100, false)]
        public void Odd_And_Even_Test(int value, bool expected)
        {
            var calc = calculatorFixture.Calc;
            bool actual = calc.IsOdd(value);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(OddEvenShareDataTest.IsOddOrEvenData),MemberType =typeof(OddEvenShareDataTest))]
        public void Odd_And_Even_Test_Shared_Data(int value, bool expected)
        {
            var calc = calculatorFixture.Calc;
            bool actual = calc.IsOdd(value);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [IsOddOrEvenData]
        public void Odd_And_Even_Test_Shared_Data_Custom_Attribute(int value, bool expected)
        {
            var calc = calculatorFixture.Calc;
            bool actual = calc.IsOdd(value);

            Assert.Equal(expected, actual);
        }

        public void Dispose()
        {
            this.testOutputHelper.WriteLine("CalculatorTest -> Dispose is called");
        }
    }
}

