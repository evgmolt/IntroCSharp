using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            DateTime datetoday = DateTime.Now;
            Console.WriteLine($"Hello, {name}, today "+datetoday.ToShortDateString());
            Console.ReadKey();
        }
    }
}
