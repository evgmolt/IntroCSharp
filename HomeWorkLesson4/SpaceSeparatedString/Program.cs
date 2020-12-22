using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceSeparatedString
{
    class Program
    {
        static readonly char separator = ' ';
        static readonly string errorStr = "Ошибка преобразования строки в число";
        static void Main()
        {
            Console.Write("Введите ряд целых чисел, разделенных пробелами : ");
            string enterString = Console.ReadLine();
            enterString = enterString.Trim(separator);
            string enterStringForSplit = enterString;
            int sum = 0;
            string subStr;
            int res;
            int err = 0;
            if (enterString.IndexOf(separator) >= 0)
            do
            {
                subStr = enterString.Substring(0, enterString.IndexOf(separator));
                subStr = subStr.Trim(separator);
                if (Int32.TryParse(subStr, out res))
                    sum += res;
                else
                    err++;
                enterString = enterString.Substring(enterString.IndexOf(separator) + 1);
                enterString = enterString.Trim(separator);
            }
            while (enterString.IndexOf(separator) != -1);
            if (Int32.TryParse(enterString, out res))
                sum += res;
            else
                err++;
            if (err > 0)
            {
                Console.WriteLine(errorStr);
                Console.ReadKey();
                return;
            }
            Console.WriteLine($"Сумма введенных чисел : {sum}");

            //Но проще, конечно, так

            string[] digits = enterStringForSplit.Split(separator);
            sum = 0;
            err = 0;
            for (int i = 0; i < digits.Length; i++)
            if (digits[i] != string.Empty)
            {
                if (Int32.TryParse(digits[i], out res))
                    sum += res;
                else
                    err++;
            }
            if (err > 0)
            {
                Console.WriteLine(errorStr);
                Console.ReadKey();
                return;
            }
            Console.WriteLine($"Сумма введенных чисел (split) : {sum}");
            Console.ReadKey();
        }
    }
}
