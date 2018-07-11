using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void add(object sender, EventArgs e)
        {
            double A=0;
            double B=0;
            if (double.TryParse(inputA.Text, out A) && double.TryParse(inputB.Text, out B))
            {
                double C = 0;
                C = A + B;
                outputA.Text = C.ToString();
            }
            else
                MessageBox.Show("Wrong input, numbers only!");



        }

        private void decrease(object sender, EventArgs e)
        {
            double A = 0;
            double B = 0;
            if (double.TryParse(inputA.Text, out A) && double.TryParse(inputB.Text, out B))
            {
                double C = 0;
                C = A - B;
                outputA.Text = C.ToString();
            }
            else
                MessageBox.Show("Wrong input, numbers only!");



        }

        private void multyply(object sender, EventArgs e)
        {
            double A = 0;
            double B = 0;
            if (double.TryParse(inputA.Text, out A) && double.TryParse(inputB.Text, out B))
            {
                double C = 0;
                C = A * B;
                outputA.Text = C.ToString();
            }
            else
                MessageBox.Show("Wrong input, numbers only!");




        }

        private void divide(object sender, EventArgs e)
        {
            double A = 0;
            double B = 0;
            if (double.TryParse(inputA.Text, out A) && double.TryParse(inputB.Text, out B))
            {
                double C = 0;
                C = A / B;
                outputA.Text = C.ToString();
            }
            else
                MessageBox.Show("Wrong input, numbers only!");




        }

        private void power(object sender, EventArgs e)
        {
            double A = 0;
            double B = 0;
            if (double.TryParse(inputA.Text, out A) && double.TryParse(inputB.Text, out B))
            {
                double C = 0;
                C = Math.Pow(A, B);
                outputA.Text = C.ToString();
            }
            else
                MessageBox.Show("Wrong input, numbers only!");




        }

        private void sqrt(object sender, EventArgs e)
        {
            double A = 0;
            inputB.Text = "-";

            if (double.TryParse(inputA.Text, out A) )
            {
                double C = 0;
                C = Math.Sqrt(A);
                outputA.Text = C.ToString();
            }
            else
                MessageBox.Show("Wrong input, numbers only!");





        }

        private void inputB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
