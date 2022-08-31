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
            int a = 0,b=1,c=0;
            Console.WriteLine("enter the range of Fibonacci Series:");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("{0},\n{1}",a,b);
            for(int i=2;i<n;i++)
            {
                c = a + b;
                Console.WriteLine("{0}",c);
                a = b;
                b = c;
            }
        }
    }
}
