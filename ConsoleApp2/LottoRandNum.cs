using System;

class LottoRandNum
{
    public static string title = "樂透開獎練習 LottoRandNum.cs";
    public static string GetTitle()
    {
        return title;
    }

    public static void Run()
    {
        M1();
        M2();
    }

    static void M2()
    {
        DisplayHeader("M2");
        int[] result = new int[6];
        //todo

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
    static void M1()
    {
        DisplayHeader("M1");

        int[] items = SetUpNumbers();
        int[] result = Shuffle(items);

        for(int i=0; i<6; i++)
        {
            Console.WriteLine(result[i]);
        }

    }
    private static int[] Shuffle(int[] items)
    {
        //todo
        throw new NotImplementedException();
    }
    private static int[] SetUpNumbers()
    {
        //todo
        throw new NotImplementedException();
    }
    static void DisplayHeader(string title)
    {
        Console.WriteLine("\r\n");
        Console.WriteLine(title);
        Console.WriteLine(new string('=', 40));
    }
}

