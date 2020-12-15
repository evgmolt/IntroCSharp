using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainyWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int m_jan = 1;
            int m_feb = 2;
            int m_dec = 12;
            Console.Write("Enter minimum temperature: ");
            int minTemp = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter maximum temperature: ");
            int maxTemp = Convert.ToInt16(Console.ReadLine());
            double averTemp = (minTemp + maxTemp) / 2;
            Console.Write("Enter the number of month: ");
            int numOfMonth = int.Parse(Console.ReadLine());
            var winter = new HashSet<int>() { m_jan, m_feb, m_dec };
            if (winter.Contains(numOfMonth) && averTemp > 0)
                Console.Write("Дождливая зима");
            Console.ReadKey();
        }
    }
}
