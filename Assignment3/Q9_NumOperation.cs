using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Q9_NumOperation
    {
        public void NumOperation()
        {
            int num1; int num2;
            string oper;
            Console.WriteLine("Enter number 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation");
            oper = Console.ReadLine();
            Console.WriteLine("Enter number 2");
            num2 = int.Parse(Console.ReadLine());

            switch (oper)
            {
                case "+":
                    Console.WriteLine("result is " + num1 + oper + num2 + "= {0}", num1 + num2);
                    break;
                case "-":
                    Console.Write("result is " + num1 + oper + num2 + "=  {0}", num1 - num2);
                    break;

                case "*":
                    Console.WriteLine("result is " + num1 + oper + num2 + "= {0}", num1 * num2);
                    break;

                case "/":
                    Console.WriteLine("result is " + num1 + oper + num2 + "= {0}", num1 / num2);
                    break;

                default:
                    Console.WriteLine("please enter valid operation ");
                    break;

            }
                       
        }

        public void GetCircleAreaPer()
        {
            int rad;
            const double pi = 3.14;
            Console.WriteLine("Please enter radius");
            rad = int.Parse(Console.ReadLine());

            Console.WriteLine("Area of the circle is {0}", pi*rad*rad );
            Console.WriteLine("Permiter of the circle is {0}", 2*pi*rad );

        }
    }

}
