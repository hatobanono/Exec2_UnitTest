using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Tests
{
	[TestClass()]
	public class TaiwanStockUtilityTests
	{
		[TestMethod()]
		public void IsTradingTimeTest()
		{
			var obj = new TaiwanStockUtility();
			DateTime dt1 = new DateTime(2022, 11, 1, 9, 0, 01);
			bool isTrade = obj.IsTradingTime(dt1);

			Assert.IsTrue(isTrade);
		}
	}
}