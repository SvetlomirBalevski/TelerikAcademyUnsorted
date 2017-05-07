using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Binary to hexadecimal

//Description

//Write a program to convert binary numbers to hexadecimal numbers(directly).

//Input

//On the only line you will receive a decimal number - N
//There will not be leading zeros
//Output

//Print the its binary representation on a single line
//There should not be leading zeros
//Use uppercase letters
//Constraints

//1 <= N <= 1018 = 110111100000101101101011001110100111011001000000000000000000(2)
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input   Output
//10011	13



    class Bin2Hex
    {

    static char[] Bin2HexConv (List<char> bin)
    {
        char[] hex = new char[bin.Count];
        int placeInString = 0;
        for (int i = 0; i < bin.Count; i+=4)
        {
            string temp = "";
            for (int j = placeInString *4; j < placeInString * 4+ 4; j++)
            {
                temp += bin[j];
            }
            switch (temp)
            {
                case "0000": hex[placeInString] = '0';
                    break;
                case "0001":
                    hex[placeInString] = '1';
                    break;
                case "0010":
                    hex[placeInString] = '2';
                    break;
                case "0011":
                    hex[placeInString] = '3';
                    break;
                case "0100":
                    hex[placeInString] = '4';
                    break;
                case "0101":
                    hex[placeInString] = '5';
                    break;
                case "0110":
                    hex[placeInString] = '6';
                    break;
                case "0111":
                    hex[placeInString] = '7';
                    break;
                case "1000":
                    hex[placeInString] = '8';
                    break;
                case "1001":
                    hex[placeInString] = '9';
                    break;
                case "1010":
                    hex[placeInString] = 'A';
                    break;
                case "1011":
                    hex[placeInString] = 'B';
                    break;
                case "1100":
                    hex[placeInString] = 'C';
                    break;
                case "1101":
                    hex[placeInString] = 'D';
                    break;
                case "1110":
                    hex[placeInString] = 'E';
                    break;
                case "1111":
                    hex[placeInString] = 'F';
                    break;
            }
            placeInString++;
        }
        return hex;
    }
        static void Main(string[] args)
        {
        List<char> input = Console.ReadLine().ToList();
        while (input.Count %4 !=0)
        {
            input.Insert(0, '0');
        }
        char[] result = Bin2HexConv(input);
        foreach (var item in result)
        {
            Console.Write(item);
        }
        }
    }

