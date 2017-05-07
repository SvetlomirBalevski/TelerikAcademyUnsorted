using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Binary short

//Description

//Write a program that shows the binary representation of given 16-bit signed integer number N(the C# type short).

//Input

//On the only line you will receive a decimal number - N
//Output

//Print the its binary representation on a single line
//There should be exactly 16 digits of output
//Constraints

//-215 <= N< 215
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//11	0000000000001011
//-11	1111111111110101

class BinShort
{

    static List<int> ToBinConv(long input)
    {
        List<int> result = new List<int>();
        do
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
        } while (input > 0);
        result.Reverse();
        return result;
    }

    static void Main(string[] args)
    {
        long input = long.Parse(Console.ReadLine());
        bool IsNegative = false;
        if (input < 0)
        {
            IsNegative = true;
        }
        input = Math.Abs(input);
        List<int> result = ToBinConv(input);

        int temp = result.Count;
        for (int i = temp -1; i < 14; i++)
        {
            result.Insert(0, 0);
        }
            if (IsNegative == true)
        {
            for (int i = 0; i < result.Count-1; i++)
            {
                if (result[i] == 0)
                {
                    result[i] = 1;
                }
                else
                {
                    result[i] = 0;
                }
            }
            result.Insert(0, 1);
        }
        else
        {
            result.Insert(0, 0);
        }

        Print(result);
    }
    static void Print(List<int> result)
    {
        foreach (var item in result)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}