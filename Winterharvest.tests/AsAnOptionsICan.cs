using System.Linq;
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
        public void CanStepIntoTheParseMethodIfICallToListOnTheIEnumberableItReturns()
        {
            string valueThatIsIgnoredByParseMethod = "--";

            var bobsYourUncle = new List<string> { valueThatIsIgnoredByParseMethod, "blah", "blah" };

            Assert.IsNotNull(_options.Parse(bobsYourUncle));
            IEnumerable<string> result = _options.Parse(bobsYourUncle).ToList();

            Assert.AreEqual(2, result.Count());


        }


    }
}