using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedzicenie.Models.Task
{
    public class Shape
    {
        public string name { get; set; } = "";

        public virtual double GetArea()
        { return 0; }
    }
}
