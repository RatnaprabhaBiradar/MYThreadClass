using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace MYThreadClass
{
    public class MultiThread12
    {
        public void Run()
        {
            Thread t = Thread.CurrentThread;
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(t.Name);
                Console.WriteLine(i);
                Thread.Sleep(600);
            }

        }
        public void Run2()
        {
            Thread t = Thread.CurrentThread;
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(t.Name);
                Console.WriteLine(i);
                Thread.Sleep(600);
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            MultiThread12 mythread = new MultiThread12();
            Thread first = new Thread(new ThreadStart(mythread.Run));
            Thread second = new Thread(new ThreadStart(mythread.Run));
            Thread thired = new Thread(new ThreadStart(mythread.Run2));
            first.Name = "First Thread";
            second.Name = "Second Thread";
            thired.Name = "Thired Thread";
            first.Priority = ThreadPriority.Lowest;
            second.Priority = ThreadPriority.BelowNormal;
            thired.Priority = ThreadPriority.Highest;
            first.Start();
            first.Join();
            second.Start();
            thired.Start();




        }
    }
}
