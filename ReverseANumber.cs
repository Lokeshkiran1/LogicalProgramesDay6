using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramesDay6
{
    internal class ReverseANumber
    {
        public static void reverseNumber()
        {
            int number, temp, remainder, reverse = 0;
            Console.WriteLine("Enter the number ");
            number = int.Parse(Console.ReadLine());
            temp = number;
            while (number > 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }
            Console.WriteLine("Original given number is = {0}", temp);
            Console.WriteLine("The final reversed number is = {0}", reverse);
        }
    }
}
