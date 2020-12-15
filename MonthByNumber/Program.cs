using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthByNumber
{
    class Program
    {
        enum NMonth
        {
            January,
            February,
            Marth,
            April,
            May,
            June,
            July,
            August,
            October,
            November,
            December
        }


        static void Main(string[] args)
        {
            Console.Write("Enter the number of month: ");
            int numOfMonth = int.Parse(Console.ReadLine());
            if (numOfMonth < 1 || numOfMonth > 12)
            {
                Console.Write("Wrong number");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine((NMonth)numOfMonth - 1);
                //или так можно
                DateTime newDate = new DateTime(DateTime.Now.Year, numOfMonth, 1);
                Console.WriteLine(newDate.ToString("MMMM"));
                
                Console.ReadKey();
            }
        }
    }
}
