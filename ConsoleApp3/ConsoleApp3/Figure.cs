using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Figure
    {
        protected double Area { get; set; }

        public Figure()
        {
            Area = 0;
        }
    }

    public class Triangle : Figure
    {
        private double _base;
        private double _height;

        public double Base
        {
            get => _base;
            set => _base = value;
        }

        public double Height
        {
            get => _height;
            set => _height = value;
        }

        public void CalculateArea(double baseValue, double heightValue)
        {
            _base = baseValue;
            _height = heightValue;
            Area = (_base * _height) / 2;
            Console.WriteLine($"Area of the triangle with base {_base} and height {_height} is: {Area}");
        }
    }

    public class Square : Figure
    {
        private double _sideLength;

        public double SideLength
        {
            get => _sideLength;
            set => _sideLength = value;
        }

        public void CalculateArea(double sideLengthValue)
        {
            _sideLength = sideLengthValue;
            Area = _sideLength * _sideLength;
            Console.WriteLine($"Area of the square with side {_sideLength} is: {Area}");
        }
    }
}
