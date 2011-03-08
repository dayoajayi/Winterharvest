using System;
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
            _options = new Options
                           {
                               {"h", parameter => Console.WriteLine("This is the help text")},
                               {"web", parameter => Console.WriteLine("You are about to harvest a web project")},
                               {"db", parameter => Console.WriteLine("You are about to harvest a databaseproject")}
                           };
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

            var bobsYourUncle = new List<string> { valueThatIsIgnoredByParseMethod, "blah", "blah2" };

            Assert.IsNotNull(_options.Parse(bobsYourUncle));
            List<string> result = _options.Parse(bobsYourUncle).ToList();

            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("blah", result[0]);
            Assert.AreEqual("blah2", result[1]);
        }

        [Test]
        public void CanCheckForRequiredArguments()
        {
            var allowedOptions = new List<string> {"h", "web", "db"};
            _options.Parse(new[] {"-h", "-web", "-db"}).ToList();
            Assert.Contains("web", allowedOptions,"must contain one of the items in allowedOptions");
        }

        [Test]
        public  void CanCheckForOptionalArguments()
        {
            //TODO
        }

        [Test]
        public    void CanEnforceWebOrDatabaseHarvesting()
        {
            //TODO
        }





    }
}