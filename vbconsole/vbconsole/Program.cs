using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vbconsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Druk op een toets om de applicatie te beïndigen...");
            Console.ReadKey();
        }
    }
}
