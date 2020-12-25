using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveToBinary
{
    class Program
    {
        static readonly char separator = ' ';
        static readonly string binFileName = "binfile.bin";
        static void Main()
        {
            Console.Write("Введите ряд целых чисел от 0 до 255, разделенных пробелами : ");
            string[] digitsStr = Console.ReadLine().Split(separator);
            List<byte> digits = new List<byte>();
            for (int i = 0; i < digitsStr.Length; i++)
            {
                 if (Int32.TryParse(digitsStr[i], out int res))
                     digits.Add((byte)res);
            }
            File.WriteAllBytes(binFileName, digits.ToArray());
        }
    }
}
