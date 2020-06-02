using System;

namespace Lesson09
{

    class Sms<T>
    {
        public string PhoneNumber { get; set; }
        public T Message { get; set; }

        public void SendMessage()
        {
            Console.WriteLine($"Sending to {PhoneNumber}, Message: {Message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Sms<int> sms1 = new Sms<int>();
            sms1.PhoneNumber = "045436465";
            sms1.Message = 123;
            sms1.SendMessage();
            // Sending to 045436465, Message: 123


            Sms<string> sms2 = new Sms<string>();
            sms2.PhoneNumber = "+972 5943584";
            sms2.Message = "This is a message for you";
            sms2.SendMessage();
            // Sending to +972 5943584, Message: This is a message for you

            Console.ReadKey();

        }
    }
}
