using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Q8_NumWidth
    {
        public void GetTriNumWidth()
        {
            int num;
            int w;
            Console.WriteLine("Enter your number");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the disired width");
            w = int.Parse(Console.ReadLine());
            for (int i = w; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                { Console.Write(num); }

                Console.WriteLine();
            }

        }
    }
}
