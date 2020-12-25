using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathToTextFile
{
    class Program
    {
        static readonly string pathFileName = "pathfile.txt";
        static void Main()
        {
            List<string> TextForSave = new List<string>();
            File.Delete(pathFileName);
            Console.Write("Enter path : ");
            string pathStr = Console.ReadLine();
            System.IO.DirectoryInfo pathDI = new DirectoryInfo(pathStr);
            TextForSave.Add("Без рекурсии");
            GetDirectoryTree(pathDI, false, TextForSave);
            TextForSave.Add("С рекурсей");
            GetDirectoryTree(pathDI, true, TextForSave);
            File.AppendAllLines(pathFileName, TextForSave);
        }

        static void GetDirectoryTree(System.IO.DirectoryInfo startPathInfo, bool recurs, List<string> t)
        {
            System.IO.DirectoryInfo[] subDirs = null;
            System.IO.FileInfo[] files = null;
            files = startPathInfo.GetFiles("*.*");
            if (files != null)
            {
                for (int j = 0; j < files.Length; j++)
                {
                    t.Add(files[j].Name);
                }
                subDirs = startPathInfo.GetDirectories();
                for (int i = 0; i < subDirs.Length; i++)
                {
                    t.Add(subDirs[i].FullName);
                    if (recurs) 
                        GetDirectoryTree(subDirs[i], recurs, t);
                }
            }
        }
    }
}
