using System;
using System.Threading;

namespace Øvelse3
{

    //The assignment said to use a threadpool but I don't know how to check these things on threads in the threadpool
    //So I used normal threads instead

    class Program
    {
        static void Main(string[] args)
        {
            Stuff s = new Stuff();

            Thread thread1 = new Thread(s.Method);
            Console.WriteLine($"Is it alive: {thread1.IsAlive}");
            thread1.Start();
            Console.WriteLine($"What is the priority on Thread1? {thread1.Priority}");
            Console.WriteLine($"Is Thread1 a background thread? {thread1.IsBackground}");
            Console.WriteLine($"Is Thread1 alive now? {thread1.IsAlive}");
            thread1.Priority = ThreadPriority.Highest;
            thread1.IsBackground = true;
            Console.WriteLine($"What is the priority on Thread1 now? {thread1.Priority}");
            Console.WriteLine($"Is Thread1 a background threadnow ? {thread1.IsBackground}");
        }
    }
    class Stuff
    {
        public void Method()
        {
            Thread.Sleep(5000);
        }
    }
}
