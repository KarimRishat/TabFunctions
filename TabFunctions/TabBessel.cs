using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabFunctions
{
    static class TabBessel
    {
		
        public static double FindFx(double x)
        {
			double eps = 0.000001;
			double an = 1.0 ;         //а0 = 1
			double fx = 0.0;
			double q = 1.0;
			for(int j = 0; Math.Abs(an) >= eps; j++)
            {
				fx += an;   //добавляем значение к сумме
				q = (-1) * (x / (2 * (j + 1))) * (x / (2 * (j + 1)));   //следующий множитель q
				an *= q;    //вычисляем следующее значение
			}
			return fx;
		}


        public static double LagrPol(int a, int b, double x, int n)
        {
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                double xi = GetPoint(a, b, i, n);
                double fxi = FindFx(xi);
                double mult = 1.0;
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        double xj = GetPoint(a, b, j, n);
                        mult *= (x - xj) / (xi - xj);
                    }
                }
                sum += mult * fxi;
            }
            return sum;
        }
        
        public static List<Function> GetLn(int a, int b, int n, int m)
        {
            List<Function> funcTable = new List<Function>();

            for (int i = 0; i < m; i++)
            {
                double x = GetPoint(a, b, i, m);        //Берем точку при большем количестве ущлов
                double ln = LagrPol(a, b, x, m);        //Находим 
                funcTable.Add(new Function(x, ln));
            }

            return funcTable;
        }


        public static List<Function> GetFunctions(int a, int b, int n)
        {
            List<Function> funcTable = new List<Function>();
            for (int i = 0; i < n; i++)
            {
                double x = GetPoint(a, b, i, n);
                double y = FindFx(x);
                funcTable.Add(new Function(x, y));
            }
            return funcTable;
        }       //Список значений функции


        public static double GetPoint(int a, int b, int i, int n)
        {
            double h = (double)(b - a) / n;
            double x = i * h;
            return x;
        }


    }
}
