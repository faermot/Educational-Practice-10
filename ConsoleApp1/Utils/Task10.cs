using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public class Task10
    {
        int m, n;

        public Task10(int m, int n)
        {
            this.m = m;
            this.n = n;
        }

        public void Calculate()
        {
            int result = 0;
            for (int i = m; i <= n; i++)
            {
                result += i * i;
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}
