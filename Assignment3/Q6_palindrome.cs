using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Q6_palindrome
    {
        public void isPalindrome()
        {
            string word;
            string reversedWord;
            Console.WriteLine("Please enter your word");
            word = Console.ReadLine();

            //char[] wordchar=word.ToCharArray();
            reversedWord=string.Empty;

            for(int i =word.Length-1; i>=0; i--)
            {
                reversedWord += word[i];
            
            }

            if(string.Compare(word,reversedWord,true)==0)
                Console.WriteLine("The word {0} is Palindrome", word);
            else Console.WriteLine("The word {0} is not Palindrome", word);
        }
    }
}
