using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public class Task19
    {
        private int m, n;

        public Task19(int m, int n)
        {
            this.m = m;
            this.n = n;
        }

        public void Calculate()
        {
            long product = 1;
            for (int i = m; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    product *= i * i;
                }
            }
            Console.WriteLine(product);
        }
    }
}
