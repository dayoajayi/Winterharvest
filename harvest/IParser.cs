using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace harvest
{
    public interface IParser
    {
        // command line parser
        IEnumerable<CommandLineArgument> Parse(CommandLine commandLine);
    }
}
