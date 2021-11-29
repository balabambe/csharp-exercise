using System;

public class ArrayOrdering
{
	public static string title = "陣列值排序 ArrayOrdering.cs";
    public static string getTitle()
    {
        return title;
    }
    public static void Go()
	{
		int[] array = { 5, 6, 2, 99, 1, 108, 12 };
		foreach (int item in array)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(array.ToString());
	}
}
