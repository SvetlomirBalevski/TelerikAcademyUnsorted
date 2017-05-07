using System;
using System.Linq;

//We are given a matrix of strings of size N x M.Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.Write a program that finds the longest sequence of equal strings in the matrix and prints its length.

//Input

//On the first line you will receive the numbers N and M separated by a single space
//On the next N lines there will be M strings separated with spaces - the strings in the matrix
//Output

//Print the length of the longest sequence of equal equal strings in the matrix

class Program
{
    static void Main(string[] args)
    {
        int[] InputLength = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string[,] matrix = new string[InputLength[0], InputLength[1]];

        for (int i = 0; i < InputLength[0]; i++)
        {
            string[] rows = Console.ReadLine().Split(' ');
            for (int j = 0; j < InputLength[1]; j++)
            {
                matrix[i, j] = rows[j];
            }
        }
        int sum = 1;
        int maxSum = 1;
        //checking Each row
        for (int rol = 0; rol < InputLength[0]; rol++)
        {
            for (int coll = 0; coll < InputLength[1] - 1; coll++)
            {
                if (matrix[rol, coll] == matrix[rol, coll + 1])
                {
                    sum++;
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }

                }
                else
                {
                    sum = 1;
                }
            }
        }
        sum = 1;
        // Checking each column
        for (int coll = 0; coll < InputLength[1]; coll++)
        {
            for (int rol = 0; rol < InputLength[0] - 1; rol++)

            {
                if (matrix[rol, coll] == matrix[rol + 1, coll])
                {
                    sum++;
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }

                }
                else
                {
                    sum = 1;
                }
            }
        }
         sum = 1;

    
       //  diagonal
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            sum = 1;
            int temp = row;
            for (int col = matrix.GetLength(1) - 1; col > 0 && row + 1 < matrix.GetLength(0); col--)
            {
                if (matrix[row, col] == matrix[row + 1, col - 1])
                {
                    sum++;
                    row++;

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }

                    if ((row + 1 == matrix.GetLength(0)) || (col - 1 == 0))
                    {
                        row = temp;
                        sum = 1;
                    }
                }
                else
                {
                    col = col + sum - 1;
                    sum = 1;
                    row = temp;
                }
            }

        }

        
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            sum = 1;
            int temp = row;
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    sum++;
                    row++;

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }

                    if ((row + 1 == matrix.GetLength(0)) || (col + 1 == matrix.GetLength(1)))
                    {
                        row = temp;
                        sum = 1;
                    }
                }
                else
                {
                    col = col - sum + 1;
                    sum = 1;
                    row = temp;
                }
            }
        }
        Console.WriteLine(maxSum);
    }
}