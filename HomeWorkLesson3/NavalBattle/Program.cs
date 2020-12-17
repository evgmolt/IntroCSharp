using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavalBattle
{
    class Program
    {
        private const Char emptySign = 'O';
        private const Char busySign = 'X';
        private const int posX = 0;
        private const int posY = 1;
        private const int size = 2;
        private const int orientation = 3;
        private const int horizontal = 0;
        private const int vertical = 1;

        static void CreateShip(Char[,] field, int[] shipDescription)
        {
            int startPoint;
            if (shipDescription[orientation] == horizontal)
                startPoint = posX;
            else
                startPoint = posY;
            for (int i = shipDescription[startPoint]; i < shipDescription[startPoint] + shipDescription[size]; i++)
            {
                int firstInd;
                int secondInd;
                if (shipDescription[orientation] == horizontal)
                {
                    firstInd = shipDescription[posY];
                    secondInd = i;
                }
                else
                {
                    firstInd = i;
                    secondInd = shipDescription[posX];
                }
                field[firstInd, secondInd] = busySign;
            }
        }
        static void Main(string[] args)
        {
            //Описание кораблей: [X, Y, Size, Orientation(0 - horizontal, 1 - vertical)]
            int[] ship4 = {2, 3, 4, 0};
            int[] ship3_1 = { 2, 5, 3, 1 };
            int[] ship3_2 = { 9, 3, 3, 1 };
            int[] ship2 = { 8, 8, 2, 1 };
            int[][] allShips = { ship4, ship3_1, ship3_2, ship2 };

            Char[,] battleFieldArr = new Char[10, 10];
            for (int i = 0; i < battleFieldArr.GetLength(0); i++)
            {
                for (int j = 0; j < battleFieldArr.GetLength(1); j++)
                {
                    battleFieldArr[i, j] = emptySign;
                }
            }

            for (int i = 0; i < allShips.GetLength(0); i++)
            {
                CreateShip(battleFieldArr, allShips[i]);
            }

            for (int i = 0; i < battleFieldArr.GetLength(0); i++)
            {
                for (int j = 0; j < battleFieldArr.GetLength(1); j++)
                {
                    Console.Write(battleFieldArr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
