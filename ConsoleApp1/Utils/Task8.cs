using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public class Task8
    {
        int n;

        public Task8(int n)
        {
            this.n = n;
        }

        public void Calculate() 
        {
            for (int i = n; i != 1;)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} | 2");
                    i /= 2;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} | 3");
                    i /= 3;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} | 5");
                    i /= 5;
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine($"{i} | 7");
                    i /= 7;
                }
                else
                {
                    Console.WriteLine("Число, мать его, простое!");
                    break;
                }
            }
        }
    }
}
