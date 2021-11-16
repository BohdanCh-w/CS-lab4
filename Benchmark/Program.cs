using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time for classes:" + CalculateClasses());
            Console.WriteLine("Time for structs:" + CalculateStructures());
        }

        public static long CalculateClasses()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 100_000; i++)
            {
                using (AnalisisResultClass analisis = new AnalisisResultClass(1, 1.0, "", new Dictionary<string, string>()))
                {
                    
                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }

        public static long CalculateStructures()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 100_000; i++)
            {
                using (AnalisisResultStruct analisis = new AnalisisResultStruct(1, 1.0, "", new Dictionary<string, string>()))
                {

                }
            }
            stopwatch.Stop();
            return stopwatch.ElapsedTicks;
        }
    }
}
