using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBar
{
    class Program
    {
        public static void PrintNumberWithFooBar()
        {
            for (int i = 1; i <= 100; i++)
            {
                var currentNumberString = i.ToString();
                if (i % 3 == 0)
                {
                    Console.Write("Foo");
                    currentNumberString = "";
                }
                if (i % 5 == 0)
                {
                    Console.Write("Bar");
                    currentNumberString = "";
                }
                Console.WriteLine(currentNumberString);
            }
        }
        static void Main(string[] args)
        {
            PrintNumberWithFooBar();
        }
    }
}
