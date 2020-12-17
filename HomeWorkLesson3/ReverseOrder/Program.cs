using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter something : ");
            var someWord = Console.ReadLine();
            Char[] reverseArr = new char[someWord.Length];
            for (int i = 0; i < someWord.Length; i++)
            {
                reverseArr[i] = someWord[someWord.Length - i - 1];
            }
            Console.WriteLine(new string(reverseArr));
            Console.ReadKey();
        }
    }
}
