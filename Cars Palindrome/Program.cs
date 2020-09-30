using System;
namespace IsPalindrome
{
    public class Program
    {
        static void Main(string[] args)

        {
            string inputString = "";
            string outputString = "";

            inputString = "racecar";
            outputString = ReverseString(inputString);

            Console.Write("Original String:" + inputString);
            Console.Write("Reversed String:" + outputString);
            {
                inputString = "racecar";
                outputString = ReverseString(inputString);

                Console.Write("Original String:" + inputString);
                Console.Write("Reversed String:" + outputString);
                {
                    inputString = "racecar";
                    outputString = ReverseString(inputString);

                    Console.Write("Original String:" + inputString);
                    Console.Write("Reversed String:" + outputString);
                }
            }

            Console.ReadLine();

        }
        public static string ReverseString(string outputString)
        {
            string reversedString = "";
            {
                string value = string.Empty;

                value = "racecar";
                Console.WriteLine($"[0] = [1]", value.CompareTo(reversedString));


                value = "racecars";
                Console.WriteLine($"[0] = [1]", value.CompareTo(reversedString));


                value = "rotor";
                Console.WriteLine($"[0] = [1]", value.CompareTo(reversedString));

                Console.ReadKey();

            }
        }


        private static bool IsPalindrome1(string value)
        {
            char[] chars = value.ToCharArray();
            for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
            {
                if (chars[i] != chars[j])
                    return false;
            }
            return true;
        }
    }
}