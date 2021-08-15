using System;

namespace geometryLibrary
{
    public class Triangle : Figure, ISquare
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }

        public Triangle(string name, double firstSide, double secondSide, double thirdSide) :base(name)
        {
            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
            this.ThirdSide = thirdSide;
        }
        public double Square()
        {
            if (Exist(this.FirstSide, this.SecondSide, this.ThirdSide))
            {
                if (Straight(this.FirstSide, this.SecondSide, this.ThirdSide, out double cathetus1, out double cathetus2))
                {
                    return cathetus1 * cathetus2 / 2;// находим площадь как полупроизведение катетов
                }
                else
                {
                    // иначе находим площадь по формуле Герона
                    double p = (this.FirstSide + this.SecondSide + this.ThirdSide) / 2;
                    return Math.Sqrt(p * (p - this.FirstSide) * (p - this.SecondSide) * (p - this.ThirdSide));
                }
            }
            else return 0; //фигура не треугольник
        }
    }
}
