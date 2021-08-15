
using System;

namespace geometryLibrary
{
    /// <summary>
    /// Базовый класс для всех фигур
    /// </summary>
    public class Figure: INoTypeSquare
    {
        public string Name { get; set; }

        public Figure (string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// По известной одной величине рассчитывается площадь круга, квадрата и равностор. треугольника
        /// </summary>
        /// <param name="firstSide">Известная сторона, по которой будет рассчитываться площадь фигуры</param>
        /// <returns></returns>
        public (double circleSquare, double squareArea, double triangleSquare) NoTypeSquare(double firstSide)
        {
            double circleSquare = Math.Round(Math.PI * Math.Pow(firstSide, 2), 3);
            double squareArea = Math.Round(Math.Pow(firstSide, 2), 3);
            double triangleSquare = Math.Round((Math.Pow(firstSide, 2) * Math.Sqrt(3)) / 4, 3);

            return (circleSquare, squareArea, triangleSquare);
        }

        /// <summary>
        /// По двум величинам рассчитывается площадь прямоугольника, треугольника,параллелограмма и эллипса
        /// </summary>
        /// <param name="firstSide">Первая известная сторона неизвестной фиигуры</param>
        /// <param name="secondSide">Вторая сторона</param>
        /// Можно было добавить площадь параллелограмма, но результат получится такой же как у прямоугольника
        /// <returns></returns>
        public (double rectangleSquare, double ellipseSquare) NoTypeSquare(double firstSide, double secondSide)
        {
            double rectangleSquare = Math.Round(firstSide * secondSide, 3);
            double ellipseSquare = Math.Round(Math.PI * firstSide * secondSide, 3);

            return (rectangleSquare, ellipseSquare);
        }

        /// <summary>
        /// Производится расчёт площади треугольника по трём сторонам с проверкой на его существование
        /// и проверкой на прямоугольность
        /// </summary>
        /// <param name="firstSide">Первая сторона</param>
        /// <param name="secondSide">Вторая сторона</param>
        /// <param name="thirdSide">Третья сторона</param>
        /// <returns></returns>
        public double NoTypeSquare(double firstSide, double secondSide, double thirdSide)
        {
            if (Exist(firstSide, secondSide, thirdSide))
            {
                if (Straight(firstSide, secondSide, thirdSide, out double cathetus1, out double cathetus2))
                {
                    return Math.Round(cathetus1 * cathetus2 / 2, 3); // находим площадь как полупроизведение катетов
                }
                else
                {
                    // иначе находим площадь по формуле Герона
                    double p = (firstSide + secondSide + thirdSide) / 2;
                    return Math.Round(Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide)), 3);
                }
            }
            return 0; //значит фигура не треугольник
        }
        /// <summary>
        /// Проверка на существование треугольника
        /// </summary>
        /// <param name="one">Первая сторона</param>
        /// <param name="two">Вторая сторона</param>
        /// <param name="three">Третья сторона</param>
        /// <returns></returns>
        protected internal bool Exist(double one, double two, double three)
        {
            return one < two + three &&
                two < one + three &&
                three < one + two ? true : false; 
        }

        /// <summary>
        /// Проверка на прямоугольность треугольника с нахождением катетов
        /// </summary>
        /// <param name="one">Первая сторона</param>
        /// <param name="two">Вторая сторона</param>
        /// <param name="three">Третья сторона</param>
        /// <param name="cathetus1">Первый возможный катет</param>
        /// <param name="cathetus2">Второй возможный катет</param>
        /// <returns></returns>
        protected internal bool Straight(
            double one, double two, double three, out double cathetus1, out double cathetus2)
        {
            one = Math.Pow(one, 2);
            two = Math.Pow(two, 2);
            three = Math.Pow(three, 3);
            cathetus1 = 0;
            cathetus2 = 0;
            if (one + two == three) { cathetus1 = one; cathetus2 = two; return true; }
            else if (one + three == two) { cathetus1 = one; cathetus2 = three; return true; }
            else if (two + three == one) { cathetus1 = two; cathetus2 = three; return true; }
            else return false;
        }
    }

}
