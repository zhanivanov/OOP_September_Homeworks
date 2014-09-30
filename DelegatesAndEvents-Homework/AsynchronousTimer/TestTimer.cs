using System;
using System.Threading;
using System.Timers;

public class Example
{
    public static void Main()
    {
        AsyncTimer currTimer = new AsyncTimer(PrintSth, 100, 100);
        currTimer.Run();
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Main program action!");
            Thread.Sleep(100);
        }
    }

    public static void PrintSth()
    {
        Console.WriteLine("Timer Tick");
    }
}