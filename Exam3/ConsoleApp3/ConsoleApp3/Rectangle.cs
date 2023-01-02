using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Rectangle:Shape
    {
        protected double _width = 1.0;
        protected double _length = 1.0;

        public Rectangle()
        {

        }
        public Rectangle(double width, double length)
        {
            _width = width;
            _length = length;

        }
        public Rectangle(double width, double length, string color, bool filled ):base(color, filled)
        {
            _width = width;
            _length = length;

        }

        public double GetWidth()
        {
            return _width;
        }
        public void SetWidth(double width)
        {
            _width = width;

        }
        public double GetLength()
        {
            return _length;
        }
        public void SetLength(double length)
        {
            _length = length;
        }
        public override double GetArea()
        {
            return _width * _width;
        }
        public override double GetPerimeter()
        {
            return 2 * ( _width + _width);
        }
        public override string ToString()
        {
            return $"Shape [ color = {_color}, filled = {_filled} ], width = {_width}, length = {_width} ]";
        }


    }
}
