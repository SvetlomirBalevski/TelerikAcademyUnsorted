using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//15 18 21 24 27 30 33 36 39
//12 15 18 21 24 27 30 33 36
//9 12 15 18 21 24 27 30 33
//6 9 12 15 18 21 24 27 30
//3 6 9 12 15 18 21 24 27
//0 3 6 9 12 15 18 21 24


class LoverOf3
{
    static int[,] FillMa3x(int rows, int columns)
    {
        int[,] resultMa3x = new int[rows, columns];
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                resultMa3x[r, c] = 3 * (rows - r - 1) + 3 * c;
            }
        }
        return resultMa3x;
    }

    static int WalikngAroundMa3x(int[,] Ma3x, string[] directions)
    {
        int sum = 0;
        bool[,] Ischecked = new bool[Ma3x.GetLength(0),Ma3x.GetLength(1)];
        for (int i = 0; i < Ma3x.GetLength(0); i++)
        {
            for (int j = 0; j < Ma3x.GetLength(1); j++)
            {

            }
        }
        return sum;
    }
    static void Main(string[] args)
    {
        //int[] InputLength = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //int rows = InputLength[0];
        //int columns = InputLength[1];
        //int moves = int.Parse( Console.ReadLine());
        int rows = 6;
        int columns = 7;
        int moves = 5;
        int[] movesInEachDir = new int[moves];
        string[] direction = new string[moves * 2];

        for (int i = 0; i < moves * 2; i++)
        {
            direction[i] = Console.ReadLine();
        }


    }

}

