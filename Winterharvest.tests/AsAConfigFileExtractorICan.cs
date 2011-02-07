using System.Linq;
using System.Collections.Generic;
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
            Assert.AreEqual("poop", ((ConfigurationMetaDataElement)x.First()).Key);
            Assert.AreEqual("stinky", ((ConfigurationMetaDataElement)x.First()).Value);
        }
    }
}