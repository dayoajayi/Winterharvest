using harvest;
using NUnit.Framework;
using System.Collections.Generic;

namespace Winterharvest.tests
{
    [TestFixture]
    public class AsAnOptionsICan
    {
        private Options _options;

        [SetUp]
        public void BeSetup()
        {
            _options = new Options();
        }

        [Test]
        public void BeInstanced()
        {
            Assert.IsNotNull(_options);
        }

        [Test]
        public void CanCallTheParseMethod()
        {
            var bobsYourUncle = new List<string> {"--", "blah", "blah"};

            Assert.IsNotNull(_options.Parse(bobsYourUncle));
            IEnumerable<string> result = _options.Parse(bobsYourUncle);
            if (result is List<string>)
            {
                Assert.Fail();
            }
            //Assert.AreEqual(0,result.GetEnumerator());

        }


    }
}