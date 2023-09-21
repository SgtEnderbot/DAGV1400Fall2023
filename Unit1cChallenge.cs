using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Let's play a guessing game. Guess a number between 1 and 10.");
		
        int attempts = 0;

        Random computerGuesser = new Random();
        int value = computerGuesser.Next(1, 11);
		
		Console.WriteLine(value);
		int humanGuess = 99;

		do
		{
			humanGuess = Convert.ToInt32(Console.ReadLine());
			
			attempts ++;
			
			if (humanGuess == value)
			{
				Console.WriteLine("Well done, you guessed right! That took " + attempts + " attempts.");
				break;
			}
			else if (humanGuess > value)
			{
				Console.WriteLine("Too high. Guess again.");
			}
			else if (humanGuess < value)
			{
				Console.WriteLine("Too low. Guess again.");
			}
		}
		while (value != humanGuess);    
    }
}