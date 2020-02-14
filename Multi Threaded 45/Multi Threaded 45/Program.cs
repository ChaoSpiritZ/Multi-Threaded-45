using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threaded_45
{
    class Program
    {
        static void Main(string[] args)
        {
            // QUESTION 12

            //CancellationTokenSource cancelToken = new CancellationTokenSource();
            //Task<int> t1 = Task.Run<int>(() =>
            //{
            //    int counter = 0;
            //    int sum = 0;
            //    while (!cancelToken.IsCancellationRequested)
            //    {
            //        counter++;
            //        sum += counter;
            //        Console.WriteLine(sum);
            //        Thread.Sleep(500);
            //    }
            //    return sum;
            //}, cancelToken.Token).ContinueWith((Task<int> antecendent) =>
            //{
            //    return antecendent.Result;
            //});
            //Console.ReadLine();
            //cancelToken.Cancel();
            //Console.WriteLine($"summing stopped at {t1.Result}");

            //QUESTION 13

            Task t2 = Task.Run(() =>
            {
                int[] ints = new int[5];
                int x = ints[10];
            });
            Thread.Sleep(1000);
            if (t2.IsFaulted)
            {
                t2.Exception.Handle(ex => { Console.WriteLine(ex); return true; });
            }

            Console.WriteLine("text after exception");
        }
    }
}
