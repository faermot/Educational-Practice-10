using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public class Task4
    {
        int n;

        public Task4(int n)
        {
            this.n = n;
        }

        public void Calculate()
        {
            int S = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    S += i * i;
                }
                else
                {
                    S += i * i * i;
                }
            }
            Console.WriteLine(S);
        }
    }
}
