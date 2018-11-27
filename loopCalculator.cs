using System;

public class LoopCalculator
{
	public static void Main()
	{
		string stringNumber;
		int number = 0;
		int sum = 0;

		while(number < 999)
		{
			Console.Out.Write("Enter a whole number. ");
			stringNumber = Console.ReadLine();
			number = Convert.ToInt32(stringNumber);

			if (number < 999)
				sum = sum + number;
		}

		Console.Out.Write(sum);	
	}
}