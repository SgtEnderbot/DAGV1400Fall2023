using System;
					
public class Program
{
	public static void Main()
	{
		string[] favoriteFood = {"savory", "dessert", "snack"};
		
        //Asks the user what their favorite foods are and stores the variables, then changes the appropriate spot in the array.
		Console.WriteLine("First, what's your favorite savory food?");
		string savory = Console.ReadLine();
		favoriteFood[0] = savory;
		
		Console.WriteLine("Now, what's your favorite dessert?");
		string dessert = Console.ReadLine();
		favoriteFood[1] = dessert;
		
		Console.WriteLine("Finally, what's your favorite snack?");
		string snack = Console.ReadLine();
		favoriteFood[2] = snack;
		

        //Prints the favorite foods.
		foreach (string i in favoriteFood)
		{
			Console.WriteLine("I love " + i);
		}
	}
}