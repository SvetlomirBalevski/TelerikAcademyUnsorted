using System;
using System.Text;

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range(start, end ).

//If an invalid number or non-number text is entered, the method should throw an exception.Using this method write a program that enters 10 numbers: a1, a2, ..., a10, such that 1 < a1< ... < a10< 100
//Input

//You will receive 10 lines of input, each consisted of an integer number
//a1
//a2
//...
//a10

namespace ConsoleApplication6
{
    class Program
    {
        static int ReadNumber(int start, int end)
        {
            int current = 0;

            current = int.Parse(Console.ReadLine());
            if (start >= current || current >= end)
            {
                throw new ArgumentOutOfRangeException("Agument is out of range");
            }

            return current;
        }
        static void Main()
        {
            int start = 1;
            int stop = 100;
            int[] result = new int[10];

            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(start);
                sb.AppendFormat("{0} < ", start);
                for (int i = 0; i < 10; i++)
                {
                    result[i] = ReadNumber(start, stop);
                    start = result[i];
                    sb.AppendFormat("{0} < ", start);
                }
                sb.AppendFormat("{0}", stop);
                Console.WriteLine(sb);
            }
            catch (Exception)
            {
                Console.Write("Exception");
            }
        }
    }
}
