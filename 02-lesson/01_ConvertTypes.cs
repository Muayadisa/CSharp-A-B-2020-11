using System;

namespace lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            // GetType() - get the type of a variable: 
            string str = "Hello world";
            int num = 5;
            Console.WriteLine(str.GetType());  //System.String
            Console.WriteLine(num.GetType());  //System.Int32


            //-------------------Convert from string to number: ------------------------
            // Int32- standard - 4 byte in memory. byte = 8 bit. 8*4 = 32. 

            string threeStr = "3";
            int threeNum = Convert.ToInt32(threeStr);

            double num1 = Convert.ToDouble("7.6");

            //-------------------Convert from number to string: ------------------------
            string strNum1 = num1.ToString();
            string strNum2 = threeNum.ToString();


            Console.ReadKey();
        }
    }
}
