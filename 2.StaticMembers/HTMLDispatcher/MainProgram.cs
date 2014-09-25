using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainProgram
{
    static void Main()
    {
        //ElementBuilder div = new ElementBuilder("div");
        //div.AddAttribute("id", "page");
        //div.AddAttribute("class", "big");
        //div.AddContent("<p>Hello</p>");
        //Console.WriteLine(div * 2);

        Console.WriteLine(HTMLDispatcher.CreateImage("https://www.google.bg/images/srpr/logo11w.png","google","search"));
        Console.WriteLine(HTMLDispatcher.CreateURL("https://www.google.bg/images/srpr/logo11w.png", "google", "search"));
        Console.WriteLine(HTMLDispatcher.CreateInput("submit", "google", "search"));
    }
}