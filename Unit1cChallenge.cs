using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Let's play a guessing game. Guess a number between 1 and 10.");
		
        //Here's the int that counts your attempts.
        int attempts = 0;

        //This is where the computer picks a number.
        Random computerGuesser = new Random();
        int value = computerGuesser.Next(1, 11);
		
		//This is simply to predefine the guess so it can be in this context.
		int humanGuess = 99;

		do
		{
            //Prompts user for a guess.
			humanGuess = Convert.ToInt32(Console.ReadLine());
			
            //Adds to the attempts.
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
        //Re-loops if the guess was incorrect.
		while (value != humanGuess);    
    }
}