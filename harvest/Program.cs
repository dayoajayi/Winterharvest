using System;
using System.Collections.Generic;
using System.Linq;

namespace harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = new Options();
            o.Add("d", s => {
                               Console.WriteLine("bob");
                           });
            o.Add("h", s =>
                           {
                               Console.WriteLine("This is the help menu");

                           });

            IEnumerable<string> a = o.Parse(args);
            
            var result = a.ToList();

            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
            
        }
    }
}
