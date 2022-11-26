using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Q3
    {
        public void GetReverseTriangel()
        {
            for (int i = 7; i >0; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
}
