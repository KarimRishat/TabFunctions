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
        const double h = 0.6;        //шаг
        const double h2 = 0.3;
        int n, m;
        List<Function> funcTable;      //таблица значений функции с шагом h
        List<Function> funcTableLn;     //таблица значений для полинома Лагранжа
        Point point = new Point();
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
        }

        private void buttonMaxErr_Click(object sender, EventArgs e)
        {
            int nodes = 40;
            List<double> maxErrors = new List<double>();
            for (int i = 1; i <= nodes; i++)
            {
                double temp_h = (double)(b - a) / i;
                List<Function> tempFunc = TabBessel.GetFunctions(a, i, temp_h, point);
                List<Function> tempLN = TabBessel.GetLn(a, i, temp_h, point, funcTable);
                List<Function> errors = FindError(tempFunc, tempLN);
                maxErrors.Add(errors.Max(t => t.fx));
            }
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < nodes; i++)
            {
                dataGridViewMaxError.Rows.Add(i + 1, Math.Round(maxErrors[i], 5));
                chart1.Series[0].Points.AddXY(i + 1, Math.Round(maxErrors[i], 5));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            n = (int)((b - a) / h);
            m = (int)((b - a) / h2);
            
            funcTable = TabBessel.GetFunctions(a, n, h, new Point());
            foreach (Function function in funcTable)
            {
                dataGridViewFunc.Rows.Add(function.x, Math.Round(function.fx,5));
            }
            DrawChart(funcTable, chart1.Series[0]);

            funcTableLn = TabBessel.GetLn(a, m, h2, new Point(), funcTable);
            foreach (Function function in funcTableLn)
            {
                dataGridViewLN.Rows.Add(function.x, Math.Round(function.fx,5));
            }
            
            List<Function> funcTable2 = TabBessel.GetFunctions(a, m, h2, new Point());    //поиск функции с большими узлами
            DrawErrorGraph(funcTable2, funcTableLn);
            


        }


    }
}
