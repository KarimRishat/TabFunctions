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
        int a = 0;
        int b = 3;
        double h = 0.6;        //шаг
        double h2 = 0.3;
        int n, m;
        List<Function> funcTable;      //таблица значений функции с шагом h
        List<Function> funcTableLn;     //таблица значений для полинома Лагранжа
        public Form1()
        {
            InitializeComponent();
        }

        void DrawChart(List<Function> func, System.Windows.Forms.DataVisualization.Charting.Series series)
        {
            
            foreach (Function item in func)
            {
                series.Points.AddXY(item.x, item.fx);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            n = (int)((b - a) / h);
            m = (int)((b - a) / h2);
            
            funcTable = TabBessel.GetFunctions(a, n, h, new Point());
            foreach (Function function in funcTable)
            {
                dataGridViewFunc.Rows.Add(function.x, function.fx);
            }
            DrawChart(funcTable, chart1.Series[0]);

            funcTableLn = TabBessel.GetLn(a, n, m, h2, new Point(), funcTable);
            foreach (Function function in funcTableLn)
            {
                dataGridViewLN.Rows.Add(function.x, function.fx);
            }
            
            List<Function> funcTable2 = TabBessel.GetFunctions(a, m, h2, new Point());    //поиск функции с большими узлами
            DrawErrorGraph(funcTable2, funcTableLn);
            


        }


    }
}
