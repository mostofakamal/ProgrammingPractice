using System;
using System.Text.RegularExpressions;

namespace ReplaceValidEmailAddressInAString
{
    class Program
    {
        /// <summary>
        /// Replaces valid email addresses in a string
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        public static string ReplaceValidEmailAddressInAString(string inputText)
        {
            if (string.IsNullOrEmpty(inputText))
            {
                return inputText;
            }
            // The regex for matching valid email addresses
            var emailMatchingRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            int removedEmailAddressLengthSoFar = 0;
            foreach (Match match in emailMatchingRegex.Matches(inputText))
            {
                if (match.Success)
                {
                    int matchStartIndex = match.Index;
                    inputText = inputText.Remove(matchStartIndex - removedEmailAddressLengthSoFar, match.Length);
                    removedEmailAddressLengthSoFar += match.Length;
                }
            }

            return inputText;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text: ");
            var inputText = Console.ReadLine();
            Console.WriteLine(ReplaceValidEmailAddressInAString(inputText));
        }
    }
}
