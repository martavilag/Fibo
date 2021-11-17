﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Fibo
{
    class Program
    {
        static int Sequence(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Can't use a negative number.");
            }

            return number switch
            {
                0 => 0,
                1 => 1,
                _ => Sequence(number - 1) + Sequence(number - 2),
            };
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Sequence(i));
            }
        }
    }
}
