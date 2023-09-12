using System;

public class Program
{
	public void Main()
	{
        //This is the temperature if statement.
		int currentTemp = 40;
		if (currentTemp > 30)
			Console.WriteLine("Stay hydrated, and don't spend too much time in the sun.");
		else
			Console.WriteLine("Enjoy the nice weather!");
		
        //This is the test if statement.
		int testScore = 90;
		if (testScore > 100)
			Console.WriteLine("That's impossible!");
		else if (testScore >= 90)
			Console.WriteLine("Your grade: A");
		else if (testScore >= 80)
			Console.WriteLine("Your grade: B.");
		else if (testScore >= 70)
			Console.WriteLine("Your grade: C.");
		else if (testScore >= 60)
			Console.WriteLine("Your grade: D.");
		else if (testScore <= 50)
			Console.WriteLine("Your grade: F.");
	}
}