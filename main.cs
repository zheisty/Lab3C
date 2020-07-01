using System;
using System.Diagnostics.Tracing;

namespace Lab3C
{
    class Program
    {
        static void Main(string[] args)
        {
            double remain;
            int nP = 0;

            Console.WriteLine("Enter Number ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int prime = 2; prime < number; prime++)
            {

                    remain = number % prime;
                    if (remain == 0) 
                    {
                        Console.WriteLine("The Number " + number + " is Not Prime");
                        nP++;
                    break;
                    }

                if (nP > 0)
                {
                    Console.WriteLine("The Number is " + number + " is Not Prime");
                }
                else 

                { 
                    Console.WriteLine("The Number is" + number + " is Prime");
                }

                   
            }
        }
    }
}
