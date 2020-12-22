using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFullName
{
    class Program
    {
        static string[,] peoples = new string[,] {{ "Сергей", "Сергеев", "Сергеевич" },
                                                  { "Иван", "Иванов", "Иванович" },
                                                  { "Петр", "Петров", "Петрович" },
                                                  { "Григорий", "Григорьев", "Григорьевич" } };
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return lastName + " " + firstName + " " + patronymic;
        }
        static void Main()
        {
            for (int i = 0; i < peoples.GetLength(0); i++)
                Console.WriteLine(GetFullName(peoples[i, 0], peoples[i, 1], peoples[i, 2]));
            Console.ReadKey();
        }
    }
}
