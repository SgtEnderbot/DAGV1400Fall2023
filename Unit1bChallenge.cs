using System;

public class Program
{
	public void Main()
	{
        //This is the temperature function.

		int currentTemp = 40;
		
		if (currentTemp >= 30)
			Console.WriteLine("Stay hydrated, and don't spend too much time in the sun.");
		else if (currentTemp >= 20)
			Console.WriteLine("Enjoy the nice weather!");
		else if (currentTemp >= 10)
			Console.WriteLine("Consider wearing a light jacket today.");
		else if (currentTemp < 10)
			Console.WriteLine("Stay warm! Wear warm clothing and enjoy some hot chocolate.");
		
        //This is all the stuff for the test score function, with added messages focust on the subject.

		int testScore = 77;
		string subject = "Science";
		
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
		
		switch(subject)
		{
			case "Math":
				Console.WriteLine("Keep up the hard work and always remember those equations!");
				break;
			case "Science":
				Console.WriteLine("Keep working hard and soon you'll find the science field you want!");
				break;
			case "English":
				Console.WriteLine("Looks like some day you'll be an author!");
				break;
			case "Art":
				Console.WriteLine("An artist at work! Keep up those grades!");
				break;
			case "Music":
				Console.WriteLine("Keep it up! Soon you'll be performing like a star!");
				break;
			case "History":
				Console.WriteLine("You already know so much about history, why give up? Keep going!");
				break;
		}
	}
}