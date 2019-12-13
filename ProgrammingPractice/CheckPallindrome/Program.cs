using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPallindrome
{
    class Program
    {
        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length == 1)
            {
                return true;
            }

            var inputArray = input.ToCharArray();
            var length = inputArray.Length;
            for (int i = 0; i < length; i++)
            {
                return inputArray[i] == inputArray[length - i - 1];
            }

            return true;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your input string: ");
                var input = Console.ReadLine();
                Console.WriteLine("IsPalindrome: " + IsPalindrome(input));
            }
        }
    }
}
