using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funkce06
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
            listBox1.Items.Clear();
            MessageBox.Show("Retezec je: " + Smaz(retezec, listBox1));


        }

        public static string Smaz(string retezec, ListBox listBox)
        {

            foreach(char c in retezec)
            {
                if(char.IsDigit(c))
                {
                    retezec.Remove(c);
                }

            }

            char[] sep = { ' '};
            string[] slova= retezec.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            foreach (string slovo in slova)
            {
                listBox.Items.Add(slovo);
            }
            return retezec;




        }


    }
}
