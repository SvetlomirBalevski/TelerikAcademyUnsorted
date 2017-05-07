using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sizeFirst = sizes[0];
            int sizeSec = sizes[1];
            int[] firstNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
    }
}
