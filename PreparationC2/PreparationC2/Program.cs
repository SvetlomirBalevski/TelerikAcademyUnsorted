using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PreparationC2
{
    class Program
    {
        static int rows;
        static int columns;
        static int[] moves;
        static int movesCount;
        static BigInteger[,] Ma3x;
        
        static void Main(string[] args)
        {
            //read input
            rows = int.Parse(Console.ReadLine());
            columns = int.Parse(Console.ReadLine());
            movesCount = int.Parse(Console.ReadLine());
            moves = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Ma3x = new BigInteger[rows, columns];
            FillMatrix(Ma3x);
            //PrintMa3x(Ma3x);
            //logig
            BigInteger sum = 0;
            int[] pos = { rows - 1, 0 };
            int coef = rows > columns ? rows : columns;

            sum += Ma3x[pos[0], pos[1]];
            Ma3x[pos[0], pos[1]] = 0;
            foreach (var code in moves)
            {
                int[] targPos = {code / coef, code % coef };

                while (pos[1] != targPos[1] && pos[1] >0 && pos[1]<columns)
                {
                    sum += Ma3x[pos[0],pos[1]];
                    Ma3x[pos[0], pos[1]] = 0;
                    pos[1]++;
                }

            }
        }

        private static void PrintMa3x(BigInteger[,] board)
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.Write(board[r,c]);
                }
            }
        }

        private static void FillMatrix(BigInteger[,] ma3x)
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    ma3x[rows, columns] = (2 << (rows - 1 - r + c));
                }
            }
        }
    }
}
