using System;
using System.Linq;

namespace ExtensionMethods
{
	public static class ExtensionMethods
	{
		public static double ToDouble(this string input)
		{
			if (double.TryParse(input, out double output))
				return output;
			else
				throw new Exception();
		}

		public static string GetOnlyNumbersFromString(this string input)
		{
			if (string.IsNullOrEmpty(input))
				return "";
			return new String(input.Where(Char.IsDigit).ToArray());
		}

		public static bool IsBetweenDate(this DateTime inputDate, DateTime fromDate, DateTime toDate)
		{
			return inputDate.Date >= fromDate.Date && inputDate.Date <= toDate.Date;
		}
	}
}
