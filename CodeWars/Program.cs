using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                TestClass.Kata.AdjacentElementsProduct(new int[] { 9, 5, 10, 2, 24, -1, -48 })
                );

            Console.WriteLine(
                TestClass.Kata.AdjacentElementsProduct(new int[] { 9 - 23, 4, -5, 99, -27, 329, -2, 7, -921 })
                );
        }



    }
}

