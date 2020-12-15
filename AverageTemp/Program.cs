using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter minimum temperature: ");
            int minTemp = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter maximum temperature: ");
            int maxTemp = Convert.ToInt16(Console.ReadLine());
            double averTemp = (minTemp + maxTemp) / 2;
            Console.Write("Average temperature: {0:0.0}", averTemp);
            Console.ReadKey();
        }
    }
}
