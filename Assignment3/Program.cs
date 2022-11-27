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
            Console.WriteLine("=====ANSWER Q3========");

            Q3 q3 = new Q3();
            q3.GetReverseTriangel();
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Q4: Write a program to revert your name ");
            Console.WriteLine("=====ANSWER Q4========");

            Q4 q4 = new Q4();
            string getname;
            string upperName;
            int lenName;
           

            Console.WriteLine("Please enter your name; ");
            getname = Console.ReadLine();
            upperName = getname.ToUpper();
            lenName = getname.Length;
            
            Console.WriteLine("your name is "  + getname + " In upper case " + upperName + " Length of your name " + lenName);

            Console.WriteLine("your name in reverse order is:" );
            q4.GetReverseName(getname);

            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Q5: check weather a number is even/odd, prime/composite  ");
            Console.WriteLine("=====ANSWER Q5========");

            Q5 q5 = new Q5();
            q5.IsEvnOdd();
            q5.IsPrime();

            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("Q6: check if a word is a palindrome or not ( ");
            Console.WriteLine("=====ANSWER Q6========");

            Q6_palindrome q6 = new Q6_palindrome();
            q6.isPalindrome();

            Console.WriteLine(); Console.WriteLine();
            /*
            Console.WriteLine("Q7: Write a C# Sharp program that takes a number as input and print its multiplication table  ");
            Console.WriteLine("=====ANSWER Q7========");

            Q7_prodNum q7= new Q7_prodNum();
            q7.GetNumProd();
            */

            Console.ReadLine();
        }
        
    }
}
