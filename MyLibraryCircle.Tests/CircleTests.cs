using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MyLibrary.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CircleArea()
        {
            Circle circle = new(7.0);
            Assert.AreEqual(153.93804002589985, circle.GetArea);
        }

        [ExpectedException(typeof(ArgumentException), "")]
        [TestMethod]
        public void CircleRadiusIsZero()
        {
            Circle circle = new(0.0);
        }
        [ExpectedException(typeof(ArgumentException), "")]
        [TestMethod]
        public void CircleRadiusIsNegative()
        {
            Circle circle = new(-0.5);
        }
        
    }
}