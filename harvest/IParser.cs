using System.Collections.Generic;

namespace harvest
{
    public interface IParser
    {
        // command line parser
        IEnumerable<CommandLineArgument> Parse(CommandLine commandLine);
    }
}

