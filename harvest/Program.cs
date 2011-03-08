using System;
using System.Collections.Generic;
using System.Linq;

namespace harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var help = true;
            bool CallJimsExtractionMethod = false;
            var options = new Options{
                {"?|help|h", "Prints out the options.", option => help = option != null},
                {"d=|db=|database=|databasename=","REQUIRED: DatabaseName - the database you want to harvest",option => CallJimsExtractionMethod = true},
                {"web=|server=|webserver=", "REQUIRED: WebserverName = the web project that you want to harvest",option => CallJimsExtractionMethod = true}};

            if(help)
            {
                const string usageMessage =
                    "harvest web -d[atabase] VALUE -NHibernate -masstransit";
                ShowHelp(usageMessage,options);
            }

            try
            {
                options.Parse(args).ToList();
            }
            catch(OptionException)
            {
                ShowHelp("Error - usage is: ", options);
            }   
        }

        private static void ShowHelp(string message, Options options)
        {
            Console.Error.WriteLine(message);
            options.WriteOptionDescriptions(Console.Error);
            Environment.Exit(-1);
        }
    }

    internal class OptionException : Exception
    {
    }
}
