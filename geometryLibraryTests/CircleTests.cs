using Microsoft.VisualStudio.TestTools.UnitTesting;
using geometryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometryLibrary.Tests
{
    [TestClass()]
    public class CircleTests
    {
        /// <summary>
        /// Вычисление площади круга 
        /// </summary>
        [TestMethod()]
        public void SquareTest()
        {
            //Arange
            Circle circle = new Circle("circle1", 30);
            double expected = 2827.433;
            // Act
            var actual = circle.Square();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}