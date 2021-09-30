using System;
using NUnit.Framework;
using CampaignMonitorTest;

namespace RequirmentTests
{
    [TestFixture]
    public class TriangleTests
    {       
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        [TestCase(1, -2, 3)]
        [TestCase(0, 3, 4)]
        [TestCase(1, 6, 4)]
        [Parallelizable(ParallelScope.All)]
        public void TraingleExceptionTest(double side1, double side2, double side3)
        {
            Assert.Throws<InvalidTriangleException>(() => { new Triangle(side1, side2, side3).getArea(); });
        }

        [Test]        
        [TestCase(7, 10, 5, 16.248076809271922d)]
        [TestCase(8, 10, 12, 39.686269665968858d)]
        [Parallelizable(ParallelScope.All)]
        public void TraingleAreaTest(double side1, double side2, double side3, double returnVal)
        {
            Assert.AreEqual(new Triangle(side1, side2, side3).getArea(), returnVal);
        }
    }
}
