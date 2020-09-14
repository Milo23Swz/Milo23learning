using System;

namespace dotnet_assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Code Reverse Challenge");
            Console.WriteLine("Input text to reverse");
            string StringInput = Console.ReadLine();
            string Rstring = "";
            int length;

            length = StringInput.Length - 1;

            while (length >= 0)
            {
                Rstring = Rstring + StringInput[length];
                length--;
            }
            Console.WriteLine("Text reversed");
            Console.WriteLine(Rstring);


            Console.WriteLine("Is the text input a palindrome? (same forwards and backwards");
            bool b = StringInput.Equals(Rstring, StringComparison.OrdinalIgnoreCase);

            if (b == true)
            {
                Console.WriteLine("" + StringInput + "A Palindrome Yes!");
            }
            if (b ==false)
            {
                Console.WriteLine("" + StringInput + " A Palindrome No!");
            }
            Console.Read();
        }

    }
}
