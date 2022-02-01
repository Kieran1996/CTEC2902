using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;
using System.Configuration;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiredMessage = ConfigurationManager.AppSettings["tiredMessage"];
            Console.WriteLine(tiredMessage);

            string greeting = Properties.Settings.Default.GreetingMessage;
            Console.WriteLine(greeting);

            bool inAGoodMood = Properties.Settings.Default.InAGoodMood;
            Console.WriteLine(inAGoodMood);

            string angryMessage = Properties.Settings.Default.AngryMessage;
            Console.WriteLine(angryMessage);

            Debug.WriteLine("Write something to the output window...");
            Console.WriteLine("Hello World");
            Console.WriteLine("Program has finished. Press enter to quit.", Color.Aquamarine);
            Console.ReadKey();
            

        }
    }
}
