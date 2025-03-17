using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public class Task16
    {
        private int p, q;

        public Task16(int p, int q)
        {
            this.p = p;
            this.q = q;
        }

        public void Calculate()
        {
            Console.WriteLine($"Делители числа {q}, взаимно простые с {p}:");
            for (int i = 1; i <= q; i++)
            {
                if (q % i == 0 && NOD(i, p) == 1)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        private int NOD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
