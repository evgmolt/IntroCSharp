using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.Write("Even number");
            else
                Console.Write("Odd number");
            Console.ReadKey();
        }
    }
}
