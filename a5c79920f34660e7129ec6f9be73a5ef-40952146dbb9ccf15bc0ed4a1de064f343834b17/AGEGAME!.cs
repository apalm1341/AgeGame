using System;

namespace GuessingGame
{
	class MainClass
	{
		public static void Main(string[] args)		//this is a method called "Main". It is called when the program starts!!!
		{
			Start: //start statement
			Console.WriteLine("Hello World!");
			Console.WriteLine("Let's play a guessing game!Press Enter to start or ctr C!");//
			Console.ReadLine(); //keeps console window open (does not shut it right away!) unless you press enter!!!
			Console.WriteLine("How many fingers am I holding up? Type in a whole number!");
			int number = Convert.ToInt32(Console.ReadLine());
			if (number <= 3)

			{

				Console.WriteLine("You guessed correctly!!!. Press Enter!");
				Console.ReadLine(); //keeps console window open after user presses enter!!!
				Console.WriteLine("Would you like to play again? If so, click Enter!");
				/*line = Console.ReadLine().ToLower();
				if (line == "q" || line == "quit")
				{
					break;
				}*/
				Console.ReadLine(); //keeps console window open after user presses enter!!!BUT ALSO-->MOST IMPORTANTLY-->THIS BEING PLACED HERE ALLOWS USER TO CLICK ENTER IN ORDER TO START OVER GAME!!!
				goto Start; //Jumps to "Start:".  --> THIS IS LIKE A LOOP....NOTE: goto's are outdated and not something that should be used outside of this particular challenge.
							//I have done this so that I did not have to use loops or methods right now!!!
			}//

			if (number > 3)
			{

				Console.WriteLine("You guessed wrong!!!. Press Enter!");
				Console.ReadLine(); //keeps console window open after user presses enter!!!
				Console.WriteLine("Would you like to play again? If so, click Enter!");
				Console.ReadLine(); //keeps console window open after user presses enter!!!BUT ALSO-->MOST IMPORTANTLY-->THIS BEING PLACED HERE ALLOWS USER TO CLICK ENTER IN ORDER TO START OVER GAME!!!
				goto Start; //Jumps to "Start:".  --> THIS IS LIKE A LOOP....NOTE: goto's are outdated and not something that should be used outside of this particular challenge.
							//I have done this so that I did not have to use loops or methods right now!!!
			}
		
		
		}



	}
}
