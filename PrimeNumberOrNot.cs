using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramesDay6
{
    internal class PrimeNumberOrNot
    {
        public static void PrimeNumberIdentification()
        {
            int number, primeCheck = 0;
            Console.WriteLine("Enter the number to check prime or not");
            number=int.Parse(Console.ReadLine());
            for(int i=2; i <= number; i++)
            {
                if(number%i==0)
                    {
                    primeCheck += 1;
                }
            }
            if(primeCheck == 1)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
    }
}
