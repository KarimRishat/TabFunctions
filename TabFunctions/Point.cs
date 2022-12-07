using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabFunctions
{
    class Point:IPoint
    {
        public double GetPoint(int a, int b, int i, double h) => a + (i * h);
    }
}
