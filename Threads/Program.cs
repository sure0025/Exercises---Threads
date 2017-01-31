using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start\n");
            
            Thread thread1 = new Thread(new ThreadStart(OldThread.Message1));
            thread1.Start();

         //   Thread.Sleep(1000); //sleeps for 1 second

            Thread thread2 = new Thread(new ThreadStart(OldThread.Message2));
            thread2.Start();
            

            thread1.Join();
            thread2.Join();
            Console.WriteLine("\nEnter for Exit");
            Console.ReadLine();
            Console.WriteLine("EXIT");
        }
    }
}
