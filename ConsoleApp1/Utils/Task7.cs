using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public class Task7
    {
        int n;

        public Task7(int n)
        {
            this.n = n;
        }

        public void Calculate()
        {
            for (int i = 1; i < n; i++)
            {
                if (Math.Pow(2, i) == n)
                {
                    Console.Write("Является");
                }
            }
        }
    }
}
