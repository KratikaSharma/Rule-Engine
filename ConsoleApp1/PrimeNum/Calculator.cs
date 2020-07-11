using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.PrimeNum
{
    public static class Calculator
    {
        public static List<int> getPrimeNumer(int num)
        {
            List<int> primeNumbers = new List<int>();
           
            for(int i = 0; i <= num; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= i - 1; j++)
                {
                    if(i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && i != 0 && i != 1)
                {
                    primeNumbers.Add(i);
                }
            }
            return primeNumbers;
        }

        public static bool isNumberPrime(int num)
        {
            bool isPrime = true;
            for (int j = 2; j <= num - 1; j++)
            {
                if (num % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }


    }
}
