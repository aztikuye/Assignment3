using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Q1: Write a program to list numbers from 1 to 100 separated by comma");
            Console.WriteLine("=====ANSWER Q1========");
                
            Q1 q = new Q1();
            q.ListNumbers();

            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Q2: Write a program to show numbers in a trinagle:");
            Console.WriteLine("=====ANSWER Q2========");

            Q2 q2 = new Q2();
            q2.GetTriNumber();
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Q3: Write a program to show numbers in a reverse trinagle:");
            Console.WriteLine("=====ANSWER 32========");

            Q3 q3 = new Q3();
            q3.GetReverseTriangel();

            /*
            int sum=0;
            int prod = 1;
            for(int i = 0; i < 10; i++)
            {
                sum += i;
                prod+=prod+i;
                i++;
            }
            Console.WriteLine( " The sum of numbers is {0}: ", sum);
            Console.WriteLine(" The product of numbers is {0}: ", prod);
           
            */
            Console.ReadLine();
        }
        
    }
}
