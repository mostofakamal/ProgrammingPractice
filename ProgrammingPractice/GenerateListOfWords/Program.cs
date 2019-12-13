using System;
using System.Collections.Generic;

namespace GenerateListOfWords
{
    class Program
    {
        private static string DeleteCharAtIndex(string input, int i)
        {
            return input.Remove(i, 1);
        }

        private static string ReplaceCharAtIndex(string input, int i, char c)
        {
            var inputAsArray = input.ToCharArray();
            inputAsArray[i] = c;
            return new string(inputAsArray);
        }

        private static string SwapTwoAdjacentLetter(string input, int startIndex)
        {
            if (startIndex >= input.Length - 1)
            {
                return input;
            }

            var inputAsArray = input.ToCharArray();
            var tmp = inputAsArray[startIndex];
            inputAsArray[startIndex] = inputAsArray[startIndex + 1];
            inputAsArray[startIndex + 1] = tmp;
            return new string(inputAsArray);
        }

        public static List<string> GenerateListOfAlternativeWords(string input, char alphabet)
        {
            var words = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                //1. Perform the delete operation
                words.Add(DeleteCharAtIndex(input, i));
                for (var j = 'a'; j <= 'z'; j++)
                {
                    // 2. The insert operation
                    words.Add(input.Insert(i, j.ToString()));

                    // 3. The replace operation
                    words.Add(ReplaceCharAtIndex(input, i, j));
                }
                // 4. The swap operation
                words.Add(SwapTwoAdjacentLetter(input, i));
            }

            return words;
        }


        static void Main(string[] args)
        {
            var allwords = GenerateListOfAlternativeWords("test", 'a');
            Console.WriteLine(string.Join(",", allwords));
        }
    }
}
