using System;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array and ref:

            int[] array = new int[] { 1, 2, 3 };

            // call functions:
            Console.WriteLine("_______________step 1_____________________");
            PrintArr(array);

            ChangeElement(array);

            Console.WriteLine("_______________step 2_____________________");
            PrintArr(array);

            ChangeArr(array);

            Console.WriteLine("_______________step 3_____________________");
            PrintArr(array);

            ChangeArr2(ref array);



            Console.ReadKey();
        }

        static void ChangeElement(int[] arr)
        {
            Console.WriteLine("---------- ChangeElement start -------------");
            PrintArr(arr);

            arr[1] = 9;
            Console.WriteLine("---------- ChangeElement end -------------");
            PrintArr(arr);

        }

        static void ChangeArr(int[] arr)
        {
            Console.WriteLine("---------- ChangeArr start -------------");
            PrintArr(arr);

            arr = new int[] { 5, 5, 5 };
            Console.WriteLine("---------- ChangeArr end -------------");
            PrintArr(arr);

        }

        // Ref will change the array also in main. 
        static void ChangeArr2(ref int[] arr)
        {
            Console.WriteLine("---------- ChangeArr2 start -------------");
            PrintArr(arr);

            arr = new int[] { 5, 5, 5 };
            Console.WriteLine("---------- ChangeArr2 end -------------");
            PrintArr(arr);
        }



        static void PrintArr(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }


        /*
         * RESULT: 
          -------------------------------------------
           _______________step 1_____________________
            1, 2, 3,
            ---------- ChangeElement start -------------
            1, 2, 3,
            ---------- ChangeElement end -------------
            1, 9, 3,
            _______________step 2_____________________
            1, 9, 3,
            ---------- ChangeArr start -------------
            1, 9, 3,
            ---------- ChangeArr end -------------
            5, 5, 5,
            _______________step 3_____________________
            1, 9, 3,
            ---------- ChangeArr2 start -------------
            1, 9, 3,
            ---------- ChangeArr2 end -------------
            5, 5, 5,

         */

    }
}
