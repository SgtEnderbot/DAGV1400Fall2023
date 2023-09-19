using System;
					
public class Program
{
	public static void Main()
	{
		//These two lines grab user input to figure out how big to make the pyramid.

		Console.WriteLine("How big do you want the pyramid? Type a number between 1 and 9.");
		int answer = Convert.ToInt32(Console.ReadLine());
	
		//Here is the pyramid array.
        
		int[] pyramid = {1, 22, 333, 4444, 55555, 666666, 7777777, 88888888, 999999999};
		
		//Here is the little bit of code that actually makes the pyramid.
        
		int i = 0;
		while (i < answer)
		{
			Console.WriteLine(pyramid[i]);
			i++;
		}
	}
}