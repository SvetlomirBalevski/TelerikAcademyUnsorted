using System;

//Write a program that reads a year from the console and checks whether it is a leap one.

//Hint: Use System.DateTime.


    class LeapYear
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(input))
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }

        }
    }

