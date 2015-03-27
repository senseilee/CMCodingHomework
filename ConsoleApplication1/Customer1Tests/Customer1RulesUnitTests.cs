using System;
using Customer1Rules;
using FizzBuzzLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Customer1Tests
{
    [TestClass]
    public class Customer1RulesUnitTests
    {
        private Engine engine;
        private CustomRules customer1Rules;

        [TestInitialize]
        public void Initialize()
        {
            customer1Rules = new CustomRules();
            engine = new Engine(customer1Rules);
        }

        [TestMethod]
        public void CalculateFor7()
        {
            Assert.AreEqual(engine.Calculate(7), "hello");
        }

        [TestMethod]
        public void CalculateFor10()
        {
            Assert.AreEqual(engine.Calculate(10), "goodbye");
        }

        [TestMethod]
        public void CalculateFor70()
        {
            Assert.AreEqual(engine.Calculate(70), "hellogoodbye");
        }

        [TestMethod]
        public void CalculateFor1To1000()
        {
            for (int i = 1; i <= 1000; ++i)
            {
                string expectedAnswer;

                if (i%7 == 0 && i%10 == 0)
                {
                    expectedAnswer = "hellogoodbye";
                }
                else if (i % 7 == 0)
                {
                    expectedAnswer = "hello";
                }
                else if (i%10 == 0)
                {
                    expectedAnswer = "goodbye";
                }
                else
                {
                    expectedAnswer = i.ToString();
                }

                Assert.AreEqual(expectedAnswer, engine.Calculate(i));
            }
        }
    }
}
