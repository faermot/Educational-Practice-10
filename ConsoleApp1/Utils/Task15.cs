using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public class Task15
    {
        private int n;

        public Task15(int n)
        {
            this.n = n;
        }

        public void Calculate()
        {
            Console.WriteLine($"Числа, взаимно простые с {n}:");
            for (int i = 1; i < n; i++)
            {
                if (NOD(i, n) == 1)
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
