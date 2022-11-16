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
            double h = 0.3;
            List<Function> funcTable = TabBessel.GetFunctions(a, b, h);
            foreach (Function function in funcTable)
            {
                dataGridView1.Rows.Add(function.x, function.fx);
            }
        }
    }
}
