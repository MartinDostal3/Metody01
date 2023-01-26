using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int SoucetArPosl(int a1, int a2, int n, out int diference, out int posledni)
        {
            int soucet = a1;
            posledni = a1;
            diference = a2 - a1;
            
            
            for (int i = 0; i < n - 1; i++)
            {
                soucet += a1 + (i + 1) * diference;
                posledni = posledni + diference;
            }
            return soucet;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int diference;
            int posledni;
            MessageBox.Show("Soucet je: " + SoucetArPosl(5, 7, 6, out diference, out posledni) + " diference je: " + diference + " a posledni clen je: " + posledni);

        }
    }
}
