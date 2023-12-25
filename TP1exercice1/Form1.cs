using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1exercice1
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
            int hauteur = Convert.ToInt32(textBox1.Text);
            int Base = Convert.ToInt32(textBox2.Text);
            int surface = (hauteur * Base)/2;
            label3.Text = "la surface du triangle "+ Convert.ToString(surface);
        }
    }
}
