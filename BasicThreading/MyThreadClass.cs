using System;
using System.Threading;

namespace BasicThreading
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            Thread thread = Thread.CurrentThread;

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + i);
                Thread.Sleep(500);
            }
        }
    }
}