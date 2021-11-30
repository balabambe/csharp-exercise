using System;

public class ConsoleInput
{

	public static string title = "Console Input 練習 ConsoleInput.cs";
	public static string GetTitle()
	{
		return title;
	}
	public static void Run()
	{
		InputLine();
	}
	
	static int InputLine()
    {
		int beginNumber = 1, endNumber = 99;
		Console.Write($"請輸入 {beginNumber} ~ {endNumber} 之間的數，惹輸入 x 表示結束: ");
		string value = Console.ReadLine();
		if (value == "x") return -1;
		return 1;
	}
}
