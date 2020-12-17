using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr2 = new int[10, 10];
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    {
                        arr2[i, j] = i + j;
                    }
                }
            }
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                Console.Write(arr2[i, i] + " ");
            }
            Console.ReadKey();
        }
    }
}
