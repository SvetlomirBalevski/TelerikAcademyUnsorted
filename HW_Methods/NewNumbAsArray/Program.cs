using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNumbAsArray
{
    class Program
    {
        static char[] Sum2Arrays(char[] first, char[] second, int sizeFirst, int SizeSec)
        {
            int biggestSize = sizeFirst > SizeSec ? sizeFirst : SizeSec;
            char[] result = new char[biggestSize];

            if (sizeFirst >= SizeSec)
            {
                for (int i = 0; i < sizeFirst - 1; i++)
                {
                    result[i] = first[i]  + second[i];
                }
                for (int j = SizeSec - 1; j < sizeFirst; j++)
                {
                    result[j] = first[j];
                }
            }
            else
            {
                for (int i = 0; i < SizeSec - 1; i++)
                {
                    result[i] = first[i] + second[i];
                }
                for (int j = sizeFirst - 1; j < SizeSec; j++)
                {
                    result[j] = second[j];
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sizeFirst = inputs[0];
            int sizeSec = inputs[1];
            string[] firstArr = Console.ReadLine().Split(' ').ToArray();
            string[] secondArr = Console.ReadLine().Split(' ').ToArray();

            char[] reversedFirst = new char[sizeFirst];
            for (int i = 0; i < sizeFirst; i++)
            {
                reversedFirst[sizeFirst - i - 1] = firstArr[i];
            }
            char[] reversedSec = new char[sizeSec];
            for (int i = 0; i < sizeSec; i++)
            {
                reversedSec[sizeSec - i - 1] = SecArr[i];
            }
        }
    }
}
