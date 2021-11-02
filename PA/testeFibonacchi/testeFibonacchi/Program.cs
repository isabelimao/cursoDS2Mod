using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeFibonacchi
{
    class Program
    {
       
            public int MyProperty { get; set; }
        int[] Fibonacci(int numElement)
            {
                if (numElement < 2)
                    throw new ArgumentOutOfRangeException("numElement", numElement, "Fibonnaci number to get must be greater or equal than 0");

                var n = numElement + 1; //you need n+1 positions. The 9th number is in 10th position
                var a = new int[n];
                a[0] = 0;

                if (numElement == 0)
                    return a;

                a[1] = 1;

                for (var i = 2; i < n; i++)
                    a[i] = a[i - 2] + a[i - 1];

                return a;
            }

        }
   
}
