﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using harvest;
using NUnit.Framework;


namespace Winterharvest.tests
{
    [TestFixture]
    class AsACommandLineParserICan
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
