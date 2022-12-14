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
            double an = 1.0;         //а0 = 1
            double fx = an;
            double q = 1.0;
            for (int j = 0; Math.Abs(an) >= eps; j++)
            {

                q = (-1) * (x * x) / (4 * (j + 1) * (j + 1));   //следующий множитель q
                an *= q;    //вычисляем следующее значение
                fx += an;   //добавляем значение к сумме
            }
            return fx;
        }



        public static List<Function> GetFunctions(int a, int b, int n, double h, IPoint point)
        {
            List<Function> funcTable = new List<Function>();
            double htemp = h;
            if (n == 1)
            {
                htemp = 1;
            }
            for (int i = 0; i <= n; i++)
            {
                double x = point.GetPoint(a, b, i, htemp);
                double y = FindFx(x);
                funcTable.Add(new Function(x, y));
            }
            return funcTable;
        }       //Список значений функции




        private static double LagrPol(double x, int nodes, IPoint point,int a, int b)
        {
            double sum = 0.0;
            double h = (double)(b - a) / (nodes-1);
            for (int i = 0; i < nodes; i++)
            {
                double xi = point.GetPoint(a,b,i,h);
                double fxi = FindFx(xi);
                double mult = 1.0;
                for (int j = 0; j < nodes; j++)
                {
                    if (j != i)
                    {
                        double xj = point.GetPoint(a,b,j,h);
                        mult *= (x - xj) / (xi - xj);
                    }
                }
                sum += mult * fxi;
            }
            return sum;
        }



        public static List<Function> GetLn(int a, int b, int m, double h, IPoint point, int nodes)
        {
            List<Function> funcTable = new List<Function>();
            double htemp = h;
            if (nodes - 1 == 1)
            {
                htemp = 1;
            }
            for (int i = 0; i <= m; i++)
            {
                double x = point.GetPoint(a, b, i, htemp);        //Берем точку при большем количестве ущлов
                double ln = LagrPol(x, nodes, point, a, b);        //Находим 
                funcTable.Add(new Function(x, ln));
            }

            return funcTable;
        }

        public static double Newton(double x, int nodes, IPoint point, int a, int b)
        {
            double h = (double)(b - a) / (nodes - 1);
            double sum = FindFx(point.GetPoint(a, b, 0, h));
            for (int i = 1; i < nodes; ++i)
            {

                double F = 0;
                for (int j = 0; j <= i; ++j)
                {
                    double xj = point.GetPoint(a, b, j, h);
                    double den = 1;
                    for (int k = 0; k <= i; ++k)
                    {
                        if (k != j)
                        {
                            
                            double xk = point.GetPoint(a, b, k, h);
                            den *= xj - xk;
                        }
                    }
                    double fxj = FindFx(xj); 
                    F += fxj / den;
                }

                for (int k = 0; k < i; ++k)
                {
                    double xk = point.GetPoint(a, b, k, h);
                    F *= (x - xk);
                }
                sum += F;
            }
            return sum;

        }

        public static List<Function> GetNewton(int a, int b, int m, double h, IPoint point, int nodes)
        {
            List<Function> funcTable = new List<Function>();
            double htemp = h;
            if (nodes - 1 == 1)
            {
                htemp = 1;
            }
            for (int i = 0; i <= m; i++)
            {
                double x = point.GetPoint(a, b, i, htemp);        //Берем точку при большем количестве ущлов
                double ln = Newton(x, nodes, point, a, b);        //Находим 
                funcTable.Add(new Function(x, ln));
            }

            return funcTable;
        }

    }
}
