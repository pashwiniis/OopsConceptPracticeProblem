﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Polyoverloading
{
     class PolyOverloading
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public double Add(double x, double y)
        {
            return x + y;
        }

    }
}
