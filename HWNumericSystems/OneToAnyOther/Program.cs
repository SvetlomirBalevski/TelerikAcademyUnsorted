using System;
using System.Collections.Generic;
using System.Numerics;

//Write a program to convert the number N from any numeral system of given base s to any other numeral system of base d.

//Input

//On the first line you will receive the number s
//On the second line you will receive a number in base s - N
//There will not be leading zeros
//On the third line you will receive the number d
//Output

//Print N in base d
//There should not be leading zeros
//Use uppercase letters

class AnyToAny
{
    static BigInteger toDecimal(string input, int radix)
    {
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
                result = radix * result + (digit);

            }
            return result;
        }
    }

    static List<char> ConvFromDecToAny(BigInteger decNumber,int targetNumericalSystem)
    {
        BigInteger temp = 0;
        List<char> result = new List<char>();
        char[] Hex = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        do
        {
            temp = decNumber % targetNumericalSystem;
            result.Add(Hex[(int)temp]);
            decNumber /= targetNumericalSystem;
        }
        while (decNumber > 0);
        result.Reverse();
        return result;
    }
    static void Main()
    {
        int radix = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int target = int.Parse(Console.ReadLine());
        input.ToUpper();
        BigInteger toAny = toDecimal(input,radix);
        List<char> result = ConvFromDecToAny(toAny,target);
        foreach (var item in result)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}
