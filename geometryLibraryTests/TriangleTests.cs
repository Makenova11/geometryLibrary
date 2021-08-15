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
    public class TriangleTests
    {
        /// <summary>
        /// Вычисление площади треугольника по трём сторонам
        /// </summary>
        [TestMethod()]
        public void SquareTest()
        {
            //Arange
            Triangle triangle = new Triangle("triangle1", 6, 8, 3);
            double expected = 7.644;
            // Act
            var actual = triangle.Square();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}