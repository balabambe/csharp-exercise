using System;
using System.Collections.Generic;

class ReverseLetters
{
    public static string title = "字母順序顛倒 ReverseLetters.cs";
    public static string GetTitle()
    {
        return title;
    }

    public static void Run()
    {
        Console.Write("請輸入一串字串：");
        string source = Console.ReadLine();
        string result = Reverse(source);
        Console.WriteLine(result);
    }

    static string Reverse(string source)
    {
        int len = source.Length;
        List<char> stringToIntList = new List<char>{ };
        for (int i = len - 1; i >= 0; i--)
        {
            char letter = source[i];
            stringToIntList.Add(letter);
        }
        return String.Join("", stringToIntList);
    }

}
