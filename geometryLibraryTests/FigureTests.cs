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
    public class FigureTests
    {
        /// <summary>
        /// Вычисление площади без знания типа фигуры
        /// Известна одна величина
        /// </summary>
        [TestMethod()]
        public void OneSideTest()
        {
            //Arange
            Figure figure = new Figure("Unknown1");
            double firstSide = 2;
            (double, double, double ) expectedResult = (12.566, 4, 1.732);
            // Act
            var actualResult = figure.NoTypeSquare(firstSide);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// Вычисление площади без знания типа фигуры
        /// Известны две величины
        /// </summary>
        [TestMethod()]
        public void TwoSideTest()
        {
            //Arange
            Figure figure = new Figure("Unknown2");
            double firstSide = 1;
            double secondSide = 4;
            (double, double) expectedResult = (4, 12.566);
            // Act
            var actualResult = figure.NoTypeSquare(firstSide, secondSide);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// Вычисление площади без знания типа фигуры
        /// Известны три величины
        /// </summary>
        [TestMethod()]
        public void ThreeSideTest()
        {
            //Arange
            Figure figure = new Figure("Unknown3");
            double firstSide = 6;
            double secondSide = 8;
            double thirdSide = 10;
            double expectedResult = 24;
            // Act
            var actualResult = figure.NoTypeSquare(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}