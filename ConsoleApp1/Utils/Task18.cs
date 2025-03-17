using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public class Task18
    {
        public Task18() { }

        public void Calculate()
        {
            int count = 0;
            int num = 2;
            Console.WriteLine("Первые 100 простых чисел:");
            while (count < 100)
            {
                if (CheckPrime(num))
                {
                    Console.Write($"{num} ");
                    count++;
                }
                num++;
            }
            Console.WriteLine();
        }

        private bool CheckPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
