using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    class Task6
    {
        int n;

        public Task6(int n)
        {
            this.n = n;
        }

        public void Calculate()
        {
            for (int i = 0; i < n; i++)
            {
                if (i % 5 == 0) Console.Write($"{i} ");
            }
        }
    }
}
