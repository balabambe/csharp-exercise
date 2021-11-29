using System;

public class GuessNumberInRange
{
    public static string title = "猜數字 GuessNumberInRange.cs";
    public static string getTitle()
    {
        return title;
    }

    public static void Go()
	{
        Console.Write($"請輸入起始數字[1]: ");
        int beginNumber = setNumber(1);
        Console.Write($"請輸入結束數字[99]: ");
        int endNumber = setNumber(99);
        int target = GetTargetNumber(beginNumber, endNumber);
        while (true)
        {
			int input = GetInputNumber(beginNumber, endNumber);
			if (input == -1) return;
            if (input == target)
            {
                Console.WriteLine("答對了!");
                return;
            }
            if (input < target)
            {
                beginNumber = input;
            }
            if (input > target)
            {
                endNumber = input;
            }
            Console.WriteLine("答錯了...");
        }
    }

    private static int setNumber(int defaultNumber)
    {
        try
        {
            string number = Console.ReadLine();
            return Convert.ToInt32(number);
        } catch
        {
            return defaultNumber;
        }
    }

	private static int GetTargetNumber(int beginNumber, int endNumber)
    {
		Random rand = new Random(Guid.NewGuid().GetHashCode());
		return rand.Next(beginNumber, endNumber);
    }

	private static int GetInputNumber(int beginNumber, int endNumber)
    {
        Console.Write($"請輸入 {beginNumber} ~ {endNumber} 之間的數字，輸入 x 結束程式: ");
		string value = Console.ReadLine();
        int input;
        while(true)
        {
            try
            {
                input = Convert.ToInt32(value);
                if (input <= beginNumber || endNumber <= input)
                {
                    return GetInputNumber(beginNumber, endNumber);
                }
            } catch
            {
                if (value == "x") return -1;
                return GetInputNumber(beginNumber, endNumber);
            }

            return input;
        }
    }
}
