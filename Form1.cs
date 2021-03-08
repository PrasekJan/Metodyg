using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double vzdalenost(double a1, double a2, double b1, double b2)
        {
            return Math.Sqrt((a1 - b1) * (a1- b1) + (a2 - b2) *(a2 - b2));
        }
        double mocnina(int a, int b)
        {
            double vysledek = 1;
            if (b > 0)
            {
                for (int i = 0; i < b; i++)
                {
                    vysledek *= a;
                }
            }
            else if (b < 0)
            {
                for (int i = 0; i > b; i--)
                {
                    vysledek /= a;
                }
            }
            return vysledek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Xa = Convert.ToInt32(textBox1.Text);
            double Ya = Convert.ToInt32(textBox2.Text);
            double Xb = Convert.ToInt32(textBox3.Text);
            double Yb = Convert.ToInt32(textBox4.Text);

            MessageBox.Show("Vzdalenost je "+ vzdalenost(Xa, Ya, Xb, Yb).ToString());

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            MessageBox.Show(mocnina(a, b).ToString());

        }
    }
}
