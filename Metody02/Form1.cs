using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      



        public static void UlozitCisla(double[] pole, TextBox textBox)
        {
            
            pole = new double[textBox.Lines.Count()];
            for (int i = 0; i < textBox.Lines.Count(); i++)
            {
                pole[i] = double.Parse(textBox.Lines[i]);
            }
            
        }

       public static void ZobrazitPole(ListBox listBox, double[] pole)
        {
            listBox.Items.Clear();
            for (int i = 0; i < pole.Length; i++)
            {
                listBox.Items.Add(pole[i]);
            }
        }

        public static bool JeRostouci(double[] pole)
        {
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] <= pole[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] pole = null;

            UlozitCisla(pole, textBox1);
            ZobrazitPole(listBox1, pole);

            if (JeRostouci(pole))
            {
                MessageBox.Show("Pole je rostoucí");
            }
            else MessageBox.Show("Pole není rostoucí");

        }
    }
}
