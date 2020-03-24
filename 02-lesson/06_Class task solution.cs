using System;

namespace lesson02
{
    class Program
    {
        static void Main(string[] args)
        {       
            int num = Convert.ToInt32(Console.ReadLine());
            



            Console.WriteLine("Enter length of array: ");

            // length of array: 
            int lengthOfArray = Convert.ToInt32(Console.ReadLine());         


            // number to multiply cells. 
            Console.WriteLine("Enter number to multiply: ");
            int NumToMul = Convert.ToInt32(Console.ReadLine());


            // initialize array: 
            int[] arr = new int[lengthOfArray];

            Console.WriteLine($"Num of elements: {lengthOfArray}, num to mul:{NumToMul}");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * NumToMul;
                Console.Write(arr[i]+", ");
            }


            /*
             * OUTPUT:
             * ----------------
            Enter length of array:
            4
            Enter number to multiply:
            3
            Num of elements: 4, num to mul:3
            0, 3, 6, 9,

             
             */
        }
    }
}
