using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public class Task5
    {
        int n;

        public Task5(int n)
        {
            this.n = n;
        }

        public void Calculate()
        {
            if (n > 9999)
            {
                Console.WriteLine("Превышено ограничение. ");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i > 9)
                    {
                        string digits = Convert.ToString(i);
                        int sumDigit = 0;
                        foreach (char digit in digits)
                        {
                            sumDigit += digit - '0';
                        }

                        if (sumDigit % 5 != 0 && sumDigit % 3 == 0 && i % 5 != 0 && i % 3 == 0)
                        {
                            Console.WriteLine($"{i} | {sumDigit}");
                        }
                        sumDigit = 0;
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine($"{i} | {0}");
                    }
                }
            }
        }
    }
}
