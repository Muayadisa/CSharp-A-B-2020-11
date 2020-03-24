using System;

namespace lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------Numberic-----------------

            // byte = 1 byte in memory. 
            byte b = 12;

            // int = 4 byte in memory. 
            int i = 12;

            // long = 8 byte in memory. 
            long l = 12;


            // ----------float-----------------
            double d = 12.4;
            float f = 12.555f;
            decimal dm = 3.55m;


            // -----------------המרה מרומזת---------------------
            // המרה מרומזת : תתבצע כאשר נשים משתנה מטיפוס אחד למשתנה מטיפוס אחר
            // כל עוד אין חשש שנאבד במהלך ההמרה שום מידע

            // byte to int:
            i = b;

            // byte to long:
            l = b;

            // byte to float:
            f = b;

            // byte to long:
            l = b;

            // byte to double:
            d = b;

            // -----------------int:------------
            // int to float:
            f = i;

            // int to double:
            d = i;

            // int to long:
            l = i;


            // -----------------המרה מפורשת---------------------
            // המרה מפורשת תתבצע כאשר נשים משתנה מטיפוס אחד למשתנה מטיפוס אחר
            // יש חשש שנאבד מידע במהלך ההמרה

            // int to byte:
            b = (byte)i;

            // long to byte:
            b = (byte)l;

            // long to int:
            i = (int)l;

            // double to byte:
            b = (byte)d;

            // double to float:
            f = (float)d;

            // double to decimal:
            dm = (decimal)d;

            // float to int:
            i = (int)f;

        }
    }
}
