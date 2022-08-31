using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramesDay6
{
    internal class PerfectNumber
    {
        public static void PerfectNumberIdentification()
        {
            int n, i, sum;
            Console.WriteLine("check whether a given number is perfect number or not");
            Console.WriteLine("enter the number:");
            n=int.Parse(Console.ReadLine());
            sum = 0;
            Console.WriteLine("positive factors are");
            for(i = 1; i < n; i++)
            {
                if(n%i==0)
                {
                    sum+=i;
                    Console.WriteLine("{0}",i);
                }
            }
            Console.WriteLine("the sum of the factors: {0}",sum);
            if(sum==n)
            {
                Console.WriteLine("the number is a perfect number");
            }
            else
            {
                Console.WriteLine("the number is not a perfect number");
            }
        }
    }
}
