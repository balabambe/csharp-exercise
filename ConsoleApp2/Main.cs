using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;


class MainClass
{
    static void Main(string[] args)
    {
        List<string> myClasses = new List<string>();
        myClasses.Add("Steps");
        myClasses.Add("WhileExercise");
        myClasses.Add("ConsoleInput");
        myClasses.Add("GuessNumberInRange");
        myClasses.Add("ArrayOrdering");
        myClasses.Add("LottoRandNum");

        int i = 0;
        foreach (string myClass in myClasses)
        {
            i++;
            var title = InvokeMyClass(myClass, "GetTitle");
            Console.WriteLine($"程式{i}: {title}");
        }
        Console.Write($"請輸入要執行的程式: ");

        string value = Console.ReadLine();
        int option;
        try
        {
            option = Convert.ToInt32(value);
            InvokeMyClass(myClasses[option - 1], "Run" +
                "31");
        }
        catch
        {
            return;
        }
    }

    static object InvokeMyClass(string className, string methodName)
    {
        Type t = Type.GetType(className);
        object o = Activator.CreateInstance(t);
        MethodInfo mi = t.GetMethod(methodName);
        return mi.Invoke(o, null);
    }
}
