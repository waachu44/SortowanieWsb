using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] tab = new int [100];
            Stopwatch stopwatch = new Stopwatch();
            for (int i = 0 ; i <= 90; i+=10)
            {

                tab[i] = i;
                
            }
            foreach (var item in tab)

            {
                stopwatch.Start();
                Console.WriteLine(item+" "+stopwatch.ElapsedTicks);
                stopwatch.Stop();
                stopwatch.Reset();
            }
            Console.ReadKey();
        }

    }
}
