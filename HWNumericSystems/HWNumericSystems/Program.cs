using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Decimal to binary

//Description

//Write a program that converts a decimal number N to its binary representation.

//Input

//On the only line you will receive a decimal number - N
//There will not be leading zeros
//Output

//Print the binary representation of N on a single line
//There should not be leading zeros
//Constraints

//1 <= N <= 1018
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//19	10011


class DecToBin
{

    static List<BigInteger> ToBinConv(BigInteger input)
    {
        List<BigInteger> result = new List<BigInteger>();
        while (input > 0)
        {
            if (input % 2 == 0)
            {
                result.Add(0);
            }
            else
            {
                result.Add(1);
            }
            input /= 2;
        }
        result.Reverse();
        return result;
    }

    static void Main(string[] args)
    {
        BigInteger input = BigInteger.Parse(Console.ReadLine());
        List<BigInteger> result = ToBinConv(input);
        foreach (var item in result)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}
