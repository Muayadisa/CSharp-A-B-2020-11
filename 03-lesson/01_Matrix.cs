using System;

namespace Lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------way 01 to create a matrix-------------------
            int[] arr1 = new int[3];
            arr1[0] = 1;
            arr1[1] = 2;
            arr1[2] = 3;


            int[][] matrix1 = new int[2][];
            matrix1[0] = new int[] { 1, 2, 3 };
            matrix1[1] = new int[] { 4, 5, 6 };

            // ----------------way 02 to create a matrix-------------------
            int[] arr2 = new int[3] { 1, 1, 1 };

            int[][] matrix2 = new int[2][] { new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 } };

            // ----------------way 03 to create a matrix-------------------
            int[] arr3 = new int[] { 1, 1, 1 };

            int[][] matrix3 = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } };


            // ----------------Print the data using foreach-------------------


            Console.WriteLine("---------foreach arr1----------");
            foreach (int arrItem in arr1)
            {
                Console.WriteLine($"arr1 foreach: {arrItem}");
            }

            Console.WriteLine();

            Console.WriteLine("---------foreach matrix1----------");
            foreach (int[] matrixRow in matrix1)
            {
                foreach (int matrixCol in matrixRow)
                {
                    Console.Write($"[ {matrixCol} ]");
                }
                Console.WriteLine();
            }

            // ----------------Print the data using for-------------------
            Console.WriteLine("---------for arr1----------");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"[ {arr1[i]} ]");
            }

            Console.WriteLine();

            Console.WriteLine("---------for matrix1----------");
            for (int row = 0; row < matrix1.Length; row++)
            {
                for (int col = 0; col < matrix1[row].Length; col++)
                {
                    Console.Write($"[ {matrix1[row][col]} ]");
                }
            }



            Console.ReadKey();

        }
    }
}
