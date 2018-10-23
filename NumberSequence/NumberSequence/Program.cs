using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSequence
{
    internal class Program
    {
        //f(1) = 1, f(2) = 1, f(n) = (A * f(n - 1) + B * f(n - 2)) mod 7.
        private static int NumberSequence(int a, int b, int n)
        {
            if (n > 2)
                return (a * NumberSequence(a, b, n - 1) + b * NumberSequence(a, b, n - 2)) % 7;
            else
                return 1;
        }

        private static void Main(string[] args)
        {
            int a = 1, b = 2, n = 10;
            Console.WriteLine(NumberSequence(a, b, n).ToString());
            Console.Read();
        }
    }
}