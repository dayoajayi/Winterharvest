using harvest;
using NUnit.Framework;


namespace Winterharvest.tests
{
    [TestFixture]
   public class AsACommandLineParserICan
    {
        private CommandLineParser _commandLineParser;

        [SetUp]
        public void Setup()
        {
            _commandLineParser = new CommandLineParser();
        }

        [Test]
        public  void AndBeInstanced()
        {
            Assert.IsNotNull(_commandLineParser);
        }

        [Test]
        public  void AndReturnListOfCommandLineArguments()
        {
            //TODO
            Assert.IsTrue(true);
        }


    }
}
