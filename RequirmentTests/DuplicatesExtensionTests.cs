using System;
using System.Linq;
using NUnit.Framework;
using CampaignMonitorTest;

namespace RequirmentTests
{
    [TestFixture]
    public class DuplicatesExtensionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new int[] { 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 }, new int[] { 5, 4, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 1, 6, 7 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { })]
        [Parallelizable(ParallelScope.All)]
        public void findDuplicatesTest(int[] numsInput, int[] returnVal)
        {
            var actualResult = numsInput.findDuplicates().ToList();
            var expectedResult = returnVal.ToList();

            actualResult.Sort();
            expectedResult.Sort();

            CollectionAssert.AreEqual(actualResult, expectedResult);
        }
    }
}
