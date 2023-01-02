using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class Shape
    {
        protected string _color;
        protected bool _filled = true ;

        public Shape(){}

        public Shape(string color, bool filled)
        {
            _color = color;
            _filled = filled;

        }
        public string GerColor()
        {
            return _color;
        }
        public void SetColor(string color)
        {
            _color = color;
        }
        public abstract double GetArea();
        public abstract double GetPerimeter();

        public virtual string ToString()
        {
            return $"Shape [ color = {_color}, filled = {_filled} ]";
        }

    }
}
