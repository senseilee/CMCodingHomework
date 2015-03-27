using System;
using ConsoleApplication1;
using FizzBuzzLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTester
{
    [TestClass]
    public class UnitTest1
    {
        private FizzBuzzLibrary.Engine engine;
        private ConsoleApplication1.OriginalRules originalRules;
        
        [TestInitialize]
        public void Initialize()
        {
            originalRules = new OriginalRules();
            engine = new Engine(originalRules);
        }

        [TestMethod]
        public void CalculateFor3()
        {
            Assert.AreEqual(engine.Calculate(3), "fizz");
        }

        [TestMethod]
        public void CalculateFor5()
        {
            Assert.AreEqual(engine.Calculate(5), "buzz");
        }

        [TestMethod]
        public void CalculateFor15()
        {
            Assert.AreEqual(engine.Calculate(15), "fizzbuzz");
        }

        [TestMethod]
        public void CalculateForAnyOther()
        {
            Assert.AreEqual(engine.Calculate(7), "7");
        }
    }
}
