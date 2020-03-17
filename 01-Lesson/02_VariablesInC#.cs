using System;

namespace _01_HelloWorld1
{
    class Program
    {        
        static void Main(string[] args)
        {
            // value types:


            // ------------ numeric values: ----------------

            // 1 byte - from 0 to 255
            byte b = 12;

            // 1 byte - from -128 to 127
            sbyte sb = 12;

            // int = 4 byte. 
            int i = 12;

            // uint = 4 byte. only positive numbers. 
            uint ui = 12;

            // 8 byte
            long l = 12;

            // 8 byte. only positive numbers. 
            ulong ul = 12;


            // ------------ float values: ----------------

            double db = 12.4;

            float f = 2.44f;

            // mainly for money calculations: 
            decimal dm = 3.55m;


            // ------------ chars values: ----------------

            // char = 2 byte
            char ch = 'a';

            // ------------ boolean values: ----------------

            // boolean - can contain only `true` / `false`
            bool bl = true;


            // reference types: 
            string s = "Hello";


        }
    }
}
