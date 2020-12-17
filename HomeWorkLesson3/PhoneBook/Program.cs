using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phoneBook = new string[5, 2];
            phoneBook[0, 0] = "Малкин";
            phoneBook[0, 1] = "89274444444 / malkinXXX@gmail.com";
            phoneBook[1, 0] = "Палкин";
            phoneBook[1, 1] = "89275555555 / palkinXXX@gmail.com";
            phoneBook[3, 0] = "Чалкин";
            phoneBook[3, 1] = "89277777777 / chalkinXXX@gmail.com";
            phoneBook[4, 0] = "Залкинд";
            phoneBook[4, 1] = "89278888888 / zalkindXXX@gmail.com";
            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                if (phoneBook[i, 0] != null)
                {
                    Console.WriteLine(phoneBook[i, 0] + "\t" +":" + "\t" + phoneBook[i, 1]);
                }
            }
            Console.ReadKey();
        }
    }
}
