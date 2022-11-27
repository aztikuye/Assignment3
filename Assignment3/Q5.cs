using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Q5
    {
        public void IsEvnOdd()
        {
            Console.WriteLine("Enter your number ");
           int num = int.Parse(Console.ReadLine());

            if(num%2==0) { Console.WriteLine("number {0} is Even", num); }
            else { Console.WriteLine("number {0} is Odd", num); }

        }

        public void IsPrime()
        {
            Console.WriteLine("Please enter your number");
            int num=int.Parse(Console.ReadLine());
            int a = 0;
            for(int i = 1; i <= num; i++)
            { if(num%i==0)
                a++;
            }
            if (a == 2) Console.WriteLine("number {0} is Prime", num);
            else if (a > 2) Console.WriteLine("number {0} is not Prime", num);
            else Console.WriteLine("enter valid number" );
        }
    }
}
