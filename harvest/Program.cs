using System;
using System.Collections.Generic;
using Mono.Documentation;

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
           
            IEnumerable<string> a=  o.Parse(new string[] {"/d"});
            var b = o.Parse(new[] {"a"});
        }
    }
}
