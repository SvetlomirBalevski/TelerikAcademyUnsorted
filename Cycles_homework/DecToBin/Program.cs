﻿using System;
using System.Numerics;

//Decimal to Binary

//Description

//Using loops write a program that converts an integer number to its binary representation.

//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Input

//On the only input line you will receive the decimal integer number.
//Output

//Output a single string - the representation of the input decimal number in it's binary representation.
//Constraints

//All numbers will always be valid 32-bit integers.
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//0	0
//3	11
//43691	1010101010101011
//236476736	1110000110000101100101000000

namespace DecToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            BigInteger baseValue = 1;
            BigInteger reminder;
            BigInteger decimal_val = 0;
            BigInteger binary_val = input;
            while (input > 0)
            {
                reminder = input % 2;
                decimal_val = decimal_val + reminder * baseValue;
                input = input / 2;
                baseValue = baseValue * 10;
            }
            Console.WriteLine(decimal_val);
        }
    }
}

