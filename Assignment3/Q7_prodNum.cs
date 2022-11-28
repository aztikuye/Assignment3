using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Q7_prodNum
    {
        public void GetNumProd()
        {
            int num;
            Console.WriteLine("enter your number");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(num + "*" + i + "=" + num * i);
            }
            

        }

    }
}
