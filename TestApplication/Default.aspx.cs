using System;
using System.Linq;
using System.Web.UI;
using TestApplication.Libraries;

namespace TestApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var fibIterative = new FibonacciIterative();
            var fibRecursive = new FibonnaciRecursive();

            // Fibonacci Iterative
            FibonacciIterative.Text = string.Join(" ", fibIterative.PrintFibonacciSeries(10));
            FibonacciRecursive.Text = string.Join(" ", fibRecursive.PrintFibonacciSeries(10));
        }
    }
}