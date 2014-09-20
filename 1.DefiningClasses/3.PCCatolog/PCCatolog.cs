using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Text;

class PCCatolog
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg-BG");
        Component motherboard = new Component("ASUS X70S", 450);
        Component processor = new Component("Intel i7 4900K", 1600);
        Component graphicsCard = new Component("AMD Radeon HD 9800", 7600);
        Component RAM = new Component("32 GB Corsair DDR3", 400);
        Component HDD = new Component("2TB 7200rpm", 370);
        Computer myPC = new Computer("Alienware X70", new List<Component>() { motherboard, processor, graphicsCard, RAM, HDD });
        myPC.PrintInfo();
    }
}