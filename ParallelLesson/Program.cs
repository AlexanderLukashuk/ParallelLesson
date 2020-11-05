using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parallel.Invoke(() =>
            //{
            //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            //}, () =>
            //{
            //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            //}, () =>
            //{
            //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            //}, () =>
            //{
            //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            //}, () =>
            //{
            //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            //}, () =>
            //{
            //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            //}, () =>
            //{
            //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            //}, () =>
            //{
            //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            //}, () =>
            //{
            //    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            //});


            //Parallel.For(0, 10, (i) =>
            //{
            //    Console.WriteLine(i);
            //});

            //Parallel.ForEach(new List<string> { "Astana", "Almaty", "Kostanay" }, (cityName) =>
            //{
            //    Console.WriteLine(cityName);
            //});

            var list = new List<string>
            {
                "Astana", "Almaty", "Kostanay", "Moscow", "Grozniy"
            };

            var result = list.AsParallel()
                .AsOrdered()
                .Where(cityName =>
                {
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} - {cityName} - {DateTime.Now.Ticks}");
                    return cityName.Contains("a");
                })
                .ToList();


            Console.ReadLine();

        }
    }
}
