using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Square:Rectangle
    {
        public double _side = 1.0;

        public Square()
        {

        }
        public Square(double side)
        {
            _side = side;
        }
        public Square(double side, string color,  bool filled)
        {
            _side = side;
            _color = color;
            _filled = filled;
        }
        public double GetSide()
        {
            return _side;
        }
        public void SetSide(double side)
        {
            _side = side;
        }
        public  void SetWidth(double side)
        {
            _width = side;
            
        }
        public void SetLength(double side)
        {
            _length = side;
        }
        public override string ToString()
        {
            return $" Square [Shape [ color = {_color}, filled = {_filled} ], width = {_width}, length = {_width} ]";

        }

    }
}
