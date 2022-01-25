using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("Write something to the output window...");
            Console.WriteLine("Hello World");
            Console.WriteLine("Program has finished. Press enter to quit.", Color.Aquamarine);
            Console.ReadKey();

        }
    }
}
