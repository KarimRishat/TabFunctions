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
            int n = 10;
            Point p1 = TabBessel.GetPoint(a,b,)
            List<Function> funcTable = TabBessel.GetFunctions(a, b, n);
            foreach (Function function in funcTable)
            {
                dataGridView1.Rows.Add(function.x, function.fx);
            }
            foreach (Function function in funcTable)
            {
                chart1.Series[0].Points.AddXY(function.x, function.fx);
            }
        }
    }
}
