using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Q4
    {
        public void  GetReverseName( string name)
        {
           
            int len = name.Length - 1;
            for (int i = len; i >=0; i--)
            {
               //return name[i].ToString();
                Console.Write(name[i]);
            }
          
        }


    }
}
