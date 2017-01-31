using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class OldThread
    {

      
        public static void Message1()
        {
            bool isRunning = true;
            int count = 0;
            while (isRunning)
            {
                Console.WriteLine("C # threads is easy!");
                count++; //add to the count
                Thread.Sleep(1000);
                if (count == 5)
                {
                    isRunning = false;

                }
            }
        }
           public static void Message2()
        {
            bool isRunning = true;
            int count = 0;
            while (isRunning)
            {
                Console.WriteLine("Also, with mulitple threads ...");
                count++; //add to the count
                Thread.Sleep(1000);
                if (count == 5)
                {
                    isRunning = false;

                }
            }
           

        }

       
    }
}
