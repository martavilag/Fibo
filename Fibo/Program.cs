using System;
using System.Collections;
using System.Collections.Generic;

namespace Fibo
{
    class Program
    {
        static int Sequence(int number)
        {
            
            int i = 2;

            List <int> fibonacci = new List<int>();
            fibonacci.Add(0);
            fibonacci.Add(1);

            while (i <= number)
            {
                fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
                i++;
            }

            return fibonacci[number];
        }

        static void Main(string[] args)
        {
            
        }
    }
}
