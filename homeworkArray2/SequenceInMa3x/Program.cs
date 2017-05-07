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

        // Checking right diagonal
        sum = 1;
        for (int rol = 0, coll = 0; rol < InputLength[0] - 1; rol++, coll++)
        {
            if (matrix[rol, coll] == matrix[rol + 1, coll + 1])
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
        // Checking left diagonal
        sum = 1;
        for (int rol = InputLength[0] - 1, coll = 0; (rol > 0 ); rol--, coll++)
        {
            
                if (matrix[rol, coll] == matrix[rol - 1, coll + 1])
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
        Console.WriteLine(maxSum);
    }
}