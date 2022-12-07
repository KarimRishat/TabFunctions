using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabFunctions
{
    class ChebPoint : IPoint
    {
        const double PI = Math.PI;
        public double GetPoint(int a, int b, int i, double h)
        {
            int n = (int)((b - a) / h)+1;
            double x = (b + a) / 2 + (b - a) / 2 * (Math.Cos((2 * i + 1) * PI / (2 * n + 2)));
            return x;
        }
    }
}
