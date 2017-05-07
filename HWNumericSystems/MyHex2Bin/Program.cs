using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class MyHex2Bin
{
    public static Dictionary<char, BigInteger> hexValues = new Dictionary<char, BigInteger>()
        {
            {'0', 0  },
            {'1', 1  },
            {'2', 2  },
            {'3', 3  },
            {'4', 4  },
            {'5', 5  },
            {'6', 6  },
            {'7', 7  },
            {'8', 8  },
            {'9', 9  },
            {'A', 10 },
            {'B', 11 },
            {'C', 12 },
            {'D', 13 },
            {'E', 14 },
            {'F', 15 },
        };
    static string ToBin(BigInteger decValue, int baseValue)
    {
        string result = "";

        do
        {
            BigInteger reminder = decValue % baseValue;
            result = reminder + result;
            decValue /= baseValue;
        } while (decValue > 0);
        return result;
    }
    public static BigInteger HexTwoDec(string input, int inputNumSystem)
    {
        BigInteger sum = 0;
        foreach (char item in input)
        {
            sum = hexValues[item] + sum * inputNumSystem;
        }
        return sum;
    }

    static void Main()
    {
        string input = Console.ReadLine();
        BigInteger Hex = HexTwoDec(input, 16);
        string binary = ToBin(Hex, 2);
        Console.WriteLine(binary);

    }
}

