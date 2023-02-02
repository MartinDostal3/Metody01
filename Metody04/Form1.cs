using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string retezec = textBox1.Text;
            int pocetCifer = 0;
            int soucetLichych = 0;
            if(obsahujeCifru(retezec, out pocetCifer, out soucetLichych))
            {
                MessageBox.Show("Ano, obsahuje cifru\npocet vsech cifer je: " + pocetCifer + "\nsoucet lichych cifer je: " + soucetLichych);
            }
            else
            {
                MessageBox.Show("Ne, neobsahuje cifru");
            }
        }
        public static bool obsahujeCifru(string retezec, out int pocetCifer, out int soucetLichych)
        {
            bool obsahuje = false;
            pocetCifer = 0;
            soucetLichych = 0;

            foreach (char znak in retezec)
            {
                if (char.IsDigit(znak))
                {
                    obsahuje = true;
                    pocetCifer++;
                    int cifra = int.Parse(znak.ToString());
                    
                    if(cifra%2 != 0 )
                    {
                        soucetLichych += cifra;
                    }
                }
            }




            return obsahuje;
        }
    }
}
