using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveToTextFile
{
    class Program
    {
        static readonly string quitStr = "QUIT";
        static readonly string textFileName = "textfile.txt";
        static void Main()
        {
            do
            {
                Console.Write("Enter something, 'Ouit' for exit : ");
                string enterStr = Console.ReadLine();
                if (enterStr.ToUpper() == quitStr) return;
                File.AppendAllText(textFileName, enterStr);
                File.AppendAllText(textFileName, Environment.NewLine);
            }
            while (true);
        }
    }
}
