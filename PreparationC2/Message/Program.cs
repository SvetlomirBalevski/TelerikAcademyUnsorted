using System;
using System.Numerics;

//The encryption system consists of adding or subtracting numbers in their GeorgeTheGreat numeral system.

//The GeorgeTheGreat numeral system has exactly 10 different digits and each digit consists of 3 chacters as follows:

//Digit Value
//cad 0
//xoz 1
//nop 2
//cyk 3
//min 4
//mar 5
//kon 6
//iva 7
//ogi 8
//yan 9
//Your task is to calculate the result of the operation, by given two numbers in GeorgeTheGreat numeral system and an
//    operator (subtraction or addition)


class Program
{

    static string[] SplitToSubstring(string input)
    {
        string[] sub = new string[input.Length / 3];
        for (int i = 0, j = 0; i < input.Length; i += 3)
        {
            sub[j] = input.Substring(i, 3);
            j++;
        }
        return sub;
    }

    static BigInteger Convert(string[] input)
    {
        string converted = "";
        foreach (string sub in input)
        {
            switch (sub)
            {
                case "cad": converted += '0'; break;
                case "xoz": converted += '1'; break;
                case "nop": converted += '2'; break;
                case "cyk": converted += '3'; break;
                case "min": converted += '4'; break;
                case "mar": converted += '5'; break;
                case "kon": converted += '6'; break;
                case "iva": converted += '7'; break;
                case "ogi": converted += '8'; break;
                case "yan": converted += '9'; break;
            }
        }
        return BigInteger.Parse(converted);
    }

    static string ConvertBack(BigInteger input)
    {
        string result = "";
        string[] GeorgeTheGreat = new string[] { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };
        BigInteger remainder = 0;
        while (input != 0)
        {
            remainder = input % 10;
            result = GeorgeTheGreat[(int)remainder] + result;
            input = input / 10;
        }
        return result;


    }
    static void Main(string[] args)
    {
        string first = Console.ReadLine();
        char sign = char.Parse(Console.ReadLine());
        string second = Console.ReadLine();

        BigInteger firstNumberConverted = Convert(SplitToSubstring(first));
        BigInteger secondNumberConverted = Convert(SplitToSubstring(second));

        BigInteger result = 0;
        if (sign == '-')
        {
            result = firstNumberConverted - secondNumberConverted;
        }
        else
        {
            result = firstNumberConverted + secondNumberConverted;
        }
        Console.WriteLine(ConvertBack(result));
    }
}

