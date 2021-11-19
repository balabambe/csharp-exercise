using System;

namespace ConsoleApp2
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"程式1: 計算階梯的高度 Steps.cs");
            Console.WriteLine($"程式2: 找出 300 的公因數 WhileExercise.cs");
            Console.WriteLine($"程式3: ConsoleInput.cs");
            Console.WriteLine($"程式4: 猜數字");
            Console.Write($"請輸入要執行的程式: ");
            string value = Console.ReadLine();
            switch(value)
            {
                case "1":
                    Steps.MainStep();
                    break;
                case "2":
                    WhileExercise.Divisor();
                    break;
                case "3":
                    ConsoleInput.Input();
                    break;
                case "4":
                    GuessNumberInRange.Input();
                    break;
            }
        }
    }
}
