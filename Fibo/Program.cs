using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Fibo
{
    public class Program
    {
        public static int Sequence(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Can't use a negative number.");
            }

            return number switch
            {
                0 => 0,
                1 => 1,
                2 => 1,
                _ => Sequence(number - 1) + Sequence(number - 2),
            };
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sequence(12));
        }
    }
}
