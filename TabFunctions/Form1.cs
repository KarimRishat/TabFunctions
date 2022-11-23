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
            int n = 5;
            int m = 10;
            int l = 20;        //количество узлов для полинома лагранжа
            List<Function> funcTable = TabBessel.GetFunctions(a, b, m);
            foreach (Function function in funcTable)
            {
                dataGridViewFunc.Rows.Add(function.x, function.fx);
            }
            //foreach (Function function in funcTable)
            //{
            //    chart1.Series[0].Points.AddXY(function.x, function.fx);
            //}
            List<Function> funcTableLn = TabBessel.GetLn(a, b, l, m);
            foreach (Function function in funcTableLn)
            {
                dataGridViewLN.Rows.Add(function.x, function.fx);
            }

            for (int i = 0; i < m; i++)
            {
                double y = Math.Abs(funcTable[i].fx - funcTableLn[i].fx);
                chart1.Series[1].Points.AddXY(funcTable[i].x, y);
            }

        }


    }
}
