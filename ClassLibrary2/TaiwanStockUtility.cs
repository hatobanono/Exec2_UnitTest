using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
	public class TaiwanStockUtility
	{
		public bool IsTradingTime(DateTime dt)
		{
			int wod = (int)dt.DayOfWeek;
			if (wod >= 1 && wod <= 5)
			{
				DateTime beginTime = new DateTime(dt.Year, dt.Month, dt.Day, 9, 0, 0);
				TimeSpan ts = dt - beginTime;
				if (ts.TotalHours >= 0 && ts.TotalHours <= 4.5)
				{
					return true;
				}
			}
			return false;
		}
	}
}
