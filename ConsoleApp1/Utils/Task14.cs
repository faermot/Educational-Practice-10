using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Utils
{
    public class Task14
    {
        private int n;

        public Task14(int n)
        {
            this.n = n;
        }

        public void Calculate()
        {
            int count = 0;
            for (int i = n + 1; i <= 999; i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
