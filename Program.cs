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
		//create list to hold primes
        {  List<int> myPrimes = new List<int>();
		//call fibonacci
        EvenFibonacciSequencer(13);
		//call longest collatz
        LongestCollatzSequence();
           // primerunner(15);not working
        Console.Read();
       //not working Console.WriteLine(myPrimes);//
        }      
		//this isPrime function returns true or false given a number regarding Prime status
       static public bool IsPrime(int num1)
        {
            if (num1 == 0 || num1 == 1)
            {//get 0 and 1 out of the way
                Console.WriteLine(num1 + " is not prime number");
                return false;

            }
            else
            {//test for not primes
                for (int a = 2; a <= num1; a++)
                {
                    if (num1 % a == 0)
                    {
                        Console.WriteLine(num1 + " is not prime number");
                        return false;
                    }
                    
                   
                       
                    }//must be prime now
                } Console.WriteLine(num1 + " is a prime number");
                        return true;
                
            }//runs the prime function for the set number
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
			//test each number through is prime until Nth prime
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
		//fib function
        static void EvenFibonacciSequencer(int maxValue){
            List<int> myEvens = new List<int>();
            int h = 1; //#1
            int j = 2; //#2
            int evens = 0;
            for (int i = 0; i < maxValue; i++)//for loop until speccified
            {
                int temp = h;
                h = j;
                j = temp + j;
                if (j % 2 == 0)
                {
                    evens = evens + j;
                }
            }
            Console.WriteLine(evens);//print evens
        }
        static void LongestCollatzSequence()
        {
            long start = 837799;//start number
            while (start > 1){//while there is still reducing to be done
            if (start % 2 == 0)//if it's even do this
            {
                start = start / 2;
            }
            else { start = ((start * 3) + 1); };//else odd do this
            Console.WriteLine(start);//print finished
            }

        }
            }
        }
        
        
