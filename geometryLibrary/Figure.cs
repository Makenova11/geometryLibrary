using System;

namespace geometryLibrary
{
    /// <summary>
    /// Базовый класс для всех фигур
    /// </summary>
    public class Figure
    {
        public string Name { get; set; }

        public Figure (string name)
        {
            this.Name = name;
        }
    }
}
