using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometryLibrary
{
    /// <summary>
    /// Интерфейс для вычисления площади фигуры без знания типа фигуры
    /// Возвращает кортеж площадей тех фигур, площадь которых можно посчитать исходя из предоставленных данных
    /// Например, если известна одна величина, то возвращается кортежом площадь круга, квадрата и равностороннего треугольника
    /// т.к. эти площади считаются по одному значению
    /// </summary>
    interface INoTypeSquare
    {
        public (double circleSquare, double squareArea, double triangleSquare) NoTypeSquare (double firstSide);

        public (double rectangleSquare, double ellipseSquare) NoTypeSquare(double firstSide, double secondSide);
        public double NoTypeSquare (double firstSide, double secondSide, double thirdSide);

    }
}
