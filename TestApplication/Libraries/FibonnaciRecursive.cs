using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Libraries
{
    public class FibonnaciRecursive : Fibonacci
    {
        public override int GetFibonnaciNumber(int number)
        {
            return ((number == 0) || (number == 1)) ? number : GetFibonnaciNumber(number - 2) + GetFibonnaciNumber(number - 1);
        }
    }
}