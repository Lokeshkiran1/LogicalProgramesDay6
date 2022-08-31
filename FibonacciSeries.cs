using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramesDay6
{
    internal class FibonacciSeries
    {
        public static void fibonacciSeries()
        {
            int num1 = 0,num2=1,sum=0;
            Console.WriteLine("enter the range of Fibonacci Series:");
            int range=int.Parse(Console.ReadLine());
            Console.WriteLine("{0}\n{1}",num1,num2);
            for(int i=2;i<range;i++)
            {
                sum = num1 + num2;
                Console.WriteLine("{0}",sum);
                num1 = num2;
                num2 = sum;
            }
        }
    }
}
