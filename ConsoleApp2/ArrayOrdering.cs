using System;
using System.Collections.Generic;

public class ArrayOrdering
{
	public static string title = "陣列值排序 ArrayOrdering.cs";
    public static string GetTitle()
    {
        return title;
    }
    public static void Run()
	{
        List<int> numbers = inputNumbers();

        if (numbers.Count == 0)
        {
            Console.WriteLine("沒有數字可以排序。");
            return;
        }

        Console.WriteLine("排序前：[{0}]", string.Join(", ", numbers));
        int swapCount;
        do
        {
            swapCount = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == (numbers.Count - 1))
                {
                    break;
                }
                if (numbers[i] > numbers[i + 1])
                {
                    int swapNumber = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = swapNumber;
                    swapCount++;
                }
            }
        } while (swapCount != 0);
        Console.WriteLine("排序後：[{0}]", string.Join(", ", numbers));
	}

    private static List<int> inputNumbers()
    {
        List<int> numbers = new List<int> { };

        while (true)
        {
            try
            {
                Console.Write($"請輸入數字[{string.Join(", ", numbers)}]：");
                string inputNumber = Console.ReadLine();
                int value = Convert.ToInt32(inputNumber);
                numbers.Add(value);
            }
            catch {
                break;
            }
        }


        return numbers;
    }
}
