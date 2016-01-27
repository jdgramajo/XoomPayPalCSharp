using System;

namespace XoomPayPalApplication
{
	public class XoomPayPal
	{

		public string evalNumber(int number)
		{
			string result = "";
			if (number % 3 == 0)
				result += "Xoom";
			if (number % 5 == 0)
				result += "PayPal";
			return result.Equals("") ? number.ToString() : result;
		}

		static void Main(string[] args) {
			if (args.Length < 1 || args.Length > 1 || Int32.Parse(args[0]) < 1) {
				Console.WriteLine("Usage: mono XoomPayPal.exe [Integer > 0]");
				return;
			}
			XoomPayPal xpp = new XoomPayPal();
			for(int i = 1 ; i <= Int32.Parse(args[0]) ; i++) {
				Console.WriteLine(xpp.evalNumber(i));
			}
		}
	}
}