using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramesDay6
{
    internal class CoupansGenerate
    {
        public static void RandomCoupon()
        {
            int distinct = 0, count = 0, couponNo;
            Console.WriteLine("Enter a number of given distinct coupons:");
            couponNo = int.Parse(Console.ReadLine());
            bool[] isCollected = new bool[couponNo];
            while (distinct < couponNo)
            {
                Random random = new Random();
                int newCoupon = (int)(random.NextDouble() * couponNo);
                count++;
                if (!isCollected[newCoupon])
                {
                    distinct++;
                    isCollected[newCoupon] = true;
                }
            }

            Console.WriteLine("Total random number needed to have all distinct coupons:" + count);


        }
    }
}
