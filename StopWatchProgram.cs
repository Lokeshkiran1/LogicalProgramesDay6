using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogicalProgramesDay6
{
    internal class StopWatchProgram
    {
        public static void stopWatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for(int i=0; i < 1; i++)
            {
                Thread.Sleep(100);
            }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed:{0}",stopwatch.Elapsed);
        }
    }
}
