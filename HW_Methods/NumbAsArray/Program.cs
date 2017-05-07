using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a method that adds two positive integer numbers represented as arrays of digits(each array element arr[i] contains a digit;
//the last digit is kept in arr[0]). Write a program that reads two arrays representing positive integers and outputs their sum.

//Input


//On the first line you will receive two numbers separated by spaces - the size of each array
//On the second line you will receive the first array
//On the third line you will receive the second array
//Output


//Print the sum as an array of digits (as described)
//Digits should be separated by spaces


class Program
{


    static void Main(string[] args)
    {
        int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        var firstArr = Console.ReadLine().Split(' ');
        var SecArr = Console.ReadLine().Split(' ');
        string temp = string.Empty;
        if (firstArr.Length > SecArr.Length)
        {

        }

    }

}
