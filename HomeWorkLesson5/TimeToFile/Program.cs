using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToFile
{
    class Program
    {
        static readonly string textFileName = "startup.txt";
        static void Main()
        {
            File.AppendAllText(textFileName, DateTime.Now.ToString("HH:mm:ss"));
            File.AppendAllText(textFileName, Environment.NewLine);
        }
    }
}
