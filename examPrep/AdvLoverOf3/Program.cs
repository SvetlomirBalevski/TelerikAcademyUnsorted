using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvLoverOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 6;
            int cols = 7;
            int[,] ma3x = new int[rows, cols];

            ma3x = MatrixFilling(rows, cols, ma3x);
            bool[,] isChecked = new bool[rows, cols];

        }

        private static int[,] MatrixFilling(int rows, int cols, int[,] ma3x)
        {
            for (int i = 0; i < rows; i++)
            {
                int[] row = new int[cols];
                int temp = i * 3;
                for (int j = 0; j < cols; j++)
                {
                    row[j] = temp;
                    temp += 3;
                }
                for (int k = 0; k < cols; k++)
                {
                    ma3x[i, k] = row[k];
                }
            }
            return ma3x;
        }
    }
}
