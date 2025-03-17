using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public class Task1
    {
        int a, n;

        public Task1(int a, int n)
        {
            this.a = a;
            this.n = n;
        }

        public void Calculate()
        {
            Console.WriteLine(Math.Pow(a, n));
        }
    }
}
