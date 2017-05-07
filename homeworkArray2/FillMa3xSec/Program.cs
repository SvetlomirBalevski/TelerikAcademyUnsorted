using System;


class Program
{


    static void Ma3xA(int[,] Ma3x, int size)
    {
        int counter = 1;
        for (int col = 0; col <= size - 1; col++)
        {
            for (int row = 0; row <= size - 1; row++, counter++)
            {
                Ma3x[row, col] = counter;
            }
        }
    }

    static void Ma3xB(int[,] Ma3x, int size)
    {
        int counter = 1;
        for (int col = 0; col <= size - 1; col++)
        {
            for (int row = 0; row <= size - 1; row++, counter++)
            {
                if ((col % 2) == 0)
                {
                    Ma3x[row, col] = counter;
                }
                else
                {
                    Ma3x[row, col] = counter + (size - (row * 2) - 1);
                }
            }

        }
    }

    static void DiagonalMatrix(int[,] Ma3x, int size)
    {
        int counter = 1;
        //first half of diagonal matrix
        for (int reversedRow = size - 1; reversedRow >= 0; reversedRow--)
        {
            for (int col = 0; col < (size - reversedRow); col++, counter++)
            {
                if (col == 0)
                {
                    Ma3x[reversedRow, col] = counter;
                }
                else
                {
                    Ma3x[(reversedRow + col), col] = counter;
                }
            }
        }
        //second half of diagonal matrix
        for (int col = 1; col <= size - 1; col++)
        {
            for (int row = 0; row < (size - col); row++, counter++)
            {
                if (row == 0)
                {
                    Ma3x[row, col] = counter;
                }
                else
                {
                    Ma3x[row, (col + row)] = counter;
                }
            }
        }
    }

    static void SpiralMatrixCalc(int[,] Ma3x, int size)
    {
        int counter = 1;
        for (int depth = 0; depth <= (size / 2); depth++)
        {
            for (int down = depth; down <= size - depth - 1; down++, counter++)
            {
                Ma3x[down, depth] = counter;
            }
            for (int right = depth + 1; right <= size - depth - 1; right++, counter++)
            {
                Ma3x[(size - depth - 1), right] = counter;
            }
            for (int up = size - depth - 2; up > depth; up--, counter++)
            {
                Ma3x[up, (size - depth - 1)] = counter;
            }
            for (int left = size - depth - 1; left > depth; left--, counter++)
            {
                if (Ma3x[depth, left] == 0)
                {
                    Ma3x[depth, left] = counter;
                }
                else
                {
                    break;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int matrixSize = int.Parse(Console.ReadLine());
        char matrixType = char.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];

        if (matrixType == 'a')
        {
            Ma3xA(matrix, matrixSize);
        }
        else if (matrixType == 'b')
        {
            Ma3xB(matrix, matrixSize);
        }
        else if (matrixType == 'c')
        {
            DiagonalMatrix(matrix, matrixSize);
        }
        else if (matrixType == 'd')
        {
            SpiralMatrixCalc(matrix, matrixSize);
        }

        //print

        for (int row = 0; row <= matrixSize - 1; row++)
        {
            for (int col = 0; col <= matrixSize - 1; col++)
            {

                if (col == (matrixSize - 1))
                {
                    Console.Write(matrix[row, col]);
                }
                else
                {
                    Console.Write(matrix[row, col] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
