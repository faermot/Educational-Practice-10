using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public class Task20
    {
        private int n;

        public Task20(int n)
        {
            this.n = n;
        }

        public void Calculate()
        {
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                long term = 1;
                for (int j = i; j <= 2 * i; j++)
                {
                    term *= j;
                }
                sum += term;
            }
            Console.WriteLine(sum);
        }
    }
}
