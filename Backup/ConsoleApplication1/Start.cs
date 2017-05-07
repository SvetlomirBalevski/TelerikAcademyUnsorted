using System;

namespace HWDeffClass2
{
    class Start
    {
        static void Main(string[] args)
        {
            // Testing Point in 3D
            Point3D test = new Point3D(2, 3, 5);
            Point3D test2 = new Point3D(1, 2, 43);
            Console.WriteLine(test.ToString());
            Console.WriteLine(Point3D.GetCordZero());
            Console.WriteLine(CalculateDistance.CalculateDist(test, test2));

            //Testing List Implementation for list

            GenericList<int> listTest = new GenericList<int>(10);
            for (int i = 0; i < 12; i++)
            {
                listTest.Add(i);
            }
            Console.WriteLine(listTest.ToString());
            listTest.InsertElementAt(14, 2);
            //Check for index of 1
            Console.WriteLine(listTest.FindElementByValue(1));

            //Check for index of 100 - not presented at the test list
            Console.WriteLine(listTest.FindElementByValue(100));

            //Check for min value
            Console.WriteLine(listTest.Max());
            //Check for Max value
            Console.WriteLine(listTest.Min());

            // Test of filling the matric
            Matrix<int> testMa3x = new Matrix<int>(3, 3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    testMa3x.Add(i + j, i, j);
                }
            }
            Console.WriteLine(testMa3x.ToString());

            //Test of adding, substacting and multiplocation of matrixes

            Matrix<int> testMa3x2 = new Matrix<int>(3, 3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    testMa3x2.Add(i + j, i, j);
                }
            }
            Console.WriteLine(testMa3x+testMa3x2);
            Console.WriteLine(testMa3x-testMa3x2);
            Console.WriteLine(testMa3x*testMa3x2);

            var programVersion = typeof(Program).GetCustomAttributes(false);

            foreach (var item in programVersion)
            {
                var version = (AtributeVersion)item;
                Console.WriteLine(version.Version);
            }

        }
    }
}
