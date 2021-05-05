namespace lab11
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.conclusionLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.numberOfExperimentsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfExperimentsLabel = new System.Windows.Forms.Label();
            this.autoLabel = new System.Windows.Forms.Label();
            this.probability2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.probability3NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.probability4NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.probability1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.probability2Label = new System.Windows.Forms.Label();
            this.probability3Label = new System.Windows.Forms.Label();
            this.probability4Label = new System.Windows.Forms.Label();
            this.probability5Label = new System.Windows.Forms.Label();
            this.probability1Label = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.averageLabel = new System.Windows.Forms.Label();
            this.chiLabel = new System.Windows.Forms.Label();
            this.varianceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfExperimentsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probability2NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probability3NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probability4NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probability1NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // conclusionLabel
            // 
            this.conclusionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.conclusionLabel.Location = new System.Drawing.Point(17, 347);
            this.conclusionLabel.Name = "conclusionLabel";
            this.conclusionLabel.Size = new System.Drawing.Size(277, 145);
            this.conclusionLabel.TabIndex = 28;
            this.conclusionLabel.Text = "Вывод: При увеличении числа экспериментов относительные погрешности стремятся к 0" +
    " и увеличивается вероятность подтверждения гипотезы о соответствии эмпирического" +
    " распределения теоретическому";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(167, 281);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 27;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // numberOfExperimentsNumericUpDown
            // 
            this.numberOfExperimentsNumericUpDown.Location = new System.Drawing.Point(122, 238);
            this.numberOfExperimentsNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numberOfExperimentsNumericUpDown.Name = "numberOfExperimentsNumericUpDown";
            this.numberOfExperimentsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numberOfExperimentsNumericUpDown.TabIndex = 26;
            this.numberOfExperimentsNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numberOfExperimentsLabel
            // 
            this.numberOfExperimentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfExperimentsLabel.Location = new System.Drawing.Point(17, 219);
            this.numberOfExperimentsLabel.Name = "numberOfExperimentsLabel";
            this.numberOfExperimentsLabel.Size = new System.Drawing.Size(104, 50);
            this.numberOfExperimentsLabel.TabIndex = 25;
            this.numberOfExperimentsLabel.Text = "Number of experiments:";
            // 
            // autoLabel
            // 
            this.autoLabel.AutoSize = true;
            this.autoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoLabel.Location = new System.Drawing.Point(118, 171);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(45, 20);
            this.autoLabel.TabIndex = 24;
            this.autoLabel.Text = "auto";
            // 
            // probability2NumericUpDown
            // 
            this.probability2NumericUpDown.DecimalPlaces = 3;
            this.probability2NumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.probability2NumericUpDown.Location = new System.Drawing.Point(122, 63);
            this.probability2NumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.probability2NumericUpDown.Name = "probability2NumericUpDown";
            this.probability2NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.probability2NumericUpDown.TabIndex = 23;
            this.probability2NumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // probability3NumericUpDown
            // 
            this.probability3NumericUpDown.DecimalPlaces = 3;
            this.probability3NumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.probability3NumericUpDown.Location = new System.Drawing.Point(122, 101);
            this.probability3NumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.probability3NumericUpDown.Name = "probability3NumericUpDown";
            this.probability3NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.probability3NumericUpDown.TabIndex = 22;
            this.probability3NumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // probability4NumericUpDown
            // 
            this.probability4NumericUpDown.DecimalPlaces = 3;
            this.probability4NumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.probability4NumericUpDown.Location = new System.Drawing.Point(122, 138);
            this.probability4NumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.probability4NumericUpDown.Name = "probability4NumericUpDown";
            this.probability4NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.probability4NumericUpDown.TabIndex = 21;
            this.probability4NumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // probability1NumericUpDown
            // 
            this.probability1NumericUpDown.DecimalPlaces = 3;
            this.probability1NumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.probability1NumericUpDown.Location = new System.Drawing.Point(122, 27);
            this.probability1NumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.probability1NumericUpDown.Name = "probability1NumericUpDown";
            this.probability1NumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.probability1NumericUpDown.TabIndex = 20;
            this.probability1NumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // probability2Label
            // 
            this.probability2Label.AutoSize = true;
            this.probability2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.probability2Label.Location = new System.Drawing.Point(34, 60);
            this.probability2Label.Name = "probability2Label";
            this.probability2Label.Size = new System.Drawing.Size(59, 20);
            this.probability2Label.TabIndex = 19;
            this.probability2Label.Text = "Prob. 2";
            // 
            // probability3Label
            // 
            this.probability3Label.AutoSize = true;
            this.probability3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.probability3Label.Location = new System.Drawing.Point(34, 98);
            this.probability3Label.Name = "probability3Label";
            this.probability3Label.Size = new System.Drawing.Size(59, 20);
            this.probability3Label.TabIndex = 18;
            this.probability3Label.Text = "Prob. 3";
            // 
            // probability4Label
            // 
            this.probability4Label.AutoSize = true;
            this.probability4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.probability4Label.Location = new System.Drawing.Point(34, 135);
            this.probability4Label.Name = "probability4Label";
            this.probability4Label.Size = new System.Drawing.Size(59, 20);
            this.probability4Label.TabIndex = 17;
            this.probability4Label.Text = "Prob. 4";
            // 
            // probability5Label
            // 
            this.probability5Label.AutoSize = true;
            this.probability5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.probability5Label.Location = new System.Drawing.Point(34, 171);
            this.probability5Label.Name = "probability5Label";
            this.probability5Label.Size = new System.Drawing.Size(59, 20);
            this.probability5Label.TabIndex = 16;
            this.probability5Label.Text = "Prob. 5";
            // 
            // probability1Label
            // 
            this.probability1Label.AutoSize = true;
            this.probability1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.probability1Label.Location = new System.Drawing.Point(34, 24);
            this.probability1Label.Name = "probability1Label";
            this.probability1Label.Size = new System.Drawing.Size(59, 20);
            this.probability1Label.TabIndex = 15;
            this.probability1Label.Text = "Prob. 1";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(277, 24);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(506, 300);
            this.chart1.TabIndex = 29;
            this.chart1.Text = "chart1";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.averageLabel.Location = new System.Drawing.Point(319, 350);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(72, 20);
            this.averageLabel.TabIndex = 30;
            this.averageLabel.Text = "Average:";
            // 
            // chiLabel
            // 
            this.chiLabel.AutoSize = true;
            this.chiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chiLabel.Location = new System.Drawing.Point(319, 419);
            this.chiLabel.Name = "chiLabel";
            this.chiLabel.Size = new System.Drawing.Size(95, 20);
            this.chiLabel.TabIndex = 31;
            this.chiLabel.Text = "Chi-squared";
            // 
            // varianceLabel
            // 
            this.varianceLabel.AutoSize = true;
            this.varianceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.varianceLabel.Location = new System.Drawing.Point(319, 386);
            this.varianceLabel.Name = "varianceLabel";
            this.varianceLabel.Size = new System.Drawing.Size(76, 20);
            this.varianceLabel.TabIndex = 32;
            this.varianceLabel.Text = "Variance:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.varianceLabel);
            this.Controls.Add(this.chiLabel);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.conclusionLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.numberOfExperimentsNumericUpDown);
            this.Controls.Add(this.numberOfExperimentsLabel);
            this.Controls.Add(this.autoLabel);
            this.Controls.Add(this.probability2NumericUpDown);
            this.Controls.Add(this.probability3NumericUpDown);
            this.Controls.Add(this.probability4NumericUpDown);
            this.Controls.Add(this.probability1NumericUpDown);
            this.Controls.Add(this.probability2Label);
            this.Controls.Add(this.probability3Label);
            this.Controls.Add(this.probability4Label);
            this.Controls.Add(this.probability5Label);
            this.Controls.Add(this.probability1Label);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfExperimentsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probability2NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probability3NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probability4NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probability1NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label conclusionLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.NumericUpDown numberOfExperimentsNumericUpDown;
        private System.Windows.Forms.Label numberOfExperimentsLabel;
        private System.Windows.Forms.Label autoLabel;
        private System.Windows.Forms.NumericUpDown probability2NumericUpDown;
        private System.Windows.Forms.NumericUpDown probability3NumericUpDown;
        private System.Windows.Forms.NumericUpDown probability4NumericUpDown;
        private System.Windows.Forms.NumericUpDown probability1NumericUpDown;
        private System.Windows.Forms.Label probability2Label;
        private System.Windows.Forms.Label probability3Label;
        private System.Windows.Forms.Label probability4Label;
        private System.Windows.Forms.Label probability5Label;
        private System.Windows.Forms.Label probability1Label;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label chiLabel;
        private System.Windows.Forms.Label varianceLabel;
    }
}

