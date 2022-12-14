
namespace TabFunctions
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewFunc = new System.Windows.Forms.DataGridView();
            this.args = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.values = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageFunc = new System.Windows.Forms.TabPage();
            this.tabPageLN = new System.Windows.Forms.TabPage();
            this.dataGridViewLN = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageMaxError = new System.Windows.Forms.TabPage();
            this.buttonMaxErr = new System.Windows.Forms.Button();
            this.dataGridViewMaxError = new System.Windows.Forms.DataGridView();
            this.NumberOfNodesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxErrCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageError = new System.Windows.Forms.TabPage();
            this.dataGridViewError = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageFunc.SuspendLayout();
            this.tabPageLN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLN)).BeginInit();
            this.tabPageMaxError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaxError)).BeginInit();
            this.tabPageError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFunc
            // 
            this.dataGridViewFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.args,
            this.values});
            this.dataGridViewFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFunc.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewFunc.Name = "dataGridViewFunc";
            this.dataGridViewFunc.Size = new System.Drawing.Size(189, 418);
            this.dataGridViewFunc.TabIndex = 0;
            // 
            // args
            // 
            this.args.HeaderText = "Arguments";
            this.args.Name = "args";
            // 
            // values
            // 
            this.values.HeaderText = "Values";
            this.values.Name = "values";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageFunc);
            this.tabControl.Controls.Add(this.tabPageLN);
            this.tabControl.Controls.Add(this.tabPageMaxError);
            this.tabControl.Controls.Add(this.tabPageError);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(203, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageFunc
            // 
            this.tabPageFunc.Controls.Add(this.dataGridViewFunc);
            this.tabPageFunc.Location = new System.Drawing.Point(4, 22);
            this.tabPageFunc.Name = "tabPageFunc";
            this.tabPageFunc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFunc.Size = new System.Drawing.Size(195, 424);
            this.tabPageFunc.TabIndex = 0;
            this.tabPageFunc.Text = "FunctionValues";
            this.tabPageFunc.UseVisualStyleBackColor = true;
            // 
            // tabPageLN
            // 
            this.tabPageLN.Controls.Add(this.dataGridViewLN);
            this.tabPageLN.Location = new System.Drawing.Point(4, 22);
            this.tabPageLN.Name = "tabPageLN";
            this.tabPageLN.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLN.Size = new System.Drawing.Size(195, 424);
            this.tabPageLN.TabIndex = 1;
            this.tabPageLN.Text = "InterpolValue";
            this.tabPageLN.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLN
            // 
            this.dataGridViewLN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewLN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLN.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewLN.Name = "dataGridViewLN";
            this.dataGridViewLN.Size = new System.Drawing.Size(189, 418);
            this.dataGridViewLN.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Arguments";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Values";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tabPageMaxError
            // 
            this.tabPageMaxError.Controls.Add(this.buttonMaxErr);
            this.tabPageMaxError.Controls.Add(this.dataGridViewMaxError);
            this.tabPageMaxError.Location = new System.Drawing.Point(4, 22);
            this.tabPageMaxError.Name = "tabPageMaxError";
            this.tabPageMaxError.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMaxError.Size = new System.Drawing.Size(195, 424);
            this.tabPageMaxError.TabIndex = 2;
            this.tabPageMaxError.Text = "MaxError";
            this.tabPageMaxError.UseVisualStyleBackColor = true;
            // 
            // buttonMaxErr
            // 
            this.buttonMaxErr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonMaxErr.Location = new System.Drawing.Point(61, 368);
            this.buttonMaxErr.Name = "buttonMaxErr";
            this.buttonMaxErr.Size = new System.Drawing.Size(75, 23);
            this.buttonMaxErr.TabIndex = 3;
            this.buttonMaxErr.Text = "Solve";
            this.buttonMaxErr.UseVisualStyleBackColor = true;
            this.buttonMaxErr.Click += new System.EventHandler(this.buttonMaxErr_Click);
            // 
            // dataGridViewMaxError
            // 
            this.dataGridViewMaxError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaxError.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberOfNodesCol,
            this.MaxErrCol});
            this.dataGridViewMaxError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMaxError.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMaxError.Name = "dataGridViewMaxError";
            this.dataGridViewMaxError.Size = new System.Drawing.Size(189, 418);
            this.dataGridViewMaxError.TabIndex = 2;
            // 
            // NumberOfNodesCol
            // 
            this.NumberOfNodesCol.FillWeight = 50F;
            this.NumberOfNodesCol.HeaderText = "n";
            this.NumberOfNodesCol.Name = "NumberOfNodesCol";
            this.NumberOfNodesCol.Width = 20;
            // 
            // MaxErrCol
            // 
            this.MaxErrCol.HeaderText = "MaxError";
            this.MaxErrCol.Name = "MaxErrCol";
            // 
            // tabPageError
            // 
            this.tabPageError.Controls.Add(this.dataGridViewError);
            this.tabPageError.Location = new System.Drawing.Point(4, 22);
            this.tabPageError.Name = "tabPageError";
            this.tabPageError.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageError.Size = new System.Drawing.Size(195, 424);
            this.tabPageError.TabIndex = 3;
            this.tabPageError.Text = "Error";
            this.tabPageError.UseVisualStyleBackColor = true;
            // 
            // dataGridViewError
            // 
            this.dataGridViewError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewError.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewError.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewError.Name = "dataGridViewError";
            this.dataGridViewError.Size = new System.Drawing.Size(189, 418);
            this.dataGridViewError.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.chart1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chart2);
            this.splitContainer2.Size = new System.Drawing.Size(593, 450);
            this.splitContainer2.SplitterDistance = 225;
            this.splitContainer2.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Function";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(593, 225);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Error";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(593, 221);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "x";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 20;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "|f-Ln|";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunc)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageFunc.ResumeLayout(false);
            this.tabPageLN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLN)).EndInit();
            this.tabPageMaxError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaxError)).EndInit();
            this.tabPageError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewError)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn args;
        private System.Windows.Forms.DataGridViewTextBoxColumn values;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridViewLN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageFunc;
        private System.Windows.Forms.TabPage tabPageLN;
        private System.Windows.Forms.TabPage tabPageMaxError;
        private System.Windows.Forms.DataGridView dataGridViewMaxError;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfNodesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxErrCol;
        private System.Windows.Forms.Button buttonMaxErr;
        private System.Windows.Forms.TabPage tabPageError;
        private System.Windows.Forms.DataGridView dataGridViewError;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

