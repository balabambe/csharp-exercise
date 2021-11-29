using System;

class WhileExercise
{
	public static string title = "找出 300 的公因數 WhileExercise.cs";
	public static string getTitle()
	{
		return title;
	}
	public static void Go()
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
