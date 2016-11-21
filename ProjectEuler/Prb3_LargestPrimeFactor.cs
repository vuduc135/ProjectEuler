using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public class Prb3_LargestPrimeFactor
    {
        public IEnumerable<long> Find_Prime_Factor(long number)
        {
            IList<long> primesList = new List<long> {};
            //private readonly IList<int> _fibonacciList = new List<int> { 1, 2 }; 
            
            if (number <= 3)
            {
                primesList.Add(number);
            }
            else
            {
                //int sqrtNumber = (int)Math.Sqrt(number);
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if ((number%i ==0) && Is_Prime_Number(i))
                    {
                        primesList.Add(i);
                    }
                }
                if (primesList.Count == 0) primesList.Add(number);
            }
            return primesList;
        }

        //Function to check a number is prime
        public bool Is_Prime_Number(long number)
        {
            if (number < 2)
            {
                return false;
            }
            else if (number == 2 || number == 3)
            {
                return true;
            }
            else
            {
                for (int i = 2; i <= (Math.Sqrt(number)); i++)
                {
                    if (number%i == 0)
                        return false;
                }
                return true;
            }
            //return true;
        }
    }
}