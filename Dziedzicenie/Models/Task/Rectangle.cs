using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedzicenie.Models.Task
{
    public class Rectangle : Shape 
    {
        public double width {  get; set; }
        public double height { get; set; }

        // PIr2

        public override double GetArea()
        {
            return width * height;
        }
    }
}
