using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk3
{
    class Program
    {
        static void Main(string[] args)
        {  List<int> myPrimes = new List<int>();
        EvenFibonacciSequencer(13);
        LongestCollatzSequence();
           // primerunner(15);not working
        Console.Read();
       //not working Console.WriteLine(myPrimes);//
        }      
       static public bool IsPrime(int num1)
        {
            if (num1 == 0 || num1 == 1)
            {
                Console.WriteLine(num1 + " is not prime number");
                return false;

            }
            else
            {
                for (int a = 2; a <= num1; a++)
                {
                    if (num1 % a == 0)
                    {
                        Console.WriteLine(num1 + " is not prime number");
                        return false;
                    }
                    
                   
                       
                    }
                } Console.WriteLine(num1 + " is a prime number");
                        return true;
                
            }
        static void primerunner(int NthPrime){
            
            //int i = 0;
            //while (i < NthPrime)
            //{
            //    if (IsPrime(i) == true)
            //    {
            //        i++;
            //    }
            //}
            int numbercounter = 0;
            while (numbercounter < NthPrime)
            {
                for (int i = 0; i < NthPrime; i++)
                {
                    if (IsPrime(i)==false)
                    {

                        i++;
                    }

                    else if (IsPrime(i)==true)
                    {
                        Console.WriteLine(i + " " + numbercounter);
                        //myPrimes.Add(i);
                        i++;
                        numbercounter++;

                    }
                };
            }
           
        }
        static void EvenFibonacciSequencer(int maxValue){
            List<int> myEvens = new List<int>();
            int h = 1;
            int j = 2;
            int evens = 0;
            for (int i = 0; i < maxValue; i++)
            {
                int temp = h;
                h = j;
                j = temp + j;
                if (j % 2 == 0)
                {
                    evens = evens + j;
                }
            }
            Console.WriteLine(evens);
        }
        static void LongestCollatzSequence()
        {
            long start = 837799;
            while (start > 1){
            if (start % 2 == 0)
            {
                start = start / 2;
            }
            else { start = ((start * 3) + 1); };
            Console.WriteLine(start);
            }

        }
            }
        }
        
        
