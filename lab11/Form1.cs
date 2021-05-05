using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab11
{
    public partial class Form1 : Form
    {
        double U = 1;
        const int p = 5087; // большое простое число
        int M = 2900;       // M = p - 3^n. Берем n = 7, потому что 3^8 > p
        double R;
        double[] probabilities = new double[5] { 0, 0, 0, 0, 0 };
        readonly double[] values = new double[5] { 1, 2, 3, 4, 5 };
        double[] statistics = new double[5] { 0, 0, 0, 0, 0 };

        double theoreticalAverage = 0;
        double empiricalAverage = 0;
        double averageError = 0;

        double theoreticalVariance = 0;
        double empiricalVariance = 0;
        double varianceError = 0;

        double X = 0;
        double chiSquared = 11.07; // alpha = 0.05, m = 5
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            probabilities[0] = (double)probability1NumericUpDown.Value;
            probabilities[1] = (double)probability2NumericUpDown.Value;
            probabilities[2] = (double)probability3NumericUpDown.Value;
            probabilities[3] = (double)probability4NumericUpDown.Value;
            probabilities[4] = 1 - SumOfElements(probabilities, 0, 3);

            for (int i = 0; i < statistics.Length; i++)
                statistics[i] = 0;
            FindStatistics((int)numberOfExperimentsNumericUpDown.Value);
            // Chi-squared
            X = FindX(statistics, probabilities, (int)numberOfExperimentsNumericUpDown.Value);
            if (chiSquared >= X)
            {
                chiLabel.Text = "Chi-squared: " + chiSquared.ToString() + ">= " + X + " hypothesis confirmed";
            }
            else
            {
                chiLabel.Text = "Chi-squared: " + chiSquared.ToString() + "< " + X + " hypothesis not confirmed";
            }

            for (int i = 0; i < statistics.Length; i++)
            {
                statistics[i] /= (double)numberOfExperimentsNumericUpDown.Value;
                chart1.Series[0].Points.AddXY(i + 1, statistics[i]);
            }
            // Average
            theoreticalAverage = FindAverage(probabilities, values);
            empiricalAverage = FindAverage(statistics, values);
            averageError = Math.Abs(theoreticalAverage - empiricalAverage) / Math.Abs(theoreticalAverage);
            averageLabel.Text = "Average: " + empiricalAverage.ToString() +
                                " (error = " + ((int)(averageError * 100)).ToString() + "%)";
            //Variance
            theoreticalVariance = FindVariance(probabilities, values, theoreticalAverage);
            empiricalVariance = FindVariance(statistics, values, empiricalAverage);
            varianceError = Math.Abs(theoreticalVariance - empiricalVariance) / Math.Abs(theoreticalVariance);
            varianceLabel.Text = "Variance: " + empiricalVariance.ToString() +
                                " (error = " + ((int)(varianceError * 100)).ToString() + "%)";

        }

        private void FindStatistics(int numberOfExperiments)
        {
            double tempR;
            for (int i = 0; i < numberOfExperiments; i++)
            {
                Generator();
                tempR = R;
                for (int j = 0; j < probabilities.Length; j++)
                {
                    tempR -= probabilities[j];
                    if (tempR <= 0)
                    {
                        statistics[j]++;
                        break;
                    }
                }
            }
        }

        private void Generator() // метод вычетов. Модификация Коробова
        {
            R = U / p;
            U = (U * M) % p;
        }

        private double FindAverage(double[] p, double[] x)
        {
            double average = 0;
            for (int i =0;i<x.Length;i++)
            {
                average += p[i] * x[i];
            }
            return average;
        }

        private double FindVariance(double[] p, double[] x, double average)
        {
            double variance = 0;
            for (int i = 0; i < x.Length; i++)
            {
                variance += p[i] * x[i] * x[i];
            }
            variance -= average * average;
            return variance;
        }

        private double FindX(double[] n, double[] p, int N)
        {
            double X = 0;
            for (int i = 0; i < p.Length; i++)
            { 
                if (p[i] != 0)
                    X += (n[i] * n[i]) / (N * p[i]);
            }
            X -= N;
            return X;
        }
        private double SumOfElements(double[] m, int firstElement, int lastElement)
        {
            double sum = 0;
            for (int i = firstElement; i <= lastElement; i++)
            {
                sum += m[i];
            }
            return sum;
        }

    }
}
