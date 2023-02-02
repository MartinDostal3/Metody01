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
        double[] pole;

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            double a = double.Parse(textBox2.Text);
            double b = double.Parse(textBox3.Text);
            if(a> b)
            {
                double c = a;
                a= b;
                b = c;
            }
            pole = new double[n];
            Uloz(pole, n, a, b);
          


        }
        static private void Uloz(double[] pole, int n, double a, double b)
        {
            Random rnd = new Random();         
      
            for (int i = 0; i < n; i++)
            {
                pole[i] = rnd.NextDouble() * (b - a) + a;


            }


            return;
        }
        static private void ZobrazitPole(double[] pole, ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (double x in pole)
            {
                listbox.Items.Add(x);
            }
        }
        static void prohodt(double[] pole)
        {
            int maxIndex = 0;
            int lastIndex = pole.Length - 1;
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] > pole[maxIndex])
                {
                    maxIndex = i;
                }
            }
            double pomocna = pole[lastIndex];
            pole[lastIndex] = pole[maxIndex];
            pole[maxIndex] = pomocna;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZobrazitPole(pole, listBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prohodt(pole);
        }
    }
}
