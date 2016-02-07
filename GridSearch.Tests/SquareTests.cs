using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GridSearch.Domain.Geometry;
using System.Drawing;

namespace GridSearch.Tests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void TopLeftTest()
        {
            // Arrange
            var square = new Square(2, 2, 2);
            var expectedTopLeft = new Point(1, 3);

            // Act
            var actualTopLeft = square.TopLeft;

            // Assert
            Assert.AreEqual(expectedTopLeft, actualTopLeft);
        }

        [TestMethod]
        public void BottomRightTest()
        {
            // Arrange
            var square = new Square(2, 2, 2);
            var expectedBottomRight = new Point(3, 1);

            // Act
            var actualBottomRight = square.BottomRight;

            // Assert
            Assert.AreEqual(expectedBottomRight, actualBottomRight);
        }

        [TestMethod]
        public void IsInsideTests()
        {
            var square = new Square(2, 2, 2);

            var pointIn = new Point(1, 1);
            var pointOn = new Point(3, 2);
            var pointOut = new Point(3, 4);

            Assert.IsTrue(square.IsInside(pointIn));
            Assert.IsTrue(square.IsInside(pointOn));
            Assert.IsFalse(square.IsInside(pointOut));
        }
    }
}
