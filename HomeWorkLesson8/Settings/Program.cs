using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settings
{
    class Program
    {
        static readonly ConsoleKey keyClear = ConsoleKey.C;
        static void Main()
        {
            if (Properties.Settings.Default.Name == String.Empty)
            {
                Properties.Settings.Default.Name = GetName();
                Properties.Settings.Default.Age = GetAge();
                Console.Write("Enter type of activity : ");
                Properties.Settings.Default.TypeOfActivity = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            else
            {
                Console.WriteLine($"Name : \t\t\t{Properties.Settings.Default.Name}");
                Console.WriteLine($"Age : \t\t\t{Properties.Settings.Default.Age}");
                Console.WriteLine($"Type of activity : \t{Properties.Settings.Default.TypeOfActivity}\n");
                Console.WriteLine("Press [Shift + C] to clear or any other key to quit.");
                ConsoleKeyInfo cki = Console.ReadKey();
                if (cki.Key == keyClear & cki.Modifiers == ConsoleModifiers.Shift)
                {
                    Properties.Settings.Default.Name = String.Empty;
                    Properties.Settings.Default.Age = 0;
                    Properties.Settings.Default.TypeOfActivity = String.Empty;
                    Properties.Settings.Default.Save();
                }
            }
        }

        static string GetName()
        {
            string s = String.Empty;
            while (s == String.Empty)
            {
                Console.Write("Enter Name : ");
                s = Console.ReadLine();
            }
            return s;
        }

        static byte GetAge()
        {
            byte age;
            do
            {
                Console.Write("Enter age : ");
            }
            while (!Byte.TryParse(Console.ReadLine(), out age));
            return age;
        }
    }
}
