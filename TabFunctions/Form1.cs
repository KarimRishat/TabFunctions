using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabFunctions
{
    public partial class Form1 : Form
    {
        const int a = 0;    //начало отрезка
        const int b = 3;    //конец отрезка
        const double h1 = 0.6;        //шаг
        const double h2 = 0.3;
        int n, m, nodes;
        List<Function> funcTable;      //таблица значений функции с шагом h
        List<Function> funcTableLn;     //таблица значений для полинома Лагранжа
        IPoint point;
        public Form1()
        {
            InitializeComponent();
        }

        void DrawChart(List<Function> func, System.Windows.Forms.DataVisualization.Charting.Series series)
        {
            series.Points.Clear();
            foreach (Function item in func)
            {
                series.Points.AddXY(Math.Round(item.x,5), Math.Round(item.fx, 5));
            }
        }

        List<Function> FindError(List<Function> f1, List<Function> f2)
        {
            List<Function> errors = new List<Function>();
            for (int i = 0; i < f1.Count; i++)
            {
                double y = Math.Abs(f1[i].fx - f2[i].fx);
                errors.Add(new Function(f1[i].x, y));
            }
            return errors;
        }

        void DrawErrorGraph(List<Function> f1, List<Function> f2)
        {
            List<Function> errors = FindError(f1, f2);
            DrawChart(errors, chart2.Series[0]);
            foreach (Function function in errors)
            {
                dataGridViewError.Rows.Add(function.x, Math.Round(function.fx, 5));
            }
        }

        void MaxErrLN()
        {
            nodes = 40;
            List<double> maxErrors = new List<double>();        //храним максимальные погрешности
            for (int i = 5; i <= nodes; i++)
            {
                double temp_h = (double)(b - a) / i;
                List<Function> tempFunc = TabBessel.GetFunctions(a, b, m, h2, point);
                List<Function> tempLN = TabBessel.GetLn(a,b,m,h2,point,i);    //ищем полином для i-го узла
                List<Function> errors = FindError(tempFunc, tempLN);    //нахождение погрешностей
                maxErrors.Add(errors.Max(t => t.fx));   //найти максимальную погрешность для i узлов
            }
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < nodes-5; i++)
            {
                dataGridViewMaxError.Rows.Add(i + 1, Math.Round(maxErrors[i], 5));
                chart1.Series[0].Points.AddXY(i + 1, Math.Round(maxErrors[i], 5));
            }
        }

        private void buttonMaxErr_Click(object sender, EventArgs e)
        {
            MaxErrLN();
        }

        void drawGraphs(IPoint p)
        {
            n = (int)((b - a) / h1);
            m = (int)((b - a) / h2);
            funcTable = TabBessel.GetFunctions(a, b, n, h1, p);
            foreach (Function function in funcTable)
            {
                dataGridViewFunc.Rows.Add(function.x, Math.Round(function.fx, n));
            }
            DrawChart(funcTable, chart1.Series[0]);

            nodes = 6;
            funcTableLn = TabBessel.GetLn(a, b, m, h2, p, nodes);
            foreach (Function function in funcTableLn)
            {
                dataGridViewLN.Rows.Add(function.x, Math.Round(function.fx, n));
            }

            List<Function> funcTable2 = TabBessel.GetFunctions(a, b, m, h2, p);    //поиск функции с большими узлами
            DrawErrorGraph(funcTable2, funcTableLn);


        }


        void Chebyshev()
        {
            point = new ChebPoint();
            drawGraphs(new ChebPoint());
        }

        void Default()
        {
            point = new Point();
            drawGraphs(new Point());
        }

        void Newton()
        {
            //point = new Point();
            point = new ChebPoint();
            drawGraphsNewton(point);
        }


        void MaxErrNewton()
        {
            int nodes = 40;
            List<double> maxErrors = new List<double>();        //храним максимальные погрешности
            for (int i = 5; i <= nodes; i++)
            {
                double temp_h = (double)(b - a) / i;
                List<Function> tempFunc = TabBessel.GetFunctions(a, b, m, h2, point);
                List<Function> tempLN = TabBessel.GetNewton(a, b, m, h2, point, i);    //ищем полином для i-го узла
                List<Function> errors = FindError(tempFunc, tempLN);    //нахождение погрешностей
                maxErrors.Add(errors.Max(t => t.fx));   //найти максимальную погрешность для i узлов
            }
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < nodes-5; i++)
            {
                dataGridViewMaxError.Rows.Add(i + 1, Math.Round(maxErrors[i], 5));
                chart1.Series[0].Points.AddXY(i + 1, Math.Round(maxErrors[i], 5));
            }
        }

        private void drawGraphsNewton(IPoint p)
        {
            n = (int)((b - a) / h1);
            m = (int)((b - a) / h2);
            funcTable = TabBessel.GetFunctions(a, b, n, h1, p);
            foreach (Function function in funcTable)
            {
                dataGridViewFunc.Rows.Add(function.x, Math.Round(function.fx, 5));
            }
            DrawChart(funcTable, chart1.Series[0]);


            nodes = 6;
            funcTableLn = TabBessel.GetNewton(a, b, m, h2, p, nodes);
            foreach (Function function in funcTableLn)
            {
                dataGridViewLN.Rows.Add(function.x, Math.Round(function.fx, 5));
            }

            List<Function> funcTable2 = TabBessel.GetFunctions(a, b, m, h2, p);    //поиск функции с большими узлами
            DrawErrorGraph(funcTable2, funcTableLn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Default();
            //Chebyshev();
            Newton();
        }
    }
}
