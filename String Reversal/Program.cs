using System;
using System.Runtime.CompilerServices;

namespace String_Reversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "This text is backwards";
            string outputString = ReverseString(inputString);

            Console.Write("Original String:" + inputString);
            Console.Write("Reversed String:" + outputString);

            Console.ReadLine();
        }
                private  static string ReverseString(string inputString)
        {
            string reversedString = "";

            for(int count=inputString.Length - 1; count >= 0; count --)
            {
                reversedString += inputString[count];
            }

            return reversedString;       
        }
    }
}
 