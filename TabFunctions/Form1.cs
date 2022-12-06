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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 0;
            int b = 3;
            double h = 0.6;        //количество узлов для полинома лагранжа
            int n = (int)((b - a) / h);
            double h2 = 0.3;
            int m = (int)((b - a) / h2);

            #region Func
            List<Function> funcTable = TabBessel.GetFunctions(a, n, h, new Point());
            foreach (Function function in funcTable)
            {
                dataGridViewFunc.Rows.Add(function.x, function.fx);
            }
            //DrawChart(funcTable, chart1.Series[0]);

            #endregion Func

            #region LN
            List<Function> funcTableLn = TabBessel.GetLn(a, n, m, h2, new Point(), funcTable);
            foreach (Function function in funcTableLn)
            {
                dataGridViewLN.Rows.Add(function.x, function.fx);
            }
            #endregion

            List<Function> funcTable2 = TabBessel.GetFunctions(a, m, h2, new Point());    //поиск функции с большими узлами
            List<Function> errors = new List<Function>();
            for (int i = 0; i <= m; i++)
            {
                double y = Math.Abs(funcTable2[i].fx - funcTableLn[i].fx);
                errors.Add(new Function(funcTable2[i].x, y));
            }
            DrawChart(errors, chart1.Series[1]);


        }


    }
}
