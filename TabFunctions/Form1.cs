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

        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 0;
            int b = 3;
            double h = 0.6;        //количество узлов для полинома лагранжа
            int n = (int)((b - a) / h);

            #region Func
            List<Function> funcTable = TabBessel.GetFunctions(a, n, h, new Point());
            foreach (Function function in funcTable)
            {
                dataGridViewFunc.Rows.Add(function.x, function.fx);
            }
            //foreach (Function function in funcTable)
            //{
            //    chart1.Series[0].Points.AddXY(function.x, function.fx);
            //}

            #endregion Func

            #region LN
            List<Function> funcTableLn = TabBessel.GetLn(a, n, h, new Point(), funcTable);
            foreach (Function function in funcTableLn)
            {
                dataGridViewLN.Rows.Add(function.x, function.fx);
            }
            #endregion

            List<Function> funcTable2 = TabBessel.GetFunctions(a, n*2, h/2, new Point());    //поиск функции с большими узлами

            for (int i = 0; i < n*2-1; i++)
            {
                double y = Math.Abs(funcTable2[i].fx - funcTableLn[i].fx);
                chart1.Series[1].Points.AddXY(funcTable2[i].x, y);
            }

        }


    }
}
