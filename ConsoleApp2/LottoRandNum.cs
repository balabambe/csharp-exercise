using System;
using System.Collections.Generic;

class LottoRandNum
{
    public static string title = "樂透開獎練習 LottoRandNum.cs";
    public static string GetTitle()
    {
        return title;
    }

    public static void Run()
    {
        List<int> lottos = M1();
        DisplayHeader("Lotto Numbers:");
        foreach (var item in lottos)
        {
            Console.WriteLine(item);
        }
    }

    static List<int> M1()
    {
        List<int> items = SetUpNumbers();
        List<int> result = Shuffle(items);
        List<int> numbers = new List<int> { };
        for(int i=0; i<6; i++)
        {
            numbers.Add(result[i]);
        }
        return numbers;

    }
    private static List<int> Shuffle(List<int> items)
    {
        Random rand = new Random();
        int leng = items.Count - 1;
        int temp;
        for (int i = leng; i > 0; i--)
        {
            int randNum = rand.Next(0, i + 1);
            temp = items[i];
            items[i] = items[randNum];
            items[randNum] = temp;
        }
        return items;
    }
    private static List<int> SetUpNumbers()
    {
        List<int> numbers = new List<int> { };
        for(var i = 1; i <= 42; i++)
        {
            numbers.Add(i);
        }
        return numbers;
    }
    static void DisplayHeader(string title)
    {
        Console.WriteLine("\r\n");
        Console.WriteLine(title);
        Console.WriteLine(new string('=', 40));
    }
}

