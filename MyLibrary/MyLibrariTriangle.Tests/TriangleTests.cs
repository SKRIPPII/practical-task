using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyLibrary;

namespace MyLibrary.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [ExpectedException(typeof(ArgumentException), "")]
        [TestMethod]
         public void ParameterIsZero()
        {
            Triangle triangle = new(9.0,3.0,0.0);
        }

        [ExpectedException(typeof(ArgumentException), "")]
        [TestMethod]
        public void ParameterIsNegative()
        {
            Triangle triangle = new(9.0, 6.0, -3.0);
        }


        [TestMethod]
        public void IsRectangular()
        {
            Triangle triangle = new(3, 4, 5);
            Assert.IsTrue(triangle.IsRectangular());
        }
        [TestMethod]
        public void IsNotRectangular()
        {
            Triangle triangle = new(3, 4, 5.5);
            Assert.IsFalse(triangle.IsRectangular());
        }

        [ExpectedException(typeof(ArgumentException), "")]
        [TestMethod]
        public void TriangleNotExist()
        {
            Triangle triangle = new(15, 5, 10);
        }
        [TestMethod]
        public void TriangleArea()
        {
            Triangle triangle = new(3,4,5);
            Assert.AreEqual(6.000, triangle.GetArea);
        }

    }
}
