﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public abstract class Shape
    {
        public double _area = 0;
        public double _perimeter = 0;

        public double Perimeter
        {
            get { return _perimeter; }
        }
        public double Area
        {
            get { return _area; }
        }

        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
    }
}
