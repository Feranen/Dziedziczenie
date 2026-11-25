using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedzicenie.Models.Task
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }
    }
}
