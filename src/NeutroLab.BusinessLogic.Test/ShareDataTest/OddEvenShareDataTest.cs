using System;
using System.Collections.Generic;

namespace NeutroLab.BusinessLogic.Test.ShareDataTest
{
	public static class OddEvenShareDataTest
	{
		public static IEnumerable<object[]> IsOddOrEvenData
		{
			get
			{
				yield return new object[] { 1, true };
				yield return new object[] { 200, false };
			}
		}
	}
}

