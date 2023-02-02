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





        double[] pole;

    
        static private void UlozitDoPole(double[] pole, TextBox textBox)
        {
            for (int i = 0; i < textBox.Lines.Length; i++)
            {
                pole[i] = int.Parse(textBox.Lines[i]);
            }
        }
        static private void ZobrazitPole(double[] pole, ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (double x in pole)
            {
                listbox.Items.Add(x);
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
           
            pole = new double[textBox1.Lines.Length];
            UlozitDoPole(pole, textBox1);

           
            ZobrazitPole(pole, listBox1);

            if (JeRostouci(pole))
            {
                MessageBox.Show("Pole je rostoucí");
            }
            else MessageBox.Show("Pole není rostoucí");

        }
    }
}
