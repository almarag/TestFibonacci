using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Libraries
{
    public class FibonacciIterative : Fibonacci
    {
        public override int GetFibonnaciNumber(int number)
        {
            var a = 0;
            var b = 1;

            for (var i = 0; i < number; i++)
            {
                int temp = a;
                a = b;
                b = temp + a;
            }

            return a;
        }
    }
}