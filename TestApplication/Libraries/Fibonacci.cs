using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Libraries
{
    public abstract class Fibonacci
    {
        public abstract int GetFibonnaciNumber(int number);

        public IEnumerable<int> PrintFibonacciSeries(int number)
        {
            for (int i = 0; i < number; i++)
            {
                yield return GetFibonnaciNumber(i);
            }
        }
    }
}