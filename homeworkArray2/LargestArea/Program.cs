using System;
using System.Linq;

class Program
{
    static int RecursiveSearch(int [,] matrix, bool isChecked)
    static void Main()
    {
        int[] InputLength = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[,] matrix = new int[InputLength[0], InputLength[1]];
        int rows = InputLength[0];
        int colls = InputLength[1];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = int.Parse(line[j]);
            }
        }
        bool[,] IsChecked = new bool[rows, colls];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colls; j++)
            {
                isChecked[i, j] = false;
            }
        }
        int count = 0;
        int maxCount = 0;
    }
}
