using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabFunctions
{
    class Function
    {
        public double fx { get; set; }
        public double x { get; set; }
        public Function(double x, double y)
        {
            this.x = x;
            fx = y;
        }
    }
}
