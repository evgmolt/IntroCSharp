using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seasons
{
    class Program
    {
        public enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }

        static Seasons GetSeason(int month)
        {
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    return (Seasons)0;
                case 3:
                case 4:
                case 5:
                    return (Seasons)1;
                case 6:
                case 7:
                case 8:
                    return (Seasons)2;
                default:
                    return (Seasons)3;
            }
        }

        static string GetSeasonName(Seasons season)
        {
            string[] rusNames = { "Зима", "Весна", "Лето", "Осень" };
            return rusNames[(int)season];
        }

        static void Main()
        {
            Console.Write("Введите номер месяца : ");
            if (!Int32.TryParse(Console.ReadLine(), out int num) || num < 1 || num > 12)
            {
                Console.WriteLine("Ошибка ввода. Введите число от 1 до 12");
                Console.ReadKey();
                return;
            };
            Console.WriteLine("Время года : " + GetSeasonName(GetSeason(num)));
            Console.ReadKey();
        }
    }
}
