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
        string source = "ABCDEFG";
        string result = Reverse(source);
        Console.WriteLine(result);
    }

    static string Reverse(string source)
    {
        int len = source.Length;
        List<int> stringToIntList = new List<int>{ };
        List<char> intListToString = new List<char>{ };
        for (int i = 0; i < len; i++)
        {
            int letter = source[i];
            stringToIntList.Add(letter);
        }
        SwapNumbers(stringToIntList);
        for (int i = 0; i < stringToIntList.Count; i++)
        {
            intListToString.Add((char)stringToIntList[i]);
        }
        return String.Join("", intListToString.ToArray());
    }

    static void SwapNumbers(List<int> num)
    {
        int len = num.Count;
        bool swaped;
        do
        {
            swaped = false;
            for (int i = 0; i < len; i++)
            {
                if (i == len - 1)
                {
                    break;
                }
                if (num[i] < num[i + 1])
                {
                    int temp = num[i];
                    num[i] = num[i + 1];
                    num[i + 1] = temp;
                    swaped = true;
                }
            }
        } while (swaped);
    }
}
