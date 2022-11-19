using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabFunctions
{
    delegate double Point(int a, int b, int i, int n);
    static class TabBessel
    {
		
        public static double FindFx(double x)
        {
			double eps = 0.000001;
			double an = 1 ;         //а0 = 1
			double fx = 0.0;
			double q = 1;
			for(int j = 0; Math.Abs(an) >= eps; j++)
            {
				fx += an;   //добавляем значение к сумме
				q = (-1) * (x / (2 * (j + 1))) * (x / (2 * (j + 1)));   //следующий множитель q
				an *= q;    //вычисляем следующее значение
			}
			return fx;
		}


        public static double LagrPol(int a, int b, double x, int n, Point p)
        {
            double h = (double)((b - a) / n);
            double sum = 0.0;
            for (int i = 0; i <= n; i++)
            {
                double xi = p(a, b, i, n);
                double fxi = FindFx(xi);
                double mult = 1.0;
                for (int j = 0; i < n; i++)
                {
                    if (j != i)
                    {
                        double xj = p(a, b, j, n);
                        mult *= (x - xj) / (xi - xj);
                    }
                }
                sum += mult;
            }
            return sum;
        }

        public static List<Function> GetFunctions(int a, int b, int n, Point p)
        {
            List<Function> funcTable = new List<Function>();
            for (int i = 0; i <= n; i++)
            {
                double x = p(a, b, i, n);
                double y = FindFx(x);
                funcTable.Add(new Function(x, y));
            }
            return funcTable;
        }       //Список значений функции


        public static double GetPoint(int a, int b, int i, int n)
        {
            double h = (double)(b - a) / n;
            double x = a + i * h;
            return x;
        }
        //Находим точку


    }
}
