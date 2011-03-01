using System;
using System.Collections.Generic;
using System.Linq;

namespace harvest
{
    class Program
    {
        static void Main(string[] args)
        {


            var options = new Options();

            options.Add("h", s => Console.WriteLine("This is the help text"));
            options.Parse(new[] {"-h"}).ToList();
            Console.ReadKey();

            // Action<T> works like a sub, or a void method: takes T as a param
            // Action<T1,T2> void method that takes two parameters
            // Func<T> it's a lambda that returns T
            // Func<T1,T2> takes T1, and returns T2
            // var x = 


        }
    }
}
