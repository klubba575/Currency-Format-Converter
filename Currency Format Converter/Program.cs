using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Currency_Format_Converter
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello there, we are going to have some fun with currency!  Please Enter a random dollar amount without the $ sign!");
			string userInput1 = Console.ReadLine();

			Console.WriteLine("Thanks, now please enter a second random dollar amount without the $ sign.");
			string userInput2 = Console.ReadLine();

			Console.WriteLine("Awesome, now enter a final random dollar amount without the $ sign! ");
			string userInput3 = Console.ReadLine();

			double firstNumber = Convert.ToDouble(userInput1);
			double secondNumber = Convert.ToDouble(userInput2);
			double thirdNumber = Convert.ToDouble(userInput3);

			double total = (firstNumber + secondNumber + thirdNumber);
			double average = Math.Round((total / 3), 2, MidpointRounding.AwayFromZero);

			List<double> inputNumbers = new List<double> { firstNumber, secondNumber, thirdNumber };
			double lowNumber = inputNumbers.Min();
			double highNumber = inputNumbers.Max();

			Console.WriteLine("The average amount of all 3 random dollar amounts is $" + average + ".");
			Console.WriteLine("The lowest of the three dollar amounts is $" + lowNumber + ".");
			Console.WriteLine("The highest of the three dollar amounts is $" + highNumber + ".");
			Console.WriteLine("The total amount of all 3 random dollar amounts is $" + total + ".");

			string totalCurrency = Convert.ToString(total);

			string moneySweden = total.ToString("C", CultureInfo.GetCultureInfo("sv-SE"));
			string moneyThai = total.ToString("C", CultureInfo.GetCultureInfo("th-TH"));
			string moneyJapan = total.ToString("C", CultureInfo.GetCultureInfo("ja-JP"));

			Console.WriteLine(" This is the total of the three random dollar amounts in Swedish Krona. " + moneySweden);
			Console.WriteLine(" This is the total of the three random dollar amounts in Thai Baht. " + moneyThai);
			Console.WriteLine(" This is the total of the three random dollar amounts in Japanese Yen. " + moneyJapan);

			Console.ReadLine();
		}

	}
}
