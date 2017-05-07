using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//write a program that reads a rectangular matrix of size n x m and finds in it the square 3 x 3 that has maximal sum of its elements.print that sum.

//input

//on the first line you will receive the numbers n and m separated by a single space
//on the next n lines there will be m numbers separated with spaces - the elements of the matrix
//output

//print the maximal sum of 3 x 3 square
//constraints

//3 <= n, m <= 1024
//numbers in the matrix will be in the interval[-1000, 1000]
//time limit: 0.1s
//memory limit: 16mb
//sample tests

//input   output
//3 3
//4 3 5
//2 6 4
//8 2 7	41
//5 5
//1 1 3 3 5
//-6 -7 2 -3 -1
//3 0 -4 5 9
//7 -7 0 1 0
//-7 -6 -4 -4 9	19

namespace MaxSumAlexWay
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] InputLength = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] matrix = new int[InputLength[0], InputLength[1]];
            int row1 = 0, col1 = 0;
            int maxSum = int.MinValue;
        }
    }
}
