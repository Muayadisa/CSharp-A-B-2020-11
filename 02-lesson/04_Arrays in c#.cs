using System;

namespace lesson02
{
    class Program
    {
        static void Main(string[] args)
        {

            // array in c#:

            // ----------------01 Way to create array: ---------------
            // דרך ראשונה: ע"י ציון מספר התאים שיש לאותו מערך
            // ללא צורך לתת את ערכי התאים בשורת האתחול
            int[] arr1 = new int[3];
            arr1[0] = 2;
            arr1[1] = 4;
            arr1[2] = 8;

            // ----------------02 Way to create array: ---------------
            // דרך שניה: ע"י ציון מספר התאים שיש לאותו מערך
            // והשמת ערכי התאים בשורת האתחול
            int[] arr2 = new int[3] { 2, 4, 8 };


            // ----------------03 Way to create array: ---------------
            // דרך שלישית: ע"י השמת ערכי התאים בשורת האתחול
            // ללא צורך בציון מספר התאים שיש לאותו מערך. 
            // מספר התאים ייקבע לפי מסרפר הערכים שניתנו באתחול
            int[] arr3 = new int[] { 2, 4, 8 };


            Console.WriteLine("---------arr1------------");

            for(int i=0; i<arr1.Length; i++)
            {
                Console.Write(arr1[i]+ " ");
            }

            /* output:
            ---------arr1------------
            2 4 8
            */
        }
    }
}
