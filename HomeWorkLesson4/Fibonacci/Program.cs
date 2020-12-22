using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static int numOfCalls;
        static long Fib(int n)
        {
            numOfCalls++;
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        static void Main()
        {
            Console.Write("Введите число : ");
            if (!Int32.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Ошибка ввода. Введите число.");
                Console.ReadKey();
                return;
            };
            numOfCalls = 0;
            Console.WriteLine($"Число Фибоначчи для {num} : {Fib(num)}");
            Console.WriteLine($"Число рекурсивных вызовов : {numOfCalls}");
            Console.ReadKey();
        }
    }
}
