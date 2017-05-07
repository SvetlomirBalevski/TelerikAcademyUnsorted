﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
//Since this ain't a walking park, let's make it more interesting - Your task is to find the average feathers count per bird and apply some more calculations on the result. If the birds count is an even number - multiply the result by the magic number 123123123123, if the birds count is an odd number - divide the result by the magic number 317.

//Input

//The input data should be read from the console.
//On the first console line you will receive a number B, that represents the number of birds in the forest. On the second console line you will receive a number F, that represents the total number of bird feathers in the forest. The input data will always be valid and in the format described.There is no need to check it explicitly.

//Output

//The output data should be printed on the console.
//On the only output line, print the average feathers count per bird, modified by the extra given conditions with 4 digits precision after the decimal point.

//Constraints

//B will be a positive integer between 0 and 80000 inclusive.
//F will be a positive integer between 0 and 2000000000 inclusive.
//Allowed memory: 16 MiB
//Allowed working time for your program: 0.1 seconds
//Examples

//Input

//3
//125
//Output

//0.1314
//Explanation

//We have 125 feathers and 3 birds, so the average is 41.666666666667 (feathers per bird)
//3 is odd, so we divide it by 317
//Final result => 41.666666666667/317 => 0.1314
//Input

//1000
//450
//Output

//55405405405.3500
//Explanation

//We have 450 feathers and 1000 birds, so the average is 0.45 (feathers per bird)
//1000 is even, so we multiply it by 123123123123
//Final result => 0.45*123123123123 => 55405405405.3500
//Input

//5000
//12425
//Output

//305960960960.6550
//Explanation

//We have 12425 feathers and 5000 birds, so the average is 2.485 (feathers per bird)
//5000 is even, so we multiply it by 123123123123
//Final result => 2.485*123123123123 => 305960960960.6550
//Input

//1
//1
//Output

//0.0032
//Explanation

//We have one feather and one bird, so the average is 1 (feather per bird).
//1 is odd, so we divide the result by 317
//Final result => 1/317 => 0.0032
//Input

//0
//0
//Output

//0.0000
//Explanation

//Since there are no birds and feathers,
//the result is always 0, no matter what extra modifications we do to it.
//Hints

//How to calculate the average feathers count per bird?
//What numeric type to use?
//How to check if a numbers is odd or even?
namespace BirdsFeathers
{
    class Program
    {
        static void Main(string[] args)
        {
            double birds = double.Parse(Console.ReadLine());
            double feathers = double.Parse(Console.ReadLine());
            double average = (double) birds / (double)feathers;

            if (average == 0)
            {
                Console.WriteLine("0.0000");
            }
            if (average != 0 && birds % 2 ==0)
            {
                average *= 123123123123;
            }
            if (average !=0 && birds %2 !=0 )
            {
                average /= 317;
            }
            Console.WriteLine("{0:0.0000}",average);
        }
    }
}
