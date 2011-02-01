using System.Linq;
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
        public void AndBeInstanced()
        {
            Assert.IsNotNull(_configFileExtractor);
        }

        [Test]
        public void AndReturnAKeyAndValueFromAConfigFile()
        {
            var x = _configFileExtractor.Extract(new ExtractionPoint());
            Assert.IsNotNull(x);
            Assert.IsInstanceOf(typeof(ConfigurationMetaDataElement), x.First());
          //  Assert.AreEqual("stinky", _configFileExtractor.Extract(new ExtractionPoint()));
        }
    }
}