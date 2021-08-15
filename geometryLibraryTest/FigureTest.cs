using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace geometryLibraryTest
{
    [TestClass]
    public class FigureTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arange
            Figure figure = new Figure("Unknown");
            double firstSide = 2;
            double expectedResult = (12.566, 4, 1.732)
            // Act
            var actualResult = NoTypeSquare(firstSide);

            //Assert
            Assert.AreEqual(expectedResult, actualResult)
        }
    }
}
