using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IO_Lab_1_Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {

            ThreadPool.QueueUserWorkItem(ThreadProc, new object[] { 2000 });
            ThreadPool.QueueUserWorkItem(ThreadProc, new object[] { 1000 });
            Thread.Sleep(5000);

        }
        static void ThreadProc(Object stateInfo)
        {
            var integer = ((object[])stateInfo)[0];
            Thread.Sleep((int)integer);
            Console.WriteLine("Poczekalem " + integer + "s");
        }

    }
}
