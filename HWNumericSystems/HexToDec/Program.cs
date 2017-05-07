using System;
using System.Numerics;

namespace HexToDec
{
    class Program
    {


        static BigInteger HexToDec(string input)
        {
            BigInteger result = 0;
            foreach (var num in input)
            {
                int digit;
                if (char.IsDigit(num))
                {
                    digit = num - '0';
                }
                else
                {
                    digit = num - 'A' + 10;
                }
                result = 16 * result + (digit);

            }
            return result;
        }
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            Console.WriteLine(HexToDec(hex));

        }
    }
}
