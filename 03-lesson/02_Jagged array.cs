using System;

namespace Lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------- Jagged array: -------------------
            int[][] JaggedArray = new int[3][];

            JaggedArray[0] = new int[3];
            JaggedArray[1] = new int[5];
            JaggedArray[2] = new int[2];


            int[][] JaggedArray1 = new int[][]
            {
                new int[] {1,2,3},
                new int[] {4,5},
                new int[] {6,7,8,9,10}
            };

            string[][] JaggedArray2 = new string[][]
            {
                new string[]{"Bob","Rachel","Dani"},
                new string[]{"Yair", "Talat"},
                new string[]{"Shmuel"}
            };


            Console.WriteLine("The jagged array data: ");
            foreach (string[] Row in JaggedArray2)
            {
                foreach (string Col in Row)
                {
                    Console.Write($" [ {Col} ] ");
                }
                Console.WriteLine();
            }
            


            Console.ReadKey();

        }
    }
}
