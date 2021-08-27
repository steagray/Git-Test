using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rand = new Random();
			Console.Write("Select a maximum number: ");
			int maxRandom = Convert.ToInt32(Console.ReadLine()); //the highest number that can be selected
			
			int minRandom; //the lowest number that can be selected
			do
			{
				Console.Write("Select a minimum number: ");
				minRandom = Convert.ToInt32(Console.ReadLine());
				if (minRandom > maxRandom)
				{
					Console.WriteLine("Minimum number must be less than or equal to the maximum number");
				}
			} while (minRandom > maxRandom); //guarantees that the min is lower than the max
			int randNum = rand.Next(minRandom, maxRandom + 1); //generates a random integer from minRandom to maxRandom
			int userGuess = minRandom - 1; //initializes userGuess to an answer that is impossible to be correct
			Console.WriteLine(String.Format("Random Number Generated from {0} to {1}!", minRandom, maxRandom));
			int attemptCount = 0;

			while (userGuess != randNum)
			{
				Console.Write("Select a number: ");
				userGuess = Convert.ToInt32(Console.ReadLine());

				if (userGuess > randNum)
				{
					Console.WriteLine(String.Format("{0} is too high!", userGuess));
				}
				if (userGuess < randNum)
				{
					Console.WriteLine(String.Format("{0} is too low!", userGuess));
				}

				attemptCount++;
			}

			Console.WriteLine(String.Format("It took you {0} attempts!", attemptCount));

		}
	}
}
