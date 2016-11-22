using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectEuler
{
    /// <summary>
    /// Problem 4: Largest palindrome product
    /// https://projecteuler.net/problem=4
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public class Prb4_LargestPalindromeProduct
    {
        //Function for determining a number is palindrome number
        public bool IsPalindromeNumber(int number)
        {
            var number2string = number.ToString();
            var length = number2string.Length;
                      
            for (int i = 0; i < length / 2 ; i++)
            {
                if (number2string[i] != number2string[length - i - 1])
                {
                    return false;
                }                
            }
            return true;                   
        }

        // Function for find palindrome number list
        public int PalindromeNumbersList(int digitNumber)
        {           
            var minimum = Convert.ToInt32(Math.Pow(10, digitNumber - 1));
            var maximum = Convert.ToInt32(Math.Pow(10, digitNumber) - 1);

            var palindNumberList = Enumerable.Range(minimum, maximum - minimum + 1).ToArray();

            var enumable = Enumerable.Range(minimum, maximum - minimum + 1)                             
                             .SelectMany(x => palindNumberList.Select(y => x * y))
                             .Where(IsPalindromeNumber);
            return enumable.Max();
        }
        
    }
}