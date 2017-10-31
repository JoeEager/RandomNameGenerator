using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomNameGenerator;

namespace RandomNameGeneratorTests
{
    [TestClass]
    public class TestRandomNameGenerator
    {
        [TestMethod]
        public void GetRandomLastName()
        {
            var test = new RandomNameGenerator.RandomNameGenerator();

            var results=test.GetRandomLastName();


            Assert.IsNotNull(results);
            Assert.IsInstanceOfType(results, typeof(string));

        }

        [TestMethod]
        public void GetRandomFemaleFirstName()
        {
            var test = new RandomNameGenerator.RandomNameGenerator();

            var results = test.GetRandomFemaleFirstName();


            Assert.IsNotNull(results);
            Assert.IsInstanceOfType(results, typeof(string));

        }

        [TestMethod]
        public void GetRandomMaleFirstName()
        {
            var test = new RandomNameGenerator.RandomNameGenerator();

            var results = test.GetRandomMaleFirstName();


            Assert.IsNotNull(results);
            Assert.IsInstanceOfType(results, typeof(string));

        }
        [TestMethod]
        public void GetRandomPercentBasedLastName()
        {
            var test = new RandomNameGenerator.RandomNameGenerator();

            var results = test.GetRandomLastName(13);


            Assert.IsNotNull(results);
            Assert.IsInstanceOfType(results, typeof(string));

        }

        [TestMethod]
        public void GetRandomPercentBasedFemaleFirstName()
        {
            var test = new RandomNameGenerator.RandomNameGenerator();

            var results = test.GetRandomFemaleFirstName(75);


            Assert.IsNotNull(results);
            Assert.IsInstanceOfType(results, typeof(string));

        }

        [TestMethod]
        public void GetRandomPercentBasedMaleFirstName()
        {
            var test = new RandomNameGenerator.RandomNameGenerator();

            var results = test.GetRandomMaleFirstName(30);


            Assert.IsNotNull(results);
            Assert.IsInstanceOfType(results, typeof(string));

        }
    }
}
