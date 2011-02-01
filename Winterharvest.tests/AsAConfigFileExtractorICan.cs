using harvest;
using NUnit.Framework;

namespace Winterharvest.tests
{   
    [TestFixture]
    public class AsAConfigFileExtractorICan
    {
        private ConfigFileExtractor _configFileExtractor;

        [SetUp]
        public void Setup ()
        {
            _configFileExtractor = new ConfigFileExtractor();
        }

        [Test]
        public void BeInstanced()
        {
            Assert.IsNotNull(_configFileExtractor);

        }

    }
}