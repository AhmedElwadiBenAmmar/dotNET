using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1exercice2
{
    public partial class Form1 : Form
    {
        private int x;

        public Form1()
        {
            InitializeComponent(
               

                );
             x = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valeurSaisie = Convert.ToInt32(textBox1.Text);

            if (valeurSaisie > x) {
                label6.Text = $"La valeur saisie est supérieure à la valeur de {x}.";
                }
            else if (valeurSaisie < x)
            {
                // La valeur saisie est inférieure à la valeur de X
                label6.Text = $"La valeur saisie est inférieure à la valeur de {x}.";
            }
            else
            {
                // La valeur saisie est égale à la valeur de X
                label6.Text = $"La valeur saisie est égale à la valeur de {x}.";

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
