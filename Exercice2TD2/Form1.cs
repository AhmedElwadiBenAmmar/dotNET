using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercice2TD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
           
            double S = a + b ;
            double s = a - b;
            double P = a * b ;
            double m = Math.Min(a, b);
            double M = Math.Max(a, b);
            double D = a / b;
            String v = (String) comboBox1.SelectedItem;
            if (v.Equals("+"))
            {
                label3.Text=S.ToString();
            }else if  (v.Equals("-"))
                {
                label3.Text = s.ToString();
            }
            else if (v.Equals("*"))
            {
                label3.Text=P.ToString();
            }else
            {
                label3.Text=D.ToString();
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
