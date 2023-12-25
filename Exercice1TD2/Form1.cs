using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice1TD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text); 
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double S = a + b + c;
            double P = a*b*c;
            double m = Math.Min(Math.Min(a, b),c);
            double M = Math.Max(Math.Max(a, b),c);
            double moy = S / 3;
            label14.Text = m.ToString();
            label15.Text = M.ToString();
            label16.Text = S.ToString();
            label17.Text = moy.ToString();
            label18.Text = P.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
