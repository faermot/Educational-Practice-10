using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public class Task12
    {
        public Task12() { }

        public void Calculate()
        {
            long product = 1;
            for (int i = -80; i <= 80; i++)
            {
                if (i % 2 != 0 && i % 7 == 0)
                {
                    product *= i;
                }
            }
            Console.WriteLine(product);
        }
    }
}
