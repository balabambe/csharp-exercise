using System;

namespace ConsoleApp2
{

	 class WhileExercise
	 {
		public static void Divisor()
		{
			int number = 300;
			int i = 0;
			while (i <= number)
            {
				i++;
				if (number % i == 0) {
                    Console.Write($"{i}{(i == number ? "。" : "、")}");
                }
            }
		}
	 }

}