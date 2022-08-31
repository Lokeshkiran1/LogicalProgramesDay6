using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramesDay6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("select choice:\n1.Fibonacci Series");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    FibonacciSeries.fibonacciSeries();
                    break;
                    default:
                    Console.WriteLine("please enter the correct choice");
                    break;
            }
        }
    }
}
