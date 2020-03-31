using System;

namespace Lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows;

            // Do while loop will run at least one time. 
            // If the user puts a bigger number that 9 or smaller than 3 - the loop 
            // will continue running. 
            do
            {
                Console.WriteLine("Please enter a number (between 3-9)");
                numOfRows = Convert.ToInt32(Console.ReadLine());
            } while (numOfRows < 3 || numOfRows > 9);


            // create a matrix that will have the amount of rows from user. 
            int[][] matrix = new int[numOfRows][];

            int x = 1;

            // For loop that will initialize the matrix: 
            // index: matrix[0][1]
            for (int row = 0; row < matrix.Length; row++,x++)
            {
                // define for each row the amount of cells: 
                matrix[row] = new int[row + 1];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = x;
                }
            }

            // Print the matrix: 
            // foreach: 1
            foreach (int[] Row in matrix)
            {
                foreach (int Col in Row)
                {
                    Console.Write(Col + " ");
                }
                Console.WriteLine();
            }


            /*
             * 
             Please enter a number (between 3-9)
                3
                1
                2 2
                3 3 3
            */


            Console.ReadKey();

        }
    }
}
