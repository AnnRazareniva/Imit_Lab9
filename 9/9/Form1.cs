using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        double[] P = new double[5];
        int[] Statistic = new int[5];
        double[] Frequency = new double[5];
        Random rand = new Random();
        double alfa, Mat, Dis, MatEmp, DisEmp, ErMat, ErDis, Xi1;

        public Form1()
        {
            InitializeComponent();
        }

        private void auto_Click(object sender, EventArgs e)
        {

            P[0] = double.Parse(Prob1.Text);
            P[1] = double.Parse(Prob2.Text);
            P[2] = double.Parse(Prob3.Text);
            P[3] = double.Parse(Prob4.Text);

            P[4] = 1 - P[0] - P[1] - P[2] - P[3];

        }

        private void button1_Click(object sender, EventArgs e)
        {

            chart1.Series[0].Points.Clear();
            Mat = 0; Dis = 0; MatEmp = 0; DisEmp = 0; ErMat = 0; ErDis = 0; Xi1 = 0;

            double Hip = 9.488;

            int N = int.Parse(NN.Text);

            for (int i = 0; i < 5; i++)
            {
                Statistic[i] = 0;
            }

            int j = 0;

            while (j < N)
            {
                int k = Data();

                Statistic[k]++;

                j++;
            }

            for (int i = 0; i < 5; i++)
            {
                Frequency[i] = ((double)Statistic[i] / (double)N);
                chart1.Series[0].Points.AddXY(i, Frequency[i]);
                Mat += (i + 1) * P[i];
            }

            for (int i = 0; i < 5; i++)
            {
                Dis += P[i] * Math.Pow((i + 1) - Mat, 2);
            }

            for (int i = 0; i < 5; i++)
            {
                MatEmp += (i + 1) * Frequency[i];
            }

            for (int i = 0; i < 5; i++)
            {
                DisEmp += Frequency[i] * Math.Pow((i + 1) - MatEmp, 2);
            }

            double relErrMat, relErrDis;

            relErrMat = 100 * Math.Abs(MatEmp - Mat) / Math.Abs(Mat);
            relErrDis = 100 * Math.Abs(DisEmp - Dis) / Math.Abs(Dis);

            for (int i = 0; i < 5; i++)
            {
                Xi1 += Math.Pow(Statistic[i], 2) / (N * P[i]);
            }

            Xi1 = Xi1 - N;

            string test = "good";

            if (Xi1 > Hip)
                test = "bad";

            Avarage.Text = MatEmp.ToString() + " (error = " + Math.Round(relErrMat, 0).ToString() + "%)";
            Variance.Text = DisEmp.ToString() + " (error = " + Math.Round(relErrDis, 0).ToString() + "%)";
            Xi.Text = Xi1.ToString() + " is " + test.ToString();
        }

        public int Data()
        {

            alfa = rand.NextDouble();

            double A = alfa;
            int k = 0;

            while (A > 0)
            {
                A = A - P[k];
                k++;
            }

            k--;

            return k;
        }
    }
}
