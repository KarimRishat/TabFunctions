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
			double fx = an;
			double q = 1.0;
			for(int j = 0; Math.Abs(an) >= eps; j++)
            {

                q = (-1) * (x * x) / (4 * (j + 1) * (j + 1));   //следующий множитель q
				an *= q;    //вычисляем следующее значение
                fx += an;   //добавляем значение к сумме
            }
            return fx;
		}



        public static List<Function> GetFunctions(int a, int n, double h, IPoint point)
        {
            List<Function> funcTable = new List<Function>();
            double htemp = h;
            if (n == 1)
            {
                htemp = 1;
            }
            for (int i = 0; i <= n; i++)
            {
                double x = point.GetPoint(a, i, htemp);
                double y = FindFx(x);
                funcTable.Add(new Function(x, y));
            }
            return funcTable;
        }       //Список значений функции




        private static double LagrPol(double x, List<Function> func)
        {
            double sum = 0.0;
            for (int i = 0; i < func.Count(); i++)
            {
                double xi = func[i].x;
                double fxi = func[i].fx;
                double mult = 1.0;
                for (int j = 0; j < func.Count(); j++)
                {
                    if (j != i)
                    {
                        double xj = func[j].x;
                        mult *= (x - xj) / (xi - xj);
                    }
                }
                sum += mult * fxi;
            }
            return sum;
        }
        


        public static List<Function> GetLn(int a, int m, double h, IPoint point, List<Function> func)
        {
            List<Function> funcTable = new List<Function>();
            double htemp = h;
            if (func.Count()-1 == 1)
            {
                htemp = 1;
            }
            for (int i = 0; i <= m; i++)
            {
                double x = point.GetPoint(a, i, htemp);        //Берем точку при большем количестве ущлов
                double ln = LagrPol(x, func);        //Находим 
                funcTable.Add(new Function(x, ln));
            }

            return funcTable;
        }





    }
}
