using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public class Task17
    {
        private int n;

        public Task17(int n)
        {
            this.n = n;
        }

        public void Calculate()
        {
            Console.WriteLine($"Простые делители числа {n}:");
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0 && CheckPrime(i))
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        private bool CheckPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }
    }
}
