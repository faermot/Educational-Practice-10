using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public class Task11
    {
        private int m, n;

        public Task11(int m, int n)
        {
            this.m = m;
            this.n = n;
        }

        public void Calculate()
        {
            int sum = 0;
            for (int i = m; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i * i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
