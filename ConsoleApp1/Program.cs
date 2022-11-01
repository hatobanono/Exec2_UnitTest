using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var obj = new TaiwanStockUtility();
			DateTime now = DateTime.Now;

			bool isTrade = obj.IsTradingTime(now);
			string result = isTrade ? "現在是交易時間" : "關門了88";
			Console.WriteLine(result);
		}
	}
}
