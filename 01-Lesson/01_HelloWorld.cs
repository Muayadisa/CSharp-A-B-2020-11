// 'using' is to add a reference to external dlls. (dll = dynamic link library)
using System;

// namespace - מעטפת חיצונית של הקובץ
namespace _01_HelloWorld1
{
    // class - המחלקה הראשית שמכילה את הפונקציה שתתחיל את ריצת התוכנית. 
    class Program
    {
        // This is the main function. The first to run. 
        static void Main(string[] args)
        {
            // Print output to the console: 
            // Shortcut: c w tab tab: 
            Console.WriteLine("Hello world");
            
            // Only for terminal not to shutdown fast:
            Console.ReadKey();
        }
    }
}
