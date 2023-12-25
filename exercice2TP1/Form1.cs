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

namespace exercice2TP1
{
    public partial class Form1 : Form
    {
        private int x;
        public Form1()
        {
            InitializeComponent();

            // Initialise la valeur de X
            x = 10;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Récupère la valeur saisie par l'utilisateur
            int valeurSaisie = Convert.ToInt32(textBox1.Text);

            // Compare la valeur saisie à la valeur de X
            if (valeurSaisie > x)
            {
                // La valeur saisie est supérieure à la valeur de X
                label2.Text = "La valeur saisie est supérieure à la valeur de X.";
            }
            else if (valeurSaisie < x)
            {
                // La valeur saisie est inférieure à la valeur de X
                label2.Text = "La valeur saisie est inférieure à la valeur de X.";
            }
            else
            {
                // La valeur saisie est égale à la valeur de X
                label2.Text = "La valeur saisie est égale à la valeur de X.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    }

