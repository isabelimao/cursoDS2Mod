using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeFibonacchi
{
    class Class1
    {
        public static int[] Fibonacci(int numElement)
        {
            int n = numElement - 1;
            int[] a = new int[numElement + 1];
            a[0] = 0;
            a[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                a[i] = a[i - 2] + a[i - 1];
            }
            return a;
        }
    }
}
