using System;
using NUnit.Framework;
using CampaignMonitorTest;

namespace RequirmentTests
{
    [TestFixture]
    public class StringExtensionFactoryTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(null, true)]
        [TestCase("a", false)]
        [TestCase("", true)]        
        [TestCase("null", false)]
        [Parallelizable(ParallelScope.All)]
        public void IsNullOrEmptyTests(String strCheck, bool returnVal)
        {
            Assert.AreEqual(strCheck.IsNullOrEmpty(), returnVal);
        }
    }
}