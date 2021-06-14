using System;

namespace tutorial
{
    class Program
    {
        static void Main(string[] args)
		{
			bool playAgain = true;
			while (playAgain)
			{
				playAgain = playGame();
				Console.WriteLine();
			}
		}

		public static bool playGame()
		{
			Console.Clear();
			Console.WriteLine("Lets Play a Game");

			Console.Write("Pick a Number at Random: ");
			string pickNumber = Console.ReadLine();

			ifStatement(pickNumber);
			Console.Write("Do you want to play again [y/n]? ");
			string yesNo = Console.ReadLine();

			if (yesNo == "y" || yesNo == "Y") return true;
			else if (yesNo == "n" || yesNo == "N") return false;

			else
			{
				return true;
			}
		}

		private static void ifStatement(string number)
		{
			Console.Clear();
			string message = "";
			Random random = new Random();
			int randomNum = random.Next(1, 3);
			string RandomToString = randomNum.ToString();

			if (number == RandomToString)
			{
				message = "You Won, proceed to pick a number for your gift";
				Console.WriteLine(message);

                Console.Write("Pick a letter: ");
                string pickLetter = Console.ReadLine();

                string callingGiftBox = giftBox(pickLetter);
                Console.WriteLine(callingGiftBox);
                Console.ReadLine();

            }
			else
			{
				message = "Try again next time";
				Console.WriteLine(message);
			}
		}

		private static string giftBox(string letter)
		{
			Console.Clear();
			string message = "";
			if (letter == "a" || letter == "f" || letter == "y")
			{
				message = "Congratulations You won yourself a car";
				return message;
			}
			else
			{
				message = "You are almost there, better luck next time";
				return message;
			}

		}
	}
}
