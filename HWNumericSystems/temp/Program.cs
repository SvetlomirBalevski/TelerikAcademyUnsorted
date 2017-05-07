using System;

internal class BinaryShort
{
    // Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
    private static void Main()
    {
        short number = short.Parse(Console.ReadLine());
        string result=null;
        for (int i = 0; i < 16; i++)
        {
            int mask = 1 << i;
            int BitAtposition = (number & mask) >> i;
            result = BitAtposition + result;
        }
        Console.WriteLine(result);
    }

}
