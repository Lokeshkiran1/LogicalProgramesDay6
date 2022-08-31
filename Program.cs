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
            Console.WriteLine("select choice:\n1.Fibonacci Series\n2.Perfect Number Identification\n3.Prime Number or not\n4.Reverse given number\n5.stop watch");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    FibonacciSeries.fibonacciSeries();
                    break;
                    case 2:
                    PerfectNumber.PerfectNumberIdentification();
                    break;
                case 3:
                    PrimeNumberOrNot.PrimeNumberIdentification();
                    break ;
                case 4:
                    ReverseANumber.reverseNumber();
                    break ;
                case 5:
                    StopWatchProgram.stopWatch();
                    break;
                    default:
                    Console.WriteLine("please enter the correct choice");
                    break;
            }
        }
    }
}
