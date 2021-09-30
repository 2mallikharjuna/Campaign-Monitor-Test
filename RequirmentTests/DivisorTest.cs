using System;
using NUnit.Framework;
using CampaignMonitorTest;

namespace RequirmentTests
{
    [TestFixture]
    public class DivisorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(15, new int[] { 1, 3, 5, 15 })]
        [TestCase(60, new int[] { 1,2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60 })]
        [TestCase(42, new int[] { 1, 2, 3, 6, 7, 14, 21, 42 })]
        [Parallelizable(ParallelScope.All)]
        public void DivisorFactorsTests(int num, int[] returnVal)
        {            
            Assert.AreEqual(returnVal, num.DivisorFactors());
        }
    }
}
