using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0_Czekaj_sr19
{
    internal class FizzBuzz
    {
        int uB;
        public FizzBuzz(int ub)
        {
            uB = ub;
        }
        public void Display()
        {
            for(int i = 1; i <= uB; i++) 
            {
                if(i % 3 != 0 && i % 5 != 0) 
                {
                    Console.Write(i);
                }
                if(i%3==0)
                {
                    Console.Write("Fizz");
                }
                if(i%5==0) 
                {
                    Console.Write("Buzz");
                }

                Console.WriteLine();

            }
        }
    }
}
