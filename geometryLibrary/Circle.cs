using System;

namespace geometryLibrary
{
    /// <summary>
    /// При создании объекта сразу указываем все параметры фигуры.
    /// Площадь вычисляется по параметрам созданной фигуры.
    /// </summary>
    public class Circle : Figure, ISquare
    {
        public double Radius { get; set; }
        public Circle(string name, double radius) : base(name)
        {
            this.Radius = radius;
        }

        public double Square()
        {
            return Math.PI * Math.Pow(this.Radius, 2);

        }
    }
}
